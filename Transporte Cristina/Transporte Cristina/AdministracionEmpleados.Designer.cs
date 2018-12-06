namespace Transporte_Cristina
{
    partial class AdministracionEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionEmpleados));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAgregar = new System.Windows.Forms.TabPage();
            this.groupboxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.comboboxPuestoAgregar = new System.Windows.Forms.ComboBox();
            this.labelPuesto = new System.Windows.Forms.Label();
            this.labelContraseñaTemporal = new System.Windows.Forms.Label();
            this.textboxUsuarioAgregar = new System.Windows.Forms.TextBox();
            this.textboxCelularAgregar = new System.Windows.Forms.TextBox();
            this.textboxTelefonoAgregar = new System.Windows.Forms.TextBox();
            this.textboxApellidoAgregar = new System.Windows.Forms.TextBox();
            this.textboxNombreAgregar = new System.Windows.Forms.TextBox();
            this.textboxIdentidadAgregar = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelIdentidad = new System.Windows.Forms.Label();
            this.btnRegresarAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tabPageModificar = new System.Windows.Forms.TabPage();
            this.textboxUsuarioBusqueda = new System.Windows.Forms.TextBox();
            this.labelUsuarioBusqueda = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelContra = new System.Windows.Forms.Label();
            this.labelPuestoModificar = new System.Windows.Forms.Label();
            this.labelCelularModificar = new System.Windows.Forms.Label();
            this.labelTelefonoModificar = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombreModificar = new System.Windows.Forms.Label();
            this.labelIdentidadModificar = new System.Windows.Forms.Label();
            this.textboxContraseña = new System.Windows.Forms.TextBox();
            this.comboboxPuestoModificar = new System.Windows.Forms.ComboBox();
            this.btnRegresarModificar = new System.Windows.Forms.Button();
            this.btnLimpiarModificar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.textboxCelularModificar = new System.Windows.Forms.TextBox();
            this.textboxTelefonoModificar = new System.Windows.Forms.TextBox();
            this.textboxApellidoModificar = new System.Windows.Forms.TextBox();
            this.textboxNombreModificar = new System.Windows.Forms.TextBox();
            this.textboxIdentidadModificar = new System.Windows.Forms.TextBox();
            this.tabPageEstado = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textboxUsuarioEstado = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnRegresarEliminar = new System.Windows.Forms.Button();
            this.btnActualizacion = new System.Windows.Forms.Button();
            this.labelUsuarioEliminar = new System.Windows.Forms.Label();
            this.errorProviderAdmin = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageAgregar.SuspendLayout();
            this.groupboxDatosPersonales.SuspendLayout();
            this.tabPageModificar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageEstado.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAgregar);
            this.tabControl1.Controls.Add(this.tabPageModificar);
            this.tabControl1.Controls.Add(this.tabPageEstado);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 589);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageAgregar
            // 
            this.tabPageAgregar.Controls.Add(this.groupboxDatosPersonales);
            this.tabPageAgregar.Location = new System.Drawing.Point(4, 29);
            this.tabPageAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAgregar.Name = "tabPageAgregar";
            this.tabPageAgregar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAgregar.Size = new System.Drawing.Size(361, 556);
            this.tabPageAgregar.TabIndex = 0;
            this.tabPageAgregar.Text = "Agregar";
            this.tabPageAgregar.UseVisualStyleBackColor = true;
            // 
            // groupboxDatosPersonales
            // 
            this.groupboxDatosPersonales.Controls.Add(this.comboboxPuestoAgregar);
            this.groupboxDatosPersonales.Controls.Add(this.labelPuesto);
            this.groupboxDatosPersonales.Controls.Add(this.labelContraseñaTemporal);
            this.groupboxDatosPersonales.Controls.Add(this.textboxUsuarioAgregar);
            this.groupboxDatosPersonales.Controls.Add(this.textboxCelularAgregar);
            this.groupboxDatosPersonales.Controls.Add(this.textboxTelefonoAgregar);
            this.groupboxDatosPersonales.Controls.Add(this.textboxApellidoAgregar);
            this.groupboxDatosPersonales.Controls.Add(this.textboxNombreAgregar);
            this.groupboxDatosPersonales.Controls.Add(this.textboxIdentidadAgregar);
            this.groupboxDatosPersonales.Controls.Add(this.labelContraseña);
            this.groupboxDatosPersonales.Controls.Add(this.labelUsuario);
            this.groupboxDatosPersonales.Controls.Add(this.labelCelular);
            this.groupboxDatosPersonales.Controls.Add(this.labelTelefono);
            this.groupboxDatosPersonales.Controls.Add(this.labelApellidos);
            this.groupboxDatosPersonales.Controls.Add(this.labelNombre);
            this.groupboxDatosPersonales.Controls.Add(this.labelIdentidad);
            this.groupboxDatosPersonales.Controls.Add(this.btnRegresarAgregar);
            this.groupboxDatosPersonales.Controls.Add(this.btnLimpiar);
            this.groupboxDatosPersonales.Controls.Add(this.btnRegistrar);
            this.groupboxDatosPersonales.Location = new System.Drawing.Point(8, 9);
            this.groupboxDatosPersonales.Name = "groupboxDatosPersonales";
            this.groupboxDatosPersonales.Size = new System.Drawing.Size(348, 540);
            this.groupboxDatosPersonales.TabIndex = 0;
            this.groupboxDatosPersonales.TabStop = false;
            this.groupboxDatosPersonales.Text = "Datos Personales:";
            // 
            // comboboxPuestoAgregar
            // 
            this.comboboxPuestoAgregar.FormattingEnabled = true;
            this.comboboxPuestoAgregar.Items.AddRange(new object[] {
            "Gerente",
            "Cajero"});
            this.comboboxPuestoAgregar.Location = new System.Drawing.Point(113, 430);
            this.comboboxPuestoAgregar.Name = "comboboxPuestoAgregar";
            this.comboboxPuestoAgregar.Size = new System.Drawing.Size(195, 28);
            this.comboboxPuestoAgregar.TabIndex = 32;
            this.comboboxPuestoAgregar.Validating += new System.ComponentModel.CancelEventHandler(this.comboboxPuestoAgregar_Validating);
            // 
            // labelPuesto
            // 
            this.labelPuesto.AutoSize = true;
            this.labelPuesto.Location = new System.Drawing.Point(27, 433);
            this.labelPuesto.Name = "labelPuesto";
            this.labelPuesto.Size = new System.Drawing.Size(63, 20);
            this.labelPuesto.TabIndex = 31;
            this.labelPuesto.Text = "Puesto:";
            // 
            // labelContraseñaTemporal
            // 
            this.labelContraseñaTemporal.AutoSize = true;
            this.labelContraseñaTemporal.Location = new System.Drawing.Point(199, 379);
            this.labelContraseñaTemporal.Name = "labelContraseñaTemporal";
            this.labelContraseñaTemporal.Size = new System.Drawing.Size(92, 20);
            this.labelContraseñaTemporal.TabIndex = 30;
            this.labelContraseñaTemporal.Text = "Contraseña";
            // 
            // textboxUsuarioAgregar
            // 
            this.textboxUsuarioAgregar.Location = new System.Drawing.Point(113, 322);
            this.textboxUsuarioAgregar.Name = "textboxUsuarioAgregar";
            this.textboxUsuarioAgregar.Size = new System.Drawing.Size(195, 26);
            this.textboxUsuarioAgregar.TabIndex = 29;
            this.textboxUsuarioAgregar.TextChanged += new System.EventHandler(this.textboxUsuarioAgregar_TextChanged);
            this.textboxUsuarioAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxUsuarioAgregar_KeyPress);
            this.textboxUsuarioAgregar.Validating += new System.ComponentModel.CancelEventHandler(this.textboxUsuarioAgregar_Validating);
            // 
            // textboxCelularAgregar
            // 
            this.textboxCelularAgregar.Location = new System.Drawing.Point(113, 268);
            this.textboxCelularAgregar.Name = "textboxCelularAgregar";
            this.textboxCelularAgregar.Size = new System.Drawing.Size(195, 26);
            this.textboxCelularAgregar.TabIndex = 28;
            this.textboxCelularAgregar.TextChanged += new System.EventHandler(this.textboxCelularAgregar_TextChanged);
            this.textboxCelularAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCelularAgregar_KeyPress);
            // 
            // textboxTelefonoAgregar
            // 
            this.textboxTelefonoAgregar.Location = new System.Drawing.Point(113, 214);
            this.textboxTelefonoAgregar.Name = "textboxTelefonoAgregar";
            this.textboxTelefonoAgregar.Size = new System.Drawing.Size(195, 26);
            this.textboxTelefonoAgregar.TabIndex = 27;
            this.textboxTelefonoAgregar.TextChanged += new System.EventHandler(this.textboxTelefonoAgregar_TextChanged);
            this.textboxTelefonoAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxTelefonoAgregar_KeyPress);
            // 
            // textboxApellidoAgregar
            // 
            this.textboxApellidoAgregar.Location = new System.Drawing.Point(113, 162);
            this.textboxApellidoAgregar.Name = "textboxApellidoAgregar";
            this.textboxApellidoAgregar.Size = new System.Drawing.Size(195, 26);
            this.textboxApellidoAgregar.TabIndex = 25;
            this.textboxApellidoAgregar.TextChanged += new System.EventHandler(this.textboxApellidoAgregar_TextChanged);
            this.textboxApellidoAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxApellidoAgregar_KeyPress);
            this.textboxApellidoAgregar.Validating += new System.ComponentModel.CancelEventHandler(this.textboxApellidoAgregar_Validating);
            // 
            // textboxNombreAgregar
            // 
            this.textboxNombreAgregar.Location = new System.Drawing.Point(113, 107);
            this.textboxNombreAgregar.Name = "textboxNombreAgregar";
            this.textboxNombreAgregar.Size = new System.Drawing.Size(195, 26);
            this.textboxNombreAgregar.TabIndex = 24;
            this.textboxNombreAgregar.TextChanged += new System.EventHandler(this.textboxNombreAgregar_TextChanged);
            this.textboxNombreAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNombreAgregar_KeyPress);
            this.textboxNombreAgregar.Validating += new System.ComponentModel.CancelEventHandler(this.textboxNombreAgregar_Validating);
            // 
            // textboxIdentidadAgregar
            // 
            this.textboxIdentidadAgregar.Location = new System.Drawing.Point(113, 52);
            this.textboxIdentidadAgregar.Name = "textboxIdentidadAgregar";
            this.textboxIdentidadAgregar.Size = new System.Drawing.Size(195, 26);
            this.textboxIdentidadAgregar.TabIndex = 23;
            this.textboxIdentidadAgregar.TextChanged += new System.EventHandler(this.textboxIdentidadAgregar_TextChanged);
            this.textboxIdentidadAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxIdentidadAgregar_KeyPress);
            this.textboxIdentidadAgregar.Validating += new System.ComponentModel.CancelEventHandler(this.textboxIdentidadAgregar_Validating);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(27, 379);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(166, 20);
            this.labelContraseña.TabIndex = 22;
            this.labelContraseña.Text = "Contraseña temporal: ";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(27, 325);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(68, 20);
            this.labelUsuario.TabIndex = 21;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Location = new System.Drawing.Point(27, 271);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(62, 20);
            this.labelCelular.TabIndex = 20;
            this.labelCelular.Text = "Celular:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(27, 217);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(75, 20);
            this.labelTelefono.TabIndex = 19;
            this.labelTelefono.Text = "Telefono:";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(27, 163);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(77, 20);
            this.labelApellidos.TabIndex = 17;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(27, 109);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(77, 20);
            this.labelNombre.TabIndex = 16;
            this.labelNombre.Text = "Nombres:";
            // 
            // labelIdentidad
            // 
            this.labelIdentidad.AutoSize = true;
            this.labelIdentidad.Location = new System.Drawing.Point(27, 55);
            this.labelIdentidad.Name = "labelIdentidad";
            this.labelIdentidad.Size = new System.Drawing.Size(80, 20);
            this.labelIdentidad.TabIndex = 15;
            this.labelIdentidad.Text = "Identidad:";
            // 
            // btnRegresarAgregar
            // 
            this.btnRegresarAgregar.Location = new System.Drawing.Point(232, 482);
            this.btnRegresarAgregar.Name = "btnRegresarAgregar";
            this.btnRegresarAgregar.Size = new System.Drawing.Size(101, 46);
            this.btnRegresarAgregar.TabIndex = 14;
            this.btnRegresarAgregar.Text = "Regresar";
            this.btnRegresarAgregar.UseVisualStyleBackColor = true;
            this.btnRegresarAgregar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(125, 482);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 46);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(18, 482);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 46);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tabPageModificar
            // 
            this.tabPageModificar.Controls.Add(this.textboxUsuarioBusqueda);
            this.tabPageModificar.Controls.Add(this.labelUsuarioBusqueda);
            this.tabPageModificar.Controls.Add(this.btnBuscar);
            this.tabPageModificar.Controls.Add(this.groupBox2);
            this.tabPageModificar.Location = new System.Drawing.Point(4, 29);
            this.tabPageModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageModificar.Name = "tabPageModificar";
            this.tabPageModificar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageModificar.Size = new System.Drawing.Size(361, 556);
            this.tabPageModificar.TabIndex = 1;
            this.tabPageModificar.Text = "Modificar";
            this.tabPageModificar.UseVisualStyleBackColor = true;
            // 
            // textboxUsuarioBusqueda
            // 
            this.textboxUsuarioBusqueda.Location = new System.Drawing.Point(85, 9);
            this.textboxUsuarioBusqueda.Name = "textboxUsuarioBusqueda";
            this.textboxUsuarioBusqueda.Size = new System.Drawing.Size(187, 26);
            this.textboxUsuarioBusqueda.TabIndex = 44;
            this.textboxUsuarioBusqueda.TextChanged += new System.EventHandler(this.textboxUsuarioBusqueda_TextChanged_1);
            this.textboxUsuarioBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxUsuarioBusqueda_KeyPress);
            this.textboxUsuarioBusqueda.Validating += new System.ComponentModel.CancelEventHandler(this.textboxUsuarioBusqueda_Validating);
            // 
            // labelUsuarioBusqueda
            // 
            this.labelUsuarioBusqueda.AutoSize = true;
            this.labelUsuarioBusqueda.Location = new System.Drawing.Point(11, 12);
            this.labelUsuarioBusqueda.Name = "labelUsuarioBusqueda";
            this.labelUsuarioBusqueda.Size = new System.Drawing.Size(68, 20);
            this.labelUsuarioBusqueda.TabIndex = 43;
            this.labelUsuarioBusqueda.Text = "Usuario:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(297, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 35);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelContra);
            this.groupBox2.Controls.Add(this.labelPuestoModificar);
            this.groupBox2.Controls.Add(this.labelCelularModificar);
            this.groupBox2.Controls.Add(this.labelTelefonoModificar);
            this.groupBox2.Controls.Add(this.labelApellido);
            this.groupBox2.Controls.Add(this.labelNombreModificar);
            this.groupBox2.Controls.Add(this.labelIdentidadModificar);
            this.groupBox2.Controls.Add(this.textboxContraseña);
            this.groupBox2.Controls.Add(this.comboboxPuestoModificar);
            this.groupBox2.Controls.Add(this.btnRegresarModificar);
            this.groupBox2.Controls.Add(this.btnLimpiarModificar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.textboxCelularModificar);
            this.groupBox2.Controls.Add(this.textboxTelefonoModificar);
            this.groupBox2.Controls.Add(this.textboxApellidoModificar);
            this.groupBox2.Controls.Add(this.textboxNombreModificar);
            this.groupBox2.Controls.Add(this.textboxIdentidadModificar);
            this.groupBox2.Location = new System.Drawing.Point(7, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 493);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Usuario:";
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.Location = new System.Drawing.Point(14, 376);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(96, 20);
            this.labelContra.TabIndex = 59;
            this.labelContra.Text = "Contraseña:";
            // 
            // labelPuestoModificar
            // 
            this.labelPuestoModificar.AutoSize = true;
            this.labelPuestoModificar.Location = new System.Drawing.Point(14, 321);
            this.labelPuestoModificar.Name = "labelPuestoModificar";
            this.labelPuestoModificar.Size = new System.Drawing.Size(63, 20);
            this.labelPuestoModificar.TabIndex = 58;
            this.labelPuestoModificar.Text = "Puesto:";
            // 
            // labelCelularModificar
            // 
            this.labelCelularModificar.AutoSize = true;
            this.labelCelularModificar.Location = new System.Drawing.Point(14, 266);
            this.labelCelularModificar.Name = "labelCelularModificar";
            this.labelCelularModificar.Size = new System.Drawing.Size(62, 20);
            this.labelCelularModificar.TabIndex = 57;
            this.labelCelularModificar.Text = "Celular:";
            // 
            // labelTelefonoModificar
            // 
            this.labelTelefonoModificar.AutoSize = true;
            this.labelTelefonoModificar.Location = new System.Drawing.Point(14, 211);
            this.labelTelefonoModificar.Name = "labelTelefonoModificar";
            this.labelTelefonoModificar.Size = new System.Drawing.Size(75, 20);
            this.labelTelefonoModificar.TabIndex = 56;
            this.labelTelefonoModificar.Text = "Telefono:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(14, 156);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(69, 20);
            this.labelApellido.TabIndex = 55;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelNombreModificar
            // 
            this.labelNombreModificar.AutoSize = true;
            this.labelNombreModificar.Location = new System.Drawing.Point(14, 101);
            this.labelNombreModificar.Name = "labelNombreModificar";
            this.labelNombreModificar.Size = new System.Drawing.Size(69, 20);
            this.labelNombreModificar.TabIndex = 54;
            this.labelNombreModificar.Text = "Nombre:";
            // 
            // labelIdentidadModificar
            // 
            this.labelIdentidadModificar.AutoSize = true;
            this.labelIdentidadModificar.Location = new System.Drawing.Point(14, 46);
            this.labelIdentidadModificar.Name = "labelIdentidadModificar";
            this.labelIdentidadModificar.Size = new System.Drawing.Size(80, 20);
            this.labelIdentidadModificar.TabIndex = 53;
            this.labelIdentidadModificar.Text = "Identidad:";
            // 
            // textboxContraseña
            // 
            this.textboxContraseña.Location = new System.Drawing.Point(129, 368);
            this.textboxContraseña.Name = "textboxContraseña";
            this.textboxContraseña.Size = new System.Drawing.Size(196, 26);
            this.textboxContraseña.TabIndex = 52;
            this.textboxContraseña.TextChanged += new System.EventHandler(this.textboxContraseña_TextChanged);
            this.textboxContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxContraseña_KeyPress);
            // 
            // comboboxPuestoModificar
            // 
            this.comboboxPuestoModificar.FormattingEnabled = true;
            this.comboboxPuestoModificar.Items.AddRange(new object[] {
            "Gerente",
            "Cajero"});
            this.comboboxPuestoModificar.Location = new System.Drawing.Point(130, 315);
            this.comboboxPuestoModificar.Name = "comboboxPuestoModificar";
            this.comboboxPuestoModificar.Size = new System.Drawing.Size(195, 28);
            this.comboboxPuestoModificar.TabIndex = 50;
            this.comboboxPuestoModificar.Validating += new System.ComponentModel.CancelEventHandler(this.comboboxPuestoModificar_Validating);
            // 
            // btnRegresarModificar
            // 
            this.btnRegresarModificar.Location = new System.Drawing.Point(224, 428);
            this.btnRegresarModificar.Name = "btnRegresarModificar";
            this.btnRegresarModificar.Size = new System.Drawing.Size(101, 46);
            this.btnRegresarModificar.TabIndex = 17;
            this.btnRegresarModificar.Text = "Regresar";
            this.btnRegresarModificar.UseVisualStyleBackColor = true;
            this.btnRegresarModificar.Click += new System.EventHandler(this.btnRegresarModificar_Click_1);
            // 
            // btnLimpiarModificar
            // 
            this.btnLimpiarModificar.Location = new System.Drawing.Point(116, 428);
            this.btnLimpiarModificar.Name = "btnLimpiarModificar";
            this.btnLimpiarModificar.Size = new System.Drawing.Size(101, 46);
            this.btnLimpiarModificar.TabIndex = 16;
            this.btnLimpiarModificar.Text = "Limpiar";
            this.btnLimpiarModificar.UseVisualStyleBackColor = true;
            this.btnLimpiarModificar.Click += new System.EventHandler(this.btnLimpiarModificar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(8, 428);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 46);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Actualizar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // textboxCelularModificar
            // 
            this.textboxCelularModificar.Location = new System.Drawing.Point(132, 260);
            this.textboxCelularModificar.Name = "textboxCelularModificar";
            this.textboxCelularModificar.Size = new System.Drawing.Size(195, 26);
            this.textboxCelularModificar.TabIndex = 46;
            this.textboxCelularModificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textboxCelularModificar_MouseClick);
            this.textboxCelularModificar.TextChanged += new System.EventHandler(this.textboxCelularModificar_TextChanged);
            this.textboxCelularModificar.Enter += new System.EventHandler(this.textboxCelularModificar_Enter);
            this.textboxCelularModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCelularModificar_KeyPress);
            // 
            // textboxTelefonoModificar
            // 
            this.textboxTelefonoModificar.Location = new System.Drawing.Point(132, 205);
            this.textboxTelefonoModificar.Name = "textboxTelefonoModificar";
            this.textboxTelefonoModificar.Size = new System.Drawing.Size(195, 26);
            this.textboxTelefonoModificar.TabIndex = 45;
            this.textboxTelefonoModificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textboxTelefonoModificar_MouseClick);
            this.textboxTelefonoModificar.TextChanged += new System.EventHandler(this.textboxTelefonoModificar_TextChanged);
            this.textboxTelefonoModificar.Enter += new System.EventHandler(this.textboxTelefonoModificar_Enter);
            this.textboxTelefonoModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxTelefonoModificar_KeyPress);
            // 
            // textboxApellidoModificar
            // 
            this.textboxApellidoModificar.Location = new System.Drawing.Point(132, 150);
            this.textboxApellidoModificar.Name = "textboxApellidoModificar";
            this.textboxApellidoModificar.Size = new System.Drawing.Size(195, 26);
            this.textboxApellidoModificar.TabIndex = 43;
            this.textboxApellidoModificar.TextChanged += new System.EventHandler(this.textboxApellidoModificar_TextChanged);
            this.textboxApellidoModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxApellidoModificar_KeyPress);
            this.textboxApellidoModificar.Validating += new System.ComponentModel.CancelEventHandler(this.textboxApellidoModificar_Validating);
            // 
            // textboxNombreModificar
            // 
            this.textboxNombreModificar.Location = new System.Drawing.Point(132, 95);
            this.textboxNombreModificar.Name = "textboxNombreModificar";
            this.textboxNombreModificar.Size = new System.Drawing.Size(195, 26);
            this.textboxNombreModificar.TabIndex = 42;
            this.textboxNombreModificar.TextChanged += new System.EventHandler(this.textboxNombreModificar_TextChanged_1);
            this.textboxNombreModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNombreModificar_KeyPress);
            this.textboxNombreModificar.Validating += new System.ComponentModel.CancelEventHandler(this.textboxNombreModificar_Validating);
            // 
            // textboxIdentidadModificar
            // 
            this.textboxIdentidadModificar.Location = new System.Drawing.Point(132, 40);
            this.textboxIdentidadModificar.Name = "textboxIdentidadModificar";
            this.textboxIdentidadModificar.Size = new System.Drawing.Size(195, 26);
            this.textboxIdentidadModificar.TabIndex = 41;
            this.textboxIdentidadModificar.TextChanged += new System.EventHandler(this.textboxIdentidadModificar_TextChanged);
            this.textboxIdentidadModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxIdentidadModificar_KeyPress);
            this.textboxIdentidadModificar.Validating += new System.ComponentModel.CancelEventHandler(this.textboxIdentidadModificar_Validating);
            // 
            // tabPageEstado
            // 
            this.tabPageEstado.Controls.Add(this.groupBox3);
            this.tabPageEstado.Location = new System.Drawing.Point(4, 29);
            this.tabPageEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageEstado.Name = "tabPageEstado";
            this.tabPageEstado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageEstado.Size = new System.Drawing.Size(361, 556);
            this.tabPageEstado.TabIndex = 2;
            this.tabPageEstado.Text = "Estado";
            this.tabPageEstado.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxEstado);
            this.groupBox3.Controls.Add(this.labelEstado);
            this.groupBox3.Controls.Add(this.textboxUsuarioEstado);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnRegresarEliminar);
            this.groupBox3.Controls.Add(this.btnActualizacion);
            this.groupBox3.Controls.Add(this.labelUsuarioEliminar);
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 540);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxEstado.Location = new System.Drawing.Point(118, 273);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(169, 28);
            this.comboBoxEstado.TabIndex = 22;
            this.comboBoxEstado.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxEstado_Validating);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(44, 273);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(64, 20);
            this.labelEstado.TabIndex = 21;
            this.labelEstado.Text = "Estado:";
            // 
            // textboxUsuarioEstado
            // 
            this.textboxUsuarioEstado.Location = new System.Drawing.Point(119, 226);
            this.textboxUsuarioEstado.Name = "textboxUsuarioEstado";
            this.textboxUsuarioEstado.Size = new System.Drawing.Size(169, 26);
            this.textboxUsuarioEstado.TabIndex = 20;
            this.textboxUsuarioEstado.TextChanged += new System.EventHandler(this.textboxUsuarioEliminar_TextChanged);
            this.textboxUsuarioEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxUsuarioEstado_KeyPress);
            this.textboxUsuarioEstado.Validating += new System.ComponentModel.CancelEventHandler(this.textboxUsuarioEstado_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(309, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Aquí puede manejar el estado del usuario. ";
            // 
            // btnRegresarEliminar
            // 
            this.btnRegresarEliminar.Location = new System.Drawing.Point(187, 338);
            this.btnRegresarEliminar.Name = "btnRegresarEliminar";
            this.btnRegresarEliminar.Size = new System.Drawing.Size(101, 46);
            this.btnRegresarEliminar.TabIndex = 19;
            this.btnRegresarEliminar.Text = "Regresar";
            this.btnRegresarEliminar.UseVisualStyleBackColor = true;
            this.btnRegresarEliminar.Click += new System.EventHandler(this.btnRegresarEliminar_Click);
            // 
            // btnActualizacion
            // 
            this.btnActualizacion.Location = new System.Drawing.Point(80, 338);
            this.btnActualizacion.Name = "btnActualizacion";
            this.btnActualizacion.Size = new System.Drawing.Size(101, 46);
            this.btnActualizacion.TabIndex = 18;
            this.btnActualizacion.Text = "Actualizar";
            this.btnActualizacion.UseVisualStyleBackColor = true;
            this.btnActualizacion.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // labelUsuarioEliminar
            // 
            this.labelUsuarioEliminar.AutoSize = true;
            this.labelUsuarioEliminar.Location = new System.Drawing.Point(44, 227);
            this.labelUsuarioEliminar.Name = "labelUsuarioEliminar";
            this.labelUsuarioEliminar.Size = new System.Drawing.Size(68, 20);
            this.labelUsuarioEliminar.TabIndex = 8;
            this.labelUsuarioEliminar.Text = "Usuario:";
            // 
            // errorProviderAdmin
            // 
            this.errorProviderAdmin.ContainerControl = this;
            // 
            // AdministracionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 595);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AdministracionEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de Empleados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministracionEmpleados_FormClosed);
            this.Load += new System.EventHandler(this.AdministracionUsuarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAgregar.ResumeLayout(false);
            this.groupboxDatosPersonales.ResumeLayout(false);
            this.groupboxDatosPersonales.PerformLayout();
            this.tabPageModificar.ResumeLayout(false);
            this.tabPageModificar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageEstado.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAgregar;
        private System.Windows.Forms.TabPage tabPageEstado;
        private System.Windows.Forms.GroupBox groupboxDatosPersonales;
        private System.Windows.Forms.Button btnRegresarAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelUsuarioEliminar;
        private System.Windows.Forms.Button btnRegresarEliminar;
        private System.Windows.Forms.Button btnActualizacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelIdentidad;
        private System.Windows.Forms.Label labelContraseñaTemporal;
        private System.Windows.Forms.TextBox textboxUsuarioAgregar;
        private System.Windows.Forms.TextBox textboxCelularAgregar;
        private System.Windows.Forms.TextBox textboxTelefonoAgregar;
        private System.Windows.Forms.TextBox textboxApellidoAgregar;
        private System.Windows.Forms.TextBox textboxNombreAgregar;
        private System.Windows.Forms.TextBox textboxIdentidadAgregar;
        private System.Windows.Forms.ComboBox comboboxPuestoAgregar;
        private System.Windows.Forms.Label labelPuesto;
        private System.Windows.Forms.TabPage tabPageModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboboxPuestoModificar;
        private System.Windows.Forms.TextBox textboxCelularModificar;
        private System.Windows.Forms.TextBox textboxTelefonoModificar;
        private System.Windows.Forms.TextBox textboxApellidoModificar;
        private System.Windows.Forms.TextBox textboxNombreModificar;
        private System.Windows.Forms.TextBox textboxIdentidadModificar;
        private System.Windows.Forms.Button btnRegresarModificar;
        private System.Windows.Forms.Button btnLimpiarModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox textboxUsuarioBusqueda;
        private System.Windows.Forms.Label labelUsuarioBusqueda;
        private System.Windows.Forms.TextBox textboxUsuarioEstado;
        private System.Windows.Forms.ErrorProvider errorProviderAdmin;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textboxContraseña;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.Label labelPuestoModificar;
        private System.Windows.Forms.Label labelCelularModificar;
        private System.Windows.Forms.Label labelTelefonoModificar;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombreModificar;
        private System.Windows.Forms.Label labelIdentidadModificar;
    }
}