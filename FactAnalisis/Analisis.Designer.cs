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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analisis));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.gpAcciones = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnMergeFact = new DevComponents.DotNetBar.ButtonX();
            this.gpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            // 
            // gpAcciones
            // 
            this.gpAcciones.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpAcciones.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpAcciones.Controls.Add(this.btnMergeFact);
            this.gpAcciones.Location = new System.Drawing.Point(12, 12);
            this.gpAcciones.Name = "gpAcciones";
            this.gpAcciones.Size = new System.Drawing.Size(367, 674);
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
            this.gpAcciones.Text = "Acciones";
            // 
            // btnMergeFact
            // 
            this.btnMergeFact.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMergeFact.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMergeFact.Location = new System.Drawing.Point(57, 15);
            this.btnMergeFact.Name = "btnMergeFact";
            this.btnMergeFact.Size = new System.Drawing.Size(218, 23);
            this.btnMergeFact.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMergeFact.TabIndex = 0;
            this.btnMergeFact.Text = "GENERAR FACTURACION NETA";
            this.btnMergeFact.Tooltip = "Ésta opción unirá la facturación bruta con las notas seleccionadas anteriormente." +
    "";
            this.btnMergeFact.Click += new System.EventHandler(this.btnMergeFact_Click);
            // 
            // Analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 698);
            this.Controls.Add(this.gpAcciones);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Analisis";
            this.Text = "Análisis";
            this.gpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.GroupPanel gpAcciones;
        private DevComponents.DotNetBar.ButtonX btnMergeFact;
    }
}