using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window_keshi
{
    public partial class Form1 : Form
    {
        private int alarmHour = 0;
        private int alarmMinute = 0;
        private int alarmSecond = 0;
        private bool finishFlag = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            TimeSpan span = new TimeSpan(0, 0, 10);
            DateTime setTime = dateTime.Add(span);
            alarmHour = setTime.Hour;
            alarmMinute = setTime.Minute;
            alarmSecond = setTime.Second;

            Nyoki1 nyoki1 = new Nyoki1();
            for (int i = 0; i < 20; i++)
            {
                if (finishFlag == false)
                {
                    nyoki1.ShowDialog();
                }
                else if (finishFlag == true)
                {
                    break;
                }
            }
            nyoki1.Dispose();



        }

        private void label1Timer_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1Timer.Text = now.ToLongTimeString();
            if (now.Hour == alarmHour && now.Minute == alarmMinute && now.Second == alarmSecond)
            {
                finishFlag = true;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
