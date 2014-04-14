using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FizzBuzzLib;

namespace FizzBuzz.UIApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void textBox_Output_TextChanged(object sender, EventArgs e)
        {
            label_Both.Text = textBox_FirstNumOutputText.Text + textBox_SecondNumOutputText.Text;
        }

        private void button_GetResults_Click(object sender, EventArgs e)
        {
            FizzBuzzLib.FizzBuzz outputter = new FizzBuzzLib.FizzBuzz();
            
            CriteriaOutputInfo info = new CriteriaOutputInfo(
                (int)numericUpDown_FirstNum.Value,
                (int)numericUpDown_SecondNum.Value,
                textBox_FirstNumOutputText.Text,
                textBox_SecondNumOutputText.Text);

            foreach (string result in outputter.GetResults(
                (int)numericUpDown_RangeStart.Value,
                (int)numericUpDown_RangeEnd.Value,
                new CriteriaOutputInfo[] { info }))
            {
                textBox_Log.AppendText(result + Environment.NewLine);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Log.Clear();
        }
    }
}
