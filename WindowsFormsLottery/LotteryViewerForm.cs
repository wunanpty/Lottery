using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLottery.Common;

namespace WindowsFormsLottery
{
    public partial class LotteryViewerForm : Form
    {
        /// <summary>
        /// DoubleColorball Rules
        /// To play DoubleColorball, you must select six red numbers from a pool between 1 and 33,
        /// and one blue number between 1 and 16. The blue number you select can be the same as
        /// one of the six red numbers.
        /// </summary>
        public LotteryViewerForm()
        {
            InitializeComponent();
            this.buttonStart.Enabled = true;
            this.buttonStop.Enabled = false;
        }

        #region Data
        /// <summary>
        /// Red numbers
        /// </summary>
        private string[] RedNums =
        {
            "01","02","03","04","05","06","07","08","09","10",
            "11","12","13","14","15","16","17","18","19","20",
            "21","22","23","24","25","26","27","28","29","30",
            "31","32","33"
        };

        /// <summary>
        /// Blue numbers
        /// </summary>
        private string[] BlueNums =
        {
            "01","02","03","04","05","06","07","08","09","10",
            "11","12","13","14","15","16"
        };

        private bool isGoOn = true;
        private List<Task> taskList = new List<Task>();
        #endregion

        #region UI
        /// <summary>
        /// Click Start Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                #region Initial Form
                this.buttonStart.Text = "Runing";
                this.buttonStart.Enabled = false;
                this.isGoOn = true;
                this.taskList = new List<Task>();
                // Reset all balls to 00
                this.labelBlue.Text = "00";
                this.labelRed1.Text = "00";
                this.labelRed2.Text = "00";
                this.labelRed3.Text = "00";
                this.labelRed4.Text = "00";
                this.labelRed5.Text = "00";
                this.labelRed6.Text = "00";
                #endregion

                Thread.Sleep(1000);
                TaskFactory taskFactory = new TaskFactory();

                foreach (var control in this.groupBox.Controls)
                {
                    if (control is Label)
                    {
                        Label lbl = (Label)control;

                        //Update blue ball
                        if (lbl.Name.Contains("Blue"))
                        {
                            taskFactory.StartNew(() =>
                            {
                                // Get a number from BlueNums
                                while (true)
                                {
                                    int indexNum = new RandomHelper().GetRandomNumberDelay(0, this.BlueNums.Length);
                                    string sNumber = this.BlueNums[indexNum];
                                    this.UpdateLabel(lbl, sNumber);
                                }
                                
                            });
                        }
                        //Update red ball
                        else
                        {
                            taskFactory.StartNew(() =>
                            {
                                // Get a number from BlueNums
                                while (true)
                                {
                                    int indexNum = new RandomHelper().GetRandomNumberDelay(0, this.RedNums.Length);
                                    string sNumber = this.RedNums[indexNum];
                                    this.UpdateLabel(lbl, sNumber);
                                }

                            });
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("DoubleColorball has exception: {0}", ex.Message);
            }
        }

        #endregion

        private void buttonStop_Click(object sender, EventArgs e)
        {

        }

        #region PrivateMethod
        private void UpdateLabel(Label lbl, string text)
        {
            if (lbl.InvokeRequired)
            {
                //Let UI thread to update label text
                this.Invoke(new Action(() =>
                {
                    lbl.Text = text;
                    Console.WriteLine($"Current UpdateLabel thread id{Thread.CurrentThread.ManagedThreadId}");
                }));
            }
            else
            {
                lbl.Text = text;
            }
        }
        #endregion
    }
}
