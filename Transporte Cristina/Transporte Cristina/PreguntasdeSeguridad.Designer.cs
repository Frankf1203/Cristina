namespace Transporte_Cristina
{
    partial class PreguntasdeSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreguntasdeSeguridad));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPregunta1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPregunta2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido(a):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = "A continuación, se le solicita que seleccione dos preguntas \r\nde seguridad para l" +
    "a recuperación de su contraseña en \r\ncaso que olvide su contraseña o su cuenta s" +
    "e encuentre \r\nbloqueada. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pregunta 1:";
            // 
            // cmbPregunta1
            // 
            this.cmbPregunta1.FormattingEnabled = true;
            this.cmbPregunta1.Items.AddRange(new object[] {
            "¿Cual es tu color favorito?",
            "¿Cual es el nombre del primer libro que leiste?",
            "¿En que año terminaste la secundaria?",
            "¿Cual es el nombre de tu mascota?",
            "¿Cual es tu pelicula favorita?",
            "¿Cual es tu restaurante preferido?"});
            this.cmbPregunta1.Location = new System.Drawing.Point(16, 196);
            this.cmbPregunta1.Name = "cmbPregunta1";
            this.cmbPregunta1.Size = new System.Drawing.Size(413, 28);
            this.cmbPregunta1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Respuesta:";
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Location = new System.Drawing.Point(16, 279);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(413, 26);
            this.txtRespuesta1.TabIndex = 5;
            this.txtRespuesta1.TextChanged += new System.EventHandler(this.txtRespuesta1_TextChanged);
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Location = new System.Drawing.Point(16, 445);
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(413, 26);
            this.txtRespuesta2.TabIndex = 9;
            this.txtRespuesta2.TextChanged += new System.EventHandler(this.txtRespuesta2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Respuesta:";
            // 
            // cmbPregunta2
            // 
            this.cmbPregunta2.FormattingEnabled = true;
            this.cmbPregunta2.Items.AddRange(new object[] {
            "¿Cual es tu color favorito?",
            "¿Cual es el nombre del primer libro que leiste?",
            "¿En que año terminaste la secundaria?",
            "¿Cual es el nombre de tu mascota?",
            "¿Cual es tu pelicula favorita?",
            "¿Cual es tu restaurante preferido?"});
            this.cmbPregunta2.Location = new System.Drawing.Point(16, 362);
            this.cmbPregunta2.Name = "cmbPregunta2";
            this.cmbPregunta2.Size = new System.Drawing.Size(413, 28);
            this.cmbPregunta2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pregunta 2:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(330, 492);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 43);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(129, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 20);
            this.lblUsuario.TabIndex = 11;
            // 
            // PreguntasdeSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 549);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRespuesta2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPregunta2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRespuesta1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPregunta1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PreguntasdeSeguridad";
            this.Text = "Preguntas de Seguridad";
            this.Load += new System.EventHandler(this.PreguntasdeSeguridad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPregunta1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPregunta2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label lblUsuario;
    }
}