namespace Transporte_Cristina
{
    partial class RecuperacionContraseña
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperacionContraseña));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.cmbPregunta = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProviderRecuperacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRecuperacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usted puede recuperar su contraseña a traves de las \r\npreguntas de seguridad.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "En caso que usted no recuerde las respuestas de las preguntas\r\n de seguridad, con" +
    "tacte a su administrador.";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(204, 58);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(238, 26);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(340, 152);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(102, 32);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(377, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Responda correctamente la pregunta de Seguridad.";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(115, 444);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(0, 20);
            this.lblContraseña.TabIndex = 32;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(231, 371);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(102, 39);
            this.btnRecuperar.TabIndex = 28;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(340, 371);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(102, 39);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(44, 324);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(397, 26);
            this.txtRespuesta.TabIndex = 26;
            this.txtRespuesta.TextChanged += new System.EventHandler(this.txtRespuesta_TextChanged);
            this.txtRespuesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRespuesta_KeyPress);
            this.txtRespuesta.Validating += new System.ComponentModel.CancelEventHandler(this.txtRespuesta_Validating);
            // 
            // cmbPregunta
            // 
            this.cmbPregunta.FormattingEnabled = true;
            this.cmbPregunta.Items.AddRange(new object[] {
            "¿Cual es tu color favorito?",
            "¿Cual es el nombre del primer libro que leiste?",
            "¿En que año terminaste la secundaria?",
            "¿Cual es el nombre de tu mascota?",
            "¿Cual es tu pelicula favorita?",
            "¿Cual es tu restaurante preferido?"});
            this.cmbPregunta.Location = new System.Drawing.Point(45, 255);
            this.cmbPregunta.Name = "cmbPregunta";
            this.cmbPregunta.Size = new System.Drawing.Size(397, 28);
            this.cmbPregunta.TabIndex = 25;
            this.cmbPregunta.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPregunta_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Respuesta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Pregunta ";
            // 
            // errorProviderRecuperacion
            // 
            this.errorProviderRecuperacion.ContainerControl = this;
            // 
            // RecuperacionContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 422);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.cmbPregunta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "RecuperacionContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperacion de Contraseña";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecuperacionContraseña_FormClosed);
            this.Load += new System.EventHandler(this.RecuperacionContraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRecuperacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.ComboBox cmbPregunta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProviderRecuperacion;
    }
}