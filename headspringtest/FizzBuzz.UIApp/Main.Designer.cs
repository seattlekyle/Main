namespace FizzBuzz.UIApp
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SecondNumOutputText = new System.Windows.Forms.TextBox();
            this.textBox_FirstNumOutputText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_FirstNum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SecondNum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_RangeStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_RangeEnd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Both = new System.Windows.Forms.Label();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.button_GetResults = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FirstNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SecondNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RangeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RangeEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "If Divisible by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "If Divisible By:";
            // 
            // textBox_SecondNumOutputText
            // 
            this.textBox_SecondNumOutputText.Location = new System.Drawing.Point(317, 157);
            this.textBox_SecondNumOutputText.Name = "textBox_SecondNumOutputText";
            this.textBox_SecondNumOutputText.Size = new System.Drawing.Size(146, 20);
            this.textBox_SecondNumOutputText.TabIndex = 7;
            this.textBox_SecondNumOutputText.TextChanged += new System.EventHandler(this.textBox_Output_TextChanged);
            // 
            // textBox_FirstNumOutputText
            // 
            this.textBox_FirstNumOutputText.Location = new System.Drawing.Point(317, 111);
            this.textBox_FirstNumOutputText.Name = "textBox_FirstNumOutputText";
            this.textBox_FirstNumOutputText.Size = new System.Drawing.Size(146, 20);
            this.textBox_FirstNumOutputText.TabIndex = 6;
            this.textBox_FirstNumOutputText.TextChanged += new System.EventHandler(this.textBox_Output_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Then Outputs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Then Outputs:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(451, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "This application will take two numbers, two output strings and output the corresp" +
    "onding text if divisible by them or both text values if divisible by both.";
            // 
            // numericUpDown_FirstNum
            // 
            this.numericUpDown_FirstNum.Location = new System.Drawing.Point(88, 112);
            this.numericUpDown_FirstNum.Name = "numericUpDown_FirstNum";
            this.numericUpDown_FirstNum.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_FirstNum.TabIndex = 9;
            // 
            // numericUpDown_SecondNum
            // 
            this.numericUpDown_SecondNum.Location = new System.Drawing.Point(88, 153);
            this.numericUpDown_SecondNum.Name = "numericUpDown_SecondNum";
            this.numericUpDown_SecondNum.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_SecondNum.TabIndex = 10;
            // 
            // numericUpDown_RangeStart
            // 
            this.numericUpDown_RangeStart.Location = new System.Drawing.Point(88, 72);
            this.numericUpDown_RangeStart.Name = "numericUpDown_RangeStart";
            this.numericUpDown_RangeStart.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_RangeStart.TabIndex = 14;
            // 
            // numericUpDown_RangeEnd
            // 
            this.numericUpDown_RangeEnd.Location = new System.Drawing.Point(317, 71);
            this.numericUpDown_RangeEnd.Name = "numericUpDown_RangeEnd";
            this.numericUpDown_RangeEnd.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_RangeEnd.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Range Start:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Range End:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "If Divisible by Both Then Outputs:";
            // 
            // label_Both
            // 
            this.label_Both.AutoSize = true;
            this.label_Both.Location = new System.Drawing.Point(241, 197);
            this.label_Both.Name = "label_Both";
            this.label_Both.Size = new System.Drawing.Size(0, 13);
            this.label_Both.TabIndex = 16;
            // 
            // textBox_Log
            // 
            this.textBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Log.Location = new System.Drawing.Point(14, 223);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ReadOnly = true;
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Log.Size = new System.Drawing.Size(449, 120);
            this.textBox_Log.TabIndex = 17;
            // 
            // button_GetResults
            // 
            this.button_GetResults.Location = new System.Drawing.Point(388, 358);
            this.button_GetResults.Name = "button_GetResults";
            this.button_GetResults.Size = new System.Drawing.Size(75, 23);
            this.button_GetResults.TabIndex = 18;
            this.button_GetResults.Text = "Get Results";
            this.button_GetResults.UseVisualStyleBackColor = true;
            this.button_GetResults.Click += new System.EventHandler(this.button_GetResults_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(307, 358);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 19;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 393);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_GetResults);
            this.Controls.Add(this.textBox_Log);
            this.Controls.Add(this.label_Both);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_RangeStart);
            this.Controls.Add(this.numericUpDown_RangeEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_SecondNum);
            this.Controls.Add(this.numericUpDown_FirstNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_SecondNumOutputText);
            this.Controls.Add(this.textBox_FirstNumOutputText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criteria Output UI Application";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FirstNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SecondNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RangeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RangeEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SecondNumOutputText;
        private System.Windows.Forms.TextBox textBox_FirstNumOutputText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_FirstNum;
        private System.Windows.Forms.NumericUpDown numericUpDown_SecondNum;
        private System.Windows.Forms.NumericUpDown numericUpDown_RangeStart;
        private System.Windows.Forms.NumericUpDown numericUpDown_RangeEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Both;
        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.Button button_GetResults;
        private System.Windows.Forms.Button button_Clear;
    }
}

