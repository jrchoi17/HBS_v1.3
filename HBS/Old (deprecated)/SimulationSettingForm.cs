﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBS
{
    public partial class SimulationSettingForm : Form
    {
        public SimulationSettingForm()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            lblTheNumberOfProcesses.Enabled = radioButton.Checked;
            nudTheNumberOfProcesses.Enabled = radioButton.Checked;
        }
    }
}
