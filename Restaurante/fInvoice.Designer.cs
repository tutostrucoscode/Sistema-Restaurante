
namespace Restaurante
{
    partial class fInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInvoice));
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLineTextBox4 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox5 = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTotal = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtDate = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtIdTable = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtIdBill = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrice = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtCount = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtUnitPrice = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodName = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnPay = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(507, 12);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.Size = new System.Drawing.Size(417, 426);
            this.dtgvBill.TabIndex = 0;
            this.dtgvBill.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvBill_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLineTextBox4);
            this.panel1.Controls.Add(this.gunaLineTextBox5);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.txtIdTable);
            this.panel1.Controls.Add(this.txtIdBill);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 210);
            this.panel1.TabIndex = 1;
            // 
            // gunaLineTextBox4
            // 
            this.gunaLineTextBox4.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox4.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox4.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox4.Location = new System.Drawing.Point(312, 127);
            this.gunaLineTextBox4.Name = "gunaLineTextBox4";
            this.gunaLineTextBox4.PasswordChar = '\0';
            this.gunaLineTextBox4.Size = new System.Drawing.Size(160, 26);
            this.gunaLineTextBox4.TabIndex = 7;
            this.gunaLineTextBox4.Text = "Volvió";
            // 
            // gunaLineTextBox5
            // 
            this.gunaLineTextBox5.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox5.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox5.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox5.Location = new System.Drawing.Point(312, 90);
            this.gunaLineTextBox5.Name = "gunaLineTextBox5";
            this.gunaLineTextBox5.PasswordChar = '\0';
            this.gunaLineTextBox5.Size = new System.Drawing.Size(160, 26);
            this.gunaLineTextBox5.TabIndex = 6;
            this.gunaLineTextBox5.Text = "Cliente que paga";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotal.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTotal.Location = new System.Drawing.Point(312, 53);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.Size = new System.Drawing.Size(160, 26);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "Total";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDate.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDate.LineColor = System.Drawing.Color.Gainsboro;
            this.txtDate.Location = new System.Drawing.Point(7, 127);
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.Size = new System.Drawing.Size(205, 26);
            this.txtDate.TabIndex = 4;
            this.txtDate.Text = "Día";
            // 
            // txtIdTable
            // 
            this.txtIdTable.BackColor = System.Drawing.Color.White;
            this.txtIdTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdTable.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdTable.LineColor = System.Drawing.Color.Gainsboro;
            this.txtIdTable.Location = new System.Drawing.Point(7, 90);
            this.txtIdTable.Name = "txtIdTable";
            this.txtIdTable.PasswordChar = '\0';
            this.txtIdTable.Size = new System.Drawing.Size(205, 26);
            this.txtIdTable.TabIndex = 3;
            this.txtIdTable.Text = "Código de mesa";
            // 
            // txtIdBill
            // 
            this.txtIdBill.BackColor = System.Drawing.Color.White;
            this.txtIdBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdBill.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdBill.LineColor = System.Drawing.Color.Gainsboro;
            this.txtIdBill.Location = new System.Drawing.Point(7, 53);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.PasswordChar = '\0';
            this.txtIdBill.Size = new System.Drawing.Size(205, 26);
            this.txtIdBill.TabIndex = 2;
            this.txtIdBill.Text = "Factura de código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información general";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtCount);
            this.panel2.Controls.Add(this.txtUnitPrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFoodName);
            this.panel2.Location = new System.Drawing.Point(12, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 210);
            this.panel2.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPrice.Location = new System.Drawing.Point(312, 102);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.Size = new System.Drawing.Size(160, 26);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.Text = "En dinero";
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.White;
            this.txtCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCount.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCount.LineColor = System.Drawing.Color.Gainsboro;
            this.txtCount.Location = new System.Drawing.Point(312, 65);
            this.txtCount.Name = "txtCount";
            this.txtCount.PasswordChar = '\0';
            this.txtCount.Size = new System.Drawing.Size(160, 26);
            this.txtCount.TabIndex = 10;
            this.txtCount.Text = "Monto";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.White;
            this.txtUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitPrice.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnitPrice.LineColor = System.Drawing.Color.Gainsboro;
            this.txtUnitPrice.Location = new System.Drawing.Point(7, 102);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PasswordChar = '\0';
            this.txtUnitPrice.Size = new System.Drawing.Size(205, 26);
            this.txtUnitPrice.TabIndex = 9;
            this.txtUnitPrice.Text = "Precio unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Información alimentaria";
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.Color.White;
            this.txtFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFoodName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFoodName.LineColor = System.Drawing.Color.Gainsboro;
            this.txtFoodName.Location = new System.Drawing.Point(7, 65);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.PasswordChar = '\0';
            this.txtFoodName.Size = new System.Drawing.Size(205, 26);
            this.txtFoodName.TabIndex = 8;
            this.txtFoodName.Text = "El nombre de la comida";
            // 
            // btnPay
            // 
            this.btnPay.ActiveImage = null;
            this.btnPay.AllowAnimations = true;
            this.btnPay.AllowBuffering = false;
            this.btnPay.AllowToggling = false;
            this.btnPay.AllowZooming = true;
            this.btnPay.AllowZoomingOnFocus = false;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPay.ErrorImage")));
            this.btnPay.FadeWhenInactive = false;
            this.btnPay.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPay.Image = global::Restaurante.Properties.Resources.pago;
            this.btnPay.ImageActive = null;
            this.btnPay.ImageLocation = null;
            this.btnPay.ImageMargin = 40;
            this.btnPay.ImageSize = new System.Drawing.Size(50, 45);
            this.btnPay.ImageZoomSize = new System.Drawing.Size(90, 85);
            this.btnPay.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPay.InitialImage")));
            this.btnPay.Location = new System.Drawing.Point(397, 450);
            this.btnPay.Name = "btnPay";
            this.btnPay.Rotation = 0;
            this.btnPay.ShowActiveImage = true;
            this.btnPay.ShowCursorChanges = true;
            this.btnPay.ShowImageBorders = true;
            this.btnPay.ShowSizeMarkers = false;
            this.btnPay.Size = new System.Drawing.Size(90, 85);
            this.btnPay.TabIndex = 6;
            this.btnPay.ToolTipText = "";
            this.btnPay.WaitOnLoad = false;
            this.btnPay.Zoom = 40;
            this.btnPay.ZoomSpeed = 10;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // fInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 543);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvBill);
            this.Name = "fInvoice";
            this.Text = "fInvoice";
            this.Load += new System.EventHandler(this.fInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox4;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox5;
        private Guna.UI.WinForms.GunaLineTextBox txtTotal;
        private Guna.UI.WinForms.GunaLineTextBox txtDate;
        private Guna.UI.WinForms.GunaLineTextBox txtIdTable;
        private Guna.UI.WinForms.GunaLineTextBox txtIdBill;
        private Guna.UI.WinForms.GunaLineTextBox txtPrice;
        private Guna.UI.WinForms.GunaLineTextBox txtCount;
        private Guna.UI.WinForms.GunaLineTextBox txtUnitPrice;
        private Guna.UI.WinForms.GunaLineTextBox txtFoodName;
        private Bunifu.UI.WinForms.BunifuImageButton btnPay;
    }
}