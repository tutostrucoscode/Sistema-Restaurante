
namespace Restaurante
{
    partial class fOrder
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
            this.txtNameTable = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.cbTenDanhMuc = new Guna.UI.WinForms.GunaComboBox();
            this.cbTenThucAn = new Guna.UI.WinForms.GunaComboBox();
            this.txtGia = new Guna.UI.WinForms.GunaLineTextBox();
            this.nmSoluong = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // txtNameTable
            // 
            this.txtNameTable.BackColor = System.Drawing.Color.White;
            this.txtNameTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameTable.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNameTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameTable.LineColor = System.Drawing.Color.Gainsboro;
            this.txtNameTable.Location = new System.Drawing.Point(90, 54);
            this.txtNameTable.Name = "txtNameTable";
            this.txtNameTable.PasswordChar = '\0';
            this.txtNameTable.Size = new System.Drawing.Size(297, 26);
            this.txtNameTable.TabIndex = 0;
            this.txtNameTable.Text = "Nombre de la tabla";
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbTenDanhMuc
            // 
            this.cbTenDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.cbTenDanhMuc.BaseColor = System.Drawing.Color.White;
            this.cbTenDanhMuc.BorderColor = System.Drawing.Color.Silver;
            this.cbTenDanhMuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTenDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenDanhMuc.FocusedColor = System.Drawing.Color.Empty;
            this.cbTenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTenDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.cbTenDanhMuc.FormattingEnabled = true;
            this.cbTenDanhMuc.Location = new System.Drawing.Point(90, 121);
            this.cbTenDanhMuc.Name = "cbTenDanhMuc";
            this.cbTenDanhMuc.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTenDanhMuc.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTenDanhMuc.Size = new System.Drawing.Size(297, 26);
            this.cbTenDanhMuc.TabIndex = 2;
            this.cbTenDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbTenDanhMuc_SelectedIndexChanged);
            // 
            // cbTenThucAn
            // 
            this.cbTenThucAn.BackColor = System.Drawing.Color.Transparent;
            this.cbTenThucAn.BaseColor = System.Drawing.Color.White;
            this.cbTenThucAn.BorderColor = System.Drawing.Color.Silver;
            this.cbTenThucAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTenThucAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenThucAn.FocusedColor = System.Drawing.Color.Empty;
            this.cbTenThucAn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTenThucAn.ForeColor = System.Drawing.Color.Black;
            this.cbTenThucAn.FormattingEnabled = true;
            this.cbTenThucAn.Location = new System.Drawing.Point(90, 181);
            this.cbTenThucAn.Name = "cbTenThucAn";
            this.cbTenThucAn.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTenThucAn.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTenThucAn.Size = new System.Drawing.Size(297, 26);
            this.cbTenThucAn.TabIndex = 3;
            this.cbTenThucAn.SelectedIndexChanged += new System.EventHandler(this.cbTenThucAn_SelectedIndexChanged);
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGia.LineColor = System.Drawing.Color.Gainsboro;
            this.txtGia.Location = new System.Drawing.Point(90, 229);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.Size = new System.Drawing.Size(297, 26);
            this.txtGia.TabIndex = 4;
            this.txtGia.Text = "Precio";
            // 
            // nmSoluong
            // 
            this.nmSoluong.BaseColor = System.Drawing.Color.White;
            this.nmSoluong.BorderColor = System.Drawing.Color.Silver;
            this.nmSoluong.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nmSoluong.ButtonForeColor = System.Drawing.Color.White;
            this.nmSoluong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nmSoluong.ForeColor = System.Drawing.Color.Black;
            this.nmSoluong.Location = new System.Drawing.Point(90, 300);
            this.nmSoluong.Maximum = ((long)(9999999));
            this.nmSoluong.Minimum = ((long)(1));
            this.nmSoluong.Name = "nmSoluong";
            this.nmSoluong.Size = new System.Drawing.Size(296, 30);
            this.nmSoluong.TabIndex = 5;
            this.nmSoluong.Text = "gunaNumeric1";
            this.nmSoluong.Value = ((long)(1));
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(87, 103);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(97, 15);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Lista de nombres";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(87, 163);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(132, 15);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "El nombre de la comida";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(87, 282);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(43, 15);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Monto";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::Restaurante.Properties.Resources.enviar;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(90, 376);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(297, 42);
            this.gunaButton1.TabIndex = 9;
            this.gunaButton1.Text = "OK";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.btnAddfood_Click);
            // 
            // fOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.nmSoluong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.cbTenThucAn);
            this.Controls.Add(this.cbTenDanhMuc);
            this.Controls.Add(this.txtNameTable);
            this.Name = "fOrder";
            this.Text = "fOrder";
            this.Load += new System.EventHandler(this.fOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox txtNameTable;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private Guna.UI.WinForms.GunaComboBox cbTenDanhMuc;
        private Guna.UI.WinForms.GunaComboBox cbTenThucAn;
        private Guna.UI.WinForms.GunaLineTextBox txtGia;
        private Guna.UI.WinForms.GunaNumeric nmSoluong;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}