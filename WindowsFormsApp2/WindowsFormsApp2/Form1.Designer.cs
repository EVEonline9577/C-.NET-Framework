
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textZero1 = new System.Windows.Forms.TextBox();
            this.buttonZero1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textZero2 = new System.Windows.Forms.TextBox();
            this.buttonZero2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonChen1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonChen2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelRejim = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAAA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPlay2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelObra1 = new System.Windows.Forms.Label();
            this.labelObra2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12b = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "P, Мпа";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0,0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextAlignChanged += new System.EventHandler(this.textBox2_TextAlignChanged);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Q см3/мин";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(84, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(64, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "0,0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textZero1
            // 
            this.textZero1.Location = new System.Drawing.Point(84, 162);
            this.textZero1.Name = "textZero1";
            this.textZero1.Size = new System.Drawing.Size(69, 20);
            this.textZero1.TabIndex = 14;
            this.textZero1.Text = "0,0";
            this.textZero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textZero1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textZero1_KeyDown);
            this.textZero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textZero1_KeyPress);
            this.textZero1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textZero1_KeyUp);
            this.textZero1.Leave += new System.EventHandler(this.textZero1_Leave);
            // 
            // buttonZero1
            // 
            this.buttonZero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZero1.Location = new System.Drawing.Point(159, 162);
            this.buttonZero1.Name = "buttonZero1";
            this.buttonZero1.Size = new System.Drawing.Size(20, 20);
            this.buttonZero1.TabIndex = 13;
            this.buttonZero1.Text = "o";
            this.buttonZero1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonZero1.UseVisualStyleBackColor = true;
            this.buttonZero1.Click += new System.EventHandler(this.buttonZero1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Д1, Мпа";
            // 
            // textZero2
            // 
            this.textZero2.Location = new System.Drawing.Point(84, 194);
            this.textZero2.Name = "textZero2";
            this.textZero2.Size = new System.Drawing.Size(69, 20);
            this.textZero2.TabIndex = 17;
            this.textZero2.Text = "0,0";
            this.textZero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textZero2.TextChanged += new System.EventHandler(this.textZero2_TextChanged);
            this.textZero2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textZero2_KeyDown);
            this.textZero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textZero2_KeyPress);
            this.textZero2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textZero2_KeyUp);
            this.textZero2.Leave += new System.EventHandler(this.textZero2_Leave);
            // 
            // buttonZero2
            // 
            this.buttonZero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZero2.Location = new System.Drawing.Point(159, 194);
            this.buttonZero2.Name = "buttonZero2";
            this.buttonZero2.Size = new System.Drawing.Size(20, 20);
            this.buttonZero2.TabIndex = 16;
            this.buttonZero2.Text = "o";
            this.buttonZero2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonZero2.UseVisualStyleBackColor = true;
            this.buttonZero2.Click += new System.EventHandler(this.buttonZero2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Д2, Мпа";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(110, 249);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(54, 20);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "0";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(21, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Д1 - Д2, Мпа";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(110, 302);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(54, 20);
            this.textBox9.TabIndex = 21;
            this.textBox9.Text = "120";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.textBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox9_KeyDown);
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Период, мс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(749, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Образец";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(750, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Длина:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(750, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Диаметр:";
            // 
            // buttonChen1
            // 
            this.buttonChen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChen1.Location = new System.Drawing.Point(935, 106);
            this.buttonChen1.Name = "buttonChen1";
            this.buttonChen1.Size = new System.Drawing.Size(90, 30);
            this.buttonChen1.TabIndex = 26;
            this.buttonChen1.Text = "Изменить";
            this.buttonChen1.UseVisualStyleBackColor = true;
            this.buttonChen1.Click += new System.EventHandler(this.buttonChen1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(750, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Флюид";
            // 
            // buttonChen2
            // 
            this.buttonChen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChen2.Location = new System.Drawing.Point(916, 194);
            this.buttonChen2.Name = "buttonChen2";
            this.buttonChen2.Size = new System.Drawing.Size(92, 30);
            this.buttonChen2.TabIndex = 34;
            this.buttonChen2.Text = "Изменить";
            this.buttonChen2.UseVisualStyleBackColor = true;
            this.buttonChen2.Click += new System.EventHandler(this.buttonChen2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(750, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 18);
            this.label15.TabIndex = 35;
            this.label15.Text = "Вязкость:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(750, 304);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 18);
            this.label16.TabIndex = 36;
            this.label16.Text = "Прониц, 10^-3 мкм2";
            // 
            // labelRejim
            // 
            this.labelRejim.AutoSize = true;
            this.labelRejim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRejim.Location = new System.Drawing.Point(81, 114);
            this.labelRejim.Name = "labelRejim";
            this.labelRejim.Size = new System.Drawing.Size(88, 16);
            this.labelRejim.TabIndex = 39;
            this.labelRejim.Text = "Остановлен";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Нефть",
            "Вода"});
            this.comboBox1.Location = new System.Drawing.Point(833, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.Text = "Нефть";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // buttonAAA
            // 
            this.buttonAAA.Font = new System.Drawing.Font("Microsoft Uighur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAAA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAAA.Image = global::WindowsFormsApp2.Properties.Resources.Снимок7;
            this.buttonAAA.Location = new System.Drawing.Point(220, 43);
            this.buttonAAA.Name = "buttonAAA";
            this.buttonAAA.Size = new System.Drawing.Size(24, 20);
            this.buttonAAA.TabIndex = 43;
            this.buttonAAA.Text = ".";
            this.buttonAAA.UseVisualStyleBackColor = true;
            this.buttonAAA.Click += new System.EventHandler(this.buttonAAA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPlay2
            // 
            this.buttonPlay2.Image = global::WindowsFormsApp2.Properties.Resources.Снимок7;
            this.buttonPlay2.Location = new System.Drawing.Point(220, 78);
            this.buttonPlay2.Name = "buttonPlay2";
            this.buttonPlay2.Size = new System.Drawing.Size(24, 20);
            this.buttonPlay2.TabIndex = 7;
            this.buttonPlay2.UseVisualStyleBackColor = true;
            this.buttonPlay2.Click += new System.EventHandler(this.buttonPlay2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(891, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "мм";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(891, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "мм";
            // 
            // labelObra1
            // 
            this.labelObra1.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelObra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObra1.Location = new System.Drawing.Point(0, 0);
            this.labelObra1.MaximumSize = new System.Drawing.Size(72, 18);
            this.labelObra1.Name = "labelObra1";
            this.labelObra1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelObra1.Size = new System.Drawing.Size(72, 18);
            this.labelObra1.TabIndex = 48;
            this.labelObra1.Text = " 60";
            this.labelObra1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelObra1.UseMnemonic = false;
            this.labelObra1.TextChanged += new System.EventHandler(this.labelObra1_TextChanged);
            this.labelObra1.Click += new System.EventHandler(this.labelObra1_Click);
            // 
            // labelObra2
            // 
            this.labelObra2.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelObra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObra2.Location = new System.Drawing.Point(-11, 0);
            this.labelObra2.Name = "labelObra2";
            this.labelObra2.Size = new System.Drawing.Size(72, 18);
            this.labelObra2.TabIndex = 49;
            this.labelObra2.Text = " 29,95";
            this.labelObra2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelObra2.UseMnemonic = false;
            this.labelObra2.TextChanged += new System.EventHandler(this.labelObra2_TextChanged);
            this.labelObra2.Click += new System.EventHandler(this.labelObra2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.labelObra1);
            this.panel1.Location = new System.Drawing.Point(819, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 18);
            this.panel1.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelObra2);
            this.panel2.Location = new System.Drawing.Point(830, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 18);
            this.panel2.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(819, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 18);
            this.label12.TabIndex = 52;
            this.label12.Text = " 15";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.TextChanged += new System.EventHandler(this.label12_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(913, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 18);
            this.label13.TabIndex = 53;
            this.label13.Text = "Мпа*с";
            // 
            // label12b
            // 
            this.label12b.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12b.Location = new System.Drawing.Point(824, 231);
            this.label12b.Name = "label12b";
            this.label12b.Size = new System.Drawing.Size(90, 18);
            this.label12b.TabIndex = 52;
            this.label12b.Text = " 0,0001";
            this.label12b.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(897, 303);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(67, 20);
            this.labelResult.TabIndex = 54;
            this.labelResult.Text = "1999,89";
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(997, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 22);
            this.button1.TabIndex = 58;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(63, 331);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 59;
            this.label17.Text = "Идет загрузка...";
            this.label17.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 454);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label12b);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonAAA);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelRejim);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonChen2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonChen1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textZero2);
            this.Controls.Add(this.buttonZero2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textZero1);
            this.Controls.Add(this.buttonZero1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonPlay2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonPlay2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textZero1;
        private System.Windows.Forms.Button buttonZero1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textZero2;
        private System.Windows.Forms.Button buttonZero2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonChen1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonChen2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelRejim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAAA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label labelObra1;
        public System.Windows.Forms.Label labelObra2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12b;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
    }
}

