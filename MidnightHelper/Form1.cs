﻿using MidnightHelper.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidnightHelper
{
    public partial class MainForm : Form
    {
        AppWorker appWorker;
        string setedTime;
        public MainForm()
        {
            appWorker = new AppWorker();
            InitializeComponent();
        }

        private void setTimerButton_Click(object sender, EventArgs e)
        {
            NumericStringCorrector correctorHours = new NumericStringCorrector(numericHours.Value.ToString());
            NumericStringCorrector correctorMinutes = new NumericStringCorrector(numericMinutes.Value.ToString());
            setedTime = $"{correctorHours.Corected}.{correctorMinutes.Corected}";
            appWorker.Start(setedTime);
        }
    }
}