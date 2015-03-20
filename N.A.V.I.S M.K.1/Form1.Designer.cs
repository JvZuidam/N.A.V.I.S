namespace N.A.V.I.S_M.K._1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnEnable = new System.Windows.Forms.Button();
            this.BtnDisable = new System.Windows.Forms.Button();
            this.SpkBtn = new System.Windows.Forms.Button();
            this.ExBtn = new System.Windows.Forms.Button();
            this.TexBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 208);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Test";
            // 
            // BtnEnable
            // 
            this.BtnEnable.Location = new System.Drawing.Point(13, 226);
            this.BtnEnable.Name = "BtnEnable";
            this.BtnEnable.Size = new System.Drawing.Size(125, 23);
            this.BtnEnable.TabIndex = 1;
            this.BtnEnable.Text = "Enable Voice Control";
            this.BtnEnable.UseVisualStyleBackColor = true;
            this.BtnEnable.Click += new System.EventHandler(this.BtnEnable_Click);
            // 
            // BtnDisable
            // 
            this.BtnDisable.Enabled = false;
            this.BtnDisable.Location = new System.Drawing.Point(144, 226);
            this.BtnDisable.Name = "BtnDisable";
            this.BtnDisable.Size = new System.Drawing.Size(128, 23);
            this.BtnDisable.TabIndex = 2;
            this.BtnDisable.Text = "Disable Voice Control";
            this.BtnDisable.UseVisualStyleBackColor = true;
            this.BtnDisable.Click += new System.EventHandler(this.BtnDisable_Click);
            // 
            // SpkBtn
            // 
            this.SpkBtn.Location = new System.Drawing.Point(13, 259);
            this.SpkBtn.Name = "SpkBtn";
            this.SpkBtn.Size = new System.Drawing.Size(125, 23);
            this.SpkBtn.TabIndex = 3;
            this.SpkBtn.Text = "Speech / Text";
            this.SpkBtn.UseVisualStyleBackColor = true;
            // 
            // ExBtn
            // 
            this.ExBtn.Location = new System.Drawing.Point(77, 291);
            this.ExBtn.Name = "ExBtn";
            this.ExBtn.Size = new System.Drawing.Size(128, 23);
            this.ExBtn.TabIndex = 4;
            this.ExBtn.Text = "Exit";
            this.ExBtn.UseVisualStyleBackColor = true;
            this.ExBtn.Click += new System.EventHandler(this.ExBtn_Click);
            // 
            // TexBtn
            // 
            this.TexBtn.Location = new System.Drawing.Point(144, 259);
            this.TexBtn.Name = "TexBtn";
            this.TexBtn.Size = new System.Drawing.Size(125, 23);
            this.TexBtn.TabIndex = 5;
            this.TexBtn.Text = "Text / Speech";
            this.TexBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 326);
            this.Controls.Add(this.TexBtn);
            this.Controls.Add(this.ExBtn);
            this.Controls.Add(this.SpkBtn);
            this.Controls.Add(this.BtnDisable);
            this.Controls.Add(this.BtnEnable);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "N.A.V.I.S M.K.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnEnable;
        private System.Windows.Forms.Button BtnDisable;
        private System.Windows.Forms.Button SpkBtn;
        private System.Windows.Forms.Button ExBtn;
        private System.Windows.Forms.Button TexBtn;
    }
}

