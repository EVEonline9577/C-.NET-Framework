
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.textBoxDl = new System.Windows.Forms.TextBox();
            this.textBoxDi = new System.Windows.Forms.TextBox();
            this.labelDlina = new System.Windows.Forms.Label();
            this.labelDiametr = new System.Windows.Forms.Label();
            this.buttonChen3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDl
            // 
            this.textBoxDl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDl.Location = new System.Drawing.Point(109, 57);
            this.textBoxDl.Name = "textBoxDl";
            this.textBoxDl.Size = new System.Drawing.Size(100, 24);
            this.textBoxDl.TabIndex = 0;
            this.textBoxDl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDl_KeyPress);
            // 
            // textBoxDi
            // 
            this.textBoxDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDi.Location = new System.Drawing.Point(109, 94);
            this.textBoxDi.Name = "textBoxDi";
            this.textBoxDi.Size = new System.Drawing.Size(100, 24);
            this.textBoxDi.TabIndex = 1;
            this.textBoxDi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDi_KeyPress);
            // 
            // labelDlina
            // 
            this.labelDlina.AutoSize = true;
            this.labelDlina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDlina.Location = new System.Drawing.Point(46, 57);
            this.labelDlina.Name = "labelDlina";
            this.labelDlina.Size = new System.Drawing.Size(57, 18);
            this.labelDlina.TabIndex = 25;
            this.labelDlina.Text = "Длина:";
            // 
            // labelDiametr
            // 
            this.labelDiametr.AutoSize = true;
            this.labelDiametr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiametr.Location = new System.Drawing.Point(29, 94);
            this.labelDiametr.Name = "labelDiametr";
            this.labelDiametr.Size = new System.Drawing.Size(74, 18);
            this.labelDiametr.TabIndex = 26;
            this.labelDiametr.Text = "Диаметр:";
            // 
            // buttonChen3
            // 
            this.buttonChen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChen3.Location = new System.Drawing.Point(92, 136);
            this.buttonChen3.Name = "buttonChen3";
            this.buttonChen3.Size = new System.Drawing.Size(94, 25);
            this.buttonChen3.TabIndex = 27;
            this.buttonChen3.Text = "Изменить";
            this.buttonChen3.UseVisualStyleBackColor = true;
            this.buttonChen3.Click += new System.EventHandler(this.buttonChen3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "мм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(215, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(106, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Образец";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 173);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChen3);
            this.Controls.Add(this.labelDiametr);
            this.Controls.Add(this.labelDlina);
            this.Controls.Add(this.textBoxDi);
            this.Controls.Add(this.textBoxDl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxDl;
        public System.Windows.Forms.TextBox textBoxDi;
        private System.Windows.Forms.Label labelDlina;
        private System.Windows.Forms.Label labelDiametr;
        public System.Windows.Forms.Button buttonChen3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}