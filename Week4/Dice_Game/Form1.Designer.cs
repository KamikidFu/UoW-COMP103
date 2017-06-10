namespace Dice_Game
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxYourCurrentMoney = new System.Windows.Forms.TextBox();
            this.textBoxYouBet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAICurrentMoney = new System.Windows.Forms.TextBox();
            this.textBoxAIBet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInitial = new System.Windows.Forms.TextBox();
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.textBoxC3 = new System.Windows.Forms.TextBox();
            this.textBoxU1 = new System.Windows.Forms.TextBox();
            this.textBoxU2 = new System.Windows.Forms.TextBox();
            this.textBoxU3 = new System.Windows.Forms.TextBox();
            this.textBoxSumAI = new System.Windows.Forms.TextBox();
            this.textBoxSumYou = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxWinner = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonInitialGame = new System.Windows.Forms.Button();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxYourCurrentMoney);
            this.groupBox1.Controls.Add(this.textBoxYouBet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Information";
            // 
            // textBoxYourCurrentMoney
            // 
            this.textBoxYourCurrentMoney.Location = new System.Drawing.Point(237, 26);
            this.textBoxYourCurrentMoney.Name = "textBoxYourCurrentMoney";
            this.textBoxYourCurrentMoney.ReadOnly = true;
            this.textBoxYourCurrentMoney.Size = new System.Drawing.Size(71, 21);
            this.textBoxYourCurrentMoney.TabIndex = 5;
            // 
            // textBoxYouBet
            // 
            this.textBoxYouBet.Location = new System.Drawing.Point(66, 26);
            this.textBoxYouBet.Name = "textBoxYouBet";
            this.textBoxYouBet.Size = new System.Drawing.Size(58, 21);
            this.textBoxYouBet.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Current Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "You bet:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAICurrentMoney);
            this.groupBox2.Controls.Add(this.textBoxAIBet);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AI Information";
            // 
            // textBoxAICurrentMoney
            // 
            this.textBoxAICurrentMoney.Location = new System.Drawing.Point(237, 24);
            this.textBoxAICurrentMoney.Name = "textBoxAICurrentMoney";
            this.textBoxAICurrentMoney.ReadOnly = true;
            this.textBoxAICurrentMoney.Size = new System.Drawing.Size(71, 21);
            this.textBoxAICurrentMoney.TabIndex = 3;
            // 
            // textBoxAIBet
            // 
            this.textBoxAIBet.Location = new System.Drawing.Point(66, 27);
            this.textBoxAIBet.Name = "textBoxAIBet";
            this.textBoxAIBet.ReadOnly = true;
            this.textBoxAIBet.Size = new System.Drawing.Size(58, 21);
            this.textBoxAIBet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "AI bets:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "AI Rolled:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "You Rolled:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Sum of AI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sum of You:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Initial Money:";
            // 
            // textBoxInitial
            // 
            this.textBoxInitial.Location = new System.Drawing.Point(171, 275);
            this.textBoxInitial.Name = "textBoxInitial";
            this.textBoxInitial.Size = new System.Drawing.Size(100, 21);
            this.textBoxInitial.TabIndex = 7;
            // 
            // textBoxC1
            // 
            this.textBoxC1.Location = new System.Drawing.Point(144, 87);
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.ReadOnly = true;
            this.textBoxC1.Size = new System.Drawing.Size(20, 21);
            this.textBoxC1.TabIndex = 8;
            // 
            // textBoxC2
            // 
            this.textBoxC2.Location = new System.Drawing.Point(89, 87);
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.ReadOnly = true;
            this.textBoxC2.Size = new System.Drawing.Size(20, 21);
            this.textBoxC2.TabIndex = 9;
            // 
            // textBoxC3
            // 
            this.textBoxC3.Location = new System.Drawing.Point(116, 87);
            this.textBoxC3.Name = "textBoxC3";
            this.textBoxC3.ReadOnly = true;
            this.textBoxC3.Size = new System.Drawing.Size(20, 21);
            this.textBoxC3.TabIndex = 10;
            // 
            // textBoxU1
            // 
            this.textBoxU1.Location = new System.Drawing.Point(257, 87);
            this.textBoxU1.Name = "textBoxU1";
            this.textBoxU1.ReadOnly = true;
            this.textBoxU1.Size = new System.Drawing.Size(20, 21);
            this.textBoxU1.TabIndex = 11;
            // 
            // textBoxU2
            // 
            this.textBoxU2.Location = new System.Drawing.Point(283, 87);
            this.textBoxU2.Name = "textBoxU2";
            this.textBoxU2.ReadOnly = true;
            this.textBoxU2.Size = new System.Drawing.Size(20, 21);
            this.textBoxU2.TabIndex = 12;
            // 
            // textBoxU3
            // 
            this.textBoxU3.Location = new System.Drawing.Point(309, 87);
            this.textBoxU3.Name = "textBoxU3";
            this.textBoxU3.ReadOnly = true;
            this.textBoxU3.Size = new System.Drawing.Size(20, 21);
            this.textBoxU3.TabIndex = 13;
            // 
            // textBoxSumAI
            // 
            this.textBoxSumAI.Location = new System.Drawing.Point(89, 121);
            this.textBoxSumAI.Name = "textBoxSumAI";
            this.textBoxSumAI.ReadOnly = true;
            this.textBoxSumAI.Size = new System.Drawing.Size(73, 21);
            this.textBoxSumAI.TabIndex = 14;
            // 
            // textBoxSumYou
            // 
            this.textBoxSumYou.Location = new System.Drawing.Point(257, 121);
            this.textBoxSumYou.Name = "textBoxSumYou";
            this.textBoxSumYou.ReadOnly = true;
            this.textBoxSumYou.Size = new System.Drawing.Size(72, 21);
            this.textBoxSumYou.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "Winner:";
            // 
            // textBoxWinner
            // 
            this.textBoxWinner.Location = new System.Drawing.Point(142, 152);
            this.textBoxWinner.Name = "textBoxWinner";
            this.textBoxWinner.ReadOnly = true;
            this.textBoxWinner.Size = new System.Drawing.Size(100, 21);
            this.textBoxWinner.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(320, 75);
            this.label11.TabIndex = 18;
            this.label11.Text = "Dice Game!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label12.Location = new System.Drawing.Point(12, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Winner is whose sum is more close to 18!";
            // 
            // buttonInitialGame
            // 
            this.buttonInitialGame.Location = new System.Drawing.Point(13, 299);
            this.buttonInitialGame.Name = "buttonInitialGame";
            this.buttonInitialGame.Size = new System.Drawing.Size(89, 23);
            this.buttonInitialGame.TabIndex = 20;
            this.buttonInitialGame.Text = "Initial Game";
            this.buttonInitialGame.UseVisualStyleBackColor = true;
            this.buttonInitialGame.Click += new System.EventHandler(this.buttonInitialGame_Click);
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(142, 299);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(75, 23);
            this.buttonRoll.TabIndex = 21;
            this.buttonRoll.Text = "Roll Dice";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(259, 299);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 22;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 402);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.buttonInitialGame);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxWinner);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSumYou);
            this.Controls.Add(this.textBoxSumAI);
            this.Controls.Add(this.textBoxU3);
            this.Controls.Add(this.textBoxU2);
            this.Controls.Add(this.textBoxU1);
            this.Controls.Add(this.textBoxC3);
            this.Controls.Add(this.textBoxC2);
            this.Controls.Add(this.textBoxC1);
            this.Controls.Add(this.textBoxInitial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxYourCurrentMoney;
        private System.Windows.Forms.TextBox textBoxYouBet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxAICurrentMoney;
        private System.Windows.Forms.TextBox textBoxAIBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInitial;
        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.TextBox textBoxC3;
        private System.Windows.Forms.TextBox textBoxU1;
        private System.Windows.Forms.TextBox textBoxU2;
        private System.Windows.Forms.TextBox textBoxU3;
        private System.Windows.Forms.TextBox textBoxSumAI;
        private System.Windows.Forms.TextBox textBoxSumYou;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxWinner;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonInitialGame;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Button buttonExit;
    }
}

