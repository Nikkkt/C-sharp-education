namespace Maze
{
    partial class LevelForm
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
            statusStrip1 = new StatusStrip();
            toolStripStatusSteps = new ToolStripStatusLabel();
            toolStripStatusHealth = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusSteps, toolStripStatusHealth });
            statusStrip1.Location = new Point(0, 443);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(662, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusSteps
            // 
            toolStripStatusSteps.Name = "toolStripStatusSteps";
            toolStripStatusSteps.Size = new Size(112, 17);
            toolStripStatusSteps.Text = "toolStripStatusSteps";
            // 
            // toolStripStatusHealth
            // 
            toolStripStatusHealth.Name = "toolStripStatusHealth";
            toolStripStatusHealth.Size = new Size(119, 17);
            toolStripStatusHealth.Text = "toolStripStatusHealth";
            // 
            // LevelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 465);
            Controls.Add(statusStrip1);
            Name = "LevelForm";
            Text = "Form1";
            KeyDown += KeyDownHandler;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusSteps;
        private ToolStripStatusLabel toolStripStatusHealth;
    }
}