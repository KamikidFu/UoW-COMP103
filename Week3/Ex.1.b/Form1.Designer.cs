namespace Ex._1.b
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
            this.buttonDrawTriangle = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonDrawPattern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDrawTriangle
            // 
            this.buttonDrawTriangle.Location = new System.Drawing.Point(12, 565);
            this.buttonDrawTriangle.Name = "buttonDrawTriangle";
            this.buttonDrawTriangle.Size = new System.Drawing.Size(116, 23);
            this.buttonDrawTriangle.TabIndex = 0;
            this.buttonDrawTriangle.Text = "Draw Triangle";
            this.buttonDrawTriangle.UseVisualStyleBackColor = true;
            this.buttonDrawTriangle.Click += new System.EventHandler(this.buttonDrawTriangle_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(304, 565);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(75, 23);
            this.buttonErase.TabIndex = 1;
            this.buttonErase.Text = "Erase";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click_1);
            // 
            // buttonDrawPattern
            // 
            this.buttonDrawPattern.Location = new System.Drawing.Point(641, 565);
            this.buttonDrawPattern.Name = "buttonDrawPattern";
            this.buttonDrawPattern.Size = new System.Drawing.Size(91, 23);
            this.buttonDrawPattern.TabIndex = 2;
            this.buttonDrawPattern.Text = "Draw Pattern";
            this.buttonDrawPattern.UseVisualStyleBackColor = true;
            this.buttonDrawPattern.Click += new System.EventHandler(this.buttonDrawPattern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 600);
            this.Controls.Add(this.buttonDrawPattern);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonDrawTriangle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawTriangle;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonDrawPattern;
    }
}

