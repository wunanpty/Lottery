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
        /// The six red numbers should not have duplicated number.
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
        private static readonly object LotteryViewForm_Lock = new object();
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
                // Let select red and select blue threads keep running
                this.isGoOn = true;
                // Reset taskList
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

                        //Select/Update blue ball
                        if (lbl.Name.Contains("Blue"))
                        {
                            taskList.Add(taskFactory.StartNew(() =>
                            {
                                // Get a number from BlueNums
                                while (this.isGoOn)
                                {
                                    int indexNum = new RandomHelper().GetRandomNumberDelay(0, this.BlueNums.Length);
                                    string sNumber = this.BlueNums[indexNum];
                                    this.UpdateLabel(lbl, sNumber);
                                }
                                
                            }));
                        }
                        //Select/Update red ball
                        else
                        {
                           taskList.Add(taskFactory.StartNew(() =>
                            {
                                // Get a number from RedNums
                                // How to make sure the six red numbers are non-duplicated number?
                                //      check current labels' text, see if this number is already exist
                                // But, there is another case might make two labels have same number
                                //      due to multi-thread, at some moment, it might happen that there are 2 thread 
                                //      check the current labels, and found there is no 7, so both of them update label with 7
                                //      so we need a lock here
                                while (this.isGoOn)
                                {
                                    int indexNum = new RandomHelper().GetRandomNumberDelay(0, this.RedNums.Length);
                                    string sNumber = this.RedNums[indexNum];
                                    lock (LotteryViewForm_Lock)
                                    {
                                        if (this.IsExistInRed(sNumber))
                                        {
                                            continue;
                                        }
                                        this.UpdateLabel(lbl, sNumber);
                                    }
                                }
                            }));
                        }
                    }
                }
                // A correct timing to enable Stop button
                // Use a thread to check if current all labels' text include "00"
                // An example of dead-lock: UI thread wait for update, other threads wait for UI update for them
                //while (true)
                //{
                //    Thread.Sleep(1000);
                //    if (!this.IsExistInRed("00") && !this.labelBlue.Text.Equals("00"))
                //    {
                //        this.buttonStop.Enabled = true;
                //        break;
                //    }
                //}
                Task.Run(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(1000);
                        if (!this.IsExistInRed("00") && !this.labelBlue.Text.Equals("00"))
                        {
                            // Remember that we need to ask UI thread to update the button status
                            this.Invoke(new Action(() =>
                            {
                                this.buttonStop.Enabled = true;
                            }));
                            break;
                        }
                    }
                });

                // A correct timing to show Result
                // Creates a continuation task that starts when a set of specified tasks has completed.
                // after clicke the stop button, need to wait for all red and blue threads complete
                taskFactory.ContinueWhenAll(this.taskList.ToArray(), tArray => this.ShowResult());
            }
            catch (Exception ex)
            {
                Console.WriteLine("DoubleColorball has exception: {0}", ex.Message);
            }
        }

        #endregion

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.buttonStop.Enabled = false;
            this.buttonStart.Enabled = true;
            this.buttonStart.Text = "Start";
            // Let isGoOn become to false, all while loop will stop, but the already trigged thread will run until complete.
            this.isGoOn = false;
            // If call ShowResult() here, the message is different with labels, because there is a delay for the 
            // the running threads
            //this.ShowResult();
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
                   // Console.WriteLine($"Current UpdateLabel thread id{Thread.CurrentThread.ManagedThreadId}");
                }));
            }
            else
            {
                lbl.Text = text;
            }
        }

        private bool IsExistInRed(string sNumber)
        {
            foreach (var control in this.groupBox.Controls)
            {
                if (control is Label)
                {
                    Label lbl = (Label)control;
                    if (lbl.Name.Contains("Red") && lbl.Text.Equals(sNumber))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void ShowResult()
        {
            MessageBox.Show(string.Format("Red balls: {0}, {1}, {2}, {3}, {4}, {5}  Blue ball: {6}"
                , this.labelRed1.Text
                , this.labelRed2.Text
                , this.labelRed3.Text
                , this.labelRed4.Text
                , this.labelRed5.Text
                , this.labelRed6.Text
                , this.labelBlue.Text));
        }
        #endregion
    }
}
