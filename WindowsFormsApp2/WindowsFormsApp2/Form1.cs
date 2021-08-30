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
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;


namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        Form3 fm3;
        Form2 fm2;
        public Queue<double> numbers = new Queue<double>();
        public Queue<string> byki = new Queue<string>();
        public Queue<string> byki2 = new Queue<string>();
        double n; //Па*с
        double q; //м3/с
        double L;  //м
        double cP; //Па
        double F; // м2
        double k;
        string a;
        string b;
        string s1;
       
        Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
        Regex regex11 = new Regex(@"(^\d+)(,+$)");
   




        public Form1()
        {
            InitializeComponent();
            
        }
        

        
        private void buttonZero1_Click(object sender, EventArgs e)
        {
            byki.Enqueue("textZero1_Zero");
            byki2.Enqueue("0,0");
            //byki.Enqueue("textZero2_Zero");
            //byki2.Enqueue(textZero2.Text);
            //this.textZero1.Text = "0,0";
            //double D1;
            //double D2;
            //double Vechit;
            //D1 = double.Parse(this.textZero1.Text);
            //D2 = double.Parse(this.textZero2.Text);
            //Vechit = D1 - D2;
            //string Vech = "" + Vechit;
            //byki.Enqueue("textBox8");
            //byki2.Enqueue(Vech);
            //this.textBox8.Text = Vech;
        }
       

        private void buttonZero2_Click(object sender, EventArgs e)
        {
            byki.Enqueue("textZero2_Zero");
            byki2.Enqueue("0,0");
            //this.textZero2.Text = "0,0";
            //double D1 = double.Parse(this.textZero1.Text);
            //double D2 = double.Parse(this.textZero2.Text);
            //double Vechit = D1 - D2;
            //string Vech = "" + Vechit;
            //byki.Enqueue("textBox8");
            //byki2.Enqueue(Vech);
            //this.textBox8.Text = Vech;
        }

        private void buttonPlay2_Click(object sender, EventArgs e)
        {
            string s1 = this.textBox4.Text;
            Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
            Regex regex11 = new Regex(@"(^\d+)(,+$)");
            MatchCollection matches1 = regex1.Matches(s1);
            MatchCollection matches11 = regex11.Matches(s1);
            if (matches1.Count > 0 & matches11.Count == 0)
            {
                int i = 0;
                if (labelRejim.Text == "Расход")
                {
                    this.buttonPlay2.Image = global::WindowsFormsApp2.Properties.Resources.Снимок7;
                    labelRejim.Text = "Остановлен";
                    byki.Enqueue("textBox3");
                    byki2.Enqueue("0,0");
                    //this.textBox3.Text = "0,0";
                    i = 2;
                }


                if (labelRejim.Text == "Остановлен" & i == 0)
                {
                    this.buttonPlay2.Image = global::WindowsFormsApp2.Properties.Resources.Снимок8;
                    labelRejim.Text = "Расход";
                    double book1 = double.Parse(this.textBox4.Text);
                    double Res = book1;
                    string s = "" + Res;
                    byki.Enqueue("textBox3");
                    byki2.Enqueue(s);
                    //this.textBox3.Text = s;
                }

                if (i == 2)
                {
                    labelRejim.Text = "Остановлен";
                }
                if (labelRejim.Text == "Давление")
                {
                    MessageBox.Show("В данный момент запущен Давление");
                }
            }
            else
            {
                MessageBox.Show("Введите повторно");
            }

            
        }

        private void buttonAAA_Click(object sender, EventArgs e)
        {
            s1 = this.textBox1.Text;
            //Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
            //Regex regex11 = new Regex(@"(^\d+)(,+$)");
            MatchCollection matches1 = regex1.Matches(s1);
            MatchCollection matches11 = regex11.Matches(s1);
            if (matches1.Count > 0 & matches11.Count == 0)
            {
                if (this.textBox1.Text == "," || this.textBox1.Text == "")
                {
                    this.textBox1.Text = "0,0";
                }
                int i = 0;
                if (labelRejim.Text == "Давление")
                {
                    this.buttonAAA.Image = global::WindowsFormsApp2.Properties.Resources.Снимок7;
                    labelRejim.Text = "Остановлен";
                    byki.Enqueue("textBox3");
                    byki2.Enqueue("0,0");
                    //byki.Enqueue("textBox2");
                    //byki2.Enqueue("0,0");
                    //this.textBox3.Text = "0,0";
                    i = 2;
                }
                if (labelRejim.Text == "Остановлен" & i == 0)
                {
                    this.buttonAAA.Image = global::WindowsFormsApp2.Properties.Resources.Снимок8;
                    labelRejim.Text = "Давление";
                    Random rndd = new Random();
                    double valuee = rndd.Next(1, 60);
                    valuee = valuee / 1000;
                    double book11 = double.Parse(this.textBox4.Text);
                    double Ress = valuee + book11;
                    string ss = "" + Ress;
                    byki.Enqueue("textBox3");
                    byki2.Enqueue(ss);
                    //this.textBox3.Text = ss;
                    //this.textBox3.Text = this.textBox4.Text;
                    Random rnd = new Random();
                    double value = rnd.Next(30, 99);
                    value = value / 1000;
                    double book1 = double.Parse(this.textBox1.Text);
                    double Res = value + book1;
                    string s = "" + Res;
                    byki.Enqueue("textBox2");
                    byki2.Enqueue(s);
                    byki.Enqueue("textZero1But");
                    byki2.Enqueue(s);
                    byki.Enqueue("textZero2But");
                    double s4 = double.Parse(s) - 0.8;
                    string s5 = s4.ToString();
                    byki2.Enqueue(s5);
                }
                if (i == 2)
                {
                    labelRejim.Text = "Остановлен";
                }

                if (labelRejim.Text == "Расход")
                {
                    MessageBox.Show("В данный момент запущено Расход");
                }
            }
            else
            {
                MessageBox.Show("Введите повторно");
            }
        } 



        private void textZero1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (this.textZero1.Text == "," || this.textZero1.Text == "")
            //{
            //    this.textZero1.Text = "0,";
            //}
            //if (e.KeyCode == Keys.Enter)
            //{
            //    double D1 = double.Parse(this.textZero1.Text);
            //    double D2 = double.Parse(this.textZero2.Text);
            //    double Vechit = D1 - D2;
            //    Vechit = Math.Round(Vechit, 2);
            //    string Vech = "" + Vechit;
            //    this.textBox8.Text = Vech;
            //}
        }

        private void textZero2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double D1 = double.Parse(this.textZero1.Text);
                double D2 = double.Parse(this.textZero2.Text);
                double Vechit = D1 - D2;
                Vechit = Math.Round(Vechit, 2);
                string Vech = "" + Vechit;
                this.textBox8.Text = Vech;
            }
        }

        private void textZero1_TextChanged(object sender, EventArgs e)
        {
            if (this.textZero1.Text == "," || this.textZero1.Text == "" )
            {
                this.textZero1.Text = "0,";
            }
            //byki.Enqueue("textZero1");
            //byki2.Enqueue(textZero1.Text);
            //textZero1.Text = textZero1.Text;



            double D1 = double.Parse(this.textZero1.Text);
            double D2 = double.Parse(this.textZero2.Text);
            double Vechit = D1 - D2;
            Vechit = Math.Round(Vechit, 2);
            string Vech = "" + Vechit;
            //byki.Enqueue("textBox8");
            //byki2.Enqueue(Vech);
            this.textBox8.Text = Vech;
        }

        private void textZero1_Leave(object sender, EventArgs e)
        {
            string s1 = this.textZero1.Text;
            string s2 = this.textZero2.Text;
            Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
            Regex regex2 = new Regex(@"(^\d+),?(\d+$)");
            Regex regex11 = new Regex(@"(^\d+)(,+$)");
            MatchCollection matches1 = regex1.Matches(s1);
            MatchCollection matches2 = regex1.Matches(s2);
            MatchCollection matches11 = regex11.Matches(s1);
            MatchCollection matches22 = regex11.Matches(s2);
            if (matches1.Count > 0 & matches2.Count > 0 & matches11.Count == 0 & matches22.Count == 0)
            {
                byki.Enqueue("textZero1_Change");
                byki2.Enqueue(textZero1.Text);
                byki.Enqueue("textZero2_Change");
                byki2.Enqueue(textZero2.Text);
                //double D1 = double.Parse(this.textZero1.Text);
                //double D2 = double.Parse(this.textZero2.Text);
                //double Vechit = D1 - D2;
                //Vechit = Math.Round(Vechit, 2);
                //string Vech = "" + Vechit;
                //byki.Enqueue("textBox8_Change");
                //byki2.Enqueue(Vech);
                //this.textBox8.Text = Vech;
            }
            else
            {
                this.textZero1.Text = "0,0";
            }
        }

        private void textZero2_TextChanged(object sender, EventArgs e)
        {
            //double D1 = double.Parse(this.textZero1.Text);
            //double D2 = double.Parse(this.textZero2.Text);
            //double Vechit = D1 - D2;
            //Vechit = Math.Round(Vechit, 2);
            //string Vech = "" + Vechit;
            //this.textBox8.Text = Vech;
        }

        private void textZero2_Leave(object sender, EventArgs e)
        {
            string s1 = this.textZero1.Text;
            string s2 = this.textZero2.Text;
            Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
            Regex regex2 = new Regex(@"(^\d+),?(\d+$)");
            Regex regex11 = new Regex(@"(^\d+)(,+$)");
            MatchCollection matches1 = regex1.Matches(s1);
            MatchCollection matches2 = regex1.Matches(s2);
            MatchCollection matches11 = regex11.Matches(s1);
            MatchCollection matches22 = regex11.Matches(s2);
            if (matches1.Count > 0 & matches2.Count > 0 & matches11.Count == 0 & matches22.Count == 0)
            {
                byki.Enqueue("textZero2_Change");
                byki2.Enqueue(textZero2.Text);
                byki.Enqueue("textZero1_Change");
                byki2.Enqueue(textZero1.Text);
                //double D1 = double.Parse(this.textZero1.Text);
                //double D2 = double.Parse(this.textZero2.Text);
                //double Vechit = D1 - D2;
                //Vechit = Math.Round(Vechit, 2);
                //string Vech = "" + Vechit;
                //byki.Enqueue("textBox8");
                //byki2.Enqueue(Vech);
                
                //this.textBox8.Text = Vech;     textZero2_Change
            }
            else
            {
                this.textZero2.Text = "0,0";
            }
            
        }
      

        private void buttonChen1_Click(object sender, EventArgs e)
        {
            fm2 = new Form2(this);
            fm2.textBoxDl.Text = this.labelObra1.Text.Trim();
            fm2.textBoxDi.Text = this.labelObra2.Text.Trim();
            fm2.ShowDialog();
        }
        public void PerformRefresh()
        {
            //this.textBoxOb1.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBoxOb1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttonChen2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            fm3 = new Form3(this);
            fm3.textBoxFluid1.Text = this.label12.Text.Trim();
            fm3.textBoxFluid2.Text = this.label12b.Text.Trim();
            fm3.ShowDialog();
        }
   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fm3 = new Form3(this);
            if (this.comboBox1.Text == "Нефть")
            {
                this.label12b.Visible = false;
                this.label12.Visible = true;
                //this.label12.Text = fm3.textBoxFluid1.Text;
            }
            if (this.comboBox1.Text == "Вода")
            {
                this.label12.Visible = false;
                this.label12b.Visible = true;
                //this.label12b.Text = fm3.textBoxFluid2.Text;
            }

            //if (this.textBox3.Text != "" & this.textBox8.Text != "0" & this.textBox8.Text != "0,0" & this.labelObra1.Text != "" & this.labelObra2.Text != "" & this.labelObra2.Text != "0" & this.labelObra2.Text != "0,0" & this.label12.Text != "")
            //{
            //    if (this.comboBox1.Text == "Нефть")
            //    {
            //        n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //    }
            //    else
            //    {
            //        n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
            //    }
            //    q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
            //    L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
            //    cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
            //    F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
            //    k = n * q * L / (cP * F);
            //    k = k * 1000;
            //    k = Math.Round(k, 2);
            //    string koef = "" + k;
            //    //koef = koef.Substring(0, koef.Length - 9);
            //    this.labelResult.Text = koef;
            //}

        }

      

        private void labelResult_Click(object sender, EventArgs e)
        {
            //double n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //double q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
            //double L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
            //double cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
            //double F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
            //double k = n * q * L / (cP * F);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
            //q = (double.Parse(this.textBox3.Text)) / 1000000 / 60
            ////////numbers.Enqueue(q = (double.Parse(this.textBox3.Text)) / 1000000 / 60);
            //if (this.comboBox1.Text == "Нефть")
            //{
            //    n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //}
            //else
            //{
            //    n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
            //}
            //n = Math.Round(n, 2);
            //this.textBox3.Text = "" + n;

            //if(this.textBox3.Text != "" & this.textBox8.Text !="0" & this.textBox8.Text != "0,0" & this.labelObra1.Text != "" & this.labelObra2.Text != "" & this.labelObra2.Text != "0" & this.labelObra2.Text != "0,0" & this.label12.Text != "")
            //{
            //    if (this.comboBox1.Text == "Нефть")
            //    {
            //        n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //    }
            //    else
            //    {
            //        n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
            //    }
            //    q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
            //    L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
            //    cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
            //    F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
            //    k = n * q * L / (cP * F);
            //    k = k * 1000;
            //    k = Math.Round(k, 2);
            //    string koef = "" + k;
            //    this.labelResult.Text = koef;
            //}
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
            //numbers.Enqueue(cP);
            //numbers.Enqueue();
            
            //if (this.textBox3.Text != "" & this.textBox8.Text != "0" & this.textBox8.Text != "0,0" & this.labelObra1.Text != "" & this.labelObra2.Text != "" & this.labelObra2.Text != "0" & this.labelObra2.Text != "0,0" & this.label12.Text != "")
            //{
            //    if (this.comboBox1.Text == "Нефть")
            //    {
            //        n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //    }
            //    else
            //    {
            //        n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
            //    }
            //    q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
            //    L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
            //    cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
            //    F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
            //    k = n * q * L / (cP * F);
            //    k = k * 1000;
            //    k = Math.Round(k, 2);
            //    string koef = "" + k;
            //    //koef = koef.Substring(0, koef.Length - 9);
            //    this.labelResult.Text = koef;
            //}
        }


        
        private void labelObra1_TextChanged(object sender, EventArgs e)
        {
            
             //Now = labelObra1.Text;
             //labelObra1.Text = Last;
             //byki.Enqueue("labelObra1");
             //byki2.Enqueue(Now);
             //j = 1;
             //label17.Text = ""+j;
            
            



            ////L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
            ////numbers.Enqueue(L);
            //if (this.textBox3.Text != "" & this.textBox8.Text != "0" & this.textBox8.Text != "0,0" & this.labelObra1.Text != "" & this.labelObra2.Text != "" & this.labelObra2.Text != "0" & this.labelObra2.Text != "0,0" & this.label12.Text != "")
            //{
            //    if (this.comboBox1.Text == "Нефть")
            //    {
            //        n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //    }
            //    else
            //    {
            //        n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
            //    }
            //    q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
            //    L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
            //    cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
            //    F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
            //    k = n * q * L / (cP * F);
            //    k = k * 1000;
            //    k = Math.Round(k, 2);
            //    string koef = "" + k;
            //    //koef = koef.Substring(0, koef.Length - 9);
            //    this.labelResult.Text = koef;
            //}
        }

        private void labelObra2_TextChanged(object sender, EventArgs e)
        {
            //F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
            //numbers.Enqueue(F);

            //if (this.textBox3.Text != "" & this.textBox8.Text != "0" & this.textBox8.Text != "0,0" & this.labelObra1.Text != "" & this.labelObra2.Text != "" & this.labelObra2.Text != "0" & this.labelObra2.Text != "0,0" & this.label12.Text != "")
            //{
            //    if (this.comboBox1.Text == "Нефть")
            //    {
            //        n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //    }
            //    else
            //    {
            //        n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
            //    }
            //    q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
            //    L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
            //    cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
            //    F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
            //    k = n * q * L / (cP * F);
            //    k = k * 1000;
            //    k = Math.Round(k, 2);
            //    string koef = "" + k;
            //    //koef = koef.Substring(0, koef.Length - 9);
            //    this.labelResult.Text = koef;
            //}
        }

        private void label12_TextChanged(object sender, EventArgs e)
        {
            //n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //numbers.Enqueue(n);

            //if (this.textBox3.Text != "" & this.textBox8.Text != "0" & this.textBox8.Text != "0,0" & this.labelObra1.Text != "" & this.labelObra2.Text != "" & this.labelObra2.Text != "0" & this.labelObra2.Text != "0,0" & this.label12.Text != "")
            //{
            //    if (this.comboBox1.Text == "Нефть")
            //    {
            //        n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //    }
            //    else
            //    {
            //        n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
            //    }
            //    q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
            //    L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
            //    cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
            //    F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
            //    k = n * q * L / (cP * F);
            //    k = k * 1000;
            //    k = Math.Round(k, 2);
            //    string koef = "" + k;
            //    //koef = koef.Substring(0, koef.Length - 9);
            //    this.labelResult.Text = koef;
            //}
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox3.Text != "" & this.textBox8.Text != "0" & this.textBox8.Text != "0,0" & this.labelObra1.Text != "" & this.labelObra2.Text != "" & this.labelObra2.Text != "0" & this.labelObra2.Text != "0,0" & this.label12.Text != "")
            //{
            //    if (this.comboBox1.Text == "Нефть")
            //    {
            //        n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //    }
            //    else
            //    {
            //        n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
            //    }
            //    q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
            //    L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
            //    cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
            //    F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
            //    k = n * q * L / (cP * F);
            //    k = k * 1000;
            //    k = Math.Round(k, 2);
            //    string koef = "" + k;
            //    //koef = koef.Substring(0, koef.Length - 9);
            //    this.labelResult.Text = koef;
            //}
        }

        private void label12b_TextChanged(object sender, EventArgs e)
        {
            //n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
            //numbers.Enqueue(n);
            //if (this.textBox3.Text != "" & this.textBox8.Text != "0" & this.textBox8.Text != "0,0" & this.labelObra1.Text != "" & this.labelObra2.Text != "" & this.labelObra2.Text != "0" & this.labelObra2.Text != "0,0" & this.label12.Text != "")
            //{
            //    if (this.comboBox1.Text == "Нефть")
            //    {
            //        n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //    }
            //    else
            //    {
            //        n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
            //    }
            //    q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
            //    L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
            //    cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
            //    F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
            //    k = n * q * L / (cP * F);
            //    k = k * 1000;
            //    k = Math.Round(k, 2);
            //    string koef = "" + k;
            //    //koef = koef.Substring(0, koef.Length - 12);
            //    this.labelResult.Text = koef;
            //}
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox3.Text != "" & this.textBox8.Text != "0" & this.textBox8.Text != "0,0" & this.labelObra1.Text != "" & this.labelObra2.Text != "" & this.labelObra2.Text != "0" & this.labelObra2.Text != "0,0" & this.label12.Text != "")
            //{
            //    if(this.comboBox1.Text == "Нефть")
            //    {
            //        n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
            //    }
            //    else
            //    {
            //        n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
            //    }
            //    q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
            //    L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
            //    cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
            //    F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
            //    k = n * q * L / (cP * F);
            //    k = k * 1000;
            //    k = Math.Round(k, 2);
            //    string koef = "" + k;
            //    //koef = koef.Substring(0, koef.Length - 9);
            //    this.labelResult.Text = koef;
            //}
        }

        private void labelObra1_Click(object sender, EventArgs e)
        {

        }

        private void labelObra2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Random rndd = new Random();
            //double valuee = rndd.Next(1, 9);
            //valuee = valuee / 1000;
            //double book11 = double.Parse(this.textBox2.Text);
            //double Ress = valuee + book11;
            //this.textZero1.Text = "" + Ress;
            //this.textZero2.Text = (""+(double.Parse(this.textBox2.Text) - 0.8));

            
        }


        //async static Task Main()
        //{
        //    await Task.Delay(10000);
        //}





        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.label17.Visible = true;
                s1 = this.textBox9.Text;
                Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
                Regex regex11 = new Regex(@"(^\d+)(,+$)");
                MatchCollection matches1 = regex1.Matches(s1);
                MatchCollection matches11 = regex11.Matches(s1);
                if (matches1.Count > 0 & matches11.Count == 0)
                {
                        while (byki.Count > 0 & textBox9.Text != "" & byki2.Count > 0)
                        {
                            a = byki.Dequeue();
                            b = byki2.Dequeue();
                            var t = Task.Run(async delegate
                            {
                                await Task.Delay(TimeSpan.FromMilliseconds(double.Parse(textBox9.Text)));
                                return 42;
                            });
                            t.Wait();
                            if (a == "textBox2")
                            {
                                textBox2.Text = b;
                            } 
                            else if(a == "textBox3")
                            {
                                 textBox3.Text = b;
                            } 
                            else if(a == "textZero1")
                            {
                                    textZero1.Text = b;
                            } 
                            else if (a == "textZero2")
                            {
                                    textZero2.Text = b;
                            }
                            else if (a == "labelObra1")
                            {
                                    labelObra1.Text = b;
                            }
                            else if (a == "labelObra2")
                            {
                                    labelObra2.Text = b;
                            }
                            else if (a == "label12")
                            {
                                    label12.Text = b;
                            }
                            else if (a == "label12b")
                            {
                                    label12b.Text = b;
                            }
                            else if (a == "textBox8")
                            {
                               textBox8.Text = b;
                            }
                            else if (a == "textZero1")
                            {
                                    textZero1.Text = b;
                            }
                            else if (a == "textZero2")
                            {
                                    textZero2.Text = b;
                            }
                            else if (a == "textZero1But")
                            {
                                textZero1.Text = b;
                                var tt = Task.Run(async delegate
                                {
                                    await Task.Delay(TimeSpan.FromMilliseconds(double.Parse(textBox9.Text)));
                                    return 42;
                                });
                                tt.Wait();
                                a = byki.Dequeue();
                                b = byki2.Dequeue();

                                
                                
                                textZero2.Text = b;
                                
 
                                double D1 = double.Parse(this.textZero1.Text);
                                double D2 = double.Parse(this.textZero2.Text);
                                double Vechit = D1 - D2;
                                Vechit = Math.Round(Vechit, 2);
                                string Vech = "" + Vechit;
                                this.textBox8.Text = Vech;
                            }
                            else if (a == "textZero1_Zero")
                            {
                                textZero1.Text = b;
                                //t = Task.Run(async delegate
                                //{
                                //    await Task.Delay(TimeSpan.FromMilliseconds(double.Parse(textBox9.Text)));
                                //    return 42;
                                //});
                                //t.Wait();
                                double D1 = double.Parse(this.textZero1.Text);
                                double D2 = double.Parse(this.textZero2.Text);
                                double Vechit = D1 - D2;
                                Vechit = Math.Round(Vechit, 2);
                                string Vech = "" + Vechit;
                                this.textBox8.Text = Vech;
                            }
                            else if (a == "textZero2_Zero")
                            {
                                textZero2.Text = b;
                                //t = Task.Run(async delegate
                                //{
                                //    await Task.Delay(TimeSpan.FromMilliseconds(double.Parse(textBox9.Text)));
                                //    return 42;
                                //});
                                //t.Wait();
                                double D1 = double.Parse(this.textZero1.Text);
                                double D2 = double.Parse(this.textZero2.Text);
                                double Vechit = D1 - D2;
                                Vechit = Math.Round(Vechit, 2);
                                string Vech = "" + Vechit;
                                this.textBox8.Text = Vech;
                            }
                            else if (a == "textZero1_Change")
                            {
                                textZero1.Text = b;
                                //t = Task.Run(async delegate
                                //{
                                //    await Task.Delay(TimeSpan.FromMilliseconds(double.Parse(textBox9.Text)));
                                //    return 42;
                                //});
                                //t.Wait();
                                double D1 = double.Parse(this.textZero1.Text);
                                double D2 = double.Parse(this.textZero2.Text);
                                double Vechit = D1 - D2;
                                Vechit = Math.Round(Vechit, 2);
                                string Vech = "" + Vechit;
                                this.textBox8.Text = Vech;
                            }
                            else if (a == "textZero2_Change")
                            {
                                textZero2.Text = b;
                                //t = Task.Run(async delegate
                                //{
                                //    await Task.Delay(TimeSpan.FromMilliseconds(double.Parse(textBox9.Text)));
                                //    return 42;
                                //});
                                //t.Wait();
                                double D1 = double.Parse(this.textZero1.Text);
                                double D2 = double.Parse(this.textZero2.Text);
                                double Vechit = D1 - D2;
                                Vechit = Math.Round(Vechit, 2);
                                string Vech = "" + Vechit;
                                this.textBox8.Text = Vech;
                                //textZero1.Text = byki2.Dequeue();
                            }
                            else if (a == "textBox8_Change")
                            {
                                textBox8.Text = b;
                                //textZero1.Text = byki2.Dequeue();
                            }


                        
                        }
                        if (this.textBox3.Text != "" & this.textBox8.Text != "0" & this.textBox8.Text != "0,0" & this.labelObra1.Text != "" & this.labelObra2.Text != "" & this.labelObra2.Text != "0" & this.labelObra2.Text != "0,0" & this.label12.Text != "")
                        {
                            if (this.comboBox1.Text == "Нефть")
                            {
                                n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
                            }
                            else
                            {
                                n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
                            }

                            q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
                            L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
                            cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
                            F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
                            k = n * q * L / (cP * F);
                            k = k * 1000000;
                            k = Math.Round(k, 2);
                            string koef = "" + k;
                            this.labelResult.Text = koef;
                            byki.Clear();
                            byki2.Clear();
                            //this.label17.Visible = false;
                        }

                this.label17.Visible = false;
                }
                else
                {
                    //this.textBox1.Text = "0";
                    MessageBox.Show("Введите повторно");
                }



                ////this.textBox3.Text = this.textBox4.Text;
                //Stopwatch stopWatch = new Stopwatch();
                //stopWatch.Start();
                ////Thread.Sleep(int.Parse(this.textBox9.Text));
                //if (this.textBox3.Text != "" & this.textBox8.Text != "0" & this.textBox8.Text != "0,0" & this.labelObra1.Text != "" & this.labelObra2.Text != "" & this.labelObra2.Text != "0" & this.labelObra2.Text != "0,0" & this.label12.Text != "")
                //{
                //    if (this.comboBox1.Text == "Нефть")
                //    {
                //        n = (double.Parse(this.label12.Text)) * 1000000; //Па*с
                //    }
                //    else
                //    {
                //        n = (double.Parse(this.label12b.Text)) * 1000000; //Па*с
                //    }
                //    q = (double.Parse(this.textBox3.Text)) / 1000000 / 60; //м3/с
                //    L = (double.Parse(this.labelObra1.Text)) / 1000;  //м
                //    cP = (double.Parse(this.textBox8.Text)) * 1000000; //Па
                //    F = ((double.Parse(this.labelObra2.Text)) / 2) * ((double.Parse(this.labelObra2.Text)) / 2) * 3.14 / 1000000; // м2
                //    k = n * q * L / (cP * F);
                //    k = k * 1000;
                //    k = Math.Round(k, 2);
                //    string koef = "" + k;
                //    //koef = koef.Substring(0, koef.Length - 9);
                //    this.labelResult.Text = koef;

                //}
                //else
                //{
                //    MessageBox.Show("Не все данные введены для расчета или они неправильные");
                //}
                //stopWatch.Stop();

                ////TimeSpan ts = stopWatch.Elapsed;
                ////string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ////    ts.Hours, ts.Minutes, ts.Seconds,
                ////    ts.Milliseconds / 10);
                ////////////////////////////
                ////////////////////////////
                ////this.labelPeriod.Text = ("RunTime=" + elapsedTime);

                //TimeSpan timeTaken = timer.Elapsed;
                //string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ( e.KeyChar != 0)
            {
                e.Handled = true;
            }

            //char number = e.KeyChar;
            //if (!(e.KeyChar >= 48 & e.KeyChar <= 58) & (e.KeyChar != 44) & e.KeyChar != 8 & e.KeyChar != 0)
            //{
            //    e.Handled = true;
            //}
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 0)
            {
                e.Handled = true;
            }

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 0)
            {
                e.Handled = true;
            }

        }

        private void textZero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //s1 = this.textZero1.Text;
            //Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
            //Regex regex11 = new Regex(@"(^\d+)(,+$)");
            //MatchCollection matches1 = regex1.Matches(s1);
            //MatchCollection matches11 = regex11.Matches(s1);
            //if (matches1.Count > 0 & matches11.Count == 0)
            //{
                char number = e.KeyChar;
                if (!(e.KeyChar >= 48 & e.KeyChar <= 58) & (e.KeyChar != 44) & e.KeyChar != 8 & e.KeyChar != 0)
                {
                    e.Handled = true;
                }
            //}
            
        }

        private void textZero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(e.KeyChar >= 48 & e.KeyChar <= 58) & (e.KeyChar != 44) & e.KeyChar != 8 & e.KeyChar != 0)
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(e.KeyChar >= 48 & e.KeyChar <= 58)  & e.KeyChar != 8 & e.KeyChar != 0 & (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(e.KeyChar >= 48 & e.KeyChar <= 58) & (e.KeyChar != 44) & e.KeyChar != 8 & e.KeyChar != 0)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(e.KeyChar >= 48 & e.KeyChar <= 58) & (e.KeyChar != 44) & e.KeyChar != 8 & e.KeyChar != 0)
            {
                e.Handled = true;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(226, 67, 67);             //= "#e24343";
            button1.FlatAppearance.BorderColor = Color.FromArgb(226, 67, 67);
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byki.Clear();
            byki2.Clear();
            Close();
        }

        Point LastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);

            
            //numbers.Enqueue(3); // очередь 3
            //numbers.Enqueue(5); // очередь 3, 5
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fm2 = new Form2(this);
            //fm2.textBoxDl.Text = "60";
            //fm2.textBoxDi.Text = "29,95";
            //labelObra1.Text = "60";
            //labelObra2.Text = "29,95";
            //label12.Text = "15";
            //label12b.Text = "0,0001";
        }

        private void textBox2_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void textZero1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string s1 = this.textZero1.Text;
                string s2 = this.textZero2.Text;
                Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
                Regex regex2 = new Regex(@"(^\d+),?(\d+$)");
                Regex regex11 = new Regex(@"(^\d+)(,+$)");
                MatchCollection matches1 = regex1.Matches(s1);
                MatchCollection matches2 = regex1.Matches(s2);
                MatchCollection matches11 = regex11.Matches(s1);
                MatchCollection matches22 = regex11.Matches(s2);
                if (matches1.Count > 0 & matches2.Count > 0 & matches11.Count == 0 & matches22.Count == 0)
                {
                    byki.Enqueue("textZero1");
                    byki2.Enqueue(textZero1.Text);
                }
                else
                {
                    this.textZero1.Text = "0,0";
                }
            }
            
        }

        private void textZero2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string s1 = this.textZero1.Text;
                string s2 = this.textZero2.Text;
                Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
                Regex regex2 = new Regex(@"(^\d+),?(\d+$)");
                Regex regex11 = new Regex(@"(^\d+)(,+$)");
                MatchCollection matches1 = regex1.Matches(s1);
                MatchCollection matches2 = regex1.Matches(s2);
                MatchCollection matches11 = regex11.Matches(s1);
                MatchCollection matches22 = regex11.Matches(s2);
                if (matches1.Count > 0 & matches2.Count > 0 & matches11.Count == 0 & matches22.Count == 0)
                {
                    byki.Enqueue("textZero2");
                    byki2.Enqueue(textZero2.Text);
                }
                else
                {
                    this.textZero1.Text = "0,0";
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            s1 = this.textBox1.Text;
            //Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
            //Regex regex11 = new Regex(@"(^\d+)(,+$)");
            MatchCollection matches1 = regex1.Matches(s1);
            MatchCollection matches11 = regex11.Matches(s1);
            if(e.KeyCode == Keys.Enter)
            {
                if (matches1.Count > 0 & matches11.Count == 0)
                {
                    if (labelRejim.Text == "Давление")
                    {
                        Random rndd = new Random();
                        double valuee = rndd.Next(1, 60);
                        valuee = valuee / 1000;
                        double book11 = double.Parse(this.textBox4.Text);
                        double Ress = valuee + book11;
                        string ss = "" + Ress;
                        byki.Enqueue("textBox3");
                        byki2.Enqueue(ss);
                        //this.textBox3.Text = ss;
                        //this.textBox3.Text = this.textBox4.Text;
                        Random rnd = new Random();
                        double value = rnd.Next(30, 99);
                        value = value / 1000;
                        double book1 = double.Parse(this.textBox1.Text);
                        double Res = value + book1;
                        string s = "" + Res;
                        byki.Enqueue("textBox2");
                        byki2.Enqueue(s);
                        byki.Enqueue("textZero1But");
                        byki2.Enqueue(s);
                        byki.Enqueue("textZero2But");
                        double s4 = double.Parse(s) - 0.8;
                        string s5 = s4.ToString();
                        byki2.Enqueue(s5);
                    }



                }
            }
            
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            s1 = this.textBox4.Text;
            //Regex regex1 = new Regex(@"(^\d+),?(\d*$)");
            //Regex regex11 = new Regex(@"(^\d+)(,+$)");
            MatchCollection matches1 = regex1.Matches(s1);
            MatchCollection matches11 = regex11.Matches(s1);
            if (e.KeyCode == Keys.Enter)
            {
                if (matches1.Count > 0 & matches11.Count == 0)
                {
                    if (labelRejim.Text == "Расход")
                    {
                        double book1 = double.Parse(this.textBox4.Text);
                        double Res = book1;
                        string s = "" + Res;
                        byki.Enqueue("textBox3");
                        byki2.Enqueue(s);
                        //this.textBox3.Text = s;
                    }



                }
            }
        }
    }
}
