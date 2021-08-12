using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reset_Relogio_Display
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = "Running...";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.SetThreadExecutionState(Program.EXECUTION_STATE.ES_AWAYMODE_REQUIRED | Program.EXECUTION_STATE.ES_CONTINUOUS | Program.EXECUTION_STATE.ES_DISPLAY_REQUIRED | Program.EXECUTION_STATE.ES_SYSTEM_REQUIRED);
        }
    }
}
