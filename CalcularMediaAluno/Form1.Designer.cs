namespace CalcularMediaAluno
{
    partial class Frm1
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
            this.Calcular = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Tit3 = new System.Windows.Forms.Label();
            this.Tit1 = new System.Windows.Forms.Label();
            this.N1 = new System.Windows.Forms.TextBox();
            this.N2 = new System.Windows.Forms.TextBox();
            this.N3 = new System.Windows.Forms.TextBox();
            this.N4 = new System.Windows.Forms.TextBox();
            this.Media = new System.Windows.Forms.Label();
            this.Tit2 = new System.Windows.Forms.Label();
            this.Limpar = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(245, 233);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(68, 39);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(136, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(18, 96);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Nota 1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(80, 96);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(39, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Nota 2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(142, 96);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(39, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Nota 3";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(204, 96);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(39, 13);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "Nota 4";
            // 
            // Tit3
            // 
            this.Tit3.AutoSize = true;
            this.Tit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tit3.Location = new System.Drawing.Point(18, 73);
            this.Tit3.Name = "Tit3";
            this.Tit3.Size = new System.Drawing.Size(146, 13);
            this.Tit3.TabIndex = 6;
            this.Tit3.Text = "Insira as Notas do Aluno";
            // 
            // Tit1
            // 
            this.Tit1.AutoSize = true;
            this.Tit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tit1.Location = new System.Drawing.Point(18, 5);
            this.Tit1.Name = "Tit1";
            this.Tit1.Size = new System.Drawing.Size(139, 13);
            this.Tit1.TabIndex = 8;
            this.Tit1.Text = "Insira o Nome do Aluno";
            // 
            // N1
            // 
            this.N1.Location = new System.Drawing.Point(21, 112);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(36, 20);
            this.N1.TabIndex = 10;
            // 
            // N2
            // 
            this.N2.Location = new System.Drawing.Point(83, 112);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(36, 20);
            this.N2.TabIndex = 11;
            // 
            // N3
            // 
            this.N3.Location = new System.Drawing.Point(145, 112);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(36, 20);
            this.N3.TabIndex = 12;
            // 
            // N4
            // 
            this.N4.Location = new System.Drawing.Point(207, 112);
            this.N4.Name = "N4";
            this.N4.Size = new System.Drawing.Size(38, 20);
            this.N4.TabIndex = 13;
            // 
            // Media
            // 
            this.Media.AutoSize = true;
            this.Media.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Media.Location = new System.Drawing.Point(18, 160);
            this.Media.Name = "Media";
            this.Media.Size = new System.Drawing.Size(0, 16);
            this.Media.TabIndex = 14;
            // 
            // Tit2
            // 
            this.Tit2.AutoSize = true;
            this.Tit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tit2.Location = new System.Drawing.Point(185, 5);
            this.Tit2.Name = "Tit2";
            this.Tit2.Size = new System.Drawing.Size(128, 16);
            this.Tit2.TabIndex = 16;
            this.Tit2.Text = "Nota de Corte 7.0";
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(162, 233);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(68, 39);
            this.Limpar.TabIndex = 17;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(18, 196);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 16);
            this.Resultado.TabIndex = 18;
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 284);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Tit2);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.N4);
            this.Controls.Add(this.N3);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.Tit1);
            this.Controls.Add(this.Tit3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Calcular);
            this.Name = "Frm1";
            this.Text = "CálculoMédiaAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label Tit3;
        private System.Windows.Forms.Label Tit1;
        private System.Windows.Forms.TextBox N1;
        private System.Windows.Forms.TextBox N2;
        private System.Windows.Forms.TextBox N3;
        private System.Windows.Forms.TextBox N4;
        private System.Windows.Forms.Label Media;
        private System.Windows.Forms.Label Tit2;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Label Resultado;
    }
}

