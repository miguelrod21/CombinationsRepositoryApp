namespace ListifyApp
{
    partial class MainForm
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
            combinationslvw = new ListView();
            SuspendLayout();
            // 
            // combinationslvw
            // 
            combinationslvw.Location = new Point(12, 89);
            combinationslvw.Name = "combinationslvw";
            combinationslvw.Size = new Size(255, 317);
            combinationslvw.TabIndex = 0;
            combinationslvw.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(combinationslvw);
            Name = "MainForm";
            Text = "Listify App";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView combinationslvw;
    }
}