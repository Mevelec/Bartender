namespace Bartender.Forms
{
    partial class CocktailsListPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ListBoxCocktails = new System.Windows.Forms.ListBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabInfos = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblName = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblVolume = new System.Windows.Forms.Label();
            this.LblAlcoholDegree = new System.Windows.Forms.Label();
            this.LblListIngredients = new System.Windows.Forms.Label();
            this.LblRecipe = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxVolume = new System.Windows.Forms.TextBox();
            this.TextBoxAlcoholDegree = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TabInfos.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ListBoxCocktails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TabControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnLayout, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 666);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ListBoxCocktails
            // 
            this.ListBoxCocktails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxCocktails.FormattingEnabled = true;
            this.ListBoxCocktails.Location = new System.Drawing.Point(0, 0);
            this.ListBoxCocktails.Margin = new System.Windows.Forms.Padding(0);
            this.ListBoxCocktails.Name = "ListBoxCocktails";
            this.ListBoxCocktails.Size = new System.Drawing.Size(450, 626);
            this.ListBoxCocktails.TabIndex = 0;
            this.ListBoxCocktails.SelectedIndexChanged += new System.EventHandler(this.ListBoxCocktails_SelectedIndexChanged);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabInfos);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(450, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(450, 626);
            this.TabControl.TabIndex = 1;
            // 
            // TabInfos
            // 
            this.TabInfos.Controls.Add(this.flowLayoutPanel1);
            this.TabInfos.Location = new System.Drawing.Point(4, 22);
            this.TabInfos.Margin = new System.Windows.Forms.Padding(0);
            this.TabInfos.Name = "TabInfos";
            this.TabInfos.Padding = new System.Windows.Forms.Padding(3);
            this.TabInfos.Size = new System.Drawing.Size(442, 600);
            this.TabInfos.TabIndex = 0;
            this.TabInfos.Text = "Infos";
            this.TabInfos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnLayout
            // 
            this.BtnLayout.ColumnCount = 2;
            this.BtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BtnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLayout.Location = new System.Drawing.Point(450, 626);
            this.BtnLayout.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLayout.Name = "BtnLayout";
            this.BtnLayout.RowCount = 1;
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BtnLayout.Size = new System.Drawing.Size(450, 40);
            this.BtnLayout.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LblName);
            this.flowLayoutPanel1.Controls.Add(this.TextBoxName);
            this.flowLayoutPanel1.Controls.Add(this.LblDescription);
            this.flowLayoutPanel1.Controls.Add(this.TextBoxDescription);
            this.flowLayoutPanel1.Controls.Add(this.LblVolume);
            this.flowLayoutPanel1.Controls.Add(this.TextBoxVolume);
            this.flowLayoutPanel1.Controls.Add(this.LblAlcoholDegree);
            this.flowLayoutPanel1.Controls.Add(this.TextBoxAlcoholDegree);
            this.flowLayoutPanel1.Controls.Add(this.LblListIngredients);
            this.flowLayoutPanel1.Controls.Add(this.LblRecipe);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 594);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(3, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(3, 39);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(60, 13);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "Description";
            // 
            // LblVolume
            // 
            this.LblVolume.AutoSize = true;
            this.LblVolume.Location = new System.Drawing.Point(3, 78);
            this.LblVolume.Name = "LblVolume";
            this.LblVolume.Size = new System.Drawing.Size(42, 13);
            this.LblVolume.TabIndex = 2;
            this.LblVolume.Text = "Volume";
            // 
            // LblAlcoholDegree
            // 
            this.LblAlcoholDegree.AutoSize = true;
            this.LblAlcoholDegree.Location = new System.Drawing.Point(3, 117);
            this.LblAlcoholDegree.Name = "LblAlcoholDegree";
            this.LblAlcoholDegree.Size = new System.Drawing.Size(80, 13);
            this.LblAlcoholDegree.TabIndex = 3;
            this.LblAlcoholDegree.Text = "Alcohol Degree";
            // 
            // LblListIngredients
            // 
            this.LblListIngredients.AutoSize = true;
            this.LblListIngredients.Location = new System.Drawing.Point(3, 156);
            this.LblListIngredients.Name = "LblListIngredients";
            this.LblListIngredients.Size = new System.Drawing.Size(78, 13);
            this.LblListIngredients.TabIndex = 4;
            this.LblListIngredients.Text = "Ingredients List";
            // 
            // LblRecipe
            // 
            this.LblRecipe.AutoSize = true;
            this.LblRecipe.Location = new System.Drawing.Point(3, 169);
            this.LblRecipe.Name = "LblRecipe";
            this.LblRecipe.Size = new System.Drawing.Size(41, 13);
            this.LblRecipe.TabIndex = 5;
            this.LblRecipe.Text = "Recipe";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(3, 16);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(436, 20);
            this.TextBoxName.TabIndex = 6;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(3, 55);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(436, 20);
            this.TextBoxDescription.TabIndex = 7;
            // 
            // TextBoxVolume
            // 
            this.TextBoxVolume.Location = new System.Drawing.Point(3, 94);
            this.TextBoxVolume.Name = "TextBoxVolume";
            this.TextBoxVolume.Size = new System.Drawing.Size(436, 20);
            this.TextBoxVolume.TabIndex = 8;
            // 
            // TextBoxAlcoholDegree
            // 
            this.TextBoxAlcoholDegree.Location = new System.Drawing.Point(3, 133);
            this.TextBoxAlcoholDegree.Name = "TextBoxAlcoholDegree";
            this.TextBoxAlcoholDegree.Size = new System.Drawing.Size(436, 20);
            this.TextBoxAlcoholDegree.TabIndex = 9;
            // 
            // CocktailsListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CocktailsListPage";
            this.Size = new System.Drawing.Size(900, 666);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.TabInfos.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox ListBoxCocktails;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabInfos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel BtnLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblVolume;
        private System.Windows.Forms.Label LblAlcoholDegree;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.TextBox TextBoxVolume;
        private System.Windows.Forms.TextBox TextBoxAlcoholDegree;
        private System.Windows.Forms.Label LblListIngredients;
        private System.Windows.Forms.Label LblRecipe;
    }
}
