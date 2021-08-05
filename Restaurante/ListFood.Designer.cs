
namespace Restaurante
{
    partial class ListFood
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
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtFoodName = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTypeName = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTypeID = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtFoodID = new Guna.UI.WinForms.GunaLineTextBox();
            this.cbbSelect = new Guna.UI.WinForms.GunaComboBox();
            this.buttonAddFood = new Guna.UI.WinForms.GunaAdvenceButton();
            this.buttonUpdateFood = new Guna.UI.WinForms.GunaAdvenceButton();
            this.buttonDeleteFood = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Size = new System.Drawing.Size(160, 32);
            this.txtSearch.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtFoodName);
            this.panel1.Controls.Add(this.txtTypeName);
            this.panel1.Controls.Add(this.txtTypeID);
            this.panel1.Controls.Add(this.txtFoodID);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 145);
            this.panel1.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.LineColor = System.Drawing.Color.DarkRed;
            this.txtPrice.Location = new System.Drawing.Point(255, 56);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.Size = new System.Drawing.Size(160, 32);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "Precio";
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.txtFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFoodName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFoodName.LineColor = System.Drawing.Color.DarkRed;
            this.txtFoodName.Location = new System.Drawing.Point(255, 13);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.PasswordChar = '\0';
            this.txtFoodName.Size = new System.Drawing.Size(160, 32);
            this.txtFoodName.TabIndex = 6;
            this.txtFoodName.Text = "El nombre de la comida";
            // 
            // txtTypeName
            // 
            this.txtTypeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.txtTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTypeName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTypeName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypeName.LineColor = System.Drawing.Color.DarkRed;
            this.txtTypeName.Location = new System.Drawing.Point(84, 99);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.PasswordChar = '\0';
            this.txtTypeName.Size = new System.Drawing.Size(160, 32);
            this.txtTypeName.TabIndex = 5;
            this.txtTypeName.Text = "Escribe un nombre";
            // 
            // txtTypeID
            // 
            this.txtTypeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.txtTypeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTypeID.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTypeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypeID.LineColor = System.Drawing.Color.DarkRed;
            this.txtTypeID.Location = new System.Drawing.Point(84, 56);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.PasswordChar = '\0';
            this.txtTypeID.Size = new System.Drawing.Size(160, 32);
            this.txtTypeID.TabIndex = 4;
            this.txtTypeID.Text = "Código de tipo";
            // 
            // txtFoodID
            // 
            this.txtFoodID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.txtFoodID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodID.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFoodID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFoodID.LineColor = System.Drawing.Color.DarkRed;
            this.txtFoodID.Location = new System.Drawing.Point(84, 13);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.PasswordChar = '\0';
            this.txtFoodID.Size = new System.Drawing.Size(160, 32);
            this.txtFoodID.TabIndex = 3;
            this.txtFoodID.Text = "Codigo alimenticio";
            // 
            // cbbSelect
            // 
            this.cbbSelect.BackColor = System.Drawing.Color.Transparent;
            this.cbbSelect.BaseColor = System.Drawing.Color.White;
            this.cbbSelect.BorderColor = System.Drawing.Color.Silver;
            this.cbbSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelect.FocusedColor = System.Drawing.Color.Empty;
            this.cbbSelect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSelect.ForeColor = System.Drawing.Color.Black;
            this.cbbSelect.FormattingEnabled = true;
            this.cbbSelect.Location = new System.Drawing.Point(20, 221);
            this.cbbSelect.Name = "cbbSelect";
            this.cbbSelect.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbSelect.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbSelect.Size = new System.Drawing.Size(160, 26);
            this.cbbSelect.TabIndex = 6;
            this.cbbSelect.SelectedIndexChanged += new System.EventHandler(this.cbbSelect_SelectedIndexChanged);
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.AnimationHoverSpeed = 0.07F;
            this.buttonAddFood.AnimationSpeed = 0.03F;
            this.buttonAddFood.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.buttonAddFood.BorderColor = System.Drawing.Color.Black;
            this.buttonAddFood.CheckedBaseColor = System.Drawing.Color.Gray;
            this.buttonAddFood.CheckedBorderColor = System.Drawing.Color.Black;
            this.buttonAddFood.CheckedForeColor = System.Drawing.Color.White;
            this.buttonAddFood.CheckedImage = global::Restaurante.Properties.Resources.lupa;
            this.buttonAddFood.CheckedLineColor = System.Drawing.Color.DimGray;
            this.buttonAddFood.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAddFood.FocusedColor = System.Drawing.Color.Empty;
            this.buttonAddFood.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFood.ForeColor = System.Drawing.Color.White;
            this.buttonAddFood.Image = global::Restaurante.Properties.Resources.boton_agregar;
            this.buttonAddFood.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonAddFood.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonAddFood.Location = new System.Drawing.Point(523, 78);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonAddFood.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonAddFood.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonAddFood.OnHoverImage = null;
            this.buttonAddFood.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonAddFood.OnPressedColor = System.Drawing.Color.Black;
            this.buttonAddFood.Size = new System.Drawing.Size(122, 32);
            this.buttonAddFood.TabIndex = 5;
            this.buttonAddFood.Text = "Más";
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // buttonUpdateFood
            // 
            this.buttonUpdateFood.AnimationHoverSpeed = 0.07F;
            this.buttonUpdateFood.AnimationSpeed = 0.03F;
            this.buttonUpdateFood.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.buttonUpdateFood.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdateFood.CheckedBaseColor = System.Drawing.Color.Gray;
            this.buttonUpdateFood.CheckedBorderColor = System.Drawing.Color.Black;
            this.buttonUpdateFood.CheckedForeColor = System.Drawing.Color.White;
            this.buttonUpdateFood.CheckedImage = global::Restaurante.Properties.Resources.lupa;
            this.buttonUpdateFood.CheckedLineColor = System.Drawing.Color.DimGray;
            this.buttonUpdateFood.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonUpdateFood.FocusedColor = System.Drawing.Color.Empty;
            this.buttonUpdateFood.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateFood.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateFood.Image = global::Restaurante.Properties.Resources.editar3;
            this.buttonUpdateFood.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonUpdateFood.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonUpdateFood.Location = new System.Drawing.Point(523, 121);
            this.buttonUpdateFood.Name = "buttonUpdateFood";
            this.buttonUpdateFood.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonUpdateFood.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonUpdateFood.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonUpdateFood.OnHoverImage = null;
            this.buttonUpdateFood.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonUpdateFood.OnPressedColor = System.Drawing.Color.Black;
            this.buttonUpdateFood.Size = new System.Drawing.Size(122, 32);
            this.buttonUpdateFood.TabIndex = 4;
            this.buttonUpdateFood.Text = "Reparar";
            this.buttonUpdateFood.Click += new System.EventHandler(this.buttonUpdateFood_Click);
            // 
            // buttonDeleteFood
            // 
            this.buttonDeleteFood.AnimationHoverSpeed = 0.07F;
            this.buttonDeleteFood.AnimationSpeed = 0.03F;
            this.buttonDeleteFood.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.buttonDeleteFood.BorderColor = System.Drawing.Color.Black;
            this.buttonDeleteFood.CheckedBaseColor = System.Drawing.Color.Gray;
            this.buttonDeleteFood.CheckedBorderColor = System.Drawing.Color.Black;
            this.buttonDeleteFood.CheckedForeColor = System.Drawing.Color.White;
            this.buttonDeleteFood.CheckedImage = global::Restaurante.Properties.Resources.lupa;
            this.buttonDeleteFood.CheckedLineColor = System.Drawing.Color.DimGray;
            this.buttonDeleteFood.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonDeleteFood.FocusedColor = System.Drawing.Color.Empty;
            this.buttonDeleteFood.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteFood.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteFood.Image = global::Restaurante.Properties.Resources.borrar;
            this.buttonDeleteFood.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonDeleteFood.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonDeleteFood.Location = new System.Drawing.Point(523, 164);
            this.buttonDeleteFood.Name = "buttonDeleteFood";
            this.buttonDeleteFood.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonDeleteFood.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonDeleteFood.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonDeleteFood.OnHoverImage = null;
            this.buttonDeleteFood.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonDeleteFood.OnPressedColor = System.Drawing.Color.Black;
            this.buttonDeleteFood.Size = new System.Drawing.Size(122, 32);
            this.buttonDeleteFood.TabIndex = 3;
            this.buttonDeleteFood.Text = "Borrar";
            this.buttonDeleteFood.Click += new System.EventHandler(this.buttonDeleteFood_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSearch.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnSearch.CheckedImage = global::Restaurante.Properties.Resources.lupa;
            this.btnSearch.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Restaurante.Properties.Resources.lupa;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.Location = new System.Drawing.Point(198, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(112, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(12, 258);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.Size = new System.Drawing.Size(633, 342);
            this.dtgvFood.TabIndex = 7;
            this.dtgvFood.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvFood_CellMouseClick);
            // 
            // ListFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 612);
            this.Controls.Add(this.dtgvFood);
            this.Controls.Add(this.cbbSelect);
            this.Controls.Add(this.buttonAddFood);
            this.Controls.Add(this.buttonUpdateFood);
            this.Controls.Add(this.buttonDeleteFood);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "ListFood";
            this.Text = "ListFood";
            this.Load += new System.EventHandler(this.ListFood_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLineTextBox txtPrice;
        private Guna.UI.WinForms.GunaLineTextBox txtFoodName;
        private Guna.UI.WinForms.GunaLineTextBox txtTypeName;
        private Guna.UI.WinForms.GunaLineTextBox txtTypeID;
        private Guna.UI.WinForms.GunaLineTextBox txtFoodID;
        private Guna.UI.WinForms.GunaAdvenceButton buttonDeleteFood;
        private Guna.UI.WinForms.GunaAdvenceButton buttonUpdateFood;
        private Guna.UI.WinForms.GunaAdvenceButton buttonAddFood;
        private Guna.UI.WinForms.GunaComboBox cbbSelect;
        private System.Windows.Forms.DataGridView dtgvFood;
    }
}