namespace Bartender.Dialogs
{
    partial class SelectIngredient
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
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearchIngredient = new System.Windows.Forms.TextBox();
            this.ListIngredients = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Tag = "Name";
            // 
            // textBoxSearchIngredient
            // 
            this.textBoxSearchIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearchIngredient.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearchIngredient.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearchIngredient.Name = "textBoxSearchIngredient";
            this.textBoxSearchIngredient.Size = new System.Drawing.Size(800, 20);
            this.textBoxSearchIngredient.TabIndex = 1;
            this.textBoxSearchIngredient.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.textBoxSearchIngredient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchIngredient_KeyUp);
            // 
            // ListIngredients
            // 
            this.ListIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListIngredients.Location = new System.Drawing.Point(0, 40);
            this.ListIngredients.Margin = new System.Windows.Forms.Padding(0);
            this.ListIngredients.Name = "ListIngredients";
            this.ListIngredients.Size = new System.Drawing.Size(800, 370);
            this.ListIngredients.TabIndex = 0;
            this.ListIngredients.UseCompatibleStateImageBehavior = false;
            this.ListIngredients.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListIngredients_ItemCheck);
            this.ListIngredients.SelectedIndexChanged += new System.EventHandler(this.ListIngredients_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ListIngredients, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSearchIngredient, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxQty, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddIngredient, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 410);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 40);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // textBoxQty
            // 
            this.textBoxQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQty.Location = new System.Drawing.Point(3, 3);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(394, 20);
            this.textBoxQty.TabIndex = 0;
            this.textBoxQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxQtyChanged);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddIngredient.Enabled = false;
            this.btnAddIngredient.Location = new System.Drawing.Point(403, 3);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(394, 34);
            this.btnAddIngredient.TabIndex = 1;
            this.btnAddIngredient.Text = "button1";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // SelectIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Text = "SelectIngredient";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.TextBox textBoxSearchIngredient;
        private System.Windows.Forms.ListView ListIngredients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.Button btnAddIngredient;
    }
}