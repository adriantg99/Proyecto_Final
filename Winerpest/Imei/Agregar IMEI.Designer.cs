namespace Winerpest.Imei
{
    partial class Agregar_IMEI
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
            this.gbxCampos = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtImei = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbRegistro = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imeiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet3 = new Winerpest.WinnerPetDataSet3();
            this.gPSTableAdapter = new Winerpest.WinnerPetDataSet3TableAdapters.GPSTableAdapter();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbxCampos.SuspendLayout();
            this.gbxOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCampos
            // 
            this.gbxCampos.Controls.Add(this.btnModificar);
            this.gbxCampos.Controls.Add(this.btnEliminar);
            this.gbxCampos.Controls.Add(this.txtImei);
            this.gbxCampos.Controls.Add(this.label1);
            this.gbxCampos.Controls.Add(this.btnAgregar);
            this.gbxCampos.Controls.Add(this.label2);
            this.gbxCampos.Controls.Add(this.txtLongitud);
            this.gbxCampos.Controls.Add(this.lblName);
            this.gbxCampos.Controls.Add(this.txtLatitud);
            this.gbxCampos.Location = new System.Drawing.Point(22, 151);
            this.gbxCampos.Name = "gbxCampos";
            this.gbxCampos.Size = new System.Drawing.Size(706, 274);
            this.gbxCampos.TabIndex = 10;
            this.gbxCampos.TabStop = false;
            this.gbxCampos.Text = "GPS";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(578, 198);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 41);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(578, 151);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 41);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtImei
            // 
            this.txtImei.Location = new System.Drawing.Point(173, 84);
            this.txtImei.MaxLength = 16;
            this.txtImei.Name = "txtImei";
            this.txtImei.Size = new System.Drawing.Size(163, 20);
            this.txtImei.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IMEI:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(578, 104);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 41);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Longitud";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(173, 136);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(163, 20);
            this.txtLongitud.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Latitud";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(173, 110);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(163, 20);
            this.txtLatitud.TabIndex = 2;
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Controls.Add(this.rbModificar);
            this.gbxOpciones.Controls.Add(this.rbEliminar);
            this.gbxOpciones.Controls.Add(this.rbRegistro);
            this.gbxOpciones.Location = new System.Drawing.Point(22, 43);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Size = new System.Drawing.Size(706, 100);
            this.gbxOpciones.TabIndex = 10;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Opciones de la base de datos";
            // 
            // rbModificar
            // 
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(467, 47);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(68, 17);
            this.rbModificar.TabIndex = 2;
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
            this.rbEliminar.TabIndex = 1;
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
            this.rbRegistro.TabIndex = 0;
            this.rbRegistro.TabStop = true;
            this.rbRegistro.Text = "Registrar";
            this.rbRegistro.UseVisualStyleBackColor = true;
            this.rbRegistro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeiDataGridViewTextBoxColumn,
            this.latitudDataGridViewTextBoxColumn,
            this.longitudDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gPSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 431);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // imeiDataGridViewTextBoxColumn
            // 
            this.imeiDataGridViewTextBoxColumn.DataPropertyName = "imei";
            this.imeiDataGridViewTextBoxColumn.HeaderText = "imei";
            this.imeiDataGridViewTextBoxColumn.Name = "imeiDataGridViewTextBoxColumn";
            this.imeiDataGridViewTextBoxColumn.Width = 150;
            // 
            // latitudDataGridViewTextBoxColumn
            // 
            this.latitudDataGridViewTextBoxColumn.DataPropertyName = "latitud";
            this.latitudDataGridViewTextBoxColumn.HeaderText = "latitud";
            this.latitudDataGridViewTextBoxColumn.Name = "latitudDataGridViewTextBoxColumn";
            // 
            // longitudDataGridViewTextBoxColumn
            // 
            this.longitudDataGridViewTextBoxColumn.DataPropertyName = "longitud";
            this.longitudDataGridViewTextBoxColumn.HeaderText = "longitud";
            this.longitudDataGridViewTextBoxColumn.Name = "longitudDataGridViewTextBoxColumn";
            // 
            // gPSBindingSource
            // 
            this.gPSBindingSource.DataMember = "GPS";
            this.gPSBindingSource.DataSource = this.winnerPetDataSet3;
            // 
            // winnerPetDataSet3
            // 
            this.winnerPetDataSet3.DataSetName = "WinnerPetDataSet3";
            this.winnerPetDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gPSTableAdapter
            // 
            this.gPSTableAdapter.ClearBeforeFill = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(595, 457);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(114, 44);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 37);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 587);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 25);
            this.panel2.TabIndex = 13;
            // 
            // Agregar_IMEI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(734, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxCampos);
            this.Name = "Agregar_IMEI";
            this.Text = "Agregar_IMEI";
            this.Load += new System.EventHandler(this.Agregar_IMEI_Load);
            this.gbxCampos.ResumeLayout(false);
            this.gbxCampos.PerformLayout();
            this.gbxOpciones.ResumeLayout(false);
            this.gbxOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxCampos;
        private System.Windows.Forms.TextBox txtImei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.RadioButton rbRegistro;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinnerPetDataSet3 winnerPetDataSet3;
        private System.Windows.Forms.BindingSource gPSBindingSource;
        private WinnerPetDataSet3TableAdapters.GPSTableAdapter gPSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}