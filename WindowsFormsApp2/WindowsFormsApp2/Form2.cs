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
    public partial class Form2 : Form
    {
        Form1 fm1;
        
        public Form2(Form1 form1)
        {
            InitializeComponent();
            fm1 = form1;
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.buttonChen3.Click += new System.EventHandler(this.buttonChen3_Click);

            
            //this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            //this.buttonChen3.Click += new System.EventHandler(this.buttonChen3_Click);
        }

        public void buttonChen3_Click(object sender, EventArgs e)
        {
            string s1 = this.textBoxDl.Text;
            string s2 = this.textBoxDi.Text;
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

                fm1.byki.Enqueue("labelObra1");
                fm1.byki2.Enqueue(this.textBoxDl.Text);

                fm1.byki.Enqueue("labelObra2");
                fm1.byki2.Enqueue(this.textBoxDi.Text);

                //fm1.labelObra1.Text = this.textBoxDl.Text;
                //fm1.labelObra2.Text = this.textBoxDi.Text;

                if (this.textBoxDl.Text == "0" || this.textBoxDi.Text == "0")
                {
                    this.textBoxDl.Text = fm1.labelObra1.Text;
                    this.textBoxDi.Text = fm1.labelObra2.Text;
                    MessageBox.Show("Введите повторно");
                }
                
            }else if(this.textBoxDl.Text == "" & this.textBoxDi.Text == "")
            {
                //fm1.byki;
                //byki.Enqueue("textZero1");
                //byki2.Enqueue("0,0");
                this.textBoxDl.Text = fm1.labelObra1.Text;
                this.textBoxDi.Text = fm1.labelObra2.Text;
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonChen3.PerformClick(); 
                //MessageBox.Show("Сработала");
            }
        }

        private void textBoxDl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(e.KeyChar >= 48 & e.KeyChar <= 58) & (e.KeyChar != 44) & e.KeyChar != 8 & e.KeyChar != 0)
            {
                e.Handled = true;
            }
        }

        private void textBoxDi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(e.KeyChar >= 48 & e.KeyChar <= 58) & (e.KeyChar != 44) & e.KeyChar != 8 & e.KeyChar != 0)
            {
                e.Handled = true;
            }
        }
    }
}
