namespace Winerpest.Cliente
{
    partial class EliminarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbxID = new System.Windows.Forms.GroupBox();
            this.btnEliminarId = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.gbxNombre = new System.Windows.Forms.GroupBox();
            this.btnEliminarName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.gbxTelefono = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarTel = new System.Windows.Forms.Button();
            this.txtboxTelefon = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet2 = new Winerpest.WinnerPetDataSet2();
            this.cLIENTETableAdapter = new Winerpest.WinnerPetDataSet2TableAdapters.CLIENTETableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.winnerpetDataSetClienteTAP = new Winerpest.winnerpetDataSetClienteTAP();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter1 = new Winerpest.winnerpetDataSetClienteTAPTableAdapters.clienteTableAdapter();
            this.winnerpetDataSetCliente = new Winerpest.winnerpetDataSetCliente();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter2 = new Winerpest.winnerpetDataSetClienteTableAdapters.clienteTableAdapter();
            this.cveclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gbxID.SuspendLayout();
            this.gbxNombre.SuspendLayout();
            this.gbxTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerpetDataSetClienteTAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerpetDataSetCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(617, 505);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(146, 54);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(1, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de medios";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(517, 38);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Por telefono";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(276, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Por Nombre";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(43, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por ID";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbxID
            // 
            this.gbxID.Controls.Add(this.btnEliminarId);
            this.gbxID.Controls.Add(this.lblId);
            this.gbxID.Controls.Add(this.txtboxId);
            this.gbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxID.Location = new System.Drawing.Point(12, 193);
            this.gbxID.Name = "gbxID";
            this.gbxID.Size = new System.Drawing.Size(224, 154);
            this.gbxID.TabIndex = 3;
            this.gbxID.TabStop = false;
            this.gbxID.Text = "Por Id";
            // 
            // btnEliminarId
            // 
            this.btnEliminarId.Location = new System.Drawing.Point(99, 94);
            this.btnEliminarId.Name = "btnEliminarId";
            this.btnEliminarId.Size = new System.Drawing.Size(119, 47);
            this.btnEliminarId.TabIndex = 6;
            this.btnEliminarId.Text = "Eliminar Registro por ID";
            this.btnEliminarId.UseVisualStyleBackColor = true;
            this.btnEliminarId.Click += new System.EventHandler(this.btnEliminarId_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(91, 16);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Introduce el id";
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(113, 42);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(100, 22);
            this.txtboxId.TabIndex = 0;
            // 
            // gbxNombre
            // 
            this.gbxNombre.Controls.Add(this.btnEliminarName);
            this.gbxNombre.Controls.Add(this.label1);
            this.gbxNombre.Controls.Add(this.txtboxName);
            this.gbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNombre.Location = new System.Drawing.Point(253, 193);
            this.gbxNombre.Name = "gbxNombre";
            this.gbxNombre.Size = new System.Drawing.Size(251, 154);
            this.gbxNombre.TabIndex = 0;
            this.gbxNombre.TabStop = false;
            this.gbxNombre.Text = "Por nombre";
            // 
            // btnEliminarName
            // 
            this.btnEliminarName.Location = new System.Drawing.Point(110, 94);
            this.btnEliminarName.Name = "btnEliminarName";
            this.btnEliminarName.Size = new System.Drawing.Size(122, 47);
            this.btnEliminarName.TabIndex = 6;
            this.btnEliminarName.Text = "Eliminar Registro por nombre";
            this.btnEliminarName.UseVisualStyleBackColor = true;
            this.btnEliminarName.Click += new System.EventHandler(this.btnEliminarName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduce el nombre";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(129, 38);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(100, 22);
            this.txtboxName.TabIndex = 2;
            this.txtboxName.TextChanged += new System.EventHandler(this.txtboxName_TextChanged);
            // 
            // gbxTelefono
            // 
            this.gbxTelefono.Controls.Add(this.label2);
            this.gbxTelefono.Controls.Add(this.btnEliminarTel);
            this.gbxTelefono.Controls.Add(this.txtboxTelefon);
            this.gbxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTelefono.Location = new System.Drawing.Point(529, 193);
            this.gbxTelefono.Name = "gbxTelefono";
            this.gbxTelefono.Size = new System.Drawing.Size(262, 154);
            this.gbxTelefono.TabIndex = 0;
            this.gbxTelefono.TabStop = false;
            this.gbxTelefono.Text = "Por telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introduce el telefono";
            // 
            // btnEliminarTel
            // 
            this.btnEliminarTel.Location = new System.Drawing.Point(143, 94);
            this.btnEliminarTel.Name = "btnEliminarTel";
            this.btnEliminarTel.Size = new System.Drawing.Size(119, 47);
            this.btnEliminarTel.TabIndex = 4;
            this.btnEliminarTel.Text = "Eliminar Registro por telefono";
            this.btnEliminarTel.UseVisualStyleBackColor = true;
            this.btnEliminarTel.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtboxTelefon
            // 
            this.txtboxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTelefon.Location = new System.Drawing.Point(140, 37);
            this.txtboxTelefon.MaxLength = 10;
            this.txtboxTelefon.Name = "txtboxTelefon";
            this.txtboxTelefon.Size = new System.Drawing.Size(116, 21);
            this.txtboxTelefon.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cveclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.telefonoclienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.winnerPetDataSet2;
            // 
            // winnerPetDataSet2
            // 
            this.winnerPetDataSet2.DataSetName = "WinnerPetDataSet2";
            this.winnerPetDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 42);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 37);
            this.panel2.TabIndex = 7;
            // 
            // winnerpetDataSetClienteTAP
            // 
            this.winnerpetDataSetClienteTAP.DataSetName = "winnerpetDataSetClienteTAP";
            this.winnerpetDataSetClienteTAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "cliente";
            this.clienteBindingSource1.DataSource = this.winnerpetDataSetClienteTAP;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // winnerpetDataSetCliente
            // 
            this.winnerpetDataSetCliente.DataSetName = "winnerpetDataSetCliente";
            this.winnerpetDataSetCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "cliente";
            this.clienteBindingSource2.DataSource = this.winnerpetDataSetCliente;
            // 
            // clienteTableAdapter2
            // 
            this.clienteTableAdapter2.ClearBeforeFill = true;
            // 
            // cveclienteDataGridViewTextBoxColumn
            // 
            this.cveclienteDataGridViewTextBoxColumn.DataPropertyName = "cve_cliente";
            this.cveclienteDataGridViewTextBoxColumn.HeaderText = "cve_cliente";
            this.cveclienteDataGridViewTextBoxColumn.Name = "cveclienteDataGridViewTextBoxColumn";
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            // 
            // telefonoclienteDataGridViewTextBoxColumn
            // 
            this.telefonoclienteDataGridViewTextBoxColumn.DataPropertyName = "telefono_cliente";
            this.telefonoclienteDataGridViewTextBoxColumn.HeaderText = "telefono_cliente";
            this.telefonoclienteDataGridViewTextBoxColumn.Name = "telefonoclienteDataGridViewTextBoxColumn";
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(856, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxTelefono);
            this.Controls.Add(this.gbxNombre);
            this.Controls.Add(this.gbxID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresar);
            this.Name = "EliminarCliente";
            this.Text = "EliminarCliente";
            this.Load += new System.EventHandler(this.EliminarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxID.ResumeLayout(false);
            this.gbxID.PerformLayout();
            this.gbxNombre.ResumeLayout(false);
            this.gbxNombre.PerformLayout();
            this.gbxTelefono.ResumeLayout(false);
            this.gbxTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerpetDataSetClienteTAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerpetDataSetCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gbxID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtboxId;
        private System.Windows.Forms.GroupBox gbxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.GroupBox gbxTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxTelefon;
        private System.Windows.Forms.Button btnEliminarTel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinnerPetDataSet2 winnerPetDataSet2;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private WinnerPetDataSet2TableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.Button btnEliminarId;
        private System.Windows.Forms.Button btnEliminarName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private winnerpetDataSetClienteTAP winnerpetDataSetClienteTAP;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private winnerpetDataSetClienteTAPTableAdapters.clienteTableAdapter clienteTableAdapter1;
        private winnerpetDataSetCliente winnerpetDataSetCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private winnerpetDataSetClienteTableAdapters.clienteTableAdapter clienteTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoclienteDataGridViewTextBoxColumn;
    }
}