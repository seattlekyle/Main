using System;
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
            FizzBuzzHelper outputter = new FizzBuzzHelper(
                (int)numericUpDown_RangeStart.Value,
                (int)numericUpDown_RangeEnd.Value,
                new CriteriaOutputInfo[]
                {
                    new CriteriaOutputInfo(
                        (int)numericUpDown_FirstNum.Value,
                        textBox_FirstNumOutputText.Text),
                    new CriteriaOutputInfo(
                        (int)numericUpDown_SecondNum.Value,
                        textBox_SecondNumOutputText.Text)
                });
            
            foreach (string result in outputter.GetResults())
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
