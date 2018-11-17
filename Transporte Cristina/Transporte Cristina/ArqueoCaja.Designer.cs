namespace Transporte_Cristina
{
    partial class ArqueoCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArqueoCaja));
            this.groupboxCaja = new System.Windows.Forms.GroupBox();
            this.textboxTotalFacturas = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textboxSaldoInicial = new System.Windows.Forms.TextBox();
            this.labelSaldoInicial = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.groupboxContador = new System.Windows.Forms.GroupBox();
            this.buttonTotalBilletes = new System.Windows.Forms.Button();
            this.buttonTodoACero = new System.Windows.Forms.Button();
            this.textboxTotalBilletes = new System.Windows.Forms.TextBox();
            this.textboxL1 = new System.Windows.Forms.TextBox();
            this.textboxL2 = new System.Windows.Forms.TextBox();
            this.textboxL5 = new System.Windows.Forms.TextBox();
            this.textboxL10 = new System.Windows.Forms.TextBox();
            this.textboxL20 = new System.Windows.Forms.TextBox();
            this.textboxL50 = new System.Windows.Forms.TextBox();
            this.textboxL100 = new System.Windows.Forms.TextBox();
            this.textboxL500 = new System.Windows.Forms.TextBox();
            this.labelTotalBilletes = new System.Windows.Forms.Label();
            this.labelL1 = new System.Windows.Forms.Label();
            this.labelL2 = new System.Windows.Forms.Label();
            this.labelL5 = new System.Windows.Forms.Label();
            this.labelL10 = new System.Windows.Forms.Label();
            this.labelL20 = new System.Windows.Forms.Label();
            this.labelL50 = new System.Windows.Forms.Label();
            this.labelL100 = new System.Windows.Forms.Label();
            this.labelL500 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCierraCaja = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.groupboxCaja.SuspendLayout();
            this.groupboxContador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxCaja
            // 
            this.groupboxCaja.Controls.Add(this.textboxTotalFacturas);
            this.groupboxCaja.Controls.Add(this.labelTotal);
            this.groupboxCaja.Controls.Add(this.textboxSaldoInicial);
            this.groupboxCaja.Controls.Add(this.labelSaldoInicial);
            this.groupboxCaja.Controls.Add(this.labelFecha);
            this.groupboxCaja.Controls.Add(this.labelUser);
            this.groupboxCaja.Controls.Add(this.labelUsuario);
            this.groupboxCaja.Location = new System.Drawing.Point(20, 20);
            this.groupboxCaja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupboxCaja.Name = "groupboxCaja";
            this.groupboxCaja.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupboxCaja.Size = new System.Drawing.Size(251, 376);
            this.groupboxCaja.TabIndex = 0;
            this.groupboxCaja.TabStop = false;
            this.groupboxCaja.Text = "Caja";
            // 
            // textboxTotalFacturas
            // 
            this.textboxTotalFacturas.Location = new System.Drawing.Point(51, 273);
            this.textboxTotalFacturas.Name = "textboxTotalFacturas";
            this.textboxTotalFacturas.Size = new System.Drawing.Size(152, 26);
            this.textboxTotalFacturas.TabIndex = 6;
            this.textboxTotalFacturas.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(47, 231);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(137, 20);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total en Facturas:";
            // 
            // textboxSaldoInicial
            // 
            this.textboxSaldoInicial.Location = new System.Drawing.Point(51, 183);
            this.textboxSaldoInicial.Name = "textboxSaldoInicial";
            this.textboxSaldoInicial.Size = new System.Drawing.Size(152, 26);
            this.textboxSaldoInicial.TabIndex = 4;
            this.textboxSaldoInicial.Text = "0";
            this.textboxSaldoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxSaldoInicial_KeyPress);
            // 
            // labelSaldoInicial
            // 
            this.labelSaldoInicial.AutoSize = true;
            this.labelSaldoInicial.Location = new System.Drawing.Point(47, 141);
            this.labelSaldoInicial.Name = "labelSaldoInicial";
            this.labelSaldoInicial.Size = new System.Drawing.Size(156, 20);
            this.labelSaldoInicial.TabIndex = 3;
            this.labelSaldoInicial.Text = "Saldo Inicial en Caja:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(47, 99);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(58, 20);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(122, 57);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 20);
            this.labelUser.TabIndex = 1;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(47, 57);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(68, 20);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario:";
            // 
            // groupboxContador
            // 
            this.groupboxContador.Controls.Add(this.buttonTotalBilletes);
            this.groupboxContador.Controls.Add(this.buttonTodoACero);
            this.groupboxContador.Controls.Add(this.textboxTotalBilletes);
            this.groupboxContador.Controls.Add(this.textboxL1);
            this.groupboxContador.Controls.Add(this.textboxL2);
            this.groupboxContador.Controls.Add(this.textboxL5);
            this.groupboxContador.Controls.Add(this.textboxL10);
            this.groupboxContador.Controls.Add(this.textboxL20);
            this.groupboxContador.Controls.Add(this.textboxL50);
            this.groupboxContador.Controls.Add(this.textboxL100);
            this.groupboxContador.Controls.Add(this.textboxL500);
            this.groupboxContador.Controls.Add(this.labelTotalBilletes);
            this.groupboxContador.Controls.Add(this.labelL1);
            this.groupboxContador.Controls.Add(this.labelL2);
            this.groupboxContador.Controls.Add(this.labelL5);
            this.groupboxContador.Controls.Add(this.labelL10);
            this.groupboxContador.Controls.Add(this.labelL20);
            this.groupboxContador.Controls.Add(this.labelL50);
            this.groupboxContador.Controls.Add(this.labelL100);
            this.groupboxContador.Controls.Add(this.labelL500);
            this.groupboxContador.Location = new System.Drawing.Point(279, 20);
            this.groupboxContador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupboxContador.Name = "groupboxContador";
            this.groupboxContador.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupboxContador.Size = new System.Drawing.Size(409, 376);
            this.groupboxContador.TabIndex = 1;
            this.groupboxContador.TabStop = false;
            this.groupboxContador.Text = "Contador de Billetes";
            // 
            // buttonTotalBilletes
            // 
            this.buttonTotalBilletes.Location = new System.Drawing.Point(243, 337);
            this.buttonTotalBilletes.Name = "buttonTotalBilletes";
            this.buttonTotalBilletes.Size = new System.Drawing.Size(130, 30);
            this.buttonTotalBilletes.TabIndex = 19;
            this.buttonTotalBilletes.Text = "Calcular Total";
            this.buttonTotalBilletes.UseVisualStyleBackColor = true;
            this.buttonTotalBilletes.Click += new System.EventHandler(this.buttonTotalBilletes_Click);
            // 
            // buttonTodoACero
            // 
            this.buttonTodoACero.Location = new System.Drawing.Point(107, 337);
            this.buttonTodoACero.Name = "buttonTodoACero";
            this.buttonTodoACero.Size = new System.Drawing.Size(130, 31);
            this.buttonTodoACero.TabIndex = 18;
            this.buttonTodoACero.Text = "Todos a Cero";
            this.buttonTodoACero.UseVisualStyleBackColor = true;
            this.buttonTodoACero.Click += new System.EventHandler(this.buttonTodoACero_Click);
            // 
            // textboxTotalBilletes
            // 
            this.textboxTotalBilletes.Location = new System.Drawing.Point(138, 294);
            this.textboxTotalBilletes.Name = "textboxTotalBilletes";
            this.textboxTotalBilletes.Size = new System.Drawing.Size(208, 26);
            this.textboxTotalBilletes.TabIndex = 17;
            this.textboxTotalBilletes.Text = "0";
            // 
            // textboxL1
            // 
            this.textboxL1.Location = new System.Drawing.Point(274, 226);
            this.textboxL1.Name = "textboxL1";
            this.textboxL1.Size = new System.Drawing.Size(72, 26);
            this.textboxL1.TabIndex = 16;
            this.textboxL1.Text = "0";
            // 
            // textboxL2
            // 
            this.textboxL2.Location = new System.Drawing.Point(274, 166);
            this.textboxL2.Name = "textboxL2";
            this.textboxL2.Size = new System.Drawing.Size(72, 26);
            this.textboxL2.TabIndex = 15;
            this.textboxL2.Text = "0";
            // 
            // textboxL5
            // 
            this.textboxL5.Location = new System.Drawing.Point(279, 102);
            this.textboxL5.Name = "textboxL5";
            this.textboxL5.Size = new System.Drawing.Size(67, 26);
            this.textboxL5.TabIndex = 14;
            this.textboxL5.Text = "0";
            // 
            // textboxL10
            // 
            this.textboxL10.Location = new System.Drawing.Point(279, 37);
            this.textboxL10.Name = "textboxL10";
            this.textboxL10.Size = new System.Drawing.Size(67, 26);
            this.textboxL10.TabIndex = 13;
            this.textboxL10.Text = "0";
            // 
            // textboxL20
            // 
            this.textboxL20.Location = new System.Drawing.Point(138, 229);
            this.textboxL20.Name = "textboxL20";
            this.textboxL20.Size = new System.Drawing.Size(67, 26);
            this.textboxL20.TabIndex = 12;
            this.textboxL20.Text = "0";
            // 
            // textboxL50
            // 
            this.textboxL50.Location = new System.Drawing.Point(138, 166);
            this.textboxL50.Name = "textboxL50";
            this.textboxL50.Size = new System.Drawing.Size(67, 26);
            this.textboxL50.TabIndex = 11;
            this.textboxL50.Text = "0";
            // 
            // textboxL100
            // 
            this.textboxL100.Location = new System.Drawing.Point(138, 102);
            this.textboxL100.Name = "textboxL100";
            this.textboxL100.Size = new System.Drawing.Size(67, 26);
            this.textboxL100.TabIndex = 10;
            this.textboxL100.Text = "0";
            // 
            // textboxL500
            // 
            this.textboxL500.Location = new System.Drawing.Point(138, 37);
            this.textboxL500.Name = "textboxL500";
            this.textboxL500.Size = new System.Drawing.Size(67, 26);
            this.textboxL500.TabIndex = 9;
            this.textboxL500.Text = "0";
            this.textboxL500.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxL500_KeyPress);
            // 
            // labelTotalBilletes
            // 
            this.labelTotalBilletes.AutoSize = true;
            this.labelTotalBilletes.Location = new System.Drawing.Point(62, 300);
            this.labelTotalBilletes.Name = "labelTotalBilletes";
            this.labelTotalBilletes.Size = new System.Drawing.Size(48, 20);
            this.labelTotalBilletes.TabIndex = 8;
            this.labelTotalBilletes.Text = "Total:";
            // 
            // labelL1
            // 
            this.labelL1.AutoSize = true;
            this.labelL1.Location = new System.Drawing.Point(216, 229);
            this.labelL1.Name = "labelL1";
            this.labelL1.Size = new System.Drawing.Size(52, 20);
            this.labelL1.TabIndex = 7;
            this.labelL1.Text = "Lps. 1";
            // 
            // labelL2
            // 
            this.labelL2.AutoSize = true;
            this.labelL2.Location = new System.Drawing.Point(216, 166);
            this.labelL2.Name = "labelL2";
            this.labelL2.Size = new System.Drawing.Size(52, 20);
            this.labelL2.TabIndex = 6;
            this.labelL2.Text = "Lps. 2";
            // 
            // labelL5
            // 
            this.labelL5.AutoSize = true;
            this.labelL5.Location = new System.Drawing.Point(216, 103);
            this.labelL5.Name = "labelL5";
            this.labelL5.Size = new System.Drawing.Size(52, 20);
            this.labelL5.TabIndex = 5;
            this.labelL5.Text = "Lps. 5";
            // 
            // labelL10
            // 
            this.labelL10.AutoSize = true;
            this.labelL10.Location = new System.Drawing.Point(212, 40);
            this.labelL10.Name = "labelL10";
            this.labelL10.Size = new System.Drawing.Size(61, 20);
            this.labelL10.TabIndex = 4;
            this.labelL10.Text = "Lps. 10";
            // 
            // labelL20
            // 
            this.labelL20.AutoSize = true;
            this.labelL20.Location = new System.Drawing.Point(62, 235);
            this.labelL20.Name = "labelL20";
            this.labelL20.Size = new System.Drawing.Size(61, 20);
            this.labelL20.TabIndex = 3;
            this.labelL20.Text = "Lps. 20";
            // 
            // labelL50
            // 
            this.labelL50.AutoSize = true;
            this.labelL50.Location = new System.Drawing.Point(62, 170);
            this.labelL50.Name = "labelL50";
            this.labelL50.Size = new System.Drawing.Size(61, 20);
            this.labelL50.TabIndex = 2;
            this.labelL50.Text = "Lps. 50";
            // 
            // labelL100
            // 
            this.labelL100.AutoSize = true;
            this.labelL100.Location = new System.Drawing.Point(62, 105);
            this.labelL100.Name = "labelL100";
            this.labelL100.Size = new System.Drawing.Size(70, 20);
            this.labelL100.TabIndex = 1;
            this.labelL100.Text = "Lps. 100";
            // 
            // labelL500
            // 
            this.labelL500.AutoSize = true;
            this.labelL500.Location = new System.Drawing.Point(62, 40);
            this.labelL500.Name = "labelL500";
            this.labelL500.Size = new System.Drawing.Size(70, 20);
            this.labelL500.TabIndex = 0;
            this.labelL500.Text = "Lps. 500";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(20, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 221);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturas del Dia:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonCierraCaja
            // 
            this.buttonCierraCaja.Location = new System.Drawing.Point(522, 644);
            this.buttonCierraCaja.Name = "buttonCierraCaja";
            this.buttonCierraCaja.Size = new System.Drawing.Size(130, 45);
            this.buttonCierraCaja.TabIndex = 3;
            this.buttonCierraCaja.Text = "Cierre Caja";
            this.buttonCierraCaja.UseVisualStyleBackColor = true;
            this.buttonCierraCaja.Click += new System.EventHandler(this.buttonCierraCaja_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(386, 644);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(130, 45);
            this.buttonRegresar.TabIndex = 4;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // ArqueoCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 705);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonCierraCaja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupboxContador);
            this.Controls.Add(this.groupboxCaja);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArqueoCaja";
            this.Text = "Arqueo de Caja";
            this.Load += new System.EventHandler(this.ArqueoCaja_Load);
            this.groupboxCaja.ResumeLayout(false);
            this.groupboxCaja.PerformLayout();
            this.groupboxContador.ResumeLayout(false);
            this.groupboxContador.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxCaja;
        private System.Windows.Forms.TextBox textboxTotalFacturas;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textboxSaldoInicial;
        private System.Windows.Forms.Label labelSaldoInicial;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.GroupBox groupboxContador;
        private System.Windows.Forms.TextBox textboxL50;
        private System.Windows.Forms.TextBox textboxL100;
        private System.Windows.Forms.TextBox textboxL500;
        private System.Windows.Forms.Label labelTotalBilletes;
        private System.Windows.Forms.Label labelL1;
        private System.Windows.Forms.Label labelL2;
        private System.Windows.Forms.Label labelL5;
        private System.Windows.Forms.Label labelL10;
        private System.Windows.Forms.Label labelL20;
        private System.Windows.Forms.Label labelL50;
        private System.Windows.Forms.Label labelL100;
        private System.Windows.Forms.Label labelL500;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textboxL2;
        private System.Windows.Forms.TextBox textboxL5;
        private System.Windows.Forms.TextBox textboxL10;
        private System.Windows.Forms.TextBox textboxL20;
        private System.Windows.Forms.TextBox textboxTotalBilletes;
        private System.Windows.Forms.TextBox textboxL1;
        private System.Windows.Forms.Button buttonTotalBilletes;
        private System.Windows.Forms.Button buttonTodoACero;
        private System.Windows.Forms.Button buttonCierraCaja;
        private System.Windows.Forms.Button buttonRegresar;
    }
}