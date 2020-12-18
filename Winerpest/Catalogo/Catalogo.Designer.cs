namespace Winerpest.Catalogo
{
    partial class Catalogo
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbRegistro = new System.Windows.Forms.RadioButton();
            this.gbxCampos = new System.Windows.Forms.GroupBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtClaveProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cveproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATALOGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet4 = new Winerpest.WinnerPetDataSet4();
            this.cATALOGOTableAdapter = new Winerpest.WinnerPetDataSet4TableAdapters.CATALOGOTableAdapter();
            this.winnerpetDataSetCatalogo = new Winerpest.winnerpetDataSetCatalogo();
            this.catalogoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catalogoTableAdapter1 = new Winerpest.winnerpetDataSetCatalogoTableAdapters.catalogoTableAdapter();
            this.gbxOpciones.SuspendLayout();
            this.gbxCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerpetDataSetCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(604, 557);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(114, 44);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Controls.Add(this.rbModificar);
            this.gbxOpciones.Controls.Add(this.rbEliminar);
            this.gbxOpciones.Controls.Add(this.rbRegistro);
            this.gbxOpciones.Location = new System.Drawing.Point(12, 12);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Size = new System.Drawing.Size(706, 100);
            this.gbxOpciones.TabIndex = 13;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Opciones de la base de datos";
            // 
            // rbModificar
            // 
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(467, 47);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(68, 17);
            this.rbModificar.TabIndex = 3;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.rbModificar_CheckedChanged);
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(219, 47);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(61, 17);
            this.rbEliminar.TabIndex = 2;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.rbEliminar_CheckedChanged);
            // 
            // rbRegistro
            // 
            this.rbRegistro.AutoSize = true;
            this.rbRegistro.Location = new System.Drawing.Point(21, 47);
            this.rbRegistro.Name = "rbRegistro";
            this.rbRegistro.Size = new System.Drawing.Size(67, 17);
            this.rbRegistro.TabIndex = 1;
            this.rbRegistro.TabStop = true;
            this.rbRegistro.Text = "Registrar";
            this.rbRegistro.UseVisualStyleBackColor = true;
            this.rbRegistro.CheckedChanged += new System.EventHandler(this.rbRegistro_CheckedChanged);
            // 
            // gbxCampos
            // 
            this.gbxCampos.Controls.Add(this.txtPrecioProducto);
            this.gbxCampos.Controls.Add(this.label3);
            this.gbxCampos.Controls.Add(this.label5);
            this.gbxCampos.Controls.Add(this.txtClasificacion);
            this.gbxCampos.Controls.Add(this.btnModificar);
            this.gbxCampos.Controls.Add(this.btnEliminar);
            this.gbxCampos.Controls.Add(this.txtClaveProducto);
            this.gbxCampos.Controls.Add(this.label1);
            this.gbxCampos.Controls.Add(this.btnAgregar);
            this.gbxCampos.Controls.Add(this.label2);
            this.gbxCampos.Controls.Add(this.txtNombreProducto);
            this.gbxCampos.Controls.Add(this.lblName);
            this.gbxCampos.Controls.Add(this.txtTipoProducto);
            this.gbxCampos.Location = new System.Drawing.Point(12, 126);
            this.gbxCampos.Name = "gbxCampos";
            this.gbxCampos.Size = new System.Drawing.Size(706, 319);
            this.gbxCampos.TabIndex = 14;
            this.gbxCampos.TabStop = false;
            this.gbxCampos.Text = "GPS";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(173, 120);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(163, 20);
            this.txtPrecioProducto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio del producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Clasificación";
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(173, 146);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(163, 20);
            this.txtClasificacion.TabIndex = 8;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(587, 243);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 41);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(587, 196);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 41);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtClaveProducto
            // 
            this.txtClaveProducto.Location = new System.Drawing.Point(173, 42);
            this.txtClaveProducto.Name = "txtClaveProducto";
            this.txtClaveProducto.Size = new System.Drawing.Size(163, 20);
            this.txtClaveProducto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clave del producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(587, 149);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 41);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(173, 67);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(163, 20);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tipo de producto";
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Location = new System.Drawing.Point(173, 94);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(163, 20);
            this.txtTipoProducto.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cveproductoDataGridViewTextBoxColumn,
            this.tipoproductoDataGridViewTextBoxColumn,
            this.nombreproductoDataGridViewTextBoxColumn,
            this.precioproductoDataGridViewTextBoxColumn,
            this.clasificacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catalogoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 451);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // cveproductoDataGridViewTextBoxColumn
            // 
            this.cveproductoDataGridViewTextBoxColumn.DataPropertyName = "cve_producto";
            this.cveproductoDataGridViewTextBoxColumn.HeaderText = "cve_producto";
            this.cveproductoDataGridViewTextBoxColumn.Name = "cveproductoDataGridViewTextBoxColumn";
            // 
            // tipoproductoDataGridViewTextBoxColumn
            // 
            this.tipoproductoDataGridViewTextBoxColumn.DataPropertyName = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.HeaderText = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.Name = "tipoproductoDataGridViewTextBoxColumn";
            // 
            // nombreproductoDataGridViewTextBoxColumn
            // 
            this.nombreproductoDataGridViewTextBoxColumn.DataPropertyName = "nombre_producto";
            this.nombreproductoDataGridViewTextBoxColumn.HeaderText = "nombre_producto";
            this.nombreproductoDataGridViewTextBoxColumn.Name = "nombreproductoDataGridViewTextBoxColumn";
            // 
            // precioproductoDataGridViewTextBoxColumn
            // 
            this.precioproductoDataGridViewTextBoxColumn.DataPropertyName = "precio_producto";
            this.precioproductoDataGridViewTextBoxColumn.HeaderText = "precio_producto";
            this.precioproductoDataGridViewTextBoxColumn.Name = "precioproductoDataGridViewTextBoxColumn";
            // 
            // clasificacionDataGridViewTextBoxColumn
            // 
            this.clasificacionDataGridViewTextBoxColumn.DataPropertyName = "clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.HeaderText = "clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.Name = "clasificacionDataGridViewTextBoxColumn";
            // 
            // cATALOGOBindingSource
            // 
            this.cATALOGOBindingSource.DataMember = "CATALOGO";
            this.cATALOGOBindingSource.DataSource = this.winnerPetDataSet4;
            // 
            // winnerPetDataSet4
            // 
            this.winnerPetDataSet4.DataSetName = "WinnerPetDataSet4";
            this.winnerPetDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATALOGOTableAdapter
            // 
            this.cATALOGOTableAdapter.ClearBeforeFill = true;
            // 
            // winnerpetDataSetCatalogo
            // 
            this.winnerpetDataSetCatalogo.DataSetName = "winnerpetDataSetCatalogo";
            this.winnerpetDataSetCatalogo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catalogoBindingSource1
            // 
            this.catalogoBindingSource1.DataMember = "catalogo";
            this.catalogoBindingSource1.DataSource = this.winnerpetDataSetCatalogo;
            // 
            // catalogoTableAdapter1
            // 
            this.catalogoTableAdapter1.ClearBeforeFill = true;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxCampos);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.gbxOpciones.ResumeLayout(false);
            this.gbxOpciones.PerformLayout();
            this.gbxCampos.ResumeLayout(false);
            this.gbxCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerpetDataSetCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.RadioButton rbRegistro;
        private System.Windows.Forms.GroupBox gbxCampos;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtClaveProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinnerPetDataSet4 winnerPetDataSet4;
        private System.Windows.Forms.BindingSource cATALOGOBindingSource;
        private WinnerPetDataSet4TableAdapters.CATALOGOTableAdapter cATALOGOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacionDataGridViewTextBoxColumn;
        private winnerpetDataSetCatalogo winnerpetDataSetCatalogo;
        private System.Windows.Forms.BindingSource catalogoBindingSource1;
        private winnerpetDataSetCatalogoTableAdapters.catalogoTableAdapter catalogoTableAdapter1;
    }
}