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
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.configFormValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panelPrincipal = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtHost = new DevComponents.Editors.IpAddressInput();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUsername = new DevComponents.DotNetBar.LabelX();
            this.txtPuerto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPuerto = new DevComponents.DotNetBar.LabelX();
            this.lblHost = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(602, 148);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(697, 148);
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
            // panelPrincipal
            // 
            this.panelPrincipal.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelPrincipal.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelPrincipal.Controls.Add(this.txtHost);
            this.panelPrincipal.Controls.Add(this.buttonX1);
            this.panelPrincipal.Controls.Add(this.txtPassword);
            this.panelPrincipal.Controls.Add(this.lblPassword);
            this.panelPrincipal.Controls.Add(this.txtUsername);
            this.panelPrincipal.Controls.Add(this.lblUsername);
            this.panelPrincipal.Controls.Add(this.txtPuerto);
            this.panelPrincipal.Controls.Add(this.lblPuerto);
            this.panelPrincipal.Controls.Add(this.lblHost);
            this.panelPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(766, 130);
            // 
            // 
            // 
            this.panelPrincipal.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelPrincipal.Style.BackColorGradientAngle = 90;
            this.panelPrincipal.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelPrincipal.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelPrincipal.Style.BorderBottomWidth = 1;
            this.panelPrincipal.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelPrincipal.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelPrincipal.Style.BorderLeftWidth = 1;
            this.panelPrincipal.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelPrincipal.Style.BorderRightWidth = 1;
            this.panelPrincipal.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelPrincipal.Style.BorderTopWidth = 1;
            this.panelPrincipal.Style.Class = "";
            this.panelPrincipal.Style.CornerDiameter = 4;
            this.panelPrincipal.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelPrincipal.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.panelPrincipal.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelPrincipal.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.panelPrincipal.StyleMouseDown.Class = "";
            this.panelPrincipal.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelPrincipal.StyleMouseOver.Class = "";
            this.panelPrincipal.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelPrincipal.TabIndex = 8;
            this.panelPrincipal.Text = "CONFIGURACION DE LA BASE DE DATOS";
            // 
            // txtHost
            // 
            this.txtHost.AutoOverwrite = true;
            // 
            // 
            // 
            this.txtHost.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtHost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHost.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtHost.ButtonFreeText.Visible = true;
            this.txtHost.Location = new System.Drawing.Point(63, 27);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(129, 20);
            this.txtHost.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtHost.TabIndex = 9;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(682, 27);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 48);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 8;
            this.buttonX1.Text = "PROBAR CONEXION";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Location = new System.Drawing.Point(429, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(209, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            // 
            // 
            // 
            this.lblPassword.BackgroundStyle.Class = "";
            this.lblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPassword.Location = new System.Drawing.Point(341, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsername.Location = new System.Drawing.Point(429, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(209, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            // 
            // 
            // 
            this.lblUsername.BackgroundStyle.Class = "";
            this.lblUsername.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUsername.Location = new System.Drawing.Point(288, 27);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(135, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "NOMBRE DE USUARIO:";
            // 
            // txtPuerto
            // 
            // 
            // 
            // 
            this.txtPuerto.Border.Class = "TextBoxBorder";
            this.txtPuerto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPuerto.Location = new System.Drawing.Point(63, 66);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(129, 20);
            this.txtPuerto.TabIndex = 3;
            // 
            // lblPuerto
            // 
            // 
            // 
            // 
            this.lblPuerto.BackgroundStyle.Class = "";
            this.lblPuerto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPuerto.Location = new System.Drawing.Point(3, 66);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(58, 20);
            this.lblPuerto.TabIndex = 2;
            this.lblPuerto.Text = "PUERTO:";
            // 
            // lblHost
            // 
            // 
            // 
            // 
            this.lblHost.BackgroundStyle.Class = "";
            this.lblHost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHost.Location = new System.Drawing.Point(3, 27);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(39, 20);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "HOST:";
            // 
            // ConfigurationForm
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(790, 189);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconTooltip = "VENTANA DE CONFIGURACION DE LA APLICACION";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationForm";
            this.Text = "CONFIGURACION";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnAceptar;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.Validator.SuperValidator configFormValidator;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Controls.GroupPanel panelPrincipal;
        private DevComponents.DotNetBar.LabelX lblHost;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private DevComponents.DotNetBar.LabelX lblUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPuerto;
        private DevComponents.DotNetBar.LabelX lblPuerto;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.Editors.IpAddressInput txtHost;
    }
}