namespace SortingWF
{
    partial class MainForm
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
            displayPanel = new DoubleBufferedPanel();
            menuStrip = new MenuStrip();
            sortsToolStripMenuItem = new ToolStripMenuItem();
            displayPanel.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // displayPanel
            // 
            displayPanel.Controls.Add(menuStrip);
            displayPanel.Dock = DockStyle.Fill;
            displayPanel.Location = new Point(0, 0);
            displayPanel.Name = "displayPanel";
            displayPanel.Size = new Size(800, 450);
            displayPanel.TabIndex = 0;
            displayPanel.Paint += displayPanel_Paint;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(28, 28);
            menuStrip.Items.AddRange(new ToolStripItem[] { sortsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 38);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // sortsToolStripMenuItem
            // 
            sortsToolStripMenuItem.Name = "sortsToolStripMenuItem";
            sortsToolStripMenuItem.Size = new Size(77, 34);
            sortsToolStripMenuItem.Text = "Sorts";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(displayPanel);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Form1";
            displayPanel.ResumeLayout(false);
            displayPanel.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem sortsToolStripMenuItem;
        private DoubleBufferedPanel displayPanel;
    }
}
