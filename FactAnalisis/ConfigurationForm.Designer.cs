namespace FactAnalisis
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lblRutaBD = new DevComponents.DotNetBar.LabelX();
            this.lblRutaExport = new DevComponents.DotNetBar.LabelX();
            this.txtRutaBD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRutaExport = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnRutaBD = new DevComponents.DotNetBar.ButtonX();
            this.btnRutaExport = new DevComponents.DotNetBar.ButtonX();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.configFormValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            // 
            // lblRutaBD
            // 
            // 
            // 
            // 
            this.lblRutaBD.BackgroundStyle.Class = "";
            this.lblRutaBD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRutaBD.Location = new System.Drawing.Point(12, 12);
            this.lblRutaBD.Name = "lblRutaBD";
            this.lblRutaBD.Size = new System.Drawing.Size(98, 23);
            this.lblRutaBD.TabIndex = 0;
            this.lblRutaBD.Text = "RUTA A LA BD:";
            // 
            // lblRutaExport
            // 
            // 
            // 
            // 
            this.lblRutaExport.BackgroundStyle.Class = "";
            this.lblRutaExport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRutaExport.Location = new System.Drawing.Point(12, 41);
            this.lblRutaExport.Name = "lblRutaExport";
            this.lblRutaExport.Size = new System.Drawing.Size(136, 23);
            this.lblRutaExport.TabIndex = 1;
            this.lblRutaExport.Text = "RUTA EXPORTAR DBF:";
            // 
            // txtRutaBD
            // 
            // 
            // 
            // 
            this.txtRutaBD.Border.Class = "TextBoxBorder";
            this.txtRutaBD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRutaBD.Location = new System.Drawing.Point(140, 12);
            this.txtRutaBD.Name = "txtRutaBD";
            this.txtRutaBD.ReadOnly = true;
            this.txtRutaBD.Size = new System.Drawing.Size(418, 20);
            this.txtRutaBD.TabIndex = 2;
            // 
            // txtRutaExport
            // 
            // 
            // 
            // 
            this.txtRutaExport.Border.Class = "TextBoxBorder";
            this.txtRutaExport.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRutaExport.Location = new System.Drawing.Point(140, 44);
            this.txtRutaExport.Name = "txtRutaExport";
            this.txtRutaExport.ReadOnly = true;
            this.txtRutaExport.Size = new System.Drawing.Size(418, 20);
            this.txtRutaExport.TabIndex = 3;
            // 
            // btnRutaBD
            // 
            this.btnRutaBD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRutaBD.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRutaBD.Image = global::FactAnalisis.Properties.Resources.cloud_computing;
            this.btnRutaBD.Location = new System.Drawing.Point(564, 12);
            this.btnRutaBD.Name = "btnRutaBD";
            this.btnRutaBD.Size = new System.Drawing.Size(75, 23);
            this.btnRutaBD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRutaBD.TabIndex = 4;
            this.btnRutaBD.Click += new System.EventHandler(this.btnRutaBD_Click);
            // 
            // btnRutaExport
            // 
            this.btnRutaExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRutaExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRutaExport.Image = global::FactAnalisis.Properties.Resources.cloud_computing;
            this.btnRutaExport.Location = new System.Drawing.Point(564, 44);
            this.btnRutaExport.Name = "btnRutaExport";
            this.btnRutaExport.Size = new System.Drawing.Size(75, 23);
            this.btnRutaExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRutaExport.TabIndex = 5;
            this.btnRutaExport.Click += new System.EventHandler(this.btnRutaExport_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Location = new System.Drawing.Point(483, 92);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(564, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // configFormValidator
            // 
            this.configFormValidator.ContainerControl = this;
            this.configFormValidator.ErrorProvider = this.errorProvider1;
            this.configFormValidator.Highlighter = this.highlighter1;
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
            // ConfigurationForm
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(683, 127);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnRutaExport);
            this.Controls.Add(this.btnRutaBD);
            this.Controls.Add(this.txtRutaExport);
            this.Controls.Add(this.txtRutaBD);
            this.Controls.Add(this.lblRutaExport);
            this.Controls.Add(this.lblRutaBD);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconTooltip = "VENTANA DE CONFIGURACION DE LA APLICACION";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationForm";
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX lblRutaBD;
        private DevComponents.DotNetBar.LabelX lblRutaExport;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRutaBD;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRutaExport;
        private DevComponents.DotNetBar.ButtonX btnRutaBD;
        private DevComponents.DotNetBar.ButtonX btnRutaExport;
        private DevComponents.DotNetBar.ButtonX btnAceptar;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.Validator.SuperValidator configFormValidator;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    }
}