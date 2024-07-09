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
            CombinationsLbl = new Label();
            AddWinningtxtbox = new TextBox();
            AddWinningLbl = new Label();
            AddWinningBtn = new Button();
            SuspendLayout();
            // 
            // combinationslvw
            // 
            combinationslvw.Location = new Point(12, 34);
            combinationslvw.Name = "combinationslvw";
            combinationslvw.Size = new Size(255, 317);
            combinationslvw.TabIndex = 0;
            combinationslvw.UseCompatibleStateImageBehavior = false;
            // 
            // CombinationsLbl
            // 
            CombinationsLbl.AutoSize = true;
            CombinationsLbl.Location = new Point(12, 16);
            CombinationsLbl.Name = "CombinationsLbl";
            CombinationsLbl.Size = new Size(148, 15);
            CombinationsLbl.TabIndex = 1;
            CombinationsLbl.Text = "Combinaciones premiadas";
            // 
            // AddWinningtxtbox
            // 
            AddWinningtxtbox.Location = new Point(306, 34);
            AddWinningtxtbox.Name = "AddWinningtxtbox";
            AddWinningtxtbox.Size = new Size(191, 23);
            AddWinningtxtbox.TabIndex = 2;
            // 
            // AddWinningLbl
            // 
            AddWinningLbl.AutoSize = true;
            AddWinningLbl.Location = new Point(304, 16);
            AddWinningLbl.Name = "AddWinningLbl";
            AddWinningLbl.Size = new Size(193, 15);
            AddWinningLbl.TabIndex = 3;
            AddWinningLbl.Text = "Añadir a combinaciones premiadas";
            // 
            // AddWinningBtn
            // 
            AddWinningBtn.Location = new Point(503, 16);
            AddWinningBtn.Name = "AddWinningBtn";
            AddWinningBtn.Size = new Size(79, 41);
            AddWinningBtn.TabIndex = 4;
            AddWinningBtn.Text = "Añadir";
            AddWinningBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddWinningBtn);
            Controls.Add(AddWinningLbl);
            Controls.Add(AddWinningtxtbox);
            Controls.Add(CombinationsLbl);
            Controls.Add(combinationslvw);
            Name = "MainForm";
            Text = "Listify App";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView combinationslvw;
        private Label CombinationsLbl;
        private TextBox AddWinningtxtbox;
        private Label AddWinningLbl;
        private Button AddWinningBtn;
    }
}