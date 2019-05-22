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
            this.WindowControlls = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.BtnExit = new System.Windows.Forms.Button();
            this.CocktailsListTab = new System.Windows.Forms.TabPage();
            this.PumpsListTab = new System.Windows.Forms.TabPage();
            this.TabIngredients = new System.Windows.Forms.TabPage();
            this.WindowControlls.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowControlls
            // 
            this.WindowControlls.Controls.Add(this.HomeTab);
            this.WindowControlls.Controls.Add(this.CocktailsListTab);
            this.WindowControlls.Controls.Add(this.PumpsListTab);
            this.WindowControlls.Controls.Add(this.TabIngredients);
            this.WindowControlls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowControlls.Location = new System.Drawing.Point(0, 0);
            this.WindowControlls.Name = "WindowControlls";
            this.WindowControlls.SelectedIndex = 0;
            this.WindowControlls.Size = new System.Drawing.Size(955, 596);
            this.WindowControlls.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.BtnExit);
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(947, 570);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(8, 8);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CocktailsListTab
            // 
            this.CocktailsListTab.Location = new System.Drawing.Point(4, 22);
            this.CocktailsListTab.Name = "CocktailsListTab";
            this.CocktailsListTab.Padding = new System.Windows.Forms.Padding(3);
            this.CocktailsListTab.Size = new System.Drawing.Size(947, 570);
            this.CocktailsListTab.TabIndex = 1;
            this.CocktailsListTab.Text = "CocktailsListPage";
            this.CocktailsListTab.UseVisualStyleBackColor = true;
            // 
            // PumpsListTab
            // 
            this.PumpsListTab.Location = new System.Drawing.Point(4, 22);
            this.PumpsListTab.Name = "PumpsListTab";
            this.PumpsListTab.Size = new System.Drawing.Size(947, 570);
            this.PumpsListTab.TabIndex = 2;
            this.PumpsListTab.Text = "PumpsListPage";
            this.PumpsListTab.UseVisualStyleBackColor = true;
            // 
            // TabIngredients
            // 
            this.TabIngredients.Location = new System.Drawing.Point(4, 22);
            this.TabIngredients.Name = "TabIngredients";
            this.TabIngredients.Size = new System.Drawing.Size(947, 570);
            this.TabIngredients.TabIndex = 3;
            this.TabIngredients.Text = "Ingredients";
            this.TabIngredients.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(955, 596);
            this.Controls.Add(this.WindowControlls);
            this.Name = "MainWindow";
            this.WindowControlls.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TabControl WindowControlls;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TabPage CocktailsListTab;
        private System.Windows.Forms.TabPage PumpsListTab;
        private System.Windows.Forms.TabPage TabIngredients;
    }
}