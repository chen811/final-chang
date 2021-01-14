using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Guest_Big_Small
{
    public partial class Form1 : Form
    {


        List<Image> head = new List<Image>();
        List<Image> risk = new List<Image>();

        public class resp
        {
            public List<img> data { get; set; }
        }

        public class img
        {
            public string link { get; set; }
        }

        private resp GetImages(string albumHash, string clientId)
        {
            resp result = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://api.imgur.com/3/album/{albumHash}/images");
                //Add Header 
                WebHeaderCollection webHeaderCollection = request.Headers;
                webHeaderCollection.Add("Authorization", $"Client-ID {clientId}");


                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                string json = readStream.ReadToEnd();

                result = JsonConvert.DeserializeObject<resp>(json);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());

            }
            return result;
        }

        private Image GetImageFromUrl(string url)
        {
            Image result;
            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                result = System.Drawing.Image.FromStream(receiveStream);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            return result;
        }

        string[] d = new string[54];  
        static int[] a = new int[52];      

        int point, flower, bigsmall;

        public enum guessCard { red,black,big,samll };

        bool red;    
        bool gameover;  

        string topText = "A為大牌，2~7小牌，9以上大牌，8大小通吃";

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            gameover = false;
            EnableButton(false);
            infolabel.Text = string.Empty;

            string picPath = GetDirectory("pic");      
            for (int i = 0; i <= 52; i++)
                d[i] = picPath + @"\g" + i.ToString() + ".jpg";
        }

        private string GetDirectory(string name)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Application.StartupPath);
            string path = (dir.Parent).Parent.FullName;
            return path + string.Format(@"\{0}\", name);
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            int i, rnum, temp;

            EnableButton(true);
            pictureBox1.Image = Image.FromFile(@d[52]);

                Random ran = new Random();
                for (i = 0; i < 52; i++)
                {
                    a[i] = i;
                }
                for (i = 0; i < 52; i++)
                {
                    rnum = ran.Next(51);
                    temp = a[i];
                    a[i] = a[rnum];
                    a[rnum] = temp;
                }                               
            

            if(gameover)
            {
                lbtoptext.Text = topText;
                btnDeal.Text = "發牌";
                tbmoney.Text = "10";
                lbmoney.Text = "100";
                gameover = false;
            }
        }

        enum state { red=1, black=2, big=4, small=8, both=16 }

        public void opencard(guessCard guess)
        {
            bool bingo = false;
            int playerguess = (int)guess;
            int playermoney;
            if (!Int32.TryParse(lbmoney.Text, out playermoney))
            {
                playermoney = 0;
            }
            int betMoney;
            if (!Int32.TryParse(tbmoney.Text, out betMoney))
            {
                betMoney = 0;
                MessageBox.Show("金額有在小數點逆?");
                return;
            }

            if (betMoney > 0 && betMoney <= playermoney) 
            {
                EnableButton(false); 

                pictureBox1.Image = Image.FromFile(@d[a[0]]);
                int cardRate = -1;
                red = true;
                infolabel.Text = "";

                flower = (byte)a[0] % 4;       
                point = a[0] / 4;              
         
                if (flower == 3 || flower == 0) 
                {
                    red = false;
                    infolabel.Text = "黑色,";
                    if (playerguess == 1)
                        bingo = true;
                }
                else
                {
                    infolabel.Text = "紅色,";
                    if (playerguess == 0)
                        bingo = true;
                }

                if (point == 7)
                {
                    bigsmall = 0;
                    infolabel.Text += "通殺";
                    if (playerguess > 1)
                        bingo = true;
                }
                else if (point < 7 && point != 0)
                {
                    bigsmall = 1;
                    infolabel.Text += "小";
                    if (playerguess == 3)
                        bingo = true;
                }
                else
                {
                    bigsmall = 2;
                    infolabel.Text += "大";
                    if (playerguess == 2)
                        bingo = true;
                }

                lbwinlose.Text = bingo ? "你贏了" : "你輸了";
                if (bingo)
                {
                    cardRate = 1;
                }
                playermoney += betMoney * cardRate;
                lbmoney.Text = playermoney.ToString();

                if (playermoney <= 0)
                {
                    btnDeal.Text = "重新開始";
                    lbtoptext.Text = "你破產了，窮B";
                    gameover = true;
                }
            }

            else
            {
                MessageBox.Show("請輸入大於0並且小於等於剩餘籌碼的金額。");
            }
        }

        private void btnbig_Click(object sender, EventArgs e)
        {    
            opencard(guessCard.big);
        }

        private void btnsmall_Click(object sender, EventArgs e)
        {           
            opencard(guessCard.samll);
        }

        private void btnblack_Click(object sender, EventArgs e)
        {
            opencard(guessCard.black);
        }       

        private void btnred_Click(object sender, EventArgs e)
        {         
            opencard(guessCard.red);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void EnableButton(bool isEnable)
        {
            btnbig.Enabled = isEnable;
            btnsmall.Enabled = isEnable;
            btnred.Enabled = isEnable;
            btnblack.Enabled = isEnable;
            btnDeal.Enabled = !isEnable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //更換敵人
            var imgurData = GetImages("RhhOaIU", "5add18c101a7102");

            if (imgurData == null)
            {
                return;
            }
            int randomNum = new Random().Next(8);
            Image image = GetImageFromUrl(imgurData.data[randomNum].link);
            pictureBox3.Image = image;
            if (image == null)
            {
                return;
            }

            //json --> object 
            Console.WriteLine(imgurData);
        }
        



        private void btnend_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("你確定要結束遊戲嗎?","結束遊戲", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }  
        }

        private class JsonConvert
        {
            internal static T DeserializeObject<T>(string json)
            {
                throw new NotImplementedException();
            }
        }
    }
}