namespace CityTime
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
            textBoxCity = new TextBox();
            lblCurrentTime = new Label();
            btnGetTime = new Button();
            SuspendLayout();
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(12, 26);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(221, 23);
            textBoxCity.TabIndex = 0;
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Location = new Point(12, 73);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(38, 15);
            lblCurrentTime.TabIndex = 1;
            lblCurrentTime.Text = "label1";
            // 
            // btnGetTime
            // 
            btnGetTime.Location = new Point(12, 107);
            btnGetTime.Name = "btnGetTime";
            btnGetTime.Size = new Size(75, 23);
            btnGetTime.TabIndex = 2;
            btnGetTime.Text = "Get time";
            btnGetTime.UseVisualStyleBackColor = true;
            btnGetTime.Click += btnGetTime_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 224);
            Controls.Add(btnGetTime);
            Controls.Add(lblCurrentTime);
            Controls.Add(textBoxCity);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCity;
        private Label lblCurrentTime;
        private Button btnGetTime;
    }
}