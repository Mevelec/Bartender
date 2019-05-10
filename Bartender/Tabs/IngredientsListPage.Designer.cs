namespace Bartender.Forms
{
    partial class IngredientsListPage
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
            this.ListBoxIngredients = new System.Windows.Forms.ListBox();
            this.TabAddIngredient = new System.Windows.Forms.TabControl();
            this.TabInfos = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectType = new System.Windows.Forms.ComboBox();
            this.BoxIngredientForm = new System.Windows.Forms.GroupBox();
            this.BtnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.TabAddIngredient.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ListBoxIngredients, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TabAddIngredient, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnLayout, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnRefresh, 0, 1);
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
            // ListBoxIngredients
            // 
            this.ListBoxIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxIngredients.FormattingEnabled = true;
            this.ListBoxIngredients.Location = new System.Drawing.Point(0, 0);
            this.ListBoxIngredients.Margin = new System.Windows.Forms.Padding(0);
            this.ListBoxIngredients.Name = "ListBoxIngredients";
            this.ListBoxIngredients.Size = new System.Drawing.Size(450, 626);
            this.ListBoxIngredients.TabIndex = 0;
            this.ListBoxIngredients.SelectedIndexChanged += new System.EventHandler(this.ListBoxIngredients_SelectedIndexChanged);
            // 
            // TabAddIngredient
            // 
            this.TabAddIngredient.Controls.Add(this.TabInfos);
            this.TabAddIngredient.Controls.Add(this.tabPage2);
            this.TabAddIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabAddIngredient.Location = new System.Drawing.Point(450, 0);
            this.TabAddIngredient.Margin = new System.Windows.Forms.Padding(0);
            this.TabAddIngredient.Name = "TabAddIngredient";
            this.TabAddIngredient.SelectedIndex = 0;
            this.TabAddIngredient.Size = new System.Drawing.Size(450, 626);
            this.TabAddIngredient.TabIndex = 1;
            // 
            // TabInfos
            // 
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
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Ingredient";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.SelectType, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BoxIngredientForm, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(436, 594);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SelectType
            // 
            this.SelectType.FormattingEnabled = true;
            this.SelectType.Location = new System.Drawing.Point(3, 3);
            this.SelectType.Name = "SelectType";
            this.SelectType.Size = new System.Drawing.Size(430, 21);
            this.SelectType.TabIndex = 0;
            this.SelectType.SelectedIndexChanged += new System.EventHandler(this.SelectType_SelectedIndexChanged);
            // 
            // BoxIngredientForm
            // 
            this.BoxIngredientForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxIngredientForm.Location = new System.Drawing.Point(3, 43);
            this.BoxIngredientForm.Name = "BoxIngredientForm";
            this.BoxIngredientForm.Size = new System.Drawing.Size(430, 548);
            this.BoxIngredientForm.TabIndex = 1;
            this.BoxIngredientForm.TabStop = false;
            this.BoxIngredientForm.Text = "Form";
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
            // BtnRefresh
            // 
            this.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRefresh.Location = new System.Drawing.Point(3, 629);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(444, 34);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // IngredientsListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IngredientsListPage";
            this.Size = new System.Drawing.Size(900, 666);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TabAddIngredient.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox ListBoxIngredients;
        private System.Windows.Forms.TabControl TabAddIngredient;
        private System.Windows.Forms.TabPage TabInfos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel BtnLayout;
        private System.Windows.Forms.ComboBox SelectType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox BoxIngredientForm;
        private System.Windows.Forms.Button BtnRefresh;
    }
}
