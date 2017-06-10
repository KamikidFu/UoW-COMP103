namespace Week1_Ex1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChangeColour = new System.Windows.Forms.Button();
            this.buttonBigger = new System.Windows.Forms.Button();
            this.buttonSmaller = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonChangeText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangeColour
            // 
            this.buttonChangeColour.Location = new System.Drawing.Point(30, 85);
            this.buttonChangeColour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChangeColour.Name = "buttonChangeColour";
            this.buttonChangeColour.Size = new System.Drawing.Size(153, 24);
            this.buttonChangeColour.TabIndex = 0;
            this.buttonChangeColour.Text = "Change Colour";
            this.buttonChangeColour.UseVisualStyleBackColor = true;
            this.buttonChangeColour.Click += new System.EventHandler(this.buttonChangeColour_Click);
            // 
            // buttonBigger
            // 
            this.buttonBigger.Location = new System.Drawing.Point(30, 115);
            this.buttonBigger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBigger.Name = "buttonBigger";
            this.buttonBigger.Size = new System.Drawing.Size(153, 24);
            this.buttonBigger.TabIndex = 1;
            this.buttonBigger.Text = "Bigger";
            this.buttonBigger.UseVisualStyleBackColor = true;
            this.buttonBigger.Click += new System.EventHandler(this.buttonBigger_Click);
            // 
            // buttonSmaller
            // 
            this.buttonSmaller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSmaller.Location = new System.Drawing.Point(30, 144);
            this.buttonSmaller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSmaller.Name = "buttonSmaller";
            this.buttonSmaller.Size = new System.Drawing.Size(153, 24);
            this.buttonSmaller.TabIndex = 2;
            this.buttonSmaller.Text = "Smaller";
            this.buttonSmaller.UseVisualStyleBackColor = true;
            this.buttonSmaller.Click += new System.EventHandler(this.buttonSmaller_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.ForeColor = System.Drawing.Color.Blue;
            this.labelOutput.Location = new System.Drawing.Point(32, 20);
            this.labelOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(92, 33);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "Kia ora";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(30, 173);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(153, 24);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonChangeText
            // 
            this.buttonChangeText.Location = new System.Drawing.Point(30, 56);
            this.buttonChangeText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChangeText.Name = "buttonChangeText";
            this.buttonChangeText.Size = new System.Drawing.Size(153, 24);
            this.buttonChangeText.TabIndex = 5;
            this.buttonChangeText.Text = "Change Text";
            this.buttonChangeText.UseVisualStyleBackColor = true;
            this.buttonChangeText.Click += new System.EventHandler(this.buttonChangeText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 207);
            this.Controls.Add(this.buttonChangeText);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonSmaller);
            this.Controls.Add(this.buttonBigger);
            this.Controls.Add(this.buttonChangeColour);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "My First Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeColour;
        private System.Windows.Forms.Button buttonBigger;
        private System.Windows.Forms.Button buttonSmaller;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonChangeText;
    }
}

