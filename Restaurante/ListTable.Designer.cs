
namespace Restaurante
{
    partial class ListTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTable));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgvFoodbyId = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMergeTable = new Guna.UI.WinForms.GunaButton();
            this.btnSwichTable = new Guna.UI.WinForms.GunaButton();
            this.cbbMergeTable = new System.Windows.Forms.ComboBox();
            this.cbbSwichTable = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.buttonOrder = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonPayMonney = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodbyId)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(385, 460);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // dtgvFoodbyId
            // 
            this.dtgvFoodbyId.AllowUserToAddRows = false;
            this.dtgvFoodbyId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFoodbyId.Location = new System.Drawing.Point(403, 35);
            this.dtgvFoodbyId.Name = "dtgvFoodbyId";
            this.dtgvFoodbyId.Size = new System.Drawing.Size(385, 460);
            this.dtgvFoodbyId.TabIndex = 3;
            this.dtgvFoodbyId.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFoodbyId_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMergeTable);
            this.panel1.Controls.Add(this.btnSwichTable);
            this.panel1.Controls.Add(this.cbbMergeTable);
            this.panel1.Controls.Add(this.cbbSwichTable);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(331, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 125);
            this.panel1.TabIndex = 4;
            // 
            // btnMergeTable
            // 
            this.btnMergeTable.AnimationHoverSpeed = 0.07F;
            this.btnMergeTable.AnimationSpeed = 0.03F;
            this.btnMergeTable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnMergeTable.BorderColor = System.Drawing.Color.Black;
            this.btnMergeTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMergeTable.FocusedColor = System.Drawing.Color.Empty;
            this.btnMergeTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMergeTable.ForeColor = System.Drawing.Color.White;
            this.btnMergeTable.Image = global::Restaurante.Properties.Resources.unir;
            this.btnMergeTable.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMergeTable.Location = new System.Drawing.Point(136, 71);
            this.btnMergeTable.Name = "btnMergeTable";
            this.btnMergeTable.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMergeTable.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMergeTable.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMergeTable.OnHoverImage = null;
            this.btnMergeTable.OnPressedColor = System.Drawing.Color.Black;
            this.btnMergeTable.Size = new System.Drawing.Size(101, 34);
            this.btnMergeTable.TabIndex = 8;
            this.btnMergeTable.Text = "Unir";
            // 
            // btnSwichTable
            // 
            this.btnSwichTable.AnimationHoverSpeed = 0.07F;
            this.btnSwichTable.AnimationSpeed = 0.03F;
            this.btnSwichTable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSwichTable.BorderColor = System.Drawing.Color.Black;
            this.btnSwichTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSwichTable.FocusedColor = System.Drawing.Color.Empty;
            this.btnSwichTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSwichTable.ForeColor = System.Drawing.Color.White;
            this.btnSwichTable.Image = global::Restaurante.Properties.Resources.cambiar;
            this.btnSwichTable.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSwichTable.Location = new System.Drawing.Point(136, 21);
            this.btnSwichTable.Name = "btnSwichTable";
            this.btnSwichTable.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSwichTable.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSwichTable.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSwichTable.OnHoverImage = null;
            this.btnSwichTable.OnPressedColor = System.Drawing.Color.Black;
            this.btnSwichTable.Size = new System.Drawing.Size(101, 34);
            this.btnSwichTable.TabIndex = 7;
            this.btnSwichTable.Text = "Cambio";
            this.btnSwichTable.Click += new System.EventHandler(this.btn_SwitchTable);
            // 
            // cbbMergeTable
            // 
            this.cbbMergeTable.FormattingEnabled = true;
            this.cbbMergeTable.Location = new System.Drawing.Point(9, 79);
            this.cbbMergeTable.Name = "cbbMergeTable";
            this.cbbMergeTable.Size = new System.Drawing.Size(121, 21);
            this.cbbMergeTable.TabIndex = 7;
            // 
            // cbbSwichTable
            // 
            this.cbbSwichTable.FormattingEnabled = true;
            this.cbbSwichTable.Location = new System.Drawing.Point(9, 29);
            this.cbbSwichTable.Name = "cbbSwichTable";
            this.cbbSwichTable.Size = new System.Drawing.Size(121, 21);
            this.cbbSwichTable.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(262, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad total";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(12, 52);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(151, 22);
            this.txtTongTien.TabIndex = 6;
            // 
            // buttonOrder
            // 
            this.buttonOrder.ActiveImage = null;
            this.buttonOrder.AllowAnimations = true;
            this.buttonOrder.AllowBuffering = false;
            this.buttonOrder.AllowToggling = false;
            this.buttonOrder.AllowZooming = true;
            this.buttonOrder.AllowZoomingOnFocus = false;
            this.buttonOrder.BackColor = System.Drawing.Color.Transparent;
            this.buttonOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonOrder.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonOrder.ErrorImage")));
            this.buttonOrder.FadeWhenInactive = false;
            this.buttonOrder.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonOrder.Image = global::Restaurante.Properties.Resources.orden2;
            this.buttonOrder.ImageActive = null;
            this.buttonOrder.ImageLocation = null;
            this.buttonOrder.ImageMargin = 40;
            this.buttonOrder.ImageSize = new System.Drawing.Size(50, 45);
            this.buttonOrder.ImageZoomSize = new System.Drawing.Size(90, 85);
            this.buttonOrder.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonOrder.InitialImage")));
            this.buttonOrder.Location = new System.Drawing.Point(116, 521);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Rotation = 0;
            this.buttonOrder.ShowActiveImage = true;
            this.buttonOrder.ShowCursorChanges = true;
            this.buttonOrder.ShowImageBorders = true;
            this.buttonOrder.ShowSizeMarkers = false;
            this.buttonOrder.Size = new System.Drawing.Size(90, 85);
            this.buttonOrder.TabIndex = 6;
            this.buttonOrder.ToolTipText = "";
            this.buttonOrder.WaitOnLoad = false;
            this.buttonOrder.Zoom = 40;
            this.buttonOrder.ZoomSpeed = 10;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonPayMonney
            // 
            this.buttonPayMonney.ActiveImage = null;
            this.buttonPayMonney.AllowAnimations = true;
            this.buttonPayMonney.AllowBuffering = false;
            this.buttonPayMonney.AllowToggling = false;
            this.buttonPayMonney.AllowZooming = true;
            this.buttonPayMonney.AllowZoomingOnFocus = false;
            this.buttonPayMonney.BackColor = System.Drawing.Color.Transparent;
            this.buttonPayMonney.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonPayMonney.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonPayMonney.ErrorImage")));
            this.buttonPayMonney.FadeWhenInactive = false;
            this.buttonPayMonney.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonPayMonney.Image = global::Restaurante.Properties.Resources.pago;
            this.buttonPayMonney.ImageActive = null;
            this.buttonPayMonney.ImageLocation = null;
            this.buttonPayMonney.ImageMargin = 40;
            this.buttonPayMonney.ImageSize = new System.Drawing.Size(50, 45);
            this.buttonPayMonney.ImageZoomSize = new System.Drawing.Size(90, 85);
            this.buttonPayMonney.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonPayMonney.InitialImage")));
            this.buttonPayMonney.Location = new System.Drawing.Point(212, 521);
            this.buttonPayMonney.Name = "buttonPayMonney";
            this.buttonPayMonney.Rotation = 0;
            this.buttonPayMonney.ShowActiveImage = true;
            this.buttonPayMonney.ShowCursorChanges = true;
            this.buttonPayMonney.ShowImageBorders = true;
            this.buttonPayMonney.ShowSizeMarkers = false;
            this.buttonPayMonney.Size = new System.Drawing.Size(90, 85);
            this.buttonPayMonney.TabIndex = 5;
            this.buttonPayMonney.ToolTipText = "";
            this.buttonPayMonney.WaitOnLoad = false;
            this.buttonPayMonney.Zoom = 40;
            this.buttonPayMonney.ZoomSpeed = 10;
            this.buttonPayMonney.Click += new System.EventHandler(this.buttonPayMonney_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Restaurante.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(772, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ListTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonPayMonney);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvFoodbyId);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ListTable";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ListTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodbyId)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgvFoodbyId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cbbMergeTable;
        private System.Windows.Forms.ComboBox cbbSwichTable;
        private Bunifu.UI.WinForms.BunifuImageButton buttonPayMonney;
        private Bunifu.UI.WinForms.BunifuImageButton buttonOrder;
        private Guna.UI.WinForms.GunaButton btnSwichTable;
        private Guna.UI.WinForms.GunaButton btnMergeTable;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}