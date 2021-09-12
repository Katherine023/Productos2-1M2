namespace ProductosApp.Forms
{
    partial class FrmProductManage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlMeasureUnit = new System.Windows.Forms.Panel();
            this.cmbMeasureUnit = new System.Windows.Forms.ComboBox();
            this.pnlPriceRange = new System.Windows.Forms.Panel();
            this.nudToPrice = new System.Windows.Forms.NumericUpDown();
            this.nudFromPrice = new System.Windows.Forms.NumericUpDown();
            this.pnlCaducity = new System.Windows.Forms.Panel();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.rtbProductView = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.pnlMeasureUnit.SuspendLayout();
            this.pnlPriceRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).BeginInit();
            this.pnlCaducity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSalir);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 326);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(582, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(424, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(345, 2);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(266, 2);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 24);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // cmbFinder
            // 
            this.cmbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Items.AddRange(new object[] {
            "Id",
            "Unidad de Medida",
            "Rango de Precio",
            "Fecha de Vencimiento"});
            this.cmbFinder.Location = new System.Drawing.Point(9, 10);
            this.cmbFinder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(150, 21);
            this.cmbFinder.TabIndex = 1;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.txtId);
            this.pnlId.Location = new System.Drawing.Point(173, 10);
            this.pnlId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(257, 20);
            this.pnlId.TabIndex = 2;
            this.pnlId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(2, 0);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(254, 20);
            this.txtId.TabIndex = 3;
            // 
            // pnlMeasureUnit
            // 
            this.pnlMeasureUnit.Controls.Add(this.cmbMeasureUnit);
            this.pnlMeasureUnit.Location = new System.Drawing.Point(172, 10);
            this.pnlMeasureUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMeasureUnit.Name = "pnlMeasureUnit";
            this.pnlMeasureUnit.Size = new System.Drawing.Size(257, 21);
            this.pnlMeasureUnit.TabIndex = 3;
            this.pnlMeasureUnit.Visible = false;
            // 
            // cmbMeasureUnit
            // 
            this.cmbMeasureUnit.FormattingEnabled = true;
            this.cmbMeasureUnit.Location = new System.Drawing.Point(2, 0);
            this.cmbMeasureUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMeasureUnit.Name = "cmbMeasureUnit";
            this.cmbMeasureUnit.Size = new System.Drawing.Size(254, 21);
            this.cmbMeasureUnit.TabIndex = 4;
            // 
            // pnlPriceRange
            // 
            this.pnlPriceRange.Controls.Add(this.nudToPrice);
            this.pnlPriceRange.Controls.Add(this.nudFromPrice);
            this.pnlPriceRange.Location = new System.Drawing.Point(170, 10);
            this.pnlPriceRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPriceRange.Name = "pnlPriceRange";
            this.pnlPriceRange.Size = new System.Drawing.Size(257, 20);
            this.pnlPriceRange.TabIndex = 3;
            this.pnlPriceRange.Visible = false;
            // 
            // nudToPrice
            // 
            this.nudToPrice.Location = new System.Drawing.Point(128, 0);
            this.nudToPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudToPrice.Name = "nudToPrice";
            this.nudToPrice.Size = new System.Drawing.Size(122, 20);
            this.nudToPrice.TabIndex = 4;
            // 
            // nudFromPrice
            // 
            this.nudFromPrice.Location = new System.Drawing.Point(2, 0);
            this.nudFromPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudFromPrice.Name = "nudFromPrice";
            this.nudFromPrice.Size = new System.Drawing.Size(122, 20);
            this.nudFromPrice.TabIndex = 4;
            // 
            // pnlCaducity
            // 
            this.pnlCaducity.Controls.Add(this.dtpCaducity);
            this.pnlCaducity.Location = new System.Drawing.Point(170, 10);
            this.pnlCaducity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCaducity.Name = "pnlCaducity";
            this.pnlCaducity.Size = new System.Drawing.Size(257, 20);
            this.pnlCaducity.TabIndex = 4;
            this.pnlCaducity.Visible = false;
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Location = new System.Drawing.Point(2, 0);
            this.dtpCaducity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(235, 20);
            this.dtpCaducity.TabIndex = 5;
            // 
            // rtbProductView
            // 
            this.rtbProductView.Location = new System.Drawing.Point(6, 36);
            this.rtbProductView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbProductView.Name = "rtbProductView";
            this.rtbProductView.ReadOnly = true;
            this.rtbProductView.Size = new System.Drawing.Size(583, 288);
            this.rtbProductView.TabIndex = 5;
            this.rtbProductView.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor ";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(15, 80);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(100, 20);
            this.txtproducto.TabIndex = 9;
            // 
            // txtdetalle
            // 
            this.txtdetalle.Location = new System.Drawing.Point(200, 80);
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(207, 20);
            this.txtdetalle.TabIndex = 10;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(15, 133);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 11;
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Location = new System.Drawing.Point(200, 106);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.Size = new System.Drawing.Size(207, 143);
            this.dgvdetalle.TabIndex = 12;
            this.dgvdetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalle_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(504, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtdetalle);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbProductView);
            this.Controls.Add(this.pnlCaducity);
            this.Controls.Add(this.pnlMeasureUnit);
            this.Controls.Add(this.pnlPriceRange);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.cmbFinder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmProductManage";
            this.Text = "Gestion de productos";
            this.Load += new System.EventHandler(this.FrmProductManage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlMeasureUnit.ResumeLayout(false);
            this.pnlPriceRange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).EndInit();
            this.pnlCaducity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel pnlMeasureUnit;
        private System.Windows.Forms.ComboBox cmbMeasureUnit;
        private System.Windows.Forms.Panel pnlPriceRange;
        private System.Windows.Forms.NumericUpDown nudToPrice;
        private System.Windows.Forms.NumericUpDown nudFromPrice;
        private System.Windows.Forms.Panel pnlCaducity;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
        private System.Windows.Forms.RichTextBox rtbProductView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtdetalle;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.Button btnSalir;
    }
}