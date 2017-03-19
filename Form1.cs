using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Create variable to store number
            int intInput;
            //Get value from NumericUpDown
            intInput = (int)nudInput.Value;
            //Create variable to store output
            string strOutput = intInput.ToString() + " was entered.\n" +
                (intInput + 1).ToString() + " is after you add 1!";
            //Display output
            lblOutput.Text = strOutput;
        }
    }
}
