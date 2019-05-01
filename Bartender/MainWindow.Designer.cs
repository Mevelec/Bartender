namespace Bartender
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
            this.menu1 = new Bartender.Forms.Menu();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(22, 28);
            this.menu1.Name = "menu1";
            this.menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1.Size = new System.Drawing.Size(909, 515);
            this.menu1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(955, 596);
            this.Controls.Add(this.menu1);
            this.Name = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private Forms.Menu menu1;
    }
}