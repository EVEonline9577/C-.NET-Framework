
namespace WindowsFormsApp2
{
    partial class Form3
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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFluid1 = new System.Windows.Forms.TextBox();
            this.textBoxFluid2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChenFluid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(111, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Флюид";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(235, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 18);
            this.label13.TabIndex = 56;
            this.label13.Text = "Мпа*с";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(81, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 18);
            this.label15.TabIndex = 55;
            this.label15.Text = "Вязкость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "Вода:";
            // 
            // textBoxFluid1
            // 
            this.textBoxFluid1.Location = new System.Drawing.Point(165, 45);
            this.textBoxFluid1.Name = "textBoxFluid1";
            this.textBoxFluid1.Size = new System.Drawing.Size(64, 20);
            this.textBoxFluid1.TabIndex = 59;
            this.textBoxFluid1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFluid1_KeyPress);
            // 
            // textBoxFluid2
            // 
            this.textBoxFluid2.Location = new System.Drawing.Point(165, 79);
            this.textBoxFluid2.Name = "textBoxFluid2";
            this.textBoxFluid2.Size = new System.Drawing.Size(64, 20);
            this.textBoxFluid2.TabIndex = 63;
            this.textBoxFluid2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFluid2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Нефть:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(235, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Мпа*с";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(81, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 60;
            this.label4.Text = "Вязкость:";
            // 
            // buttonChenFluid
            // 
            this.buttonChenFluid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChenFluid.Location = new System.Drawing.Point(102, 116);
            this.buttonChenFluid.Name = "buttonChenFluid";
            this.buttonChenFluid.Size = new System.Drawing.Size(94, 25);
            this.buttonChenFluid.TabIndex = 64;
            this.buttonChenFluid.Text = "Изменить";
            this.buttonChenFluid.UseVisualStyleBackColor = true;
            this.buttonChenFluid.Click += new System.EventHandler(this.buttonChenFluid_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 153);
            this.Controls.Add(this.buttonChenFluid);
            this.Controls.Add(this.textBoxFluid2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFluid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxFluid1;
        public System.Windows.Forms.TextBox textBoxFluid2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button buttonChenFluid;
    }
}