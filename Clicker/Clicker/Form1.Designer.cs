namespace Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clickButton = new Button();
            SuspendLayout();
            // 
            // clickButton
            // 
            clickButton.Location = new Point(107, 52);
            clickButton.Name = "clickButton";
            clickButton.Size = new Size(196, 97);
            clickButton.TabIndex = 0;
            clickButton.Text = "Clicks: 0";
            clickButton.UseVisualStyleBackColor = true;
            clickButton.Click += clickButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 217);
            Controls.Add(clickButton);
            Name = "Form1";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button clickButton;
    }
}