namespace UI
{
    partial class FormDetalles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalles));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.cmbDetalles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.DGventaView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.DGdetallesView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnMostrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGenerateXML = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGventaView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetallesView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDetalles
            // 
            this.cmbDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetalles.FormattingEnabled = true;
            this.cmbDetalles.Location = new System.Drawing.Point(13, 25);
            this.cmbDetalles.Name = "cmbDetalles";
            this.cmbDetalles.Size = new System.Drawing.Size(121, 21);
            this.cmbDetalles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "DETALLES DE VENTA";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(82, 178);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(0, 20);
            this.lblMonto.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(713, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // DGventaView
            // 
            this.DGventaView.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.BurlyWood;
            this.DGventaView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGventaView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGventaView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGventaView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGventaView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGventaView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGventaView.ColumnHeadersHeight = 40;
            this.DGventaView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DGventaView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGventaView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGventaView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGventaView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGventaView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DGventaView.CurrentTheme.GridColor = System.Drawing.Color.BurlyWood;
            this.DGventaView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DGventaView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DGventaView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGventaView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DGventaView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGventaView.CurrentTheme.Name = null;
            this.DGventaView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGventaView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGventaView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGventaView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGventaView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGventaView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGventaView.EnableHeadersVisualStyles = false;
            this.DGventaView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGventaView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DGventaView.HeaderBgColor = System.Drawing.Color.Empty;
            this.DGventaView.HeaderForeColor = System.Drawing.Color.White;
            this.DGventaView.Location = new System.Drawing.Point(12, 37);
            this.DGventaView.Name = "DGventaView";
            this.DGventaView.RowHeadersVisible = false;
            this.DGventaView.RowTemplate.Height = 40;
            this.DGventaView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGventaView.Size = new System.Drawing.Size(442, 99);
            this.DGventaView.TabIndex = 20;
            this.DGventaView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // DGdetallesView
            // 
            this.DGdetallesView.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DGdetallesView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGdetallesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGdetallesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGdetallesView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGdetallesView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGdetallesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGdetallesView.ColumnHeadersHeight = 40;
            this.DGdetallesView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DGdetallesView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGdetallesView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGdetallesView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGdetallesView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGdetallesView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DGdetallesView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGdetallesView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DGdetallesView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DGdetallesView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGdetallesView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DGdetallesView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGdetallesView.CurrentTheme.Name = null;
            this.DGdetallesView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGdetallesView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGdetallesView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGdetallesView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGdetallesView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGdetallesView.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGdetallesView.EnableHeadersVisualStyles = false;
            this.DGdetallesView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGdetallesView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DGdetallesView.HeaderBgColor = System.Drawing.Color.Empty;
            this.DGdetallesView.HeaderForeColor = System.Drawing.Color.White;
            this.DGdetallesView.Location = new System.Drawing.Point(12, 142);
            this.DGdetallesView.Name = "DGdetallesView";
            this.DGdetallesView.RowHeadersVisible = false;
            this.DGdetallesView.RowTemplate.Height = 40;
            this.DGdetallesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGdetallesView.Size = new System.Drawing.Size(442, 296);
            this.DGdetallesView.TabIndex = 21;
            this.DGdetallesView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnMostrar
            // 
            this.btnMostrar.AllowAnimations = true;
            this.btnMostrar.AllowMouseEffects = true;
            this.btnMostrar.AllowToggling = false;
            this.btnMostrar.AnimationSpeed = 200;
            this.btnMostrar.AutoGenerateColors = false;
            this.btnMostrar.AutoRoundBorders = false;
            this.btnMostrar.AutoSizeLeftIcon = true;
            this.btnMostrar.AutoSizeRightIcon = true;
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrar.BackgroundImage")));
            this.btnMostrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrar.ButtonText = "Mostrar";
            this.btnMostrar.ButtonTextMarginLeft = 0;
            this.btnMostrar.ColorContrastOnClick = 45;
            this.btnMostrar.ColorContrastOnHover = 45;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnMostrar.CustomizableEdges = borderEdges1;
            this.btnMostrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMostrar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMostrar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnMostrar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnMostrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMostrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.IconLeft = null;
            this.btnMostrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMostrar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMostrar.IconMarginLeft = 11;
            this.btnMostrar.IconPadding = 10;
            this.btnMostrar.IconRight = null;
            this.btnMostrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMostrar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMostrar.IconSize = 25;
            this.btnMostrar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnMostrar.IdleBorderRadius = 0;
            this.btnMostrar.IdleBorderThickness = 0;
            this.btnMostrar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnMostrar.IdleIconLeftImage = null;
            this.btnMostrar.IdleIconRightImage = null;
            this.btnMostrar.IndicateFocus = false;
            this.btnMostrar.Location = new System.Drawing.Point(13, 52);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMostrar.OnDisabledState.BorderRadius = 1;
            this.btnMostrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrar.OnDisabledState.BorderThickness = 1;
            this.btnMostrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMostrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMostrar.OnDisabledState.IconLeftImage = null;
            this.btnMostrar.OnDisabledState.IconRightImage = null;
            this.btnMostrar.onHoverState.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnMostrar.onHoverState.BorderRadius = 1;
            this.btnMostrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrar.onHoverState.BorderThickness = 1;
            this.btnMostrar.onHoverState.FillColor = System.Drawing.Color.BurlyWood;
            this.btnMostrar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.onHoverState.IconLeftImage = null;
            this.btnMostrar.onHoverState.IconRightImage = null;
            this.btnMostrar.OnIdleState.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnMostrar.OnIdleState.BorderRadius = 1;
            this.btnMostrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrar.OnIdleState.BorderThickness = 1;
            this.btnMostrar.OnIdleState.FillColor = System.Drawing.Color.BurlyWood;
            this.btnMostrar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.OnIdleState.IconLeftImage = null;
            this.btnMostrar.OnIdleState.IconRightImage = null;
            this.btnMostrar.OnPressedState.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnMostrar.OnPressedState.BorderRadius = 1;
            this.btnMostrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrar.OnPressedState.BorderThickness = 1;
            this.btnMostrar.OnPressedState.FillColor = System.Drawing.Color.BurlyWood;
            this.btnMostrar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.OnPressedState.IconLeftImage = null;
            this.btnMostrar.OnPressedState.IconRightImage = null;
            this.btnMostrar.Size = new System.Drawing.Size(91, 28);
            this.btnMostrar.TabIndex = 22;
            this.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMostrar.TextMarginLeft = 0;
            this.btnMostrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMostrar.UseDefaultRadiusAndThickness = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbDetalles);
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(460, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 97);
            this.panel1.TabIndex = 23;
            // 
            // BtnGenerateXML
            // 
            this.BtnGenerateXML.AllowAnimations = true;
            this.BtnGenerateXML.AllowMouseEffects = true;
            this.BtnGenerateXML.AllowToggling = false;
            this.BtnGenerateXML.AnimationSpeed = 200;
            this.BtnGenerateXML.AutoGenerateColors = false;
            this.BtnGenerateXML.AutoRoundBorders = false;
            this.BtnGenerateXML.AutoSizeLeftIcon = true;
            this.BtnGenerateXML.AutoSizeRightIcon = true;
            this.BtnGenerateXML.BackColor = System.Drawing.Color.Transparent;
            this.BtnGenerateXML.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnGenerateXML.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGenerateXML.BackgroundImage")));
            this.BtnGenerateXML.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnGenerateXML.ButtonText = "Generar XML";
            this.BtnGenerateXML.ButtonTextMarginLeft = 0;
            this.BtnGenerateXML.ColorContrastOnClick = 45;
            this.BtnGenerateXML.ColorContrastOnHover = 45;
            this.BtnGenerateXML.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnGenerateXML.CustomizableEdges = borderEdges2;
            this.BtnGenerateXML.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnGenerateXML.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnGenerateXML.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnGenerateXML.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnGenerateXML.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnGenerateXML.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGenerateXML.ForeColor = System.Drawing.Color.White;
            this.BtnGenerateXML.IconLeft = null;
            this.BtnGenerateXML.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerateXML.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnGenerateXML.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnGenerateXML.IconMarginLeft = 11;
            this.BtnGenerateXML.IconPadding = 10;
            this.BtnGenerateXML.IconRight = null;
            this.BtnGenerateXML.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGenerateXML.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnGenerateXML.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnGenerateXML.IconSize = 25;
            this.BtnGenerateXML.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnGenerateXML.IdleBorderRadius = 0;
            this.BtnGenerateXML.IdleBorderThickness = 0;
            this.BtnGenerateXML.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnGenerateXML.IdleIconLeftImage = null;
            this.BtnGenerateXML.IdleIconRightImage = null;
            this.BtnGenerateXML.IndicateFocus = false;
            this.BtnGenerateXML.Location = new System.Drawing.Point(476, 170);
            this.BtnGenerateXML.Name = "BtnGenerateXML";
            this.BtnGenerateXML.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnGenerateXML.OnDisabledState.BorderRadius = 1;
            this.BtnGenerateXML.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnGenerateXML.OnDisabledState.BorderThickness = 1;
            this.BtnGenerateXML.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnGenerateXML.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnGenerateXML.OnDisabledState.IconLeftImage = null;
            this.BtnGenerateXML.OnDisabledState.IconRightImage = null;
            this.BtnGenerateXML.onHoverState.BorderColor = System.Drawing.Color.BurlyWood;
            this.BtnGenerateXML.onHoverState.BorderRadius = 1;
            this.BtnGenerateXML.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnGenerateXML.onHoverState.BorderThickness = 1;
            this.BtnGenerateXML.onHoverState.FillColor = System.Drawing.Color.BurlyWood;
            this.BtnGenerateXML.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnGenerateXML.onHoverState.IconLeftImage = null;
            this.BtnGenerateXML.onHoverState.IconRightImage = null;
            this.BtnGenerateXML.OnIdleState.BorderColor = System.Drawing.Color.BurlyWood;
            this.BtnGenerateXML.OnIdleState.BorderRadius = 1;
            this.BtnGenerateXML.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnGenerateXML.OnIdleState.BorderThickness = 1;
            this.BtnGenerateXML.OnIdleState.FillColor = System.Drawing.Color.BurlyWood;
            this.BtnGenerateXML.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnGenerateXML.OnIdleState.IconLeftImage = null;
            this.BtnGenerateXML.OnIdleState.IconRightImage = null;
            this.BtnGenerateXML.OnPressedState.BorderColor = System.Drawing.Color.BurlyWood;
            this.BtnGenerateXML.OnPressedState.BorderRadius = 1;
            this.BtnGenerateXML.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnGenerateXML.OnPressedState.BorderThickness = 1;
            this.BtnGenerateXML.OnPressedState.FillColor = System.Drawing.Color.BurlyWood;
            this.BtnGenerateXML.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnGenerateXML.OnPressedState.IconLeftImage = null;
            this.BtnGenerateXML.OnPressedState.IconRightImage = null;
            this.BtnGenerateXML.Size = new System.Drawing.Size(88, 28);
            this.BtnGenerateXML.TabIndex = 24;
            this.BtnGenerateXML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGenerateXML.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnGenerateXML.TextMarginLeft = 0;
            this.BtnGenerateXML.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnGenerateXML.UseDefaultRadiusAndThickness = true;
            this.BtnGenerateXML.Click += new System.EventHandler(this.BtnGenerateXML_Click);
            // 
            // FormDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGenerateXML);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGdetallesView);
            this.Controls.Add(this.DGventaView);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FormDetalles";
            this.Text = "DETALLES DE VENTA";
            ((System.ComponentModel.ISupportInitialize)(this.DGventaView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetallesView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnSalir;
        private Bunifu.UI.WinForms.BunifuDataGridView DGventaView;
        private Bunifu.UI.WinForms.BunifuDataGridView DGdetallesView;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMostrar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnGenerateXML;
    }
}