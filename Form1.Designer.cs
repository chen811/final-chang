using System;

namespace Guest_Big_Small
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsmall = new System.Windows.Forms.Button();
            this.btnred = new System.Windows.Forms.Button();
            this.btnblack = new System.Windows.Forms.Button();
            this.btnbig = new System.Windows.Forms.Button();
            this.btnend = new System.Windows.Forms.Button();
            this.infolabel = new System.Windows.Forms.Label();
            this.lbwinlose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbmoney = new System.Windows.Forms.Label();
            this.tbmoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtoptext = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(255, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnsmall
            // 
            this.btnsmall.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsmall.Location = new System.Drawing.Point(125, 64);
            this.btnsmall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsmall.Name = "btnsmall";
            this.btnsmall.Size = new System.Drawing.Size(113, 50);
            this.btnsmall.TabIndex = 16;
            this.btnsmall.Text = "小";
            this.btnsmall.UseVisualStyleBackColor = true;
            this.btnsmall.Click += new System.EventHandler(this.btnsmall_Click);
            // 
            // btnred
            // 
            this.btnred.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnred.Location = new System.Drawing.Point(125, 131);
            this.btnred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(113, 50);
            this.btnred.TabIndex = 17;
            this.btnred.Text = "紅";
            this.btnred.UseVisualStyleBackColor = true;
            this.btnred.Click += new System.EventHandler(this.btnred_Click);
            // 
            // btnblack
            // 
            this.btnblack.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnblack.Location = new System.Drawing.Point(6, 131);
            this.btnblack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnblack.Name = "btnblack";
            this.btnblack.Size = new System.Drawing.Size(113, 50);
            this.btnblack.TabIndex = 18;
            this.btnblack.Text = "黑";
            this.btnblack.UseVisualStyleBackColor = true;
            this.btnblack.Click += new System.EventHandler(this.btnblack_Click);
            // 
            // btnbig
            // 
            this.btnbig.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbig.Location = new System.Drawing.Point(6, 64);
            this.btnbig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbig.Name = "btnbig";
            this.btnbig.Size = new System.Drawing.Size(113, 50);
            this.btnbig.TabIndex = 20;
            this.btnbig.Text = "大";
            this.btnbig.UseVisualStyleBackColor = true;
            this.btnbig.Click += new System.EventHandler(this.btnbig_Click);
            // 
            // btnend
            // 
            this.btnend.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnend.Location = new System.Drawing.Point(125, 198);
            this.btnend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(113, 50);
            this.btnend.TabIndex = 21;
            this.btnend.Text = "結束遊戲";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.infolabel.Location = new System.Drawing.Point(669, 109);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(0, 30);
            this.infolabel.TabIndex = 22;
            // 
            // lbwinlose
            // 
            this.lbwinlose.AutoSize = true;
            this.lbwinlose.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbwinlose.Location = new System.Drawing.Point(669, 151);
            this.lbwinlose.Name = "lbwinlose";
            this.lbwinlose.Size = new System.Drawing.Size(0, 30);
            this.lbwinlose.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(900, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "你的財產";
            // 
            // lbmoney
            // 
            this.lbmoney.AutoSize = true;
            this.lbmoney.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbmoney.ForeColor = System.Drawing.Color.Blue;
            this.lbmoney.Location = new System.Drawing.Point(943, 531);
            this.lbmoney.Name = "lbmoney";
            this.lbmoney.Size = new System.Drawing.Size(55, 30);
            this.lbmoney.TabIndex = 25;
            this.lbmoney.Text = "100";
            // 
            // tbmoney
            // 
            this.tbmoney.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbmoney.Location = new System.Drawing.Point(650, 64);
            this.tbmoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmoney.Name = "tbmoney";
            this.tbmoney.Size = new System.Drawing.Size(100, 43);
            this.tbmoney.TabIndex = 26;
            this.tbmoney.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(634, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 33);
            this.label2.TabIndex = 24;
            this.label2.Text = "押注金額";
            // 
            // lbtoptext
            // 
            this.lbtoptext.AutoSize = true;
            this.lbtoptext.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbtoptext.Location = new System.Drawing.Point(228, 13);
            this.lbtoptext.Name = "lbtoptext";
            this.lbtoptext.Size = new System.Drawing.Size(321, 28);
            this.lbtoptext.TabIndex = 27;
            this.lbtoptext.Text = "2~7小牌 9~A大牌 8點通殺";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 575);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbtoptext);
            this.tabPage1.Controls.Add(this.tbmoney);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.lbwinlose);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnend);
            this.tabPage1.Controls.Add(this.infolabel);
            this.tabPage1.Controls.Add(this.btnDeal);
            this.tabPage1.Controls.Add(this.btnbig);
            this.tabPage1.Controls.Add(this.btnred);
            this.tabPage1.Controls.Add(this.btnblack);
            this.tabPage1.Controls.Add(this.btnsmall);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "阿罵的賭場";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(871, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 238);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(906, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 52);
            this.button2.TabIndex = 0;
            this.button2.Text = "換個對手";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeal.Location = new System.Drawing.Point(6, 198);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(113, 50);
            this.btnDeal.TabIndex = 19;
            this.btnDeal.Text = "發牌";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 578);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbmoney);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "押大小或是牌色";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsmall;
        private System.Windows.Forms.Button btnred;
        private System.Windows.Forms.Button btnblack;
        private System.Windows.Forms.Button btnbig;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label lbwinlose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbmoney;
        private System.Windows.Forms.TextBox tbmoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtoptext;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeal;
    }
}

