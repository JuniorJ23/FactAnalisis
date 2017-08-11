namespace FactAnalisis
{
    partial class Analisis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analisis));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.gpAcciones = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnExportar = new DevComponents.DotNetBar.ButtonX();
            this.btnCorregir = new DevComponents.DotNetBar.ButtonX();
            this.txtTotalRegistros = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTotalRegistros = new DevComponents.DotNetBar.LabelX();
            this.cmbObservaciones = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.item1 = new DevComponents.Editors.ComboItem();
            this.item2 = new DevComponents.Editors.ComboItem();
            this.item3 = new DevComponents.Editors.ComboItem();
            this.item4 = new DevComponents.Editors.ComboItem();
            this.item5 = new DevComponents.Editors.ComboItem();
            this.item6 = new DevComponents.Editors.ComboItem();
            this.item7 = new DevComponents.Editors.ComboItem();
            this.lblTipoObservacion = new DevComponents.DotNetBar.LabelX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnGenerarFactNeta = new DevComponents.DotNetBar.ButtonX();
            this.btnMergeFact = new DevComponents.DotNetBar.ButtonX();
            this.pgbAnalisis = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.dataGridBase = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.item8 = new DevComponents.Editors.ComboItem();
            this.item9 = new DevComponents.Editors.ComboItem();
            this.gpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBase)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // gpAcciones
            // 
            this.gpAcciones.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpAcciones.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpAcciones.Controls.Add(this.btnExportar);
            this.gpAcciones.Controls.Add(this.btnCorregir);
            this.gpAcciones.Controls.Add(this.txtTotalRegistros);
            this.gpAcciones.Controls.Add(this.lblTotalRegistros);
            this.gpAcciones.Controls.Add(this.cmbObservaciones);
            this.gpAcciones.Controls.Add(this.lblTipoObservacion);
            this.gpAcciones.Controls.Add(this.buttonX2);
            this.gpAcciones.Controls.Add(this.buttonX1);
            this.gpAcciones.Controls.Add(this.btnGenerarFactNeta);
            this.gpAcciones.Controls.Add(this.btnMergeFact);
            this.gpAcciones.Location = new System.Drawing.Point(12, 12);
            this.gpAcciones.Name = "gpAcciones";
            this.gpAcciones.Size = new System.Drawing.Size(494, 660);
            // 
            // 
            // 
            this.gpAcciones.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpAcciones.Style.BackColorGradientAngle = 90;
            this.gpAcciones.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpAcciones.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpAcciones.Style.BorderBottomWidth = 1;
            this.gpAcciones.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpAcciones.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpAcciones.Style.BorderLeftWidth = 1;
            this.gpAcciones.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpAcciones.Style.BorderRightWidth = 1;
            this.gpAcciones.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpAcciones.Style.BorderTopWidth = 1;
            this.gpAcciones.Style.Class = "";
            this.gpAcciones.Style.CornerDiameter = 4;
            this.gpAcciones.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpAcciones.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpAcciones.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpAcciones.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpAcciones.StyleMouseDown.Class = "";
            this.gpAcciones.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpAcciones.StyleMouseOver.Class = "";
            this.gpAcciones.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpAcciones.TabIndex = 0;
            this.gpAcciones.Text = "ACCIONES";
            // 
            // btnExportar
            // 
            this.btnExportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportar.Enabled = false;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = global::FactAnalisis.Properties.Resources.dbf;
            this.btnExportar.Location = new System.Drawing.Point(378, 599);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(107, 37);
            this.btnExportar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCorregir
            // 
            this.btnCorregir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCorregir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCorregir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorregir.Location = new System.Drawing.Point(410, 97);
            this.btnCorregir.Name = "btnCorregir";
            this.btnCorregir.Size = new System.Drawing.Size(75, 23);
            this.btnCorregir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCorregir.TabIndex = 8;
            this.btnCorregir.Text = "CORREGIR";
            this.btnCorregir.Visible = false;
            this.btnCorregir.Click += new System.EventHandler(this.btnCorregir_Click);
            // 
            // txtTotalRegistros
            // 
            // 
            // 
            // 
            this.txtTotalRegistros.Border.Class = "TextBoxBorder";
            this.txtTotalRegistros.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalRegistros.Location = new System.Drawing.Point(155, 100);
            this.txtTotalRegistros.Name = "txtTotalRegistros";
            this.txtTotalRegistros.ReadOnly = true;
            this.txtTotalRegistros.Size = new System.Drawing.Size(97, 20);
            this.txtTotalRegistros.TabIndex = 7;
            // 
            // lblTotalRegistros
            // 
            // 
            // 
            // 
            this.lblTotalRegistros.BackgroundStyle.Class = "";
            this.lblTotalRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalRegistros.Location = new System.Drawing.Point(18, 100);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(131, 23);
            this.lblTotalRegistros.TabIndex = 6;
            this.lblTotalRegistros.Text = "Total de Registros:";
            // 
            // cmbObservaciones
            // 
            this.cmbObservaciones.DisplayMember = "Text";
            this.cmbObservaciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbObservaciones.FormattingEnabled = true;
            this.cmbObservaciones.ItemHeight = 14;
            this.cmbObservaciones.Items.AddRange(new object[] {
            this.item1,
            this.item2,
            this.item3,
            this.item4,
            this.item5,
            this.item6,
            this.item7,
            this.item8,
            this.item9});
            this.cmbObservaciones.Location = new System.Drawing.Point(155, 71);
            this.cmbObservaciones.Name = "cmbObservaciones";
            this.cmbObservaciones.Size = new System.Drawing.Size(295, 20);
            this.cmbObservaciones.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbObservaciones.TabIndex = 5;
            // 
            // item1
            // 
            this.item1.Text = "Ver todo";
            // 
            // item2
            // 
            this.item2.Text = "Sin Codigo de Unidad de Uso";
            // 
            // item3
            // 
            this.item3.Text = "Servicio de Agua Activo y con importes de alcantarillado";
            // 
            // item4
            // 
            this.item4.Text = "Com importe 0 por rebaja y con volumen";
            // 
            // item5
            // 
            this.item5.Text = "Con Sevicio Alcantarillado activo y con importes de agua";
            // 
            // item6
            // 
            this.item6.Text = "Usuarios Cortados con Importes de agua o de alcantarillado";
            // 
            // item7
            // 
            this.item7.Text = "Usuarios Activos con Importes pero sin Volumen";
            // 
            // lblTipoObservacion
            // 
            // 
            // 
            // 
            this.lblTipoObservacion.BackgroundStyle.Class = "";
            this.lblTipoObservacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTipoObservacion.Location = new System.Drawing.Point(18, 71);
            this.lblTipoObservacion.Name = "lblTipoObservacion";
            this.lblTipoObservacion.Size = new System.Drawing.Size(131, 23);
            this.lblTipoObservacion.TabIndex = 4;
            this.lblTipoObservacion.Text = "Tipos de Observaciones:";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(793, 15);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(158, 34);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "buttonX2";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Enabled = false;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Image = global::FactAnalisis.Properties.Resources.binoculars;
            this.buttonX1.Location = new System.Drawing.Point(456, 71);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(29, 20);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnGenerarFactNeta
            // 
            this.btnGenerarFactNeta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerarFactNeta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGenerarFactNeta.Enabled = false;
            this.btnGenerarFactNeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactNeta.Image = global::FactAnalisis.Properties.Resources.plug;
            this.btnGenerarFactNeta.Location = new System.Drawing.Point(251, 15);
            this.btnGenerarFactNeta.Name = "btnGenerarFactNeta";
            this.btnGenerarFactNeta.Size = new System.Drawing.Size(234, 34);
            this.btnGenerarFactNeta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGenerarFactNeta.TabIndex = 1;
            this.btnGenerarFactNeta.Text = "2. GENERAR FACTURACION NETA";
            this.btnGenerarFactNeta.Tooltip = "Se unirá la Facturación bruta con las notas.";
            this.btnGenerarFactNeta.Click += new System.EventHandler(this.btnGenerarFactNeta_Click);
            // 
            // btnMergeFact
            // 
            this.btnMergeFact.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMergeFact.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMergeFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMergeFact.Image = global::FactAnalisis.Properties.Resources.save;
            this.btnMergeFact.Location = new System.Drawing.Point(18, 15);
            this.btnMergeFact.Name = "btnMergeFact";
            this.btnMergeFact.Size = new System.Drawing.Size(227, 34);
            this.btnMergeFact.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMergeFact.TabIndex = 0;
            this.btnMergeFact.Text = "1. GUARDAR FACTURACION BRUTA Y NOTAS";
            this.btnMergeFact.Tooltip = "Se guardará en la BD los archivos de facturacion y notas antes seleccionados.";
            this.btnMergeFact.Click += new System.EventHandler(this.btnMergeFact_Click);
            // 
            // pgbAnalisis
            // 
            // 
            // 
            // 
            this.pgbAnalisis.BackgroundStyle.Class = "";
            this.pgbAnalisis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pgbAnalisis.Location = new System.Drawing.Point(12, 678);
            this.pgbAnalisis.Name = "pgbAnalisis";
            this.pgbAnalisis.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
            this.pgbAnalisis.Size = new System.Drawing.Size(1445, 15);
            this.pgbAnalisis.TabIndex = 1;
            this.pgbAnalisis.Text = "progressBarX1";
            this.pgbAnalisis.Visible = false;
            // 
            // dataGridBase
            // 
            this.dataGridBase.AllowUserToAddRows = false;
            this.dataGridBase.AllowUserToDeleteRows = false;
            this.dataGridBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBase.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridBase.Location = new System.Drawing.Point(512, 12);
            this.dataGridBase.MultiSelect = false;
            this.dataGridBase.Name = "dataGridBase";
            this.dataGridBase.ReadOnly = true;
            this.dataGridBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridBase.Size = new System.Drawing.Size(949, 660);
            this.dataGridBase.TabIndex = 2;
            this.dataGridBase.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // item8
            // 
            this.item8.Text = "Usuarios Con Volumen Y sin Importes";
            // 
            // item9
            // 
            this.item9.Text = "Usuario Activos Sin Importes y sin Volumen";
            // 
            // Analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 698);
            this.Controls.Add(this.dataGridBase);
            this.Controls.Add(this.pgbAnalisis);
            this.Controls.Add(this.gpAcciones);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Analisis";
            this.Text = "ANÁLISIS";
            this.gpAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.GroupPanel gpAcciones;
        private DevComponents.DotNetBar.ButtonX btnMergeFact;
        private DevComponents.DotNetBar.Controls.ProgressBarX pgbAnalisis;
        private DevComponents.DotNetBar.ButtonX btnGenerarFactNeta;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridBase;
        private DevComponents.DotNetBar.LabelX lblTipoObservacion;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbObservaciones;
        private DevComponents.Editors.ComboItem item1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTotalRegistros;
        private DevComponents.DotNetBar.LabelX lblTotalRegistros;
        private DevComponents.Editors.ComboItem item2;
        private DevComponents.Editors.ComboItem item3;
        private DevComponents.Editors.ComboItem item4;
        private DevComponents.Editors.ComboItem item5;
        private DevComponents.DotNetBar.ButtonX btnCorregir;
        private DevComponents.Editors.ComboItem item6;
        private DevComponents.Editors.ComboItem item7;
        private DevComponents.DotNetBar.ButtonX btnExportar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DevComponents.Editors.ComboItem item8;
        private DevComponents.Editors.ComboItem item9;
    }
}