namespace PW3_2022_1C_Bola8.Winforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPreg = new System.Windows.Forms.Button();
            this.lblRta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta a la Bola 8 Magica";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(449, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnPreg
            // 
            this.btnPreg.Location = new System.Drawing.Point(204, 98);
            this.btnPreg.Name = "btnPreg";
            this.btnPreg.Size = new System.Drawing.Size(100, 40);
            this.btnPreg.TabIndex = 2;
            this.btnPreg.Text = "Preguntar";
            this.btnPreg.UseVisualStyleBackColor = true;
            this.btnPreg.Click += new System.EventHandler(this.btnPreg_Click);
            // 
            // lblRta
            // 
            this.lblRta.AutoSize = true;
            this.lblRta.Location = new System.Drawing.Point(206, 163);
            this.lblRta.Name = "lblRta";
            this.lblRta.Size = new System.Drawing.Size(60, 15);
            this.lblRta.TabIndex = 3;
            this.lblRta.Text = "Respuesta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 219);
            this.Controls.Add(this.lblRta);
            this.Controls.Add(this.btnPreg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPreg;
        private System.Windows.Forms.Label lblRta;
    }
}
