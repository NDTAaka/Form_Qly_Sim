﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Qly_Sim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSimData();
        }
        private void LoadSimData()
        {
            Connection dbConn = new Connection();
            DataTable simData = dbConn.GetSimData();
            dataGridViewSim.DataSource = simData;
        }
    }
}
