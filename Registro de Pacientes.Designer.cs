
namespace Registro_de_Pacientes
{
    partial class interfaz
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfaz));
            this.lblTítulo = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.selectCedula = new System.Windows.Forms.ComboBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.imgMasculino = new System.Windows.Forms.PictureBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.lblTlf = new System.Windows.Forms.Label();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.selectTlf = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblAlergia = new System.Windows.Forms.Label();
            this.txtAlergia = new System.Windows.Forms.TextBox();
            this.rbAlergiaNO = new System.Windows.Forms.RadioButton();
            this.rbAlergiaSI = new System.Windows.Forms.RadioButton();
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.imgFemenino = new System.Windows.Forms.PictureBox();
            this.grupo2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgMasculino)).BeginInit();
            this.grupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFemenino)).BeginInit();
            this.grupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Montserrat Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTítulo.Location = new System.Drawing.Point(208, 13);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(384, 37);
            this.lblTítulo.TabIndex = 0;
            this.lblTítulo.Text = "REGISTRO DE PACIENTES";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.Black;
            this.txtNombres.Location = new System.Drawing.Point(362, 44);
            this.txtNombres.MaxLength = 28;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(328, 33);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNombres.Location = new System.Drawing.Point(253, 50);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(89, 21);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombre(s)";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblApellidos.Location = new System.Drawing.Point(253, 111);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(88, 21);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Apellido(s)";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.Black;
            this.txtApellidos.Location = new System.Drawing.Point(362, 105);
            this.txtApellidos.MaxLength = 28;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(328, 33);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGuardar.Location = new System.Drawing.Point(82, 588);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 43);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // selectCedula
            // 
            this.selectCedula.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.selectCedula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCedula.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCedula.FormattingEnabled = true;
            this.selectCedula.IntegralHeight = false;
            this.selectCedula.Items.AddRange(new object[] {
            "V",
            "E"});
            this.selectCedula.Location = new System.Drawing.Point(194, 223);
            this.selectCedula.Name = "selectCedula";
            this.selectCedula.Size = new System.Drawing.Size(40, 24);
            this.selectCedula.TabIndex = 6;
            // 
            // txtCedula
            // 
            this.txtCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCedula.BackColor = System.Drawing.SystemColors.Window;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedula.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.Black;
            this.txtCedula.Location = new System.Drawing.Point(240, 217);
            this.txtCedula.MaxLength = 8;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(145, 33);
            this.txtCedula.TabIndex = 7;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCedula.Location = new System.Drawing.Point(24, 223);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(163, 21);
            this.lblCedula.TabIndex = 10;
            this.lblCedula.Text = "Cédula de Identidad";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEdad.Location = new System.Drawing.Point(273, 169);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(49, 21);
            this.lblEdad.TabIndex = 12;
            this.lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdad.BackColor = System.Drawing.SystemColors.Window;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEdad.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.Black;
            this.txtEdad.Location = new System.Drawing.Point(362, 163);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(50, 33);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // imgMasculino
            // 
            this.imgMasculino.Image = global::Registro_de_Pacientes.Properties.Resources.masculino;
            this.imgMasculino.Location = new System.Drawing.Point(71, 31);
            this.imgMasculino.Name = "imgMasculino";
            this.imgMasculino.Size = new System.Drawing.Size(143, 165);
            this.imgMasculino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMasculino.TabIndex = 13;
            this.imgMasculino.TabStop = false;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbMasculino.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbMasculino.Location = new System.Drawing.Point(460, 169);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(95, 19);
            this.rbMasculino.TabIndex = 4;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "MASCULINO";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbFemenino.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbFemenino.Location = new System.Drawing.Point(603, 169);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(87, 19);
            this.rbFemenino.TabIndex = 5;
            this.rbFemenino.Text = "FEMENINO";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblTlf
            // 
            this.lblTlf.AutoSize = true;
            this.lblTlf.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTlf.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTlf.Location = new System.Drawing.Point(398, 223);
            this.lblTlf.Name = "lblTlf";
            this.lblTlf.Size = new System.Drawing.Size(73, 21);
            this.lblTlf.TabIndex = 17;
            this.lblTlf.Text = "Teléfono";
            // 
            // txtTlf
            // 
            this.txtTlf.BackColor = System.Drawing.SystemColors.Window;
            this.txtTlf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTlf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTlf.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTlf.ForeColor = System.Drawing.Color.Black;
            this.txtTlf.Location = new System.Drawing.Point(541, 217);
            this.txtTlf.MaxLength = 7;
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(149, 33);
            this.txtTlf.TabIndex = 9;
            this.txtTlf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTlf.TextChanged += new System.EventHandler(this.txtTlf_TextChanged);
            // 
            // selectTlf
            // 
            this.selectTlf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.selectTlf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTlf.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTlf.FormattingEnabled = true;
            this.selectTlf.Items.AddRange(new object[] {
            "0412",
            "0414",
            "0416",
            "0424",
            "0426"});
            this.selectTlf.Location = new System.Drawing.Point(477, 223);
            this.selectTlf.Name = "selectTlf";
            this.selectTlf.Size = new System.Drawing.Size(58, 24);
            this.selectTlf.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreo.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(177, 277);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(513, 33);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCorreo.Location = new System.Drawing.Point(24, 283);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(147, 21);
            this.lblCorreo.TabIndex = 20;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDireccion.Location = new System.Drawing.Point(24, 346);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 21);
            this.lblDireccion.TabIndex = 22;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(110, 338);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(580, 33);
            this.txtDireccion.TabIndex = 11;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblAlergia
            // 
            this.lblAlergia.AutoSize = true;
            this.lblAlergia.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlergia.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAlergia.Location = new System.Drawing.Point(21, 37);
            this.lblAlergia.Name = "lblAlergia";
            this.lblAlergia.Size = new System.Drawing.Size(278, 18);
            this.lblAlergia.TabIndex = 24;
            this.lblAlergia.Text = "¿Es usted alérgico a algún medicamento?";
            // 
            // txtAlergia
            // 
            this.txtAlergia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlergia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAlergia.Enabled = false;
            this.txtAlergia.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlergia.ForeColor = System.Drawing.Color.Black;
            this.txtAlergia.Location = new System.Drawing.Point(420, 30);
            this.txtAlergia.MaxLength = 28;
            this.txtAlergia.Name = "txtAlergia";
            this.txtAlergia.Size = new System.Drawing.Size(286, 33);
            this.txtAlergia.TabIndex = 14;
            this.txtAlergia.TextChanged += new System.EventHandler(this.txtAlergia_TextChanged);
            // 
            // rbAlergiaNO
            // 
            this.rbAlergiaNO.AutoSize = true;
            this.rbAlergiaNO.Checked = true;
            this.rbAlergiaNO.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbAlergiaNO.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlergiaNO.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbAlergiaNO.Location = new System.Drawing.Point(367, 37);
            this.rbAlergiaNO.Name = "rbAlergiaNO";
            this.rbAlergiaNO.Size = new System.Drawing.Size(43, 19);
            this.rbAlergiaNO.TabIndex = 13;
            this.rbAlergiaNO.TabStop = true;
            this.rbAlergiaNO.Text = "NO";
            this.rbAlergiaNO.UseVisualStyleBackColor = true;
            // 
            // rbAlergiaSI
            // 
            this.rbAlergiaSI.AutoSize = true;
            this.rbAlergiaSI.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbAlergiaSI.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlergiaSI.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbAlergiaSI.Location = new System.Drawing.Point(318, 37);
            this.rbAlergiaSI.Name = "rbAlergiaSI";
            this.rbAlergiaSI.Size = new System.Drawing.Size(35, 19);
            this.rbAlergiaSI.TabIndex = 12;
            this.rbAlergiaSI.Text = "SI";
            this.rbAlergiaSI.UseVisualStyleBackColor = true;
            this.rbAlergiaSI.CheckedChanged += new System.EventHandler(this.rbAlergiaSI_CheckedChanged);
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.selectCedula);
            this.grupo1.Controls.Add(this.txtCedula);
            this.grupo1.Controls.Add(this.txtNombres);
            this.grupo1.Controls.Add(this.lblNombres);
            this.grupo1.Controls.Add(this.lblApellidos);
            this.grupo1.Controls.Add(this.txtApellidos);
            this.grupo1.Controls.Add(this.rbMasculino);
            this.grupo1.Controls.Add(this.lblDireccion);
            this.grupo1.Controls.Add(this.rbFemenino);
            this.grupo1.Controls.Add(this.txtDireccion);
            this.grupo1.Controls.Add(this.lblCorreo);
            this.grupo1.Controls.Add(this.txtEdad);
            this.grupo1.Controls.Add(this.txtCorreo);
            this.grupo1.Controls.Add(this.lblEdad);
            this.grupo1.Controls.Add(this.txtTlf);
            this.grupo1.Controls.Add(this.selectTlf);
            this.grupo1.Controls.Add(this.lblTlf);
            this.grupo1.Controls.Add(this.lblCedula);
            this.grupo1.Controls.Add(this.imgMasculino);
            this.grupo1.Controls.Add(this.imgFemenino);
            this.grupo1.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo1.ForeColor = System.Drawing.Color.Gray;
            this.grupo1.Location = new System.Drawing.Point(34, 56);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(733, 398);
            this.grupo1.TabIndex = 17;
            this.grupo1.TabStop = false;
            this.grupo1.Text = "Datos Personales";
            // 
            // imgFemenino
            // 
            this.imgFemenino.Image = global::Registro_de_Pacientes.Properties.Resources.femenino;
            this.imgFemenino.Location = new System.Drawing.Point(71, 31);
            this.imgFemenino.Name = "imgFemenino";
            this.imgFemenino.Size = new System.Drawing.Size(143, 165);
            this.imgFemenino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFemenino.TabIndex = 23;
            this.imgFemenino.TabStop = false;
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.rbAlergiaNO);
            this.grupo2.Controls.Add(this.txtAlergia);
            this.grupo2.Controls.Add(this.rbAlergiaSI);
            this.grupo2.Controls.Add(this.lblAlergia);
            this.grupo2.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo2.ForeColor = System.Drawing.Color.Gray;
            this.grupo2.Location = new System.Drawing.Point(34, 477);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(733, 85);
            this.grupo2.TabIndex = 18;
            this.grupo2.TabStop = false;
            this.grupo2.Text = "Información Adicional";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLimpiar.Location = new System.Drawing.Point(342, 588);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 43);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Location = new System.Drawing.Point(602, 588);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 43);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // interfaz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(804, 662);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTítulo);
            this.Controls.Add(this.grupo1);
            this.Controls.Add(this.grupo2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Pacientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMasculino)).EndInit();
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFemenino)).EndInit();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox selectCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.PictureBox imgMasculino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.Label lblTlf;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.ComboBox selectTlf;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblAlergia;
        private System.Windows.Forms.TextBox txtAlergia;
        private System.Windows.Forms.RadioButton rbAlergiaNO;
        private System.Windows.Forms.RadioButton rbAlergiaSI;
        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.GroupBox grupo2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox imgFemenino;
    }
}

