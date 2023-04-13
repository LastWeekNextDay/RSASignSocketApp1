namespace RSASignatureApplication1
{
    partial class MainWindow
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
            this.textLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.Location = new System.Drawing.Point(12, 9);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(158, 16);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Text";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 28);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(245, 302);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(12, 336);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(245, 54);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Sign and Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 405);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textLabel);
            this.Name = "MainWindow";
            this.Text = "Application1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button sendButton;

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.RichTextBox textBox;

        #endregion
    }
}