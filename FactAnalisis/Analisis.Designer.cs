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
            this.btnGenerarFactNeta = new DevComponents.DotNetBar.ButtonX();
            this.btnMergeFact = new DevComponents.DotNetBar.ButtonX();
            this.pgbAnalisis = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.dataGridBase = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.gpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBase)).BeginInit();
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
            this.gpAcciones.Controls.Add(this.buttonX1);
            this.gpAcciones.Controls.Add(this.btnGenerarFactNeta);
            this.gpAcciones.Controls.Add(this.btnMergeFact);
            this.gpAcciones.Location = new System.Drawing.Point(12, 12);
            this.gpAcciones.Name = "gpAcciones";
            this.gpAcciones.Size = new System.Drawing.Size(367, 660);
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
            // btnGenerarFactNeta
            // 
            this.btnGenerarFactNeta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerarFactNeta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGenerarFactNeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactNeta.Location = new System.Drawing.Point(57, 55);
            this.btnGenerarFactNeta.Name = "btnGenerarFactNeta";
            this.btnGenerarFactNeta.Size = new System.Drawing.Size(218, 23);
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
            this.btnMergeFact.Location = new System.Drawing.Point(57, 15);
            this.btnMergeFact.Name = "btnMergeFact";
            this.btnMergeFact.Size = new System.Drawing.Size(218, 34);
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
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Enabled = false;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(57, 84);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(218, 28);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "3. VISUALIZAR DATA";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
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
            this.dataGridBase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridBase.Location = new System.Drawing.Point(385, 12);
            this.dataGridBase.MultiSelect = false;
            this.dataGridBase.Name = "dataGridBase";
            this.dataGridBase.ReadOnly = true;
            this.dataGridBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBase.Size = new System.Drawing.Size(1072, 660);
            this.dataGridBase.TabIndex = 2;
            this.dataGridBase.Visible = false;
            // 
            // Analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 698);
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
    }
}