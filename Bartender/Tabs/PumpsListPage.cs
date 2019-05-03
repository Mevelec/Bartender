using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartender.Forms
{
    public partial class PumpsListPage : UserControl
    {
        private Pumps.Logic.IPumpManager pumpManager = Pumps.PumpFacade.Instance.GetPumpManager();
        public PumpsListPage()
        {
            InitializeComponent();
            this.refreshData();
            this.ListBoxPumps.DisplayMember = "name";
            this.ListBoxPumps.ValueMember = "id";
        }

        private void ListBoxPumps_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pumps.Logic.IPump item = this.ListBoxPumps.SelectedItem as Pumps.Logic.IPump;
            this.TextBoxName.Text = item.name;
            this.TextBoxDesciption.Text = item.description;
            this.TextBoxPin.Text = item.pin;
        }

        private void BtnUpdatePump_Click(object sender, EventArgs e)
        {
            Pumps.Logic.IPump item = this.ListBoxPumps.SelectedItem as Pumps.Logic.IPump;
            item.name = this.TextBoxName.Text;
            item.description = this.TextBoxDesciption.Text;
            item.pin  =  this.TextBoxPin.Text;
            this.pumpManager.UpdatePump(item);
            this.refreshData();
        }

        public void refreshData()
        {
            this.ListBoxPumps.DataSource = this.pumpManager.GetPumps();
        }
    }
}
