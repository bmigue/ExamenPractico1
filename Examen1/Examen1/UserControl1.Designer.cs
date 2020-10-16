namespace Examen1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Iniciar = new System.Windows.Forms.Button();
            this.Comparar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textIntentos = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            //this.trampa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(159, 296);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(101, 23);
            this.Iniciar.TabIndex = 0;
            this.Iniciar.Text = "Iniciar Juego";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // Comparar
            // 
            this.Comparar.Enabled = false;
            this.Comparar.Location = new System.Drawing.Point(344, 296);
            this.Comparar.Name = "Comparar";
            this.Comparar.Size = new System.Drawing.Size(75, 23);
            this.Comparar.TabIndex = 1;
            this.Comparar.Text = "Comparar";
            this.Comparar.UseVisualStyleBackColor = true;
            this.Comparar.Click += new System.EventHandler(this.Comparar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Intentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite su codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // textCodigo
            // 
            this.textCodigo.Enabled = false;
            this.textCodigo.Location = new System.Drawing.Point(287, 153);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(132, 20);
            this.textCodigo.TabIndex = 5;
            // 
            // textIntentos
            // 
            this.textIntentos.Enabled = false;
            this.textIntentos.Location = new System.Drawing.Point(287, 105);
            this.textIntentos.Name = "textIntentos";
            this.textIntentos.Size = new System.Drawing.Size(132, 20);
            this.textIntentos.TabIndex = 6;
            // 
            // textResultado
            // 
            this.textResultado.Enabled = false;
            this.textResultado.Location = new System.Drawing.Point(287, 198);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(194, 20);
            this.textResultado.TabIndex = 7;
            // 
            // trampa
            // 
            //this.trampa.Location = new System.Drawing.Point(43, 22);
            //this.trampa.Name = "trampa";
            //this.trampa.Size = new System.Drawing.Size(93, 20);
            //this.trampa.TabIndex = 8;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textIntentos);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comparar);
            this.Controls.Add(this.Iniciar);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(585, 408);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Button Comparar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textIntentos;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.TextBox trampa;
    }
}
