namespace Bartender.Forms
{
    partial class PumpsListPage
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
            this.BaseGridLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ListBoxPumps = new System.Windows.Forms.ListBox();
            this.TabsPumpsList = new System.Windows.Forms.TabControl();
            this.TabPumpData = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TextBoxDesciption = new System.Windows.Forms.TextBox();
            this.LblPin = new System.Windows.Forms.Label();
            this.TextBoxPin = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDeletePump = new System.Windows.Forms.Button();
            this.BtnUpdatePump = new System.Windows.Forms.Button();
            this.BaseGridLayout.SuspendLayout();
            this.TabsPumpsList.SuspendLayout();
            this.TabPumpData.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.BtnLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseGridLayout
            // 
            this.BaseGridLayout.ColumnCount = 2;
            this.BaseGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BaseGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BaseGridLayout.Controls.Add(this.ListBoxPumps, 0, 0);
            this.BaseGridLayout.Controls.Add(this.TabsPumpsList, 1, 0);
            this.BaseGridLayout.Controls.Add(this.BtnLayout, 1, 1);
            this.BaseGridLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseGridLayout.Location = new System.Drawing.Point(0, 0);
            this.BaseGridLayout.Name = "BaseGridLayout";
            this.BaseGridLayout.RowCount = 2;
            this.BaseGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BaseGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.BaseGridLayout.Size = new System.Drawing.Size(795, 507);
            this.BaseGridLayout.TabIndex = 0;
            // 
            // ListBoxPumps
            // 
            this.ListBoxPumps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxPumps.FormattingEnabled = true;
            this.ListBoxPumps.Location = new System.Drawing.Point(3, 3);
            this.ListBoxPumps.Name = "ListBoxPumps";
            this.ListBoxPumps.Size = new System.Drawing.Size(391, 461);
            this.ListBoxPumps.TabIndex = 0;
            this.ListBoxPumps.SelectedIndexChanged += new System.EventHandler(this.ListBoxPumps_SelectedIndexChanged);
            // 
            // TabsPumpsList
            // 
            this.TabsPumpsList.Controls.Add(this.TabPumpData);
            this.TabsPumpsList.Controls.Add(this.tabPage2);
            this.TabsPumpsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsPumpsList.Location = new System.Drawing.Point(397, 0);
            this.TabsPumpsList.Margin = new System.Windows.Forms.Padding(0);
            this.TabsPumpsList.Name = "TabsPumpsList";
            this.TabsPumpsList.SelectedIndex = 0;
            this.TabsPumpsList.Size = new System.Drawing.Size(398, 467);
            this.TabsPumpsList.TabIndex = 1;
            // 
            // TabPumpData
            // 
            this.TabPumpData.Controls.Add(this.flowLayoutPanel1);
            this.TabPumpData.Location = new System.Drawing.Point(4, 22);
            this.TabPumpData.Name = "TabPumpData";
            this.TabPumpData.Padding = new System.Windows.Forms.Padding(3);
            this.TabPumpData.Size = new System.Drawing.Size(390, 441);
            this.TabPumpData.TabIndex = 0;
            this.TabPumpData.Text = "Pump Data";
            this.TabPumpData.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.LblName);
            this.flowLayoutPanel1.Controls.Add(this.TextBoxName);
            this.flowLayoutPanel1.Controls.Add(this.LblDescription);
            this.flowLayoutPanel1.Controls.Add(this.TextBoxDesciption);
            this.flowLayoutPanel1.Controls.Add(this.LblPin);
            this.flowLayoutPanel1.Controls.Add(this.TextBoxPin);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 435);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(3, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(41, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name :";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(0, 13);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(378, 20);
            this.TextBoxName.TabIndex = 0;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(3, 33);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(66, 13);
            this.LblDescription.TabIndex = 2;
            this.LblDescription.Text = "Description :";
            // 
            // TextBoxDesciption
            // 
            this.TextBoxDesciption.Location = new System.Drawing.Point(0, 46);
            this.TextBoxDesciption.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxDesciption.Name = "TextBoxDesciption";
            this.TextBoxDesciption.Size = new System.Drawing.Size(378, 20);
            this.TextBoxDesciption.TabIndex = 4;
            // 
            // LblPin
            // 
            this.LblPin.AutoSize = true;
            this.LblPin.Location = new System.Drawing.Point(3, 66);
            this.LblPin.Name = "LblPin";
            this.LblPin.Size = new System.Drawing.Size(22, 13);
            this.LblPin.TabIndex = 3;
            this.LblPin.Text = "Pin";
            // 
            // TextBoxPin
            // 
            this.TextBoxPin.Location = new System.Drawing.Point(0, 79);
            this.TextBoxPin.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxPin.Name = "TextBoxPin";
            this.TextBoxPin.Size = new System.Drawing.Size(378, 20);
            this.TextBoxPin.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(384, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnLayout
            // 
            this.BtnLayout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLayout.ColumnCount = 3;
            this.BtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.BtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.BtnLayout.Controls.Add(this.BtnDeletePump, 0, 0);
            this.BtnLayout.Controls.Add(this.BtnUpdatePump, 2, 0);
            this.BtnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLayout.Location = new System.Drawing.Point(397, 467);
            this.BtnLayout.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLayout.Name = "BtnLayout";
            this.BtnLayout.RowCount = 1;
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BtnLayout.Size = new System.Drawing.Size(398, 40);
            this.BtnLayout.TabIndex = 2;
            // 
            // BtnDeletePump
            // 
            this.BtnDeletePump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDeletePump.Location = new System.Drawing.Point(3, 3);
            this.BtnDeletePump.Name = "BtnDeletePump";
            this.BtnDeletePump.Size = new System.Drawing.Size(194, 34);
            this.BtnDeletePump.TabIndex = 0;
            this.BtnDeletePump.Text = "Delete";
            this.BtnDeletePump.UseVisualStyleBackColor = true;
            // 
            // BtnUpdatePump
            // 
            this.BtnUpdatePump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdatePump.Location = new System.Drawing.Point(201, 3);
            this.BtnUpdatePump.Name = "BtnUpdatePump";
            this.BtnUpdatePump.Size = new System.Drawing.Size(194, 34);
            this.BtnUpdatePump.TabIndex = 1;
            this.BtnUpdatePump.Text = "Update";
            this.BtnUpdatePump.UseVisualStyleBackColor = true;
            this.BtnUpdatePump.Click += new System.EventHandler(this.BtnUpdatePump_Click);
            // 
            // PumpsListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BaseGridLayout);
            this.Name = "PumpsListPage";
            this.Size = new System.Drawing.Size(795, 507);
            this.BaseGridLayout.ResumeLayout(false);
            this.TabsPumpsList.ResumeLayout(false);
            this.TabPumpData.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.BtnLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BaseGridLayout;
        private System.Windows.Forms.ListBox ListBoxPumps;
        private System.Windows.Forms.TabControl TabsPumpsList;
        private System.Windows.Forms.TabPage TabPumpData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel BtnLayout;
        private System.Windows.Forms.Button BtnDeletePump;
        private System.Windows.Forms.Button BtnUpdatePump;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TextBoxDesciption;
        private System.Windows.Forms.Label LblPin;
        private System.Windows.Forms.TextBox TextBoxPin;
    }
}
