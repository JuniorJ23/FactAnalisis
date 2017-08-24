namespace FactAnalisis
{
    partial class CargaArchivosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaArchivosForm));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lblFactBruta = new DevComponents.DotNetBar.LabelX();
            this.lblNotas = new DevComponents.DotNetBar.LabelX();
            this.gpArchivos = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnRutaExport = new DevComponents.DotNetBar.ButtonX();
            this.txtRutaExport = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRutaExport = new DevComponents.DotNetBar.LabelX();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.btnCargarNotas = new DevComponents.DotNetBar.ButtonX();
            this.btnCargarFactBruta = new DevComponents.DotNetBar.ButtonX();
            this.txtRutaNotas = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRutaFactBruta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.validatorCargaForm = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.gpArchivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // lblFactBruta
            // 
            // 
            // 
            // 
            this.lblFactBruta.BackgroundStyle.Class = "";
            this.lblFactBruta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFactBruta.Location = new System.Drawing.Point(3, 28);
            this.lblFactBruta.Name = "lblFactBruta";
            this.lblFactBruta.Size = new System.Drawing.Size(130, 21);
            this.lblFactBruta.TabIndex = 0;
            this.lblFactBruta.Text = "FACT. BRUTA (.csv):";
            // 
            // lblNotas
            // 
            // 
            // 
            // 
            this.lblNotas.BackgroundStyle.Class = "";
            this.lblNotas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNotas.Location = new System.Drawing.Point(3, 55);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(130, 19);
            this.lblNotas.TabIndex = 1;
            this.lblNotas.Text = "NOTAS (.csv):";
            // 
            // gpArchivos
            // 
            this.gpArchivos.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpArchivos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpArchivos.Controls.Add(this.btnRutaExport);
            this.gpArchivos.Controls.Add(this.txtRutaExport);
            this.gpArchivos.Controls.Add(this.lblRutaExport);
            this.gpArchivos.Controls.Add(this.btnAceptar);
            this.gpArchivos.Controls.Add(this.btnCargarNotas);
            this.gpArchivos.Controls.Add(this.btnCargarFactBruta);
            this.gpArchivos.Controls.Add(this.txtRutaNotas);
            this.gpArchivos.Controls.Add(this.txtRutaFactBruta);
            this.gpArchivos.Controls.Add(this.lblFactBruta);
            this.gpArchivos.Controls.Add(this.lblNotas);
            this.gpArchivos.Location = new System.Drawing.Point(12, 12);
            this.gpArchivos.Name = "gpArchivos";
            this.gpArchivos.Size = new System.Drawing.Size(818, 165);
            // 
            // 
            // 
            this.gpArchivos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpArchivos.Style.BackColorGradientAngle = 90;
            this.gpArchivos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpArchivos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpArchivos.Style.BorderBottomWidth = 1;
            this.gpArchivos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpArchivos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpArchivos.Style.BorderLeftWidth = 1;
            this.gpArchivos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpArchivos.Style.BorderRightWidth = 1;
            this.gpArchivos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpArchivos.Style.BorderTopWidth = 1;
            this.gpArchivos.Style.Class = "";
            this.gpArchivos.Style.CornerDiameter = 4;
            this.gpArchivos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpArchivos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpArchivos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpArchivos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpArchivos.StyleMouseDown.Class = "";
            this.gpArchivos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpArchivos.StyleMouseOver.Class = "";
            this.gpArchivos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpArchivos.TabIndex = 2;
            this.gpArchivos.Text = "ARCHIVOS";
            // 
            // btnRutaExport
            // 
            this.btnRutaExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRutaExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRutaExport.Image = global::FactAnalisis.Properties.Resources.cloud_computing;
            this.btnRutaExport.Location = new System.Drawing.Point(708, 78);
            this.btnRutaExport.Name = "btnRutaExport";
            this.btnRutaExport.Size = new System.Drawing.Size(75, 23);
            this.btnRutaExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRutaExport.TabIndex = 9;
            this.btnRutaExport.Click += new System.EventHandler(this.btnRutaExport_Click);
            // 
            // txtRutaExport
            // 
            // 
            // 
            // 
            this.txtRutaExport.Border.Class = "TextBoxBorder";
            this.txtRutaExport.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRutaExport.Location = new System.Drawing.Point(139, 85);
            this.txtRutaExport.Name = "txtRutaExport";
            this.txtRutaExport.ReadOnly = true;
            this.txtRutaExport.Size = new System.Drawing.Size(544, 20);
            this.txtRutaExport.TabIndex = 8;
            this.txtRutaExport.WatermarkText = "RUTA A EXPORTAR EL ARCHIVO .DBF";
            // 
            // lblRutaExport
            // 
            // 
            // 
            // 
            this.lblRutaExport.BackgroundStyle.Class = "";
            this.lblRutaExport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRutaExport.Location = new System.Drawing.Point(1, 83);
            this.lblRutaExport.Name = "lblRutaExport";
            this.lblRutaExport.Size = new System.Drawing.Size(132, 21);
            this.lblRutaExport.TabIndex = 7;
            this.lblRutaExport.Text = "RUTA EXPORTAR DBF:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Location = new System.Drawing.Point(708, 118);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCargarNotas
            // 
            this.btnCargarNotas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCargarNotas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCargarNotas.Image = global::FactAnalisis.Properties.Resources.cloud_computing;
            this.btnCargarNotas.Location = new System.Drawing.Point(708, 54);
            this.btnCargarNotas.Name = "btnCargarNotas";
            this.btnCargarNotas.Size = new System.Drawing.Size(75, 20);
            this.btnCargarNotas.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCargarNotas.TabIndex = 5;
            this.btnCargarNotas.Click += new System.EventHandler(this.btnCargarNotas_Click);
            // 
            // btnCargarFactBruta
            // 
            this.btnCargarFactBruta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCargarFactBruta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCargarFactBruta.Image = global::FactAnalisis.Properties.Resources.cloud_computing;
            this.btnCargarFactBruta.Location = new System.Drawing.Point(708, 28);
            this.btnCargarFactBruta.Name = "btnCargarFactBruta";
            this.btnCargarFactBruta.Size = new System.Drawing.Size(75, 21);
            this.btnCargarFactBruta.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCargarFactBruta.TabIndex = 0;
            this.btnCargarFactBruta.Tooltip = "Seleccionar ruta del archivo de Facturación bruta.";
            this.btnCargarFactBruta.Click += new System.EventHandler(this.btnCargarFactBruta_Click);
            // 
            // txtRutaNotas
            // 
            // 
            // 
            // 
            this.txtRutaNotas.Border.Class = "TextBoxBorder";
            this.txtRutaNotas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRutaNotas.Location = new System.Drawing.Point(139, 54);
            this.txtRutaNotas.Name = "txtRutaNotas";
            this.txtRutaNotas.ReadOnly = true;
            this.txtRutaNotas.Size = new System.Drawing.Size(544, 20);
            this.txtRutaNotas.TabIndex = 3;
            this.txtRutaNotas.WatermarkText = "RUTA AL ARCHIVO DE NOTAS";
            // 
            // txtRutaFactBruta
            // 
            // 
            // 
            // 
            this.txtRutaFactBruta.Border.Class = "TextBoxBorder";
            this.txtRutaFactBruta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRutaFactBruta.Location = new System.Drawing.Point(139, 29);
            this.txtRutaFactBruta.Name = "txtRutaFactBruta";
            this.txtRutaFactBruta.ReadOnly = true;
            this.txtRutaFactBruta.Size = new System.Drawing.Size(544, 20);
            this.txtRutaFactBruta.TabIndex = 2;
            this.txtRutaFactBruta.WatermarkText = "RUTA AL ARCHIVO DE FACTURACION BRUTA";
            // 
            // validatorCargaForm
            // 
            this.validatorCargaForm.ContainerControl = this;
            this.validatorCargaForm.ErrorProvider = this.errorProvider1;
            this.validatorCargaForm.Highlighter = this.highlighter1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // CargaArchivosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 189);
            this.Controls.Add(this.gpArchivos);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargaArchivosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CARGA DE ARCHIVOS (.csv)";
            this.gpArchivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX lblFactBruta;
        private DevComponents.DotNetBar.LabelX lblNotas;
        private DevComponents.DotNetBar.Controls.GroupPanel gpArchivos;
        private DevComponents.DotNetBar.ButtonX btnCargarFactBruta;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRutaNotas;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRutaFactBruta;
        private DevComponents.DotNetBar.ButtonX btnCargarNotas;
        private DevComponents.DotNetBar.ButtonX btnAceptar;
        private DevComponents.DotNetBar.Validator.SuperValidator validatorCargaForm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.ButtonX btnRutaExport;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRutaExport;
        private DevComponents.DotNetBar.LabelX lblRutaExport;
    }
}