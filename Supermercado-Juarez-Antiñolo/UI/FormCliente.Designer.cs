namespace UI
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFinalizarVentas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DGdetalleView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_numeric = new UI.lbl_numeric();
            this.btnSeleccionar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNroVenta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarMedioPago = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblSaludo = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalleView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnSalir);
            this.bunifuPanel1.Controls.Add(this.btnFinalizarVentas);
            this.bunifuPanel1.Controls.Add(this.DGdetalleView);
            this.bunifuPanel1.Controls.Add(this.panel3);
            this.bunifuPanel1.Controls.Add(this.panel2);
            this.bunifuPanel1.Controls.Add(this.lblNroVenta);
            this.bunifuPanel1.Controls.Add(this.label5);
            this.bunifuPanel1.Controls.Add(this.lblMonto);
            this.bunifuPanel1.Controls.Add(this.label4);
            this.bunifuPanel1.Controls.Add(this.btnAgregarMedioPago);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel4);
            this.bunifuPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel1.Controls.Add(this.lblSaludo);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1025, 593);
            this.bunifuPanel1.TabIndex = 39;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(947, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFinalizarVentas
            // 
            this.btnFinalizarVentas.AllowAnimations = true;
            this.btnFinalizarVentas.AllowMouseEffects = true;
            this.btnFinalizarVentas.AllowToggling = false;
            this.btnFinalizarVentas.AnimationSpeed = 200;
            this.btnFinalizarVentas.AutoGenerateColors = false;
            this.btnFinalizarVentas.AutoRoundBorders = false;
            this.btnFinalizarVentas.AutoSizeLeftIcon = true;
            this.btnFinalizarVentas.AutoSizeRightIcon = true;
            this.btnFinalizarVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarVentas.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnFinalizarVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizarVentas.BackgroundImage")));
            this.btnFinalizarVentas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarVentas.ButtonText = "Finalizar Venta";
            this.btnFinalizarVentas.ButtonTextMarginLeft = 0;
            this.btnFinalizarVentas.ColorContrastOnClick = 45;
            this.btnFinalizarVentas.ColorContrastOnHover = 45;
            this.btnFinalizarVentas.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnFinalizarVentas.CustomizableEdges = borderEdges1;
            this.btnFinalizarVentas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFinalizarVentas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFinalizarVentas.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnFinalizarVentas.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnFinalizarVentas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFinalizarVentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinalizarVentas.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVentas.IconLeft = null;
            this.btnFinalizarVentas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarVentas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFinalizarVentas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFinalizarVentas.IconMarginLeft = 11;
            this.btnFinalizarVentas.IconPadding = 10;
            this.btnFinalizarVentas.IconRight = null;
            this.btnFinalizarVentas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizarVentas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFinalizarVentas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFinalizarVentas.IconSize = 25;
            this.btnFinalizarVentas.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnFinalizarVentas.IdleBorderRadius = 0;
            this.btnFinalizarVentas.IdleBorderThickness = 0;
            this.btnFinalizarVentas.IdleFillColor = System.Drawing.Color.Empty;
            this.btnFinalizarVentas.IdleIconLeftImage = null;
            this.btnFinalizarVentas.IdleIconRightImage = null;
            this.btnFinalizarVentas.IndicateFocus = false;
            this.btnFinalizarVentas.Location = new System.Drawing.Point(11, 417);
            this.btnFinalizarVentas.Name = "btnFinalizarVentas";
            this.btnFinalizarVentas.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFinalizarVentas.OnDisabledState.BorderRadius = 1;
            this.btnFinalizarVentas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarVentas.OnDisabledState.BorderThickness = 1;
            this.btnFinalizarVentas.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFinalizarVentas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFinalizarVentas.OnDisabledState.IconLeftImage = null;
            this.btnFinalizarVentas.OnDisabledState.IconRightImage = null;
            this.btnFinalizarVentas.onHoverState.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnFinalizarVentas.onHoverState.BorderRadius = 1;
            this.btnFinalizarVentas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarVentas.onHoverState.BorderThickness = 1;
            this.btnFinalizarVentas.onHoverState.FillColor = System.Drawing.Color.BurlyWood;
            this.btnFinalizarVentas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVentas.onHoverState.IconLeftImage = null;
            this.btnFinalizarVentas.onHoverState.IconRightImage = null;
            this.btnFinalizarVentas.OnIdleState.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnFinalizarVentas.OnIdleState.BorderRadius = 1;
            this.btnFinalizarVentas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarVentas.OnIdleState.BorderThickness = 1;
            this.btnFinalizarVentas.OnIdleState.FillColor = System.Drawing.Color.BurlyWood;
            this.btnFinalizarVentas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVentas.OnIdleState.IconLeftImage = null;
            this.btnFinalizarVentas.OnIdleState.IconRightImage = null;
            this.btnFinalizarVentas.OnPressedState.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnFinalizarVentas.OnPressedState.BorderRadius = 1;
            this.btnFinalizarVentas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarVentas.OnPressedState.BorderThickness = 1;
            this.btnFinalizarVentas.OnPressedState.FillColor = System.Drawing.Color.BurlyWood;
            this.btnFinalizarVentas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVentas.OnPressedState.IconLeftImage = null;
            this.btnFinalizarVentas.OnPressedState.IconRightImage = null;
            this.btnFinalizarVentas.Size = new System.Drawing.Size(201, 22);
            this.btnFinalizarVentas.TabIndex = 58;
            this.btnFinalizarVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizarVentas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFinalizarVentas.TextMarginLeft = 0;
            this.btnFinalizarVentas.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFinalizarVentas.UseDefaultRadiusAndThickness = true;
            this.btnFinalizarVentas.Click += new System.EventHandler(this.btnFinalizarVentas_Click);
            // 
            // DGdetalleView
            // 
            this.DGdetalleView.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGdetalleView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGdetalleView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGdetalleView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGdetalleView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGdetalleView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGdetalleView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGdetalleView.ColumnHeadersHeight = 40;
            this.DGdetalleView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DGdetalleView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGdetalleView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGdetalleView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGdetalleView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGdetalleView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DGdetalleView.CurrentTheme.GridColor = System.Drawing.Color.BurlyWood;
            this.DGdetalleView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.BurlyWood;
            this.DGdetalleView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DGdetalleView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGdetalleView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DGdetalleView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGdetalleView.CurrentTheme.Name = null;
            this.DGdetalleView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGdetalleView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGdetalleView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGdetalleView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGdetalleView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGdetalleView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGdetalleView.EnableHeadersVisualStyles = false;
            this.DGdetalleView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGdetalleView.HeaderBackColor = System.Drawing.Color.BurlyWood;
            this.DGdetalleView.HeaderBgColor = System.Drawing.Color.Empty;
            this.DGdetalleView.HeaderForeColor = System.Drawing.Color.White;
            this.DGdetalleView.Location = new System.Drawing.Point(279, 50);
            this.DGdetalleView.Name = "DGdetalleView";
            this.DGdetalleView.RowHeadersVisible = false;
            this.DGdetalleView.RowTemplate.Height = 40;
            this.DGdetalleView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGdetalleView.Size = new System.Drawing.Size(734, 511);
            this.DGdetalleView.TabIndex = 57;
            this.DGdetalleView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.DGdetalleView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGdetalleView_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbTarjeta);
            this.panel3.Location = new System.Drawing.Point(10, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 56);
            this.panel3.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Elegir Nro Tarjeta";
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTarjeta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(3, 26);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cmbTarjeta.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.lbl_numeric);
            this.panel2.Controls.Add(this.btnSeleccionar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbProducto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(10, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 159);
            this.panel2.TabIndex = 55;
            // 
            // lbl_numeric
            // 
            this.lbl_numeric.Location = new System.Drawing.Point(10, 83);
            this.lbl_numeric.Name = "lbl_numeric";
            this.lbl_numeric.Size = new System.Drawing.Size(137, 44);
            this.lbl_numeric.TabIndex = 27;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AllowAnimations = true;
            this.btnSeleccionar.AllowMouseEffects = true;
            this.btnSeleccionar.AllowToggling = false;
            this.btnSeleccionar.AnimationSpeed = 200;
            this.btnSeleccionar.AutoGenerateColors = false;
            this.btnSeleccionar.AutoRoundBorders = false;
            this.btnSeleccionar.AutoSizeLeftIcon = true;
            this.btnSeleccionar.AutoSizeRightIcon = true;
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSeleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.BackgroundImage")));
            this.btnSeleccionar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeleccionar.ButtonText = "Seleccionar";
            this.btnSeleccionar.ButtonTextMarginLeft = 0;
            this.btnSeleccionar.ColorContrastOnClick = 45;
            this.btnSeleccionar.ColorContrastOnHover = 45;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSeleccionar.CustomizableEdges = borderEdges2;
            this.btnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeleccionar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSeleccionar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSeleccionar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSeleccionar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.IconLeft = null;
            this.btnSeleccionar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSeleccionar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSeleccionar.IconMarginLeft = 11;
            this.btnSeleccionar.IconPadding = 10;
            this.btnSeleccionar.IconRight = null;
            this.btnSeleccionar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSeleccionar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSeleccionar.IconSize = 25;
            this.btnSeleccionar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSeleccionar.IdleBorderRadius = 0;
            this.btnSeleccionar.IdleBorderThickness = 0;
            this.btnSeleccionar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSeleccionar.IdleIconLeftImage = null;
            this.btnSeleccionar.IdleIconRightImage = null;
            this.btnSeleccionar.IndicateFocus = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(27, 133);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSeleccionar.OnDisabledState.BorderRadius = 1;
            this.btnSeleccionar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeleccionar.OnDisabledState.BorderThickness = 1;
            this.btnSeleccionar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSeleccionar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSeleccionar.OnDisabledState.IconLeftImage = null;
            this.btnSeleccionar.OnDisabledState.IconRightImage = null;
            this.btnSeleccionar.onHoverState.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnSeleccionar.onHoverState.BorderRadius = 1;
            this.btnSeleccionar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeleccionar.onHoverState.BorderThickness = 1;
            this.btnSeleccionar.onHoverState.FillColor = System.Drawing.Color.BurlyWood;
            this.btnSeleccionar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.onHoverState.IconLeftImage = null;
            this.btnSeleccionar.onHoverState.IconRightImage = null;
            this.btnSeleccionar.OnIdleState.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnSeleccionar.OnIdleState.BorderRadius = 1;
            this.btnSeleccionar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeleccionar.OnIdleState.BorderThickness = 1;
            this.btnSeleccionar.OnIdleState.FillColor = System.Drawing.Color.BurlyWood;
            this.btnSeleccionar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.OnIdleState.IconLeftImage = null;
            this.btnSeleccionar.OnIdleState.IconRightImage = null;
            this.btnSeleccionar.OnPressedState.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnSeleccionar.OnPressedState.BorderRadius = 1;
            this.btnSeleccionar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeleccionar.OnPressedState.BorderThickness = 1;
            this.btnSeleccionar.OnPressedState.FillColor = System.Drawing.Color.BurlyWood;
            this.btnSeleccionar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.OnPressedState.IconLeftImage = null;
            this.btnSeleccionar.OnPressedState.IconRightImage = null;
            this.btnSeleccionar.Size = new System.Drawing.Size(120, 23);
            this.btnSeleccionar.TabIndex = 27;
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSeleccionar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSeleccionar.TextMarginLeft = 0;
            this.btnSeleccionar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSeleccionar.UseDefaultRadiusAndThickness = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(9, 55);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(153, 21);
            this.cmbProducto.TabIndex = 11;
            this.cmbProducto.SelectionChangeCommitted += new System.EventHandler(this.cmbProducto_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SELECCION DE PRODUCTOS";
            // 
            // lblNroVenta
            // 
            this.lblNroVenta.AutoSize = true;
            this.lblNroVenta.Location = new System.Drawing.Point(120, 365);
            this.lblNroVenta.Name = "lblNroVenta";
            this.lblNroVenta.Size = new System.Drawing.Size(52, 13);
            this.lblNroVenta.TabIndex = 54;
            this.lblNroVenta.Text = "---------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Numero Venta:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(120, 382);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(52, 13);
            this.lblMonto.TabIndex = 52;
            this.lblMonto.Text = "---------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Monto Acumulado: ";
            // 
            // btnAgregarMedioPago
            // 
            this.btnAgregarMedioPago.AllowAnimations = true;
            this.btnAgregarMedioPago.AllowMouseEffects = true;
            this.btnAgregarMedioPago.AllowToggling = false;
            this.btnAgregarMedioPago.AnimationSpeed = 200;
            this.btnAgregarMedioPago.AutoGenerateColors = false;
            this.btnAgregarMedioPago.AutoRoundBorders = false;
            this.btnAgregarMedioPago.AutoSizeLeftIcon = true;
            this.btnAgregarMedioPago.AutoSizeRightIcon = true;
            this.btnAgregarMedioPago.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMedioPago.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAgregarMedioPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarMedioPago.BackgroundImage")));
            this.btnAgregarMedioPago.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMedioPago.ButtonText = "Agregar Medio De Pago";
            this.btnAgregarMedioPago.ButtonTextMarginLeft = 0;
            this.btnAgregarMedioPago.ColorContrastOnClick = 45;
            this.btnAgregarMedioPago.ColorContrastOnHover = 45;
            this.btnAgregarMedioPago.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAgregarMedioPago.CustomizableEdges = borderEdges3;
            this.btnAgregarMedioPago.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarMedioPago.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarMedioPago.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAgregarMedioPago.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAgregarMedioPago.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregarMedioPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarMedioPago.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMedioPago.IconLeft = null;
            this.btnAgregarMedioPago.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMedioPago.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarMedioPago.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarMedioPago.IconMarginLeft = 11;
            this.btnAgregarMedioPago.IconPadding = 10;
            this.btnAgregarMedioPago.IconRight = null;
            this.btnAgregarMedioPago.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarMedioPago.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarMedioPago.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarMedioPago.IconSize = 25;
            this.btnAgregarMedioPago.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAgregarMedioPago.IdleBorderRadius = 0;
            this.btnAgregarMedioPago.IdleBorderThickness = 0;
            this.btnAgregarMedioPago.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAgregarMedioPago.IdleIconLeftImage = null;
            this.btnAgregarMedioPago.IdleIconRightImage = null;
            this.btnAgregarMedioPago.IndicateFocus = false;
            this.btnAgregarMedioPago.Location = new System.Drawing.Point(37, 508);
            this.btnAgregarMedioPago.Name = "btnAgregarMedioPago";
            this.btnAgregarMedioPago.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarMedioPago.OnDisabledState.BorderRadius = 1;
            this.btnAgregarMedioPago.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMedioPago.OnDisabledState.BorderThickness = 1;
            this.btnAgregarMedioPago.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarMedioPago.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarMedioPago.OnDisabledState.IconLeftImage = null;
            this.btnAgregarMedioPago.OnDisabledState.IconRightImage = null;
            this.btnAgregarMedioPago.onHoverState.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnAgregarMedioPago.onHoverState.BorderRadius = 1;
            this.btnAgregarMedioPago.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMedioPago.onHoverState.BorderThickness = 1;
            this.btnAgregarMedioPago.onHoverState.FillColor = System.Drawing.Color.BurlyWood;
            this.btnAgregarMedioPago.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMedioPago.onHoverState.IconLeftImage = null;
            this.btnAgregarMedioPago.onHoverState.IconRightImage = null;
            this.btnAgregarMedioPago.OnIdleState.BorderColor = System.Drawing.Color.Tan;
            this.btnAgregarMedioPago.OnIdleState.BorderRadius = 1;
            this.btnAgregarMedioPago.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMedioPago.OnIdleState.BorderThickness = 1;
            this.btnAgregarMedioPago.OnIdleState.FillColor = System.Drawing.Color.Tan;
            this.btnAgregarMedioPago.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMedioPago.OnIdleState.IconLeftImage = null;
            this.btnAgregarMedioPago.OnIdleState.IconRightImage = null;
            this.btnAgregarMedioPago.OnPressedState.BorderColor = System.Drawing.Color.Tan;
            this.btnAgregarMedioPago.OnPressedState.BorderRadius = 1;
            this.btnAgregarMedioPago.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMedioPago.OnPressedState.BorderThickness = 1;
            this.btnAgregarMedioPago.OnPressedState.FillColor = System.Drawing.Color.Tan;
            this.btnAgregarMedioPago.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMedioPago.OnPressedState.IconLeftImage = null;
            this.btnAgregarMedioPago.OnPressedState.IconRightImage = null;
            this.btnAgregarMedioPago.Size = new System.Drawing.Size(150, 39);
            this.btnAgregarMedioPago.TabIndex = 50;
            this.btnAgregarMedioPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarMedioPago.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarMedioPago.TextMarginLeft = 0;
            this.btnAgregarMedioPago.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAgregarMedioPago.UseDefaultRadiusAndThickness = true;
            this.btnAgregarMedioPago.Click += new System.EventHandler(this.btnAgregarMedioPago_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Arial", 20F);
            this.bunifuLabel2.Location = new System.Drawing.Point(66, 3);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(133, 32);
            this.bunifuLabel2.TabIndex = 49;
            this.bunifuLabel2.Text = "Bienvenido ";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Arial", 20F);
            this.bunifuLabel4.Location = new System.Drawing.Point(279, 12);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(203, 32);
            this.bunifuLabel4.TabIndex = 46;
            this.bunifuLabel4.Text = "Realizar Compra";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 28;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(0, 3);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(57, 57);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 42;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblSaludo
            // 
            this.lblSaludo.AllowParentOverrides = false;
            this.lblSaludo.AutoEllipsis = false;
            this.lblSaludo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSaludo.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblSaludo.Font = new System.Drawing.Font("Arial", 18F);
            this.lblSaludo.Location = new System.Drawing.Point(66, 33);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSaludo.Size = new System.Drawing.Size(64, 27);
            this.lblSaludo.TabIndex = 1;
            this.lblSaludo.Text = "Pepe!";
            this.lblSaludo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSaludo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1025, 588);
            this.Controls.Add(this.bunifuPanel1);
            this.MaximizeBox = false;
            this.Name = "FormCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalleView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblSaludo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregarMedioPago;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFinalizarVentas;
        private Bunifu.UI.WinForms.BunifuDataGridView DGdetalleView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.Panel panel2;
        private lbl_numeric lbl_numeric;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSeleccionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNroVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
    }
}