﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDO_Timers
{
    public partial class Form1 : Form
    {

        // State variables
        int tid1;
        int tid2;
        bool tid1On = false;
        bool tid2On = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //State the value of tid1 and sets the value of tid1On to true (Activates the timer).
            tid1 = 900;
            tid1On = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tid2 = 600;
            tid2On = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Disables the timer.
            tid1On = false;
            tid2On = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            doWork();

        }
        #region Functions

        //Create Method to perform task.
        private void doWork()
        {


            if (tid1On)
            {
                //Converts and posts the value of tid1 to string (15:00)
                label1.Text = tid1 / 60 + ":" + ((tid1 % 60) >= 10 ? (tid1 % 60).ToString() : "0" + tid1 % 60);
                //Subtracts the value from tid1 by 1 each time.
                tid1--;
                // if statement, to evaluate if the remaining value of tid1 is less than 0, and disables the timer if true.
                if (tid1 < 0)
                {
                    tid1On = false;
                }
            }

            if (tid2On)
            {
                label1.Text = tid2 / 60 + ":" + ((tid2 % 60) >= 10 ? (tid2 % 60).ToString() : "0" + tid2 % 60);
                tid2--;
                if (tid2 < 0)
                {
                    tid2On = false;

                }
            }

        }
        #endregion
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = trackBar1.Value * 0.1;

        }
    }
}
