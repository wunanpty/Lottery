﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLottery
{
    public partial class LotteryViewerForm : Form
    {
        public LotteryViewerForm()
        {
            InitializeComponent();
            this.buttonStart.Enabled = true;
            this.buttonStop.Enabled = false;
        }

        #region Data
        /// <summary>
        /// Red balls
        /// </summary>
        private string[] RedNums =
        {
            "01","02","03","04","05","06","07","08","09","10",
            "11","12","13","14","15","16","17","18","19","20",
            "21","22","23","24","25","26","27","28","29","30",
            "31","32","33"
        };

        private string[] BlueNums =
        {
            "01","02","03","04","05","06","07","08","09","10",
            "11","12","13","14","15","16"
        };

        #endregion
    }
}