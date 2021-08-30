using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        Form1 fm1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            fm1 = form1;
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp);
            this.buttonChenFluid.Click += new System.EventHandler(this.buttonChenFluid_Click);
        }

        private void buttonChenFluid_Click(object sender, EventArgs e)
        {
            string s1 = this.textBoxFluid1.Text;
            string s2 = this.textBoxFluid2.Text;
            Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
            Regex regex2 = new Regex(@"(^\d+),?(\d+$)");
            Regex regex11 = new Regex(@"(^\d+)(,+$)");
            MatchCollection matches1 = regex1.Matches(s1);
            MatchCollection matches2 = regex1.Matches(s2);
            MatchCollection matches11 = regex11.Matches(s1);
            MatchCollection matches22 = regex11.Matches(s2);
            if (matches1.Count > 0 & matches2.Count > 0 & matches11.Count == 0 & matches22.Count == 0)
            {
                this.Hide();

                fm1.byki.Enqueue("label12");
                fm1.byki2.Enqueue(this.textBoxFluid1.Text);

                fm1.byki.Enqueue("label12b");
                fm1.byki2.Enqueue(this.textBoxFluid2.Text);

                //fm1.label12.Text = this.textBoxFluid1.Text;
                //fm1.label12b.Text = this.textBoxFluid2.Text;
                
                if (this.textBoxFluid1.Text == "0" || this.textBoxFluid2.Text == "0")
                {
                    this.textBoxFluid1.Text = fm1.label12.Text;
                    this.textBoxFluid2.Text = fm1.label12b.Text;
                    MessageBox.Show("Введите повторно");
                }
                
                
            }else if (this.textBoxFluid1.Text == "" & this.textBoxFluid2.Text == "")
            {
                this.textBoxFluid1.Text = fm1.label12.Text;
                this.textBoxFluid2.Text = fm1.label12b.Text;
            }
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonChenFluid.PerformClick(); ;
                //MessageBox.Show("Сработала");
            }
        }

        private void textBoxFluid1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(e.KeyChar >= 48 & e.KeyChar <= 58) & (e.KeyChar != 44) & e.KeyChar != 8 & e.KeyChar != 0)
            {
                e.Handled = true;
            }
        }

        private void textBoxFluid2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(e.KeyChar >= 48 & e.KeyChar <= 58) & (e.KeyChar != 44) & e.KeyChar != 8 & e.KeyChar != 0)
            {
                e.Handled = true;
            }
        }
    }
}
