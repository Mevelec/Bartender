namespace Bartender.Display
{
    partial class IngLiquid
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.LblComposition = new System.Windows.Forms.Label();
            this.LblNutritionalValue = new System.Windows.Forms.Label();
            this.TextBoxNutritionalValue = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitle.Location = new System.Drawing.Point(3, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(459, 13);
            this.LblTitle.TabIndex = 5;
            this.LblTitle.Text = "Liquid";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(3, 13);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(3, 29);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(459, 20);
            this.TextBoxName.TabIndex = 1;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(3, 52);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(60, 13);
            this.LblDescription.TabIndex = 2;
            this.LblDescription.Text = "Description";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(3, 68);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(459, 20);
            this.TextBoxDescription.TabIndex = 6;
            // 
            // LblComposition
            // 
            this.LblComposition.AutoSize = true;
            this.LblComposition.Location = new System.Drawing.Point(3, 91);
            this.LblComposition.Name = "LblComposition";
            this.LblComposition.Size = new System.Drawing.Size(64, 13);
            this.LblComposition.TabIndex = 3;
            this.LblComposition.Text = "Composition";
            // 
            // LblNutritionalValue
            // 
            this.LblNutritionalValue.AutoSize = true;
            this.LblNutritionalValue.Location = new System.Drawing.Point(3, 104);
            this.LblNutritionalValue.Name = "LblNutritionalValue";
            this.LblNutritionalValue.Size = new System.Drawing.Size(84, 13);
            this.LblNutritionalValue.TabIndex = 4;
            this.LblNutritionalValue.Text = "Nutritional Value";
            // 
            // TextBoxNutritionalValue
            // 
            this.TextBoxNutritionalValue.Location = new System.Drawing.Point(3, 120);
            this.TextBoxNutritionalValue.Name = "TextBoxNutritionalValue";
            this.TextBoxNutritionalValue.Size = new System.Drawing.Size(459, 20);
            this.TextBoxNutritionalValue.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LblTitle);
            this.flowLayoutPanel1.Controls.Add(this.LblName);
            this.flowLayoutPanel1.Controls.Add(this.TextBoxName);
            this.flowLayoutPanel1.Controls.Add(this.LblDescription);
            this.flowLayoutPanel1.Controls.Add(this.TextBoxDescription);
            this.flowLayoutPanel1.Controls.Add(this.LblComposition);
            this.flowLayoutPanel1.Controls.Add(this.LblNutritionalValue);
            this.flowLayoutPanel1.Controls.Add(this.TextBoxNutritionalValue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(501, 414);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // IngLiquid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "IngLiquid";
            this.Size = new System.Drawing.Size(501, 414);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label LblComposition;
        private System.Windows.Forms.Label LblNutritionalValue;
        private System.Windows.Forms.TextBox TextBoxNutritionalValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
