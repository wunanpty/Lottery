
namespace WindowsFormsLottery
{
    partial class LotteryViewerForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelRed2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelRed3 = new System.Windows.Forms.Label();
            this.labelRed4 = new System.Windows.Forms.Label();
            this.labelRed5 = new System.Windows.Forms.Label();
            this.labelRed6 = new System.Windows.Forms.Label();
            this.labelRed1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.MintCream;
            this.groupBox.Controls.Add(this.buttonStop);
            this.groupBox.Controls.Add(this.labelBlue);
            this.groupBox.Controls.Add(this.labelRed2);
            this.groupBox.Controls.Add(this.buttonStart);
            this.groupBox.Controls.Add(this.labelRed3);
            this.groupBox.Controls.Add(this.labelRed4);
            this.groupBox.Controls.Add(this.labelRed5);
            this.groupBox.Controls.Add(this.labelRed6);
            this.groupBox.Controls.Add(this.labelRed1);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.groupBox.Location = new System.Drawing.Point(87, 61);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(676, 341);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "DoubleColorBall";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(497, 233);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(135, 42);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelBlue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelBlue.Location = new System.Drawing.Point(260, 211);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(41, 32);
            this.labelBlue.TabIndex = 6;
            this.labelBlue.Text = "00";
            // 
            // labelRed2
            // 
            this.labelRed2.AutoSize = true;
            this.labelRed2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelRed2.ForeColor = System.Drawing.Color.Red;
            this.labelRed2.Location = new System.Drawing.Point(100, 150);
            this.labelRed2.Name = "labelRed2";
            this.labelRed2.Size = new System.Drawing.Size(41, 32);
            this.labelRed2.TabIndex = 5;
            this.labelRed2.Text = "00";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(497, 61);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(135, 42);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelRed3
            // 
            this.labelRed3.AutoSize = true;
            this.labelRed3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelRed3.ForeColor = System.Drawing.Color.Red;
            this.labelRed3.Location = new System.Drawing.Point(170, 150);
            this.labelRed3.Name = "labelRed3";
            this.labelRed3.Size = new System.Drawing.Size(41, 32);
            this.labelRed3.TabIndex = 4;
            this.labelRed3.Text = "00";
            // 
            // labelRed4
            // 
            this.labelRed4.AutoSize = true;
            this.labelRed4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelRed4.ForeColor = System.Drawing.Color.Red;
            this.labelRed4.Location = new System.Drawing.Point(240, 150);
            this.labelRed4.Name = "labelRed4";
            this.labelRed4.Size = new System.Drawing.Size(41, 32);
            this.labelRed4.TabIndex = 3;
            this.labelRed4.Text = "00";
            // 
            // labelRed5
            // 
            this.labelRed5.AutoSize = true;
            this.labelRed5.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelRed5.ForeColor = System.Drawing.Color.Red;
            this.labelRed5.Location = new System.Drawing.Point(310, 150);
            this.labelRed5.Name = "labelRed5";
            this.labelRed5.Size = new System.Drawing.Size(41, 32);
            this.labelRed5.TabIndex = 2;
            this.labelRed5.Text = "00";
            // 
            // labelRed6
            // 
            this.labelRed6.AutoSize = true;
            this.labelRed6.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelRed6.ForeColor = System.Drawing.Color.Red;
            this.labelRed6.Location = new System.Drawing.Point(380, 150);
            this.labelRed6.Name = "labelRed6";
            this.labelRed6.Size = new System.Drawing.Size(41, 32);
            this.labelRed6.TabIndex = 1;
            this.labelRed6.Text = "00";
            // 
            // labelRed1
            // 
            this.labelRed1.AutoSize = true;
            this.labelRed1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelRed1.ForeColor = System.Drawing.Color.Red;
            this.labelRed1.Location = new System.Drawing.Point(30, 150);
            this.labelRed1.Name = "labelRed1";
            this.labelRed1.Size = new System.Drawing.Size(41, 32);
            this.labelRed1.TabIndex = 0;
            this.labelRed1.Text = "00";
            // 
            // LotteryViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 475);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "LotteryViewerForm";
            this.Text = "Lottery Viewer Form";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelRed2;
        private System.Windows.Forms.Label labelRed3;
        private System.Windows.Forms.Label labelRed4;
        private System.Windows.Forms.Label labelRed5;
        private System.Windows.Forms.Label labelRed6;
        private System.Windows.Forms.Label labelRed1;
    }
}

