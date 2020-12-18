namespace Winerpest
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Cliente = new System.Windows.Forms.Button();
            this.btn_Mascota = new System.Windows.Forms.Button();
            this.btn_Catalogo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnAltas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Btn_Cliente
            // 
            this.Btn_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cliente.Location = new System.Drawing.Point(12, 76);
            this.Btn_Cliente.Name = "Btn_Cliente";
            this.Btn_Cliente.Size = new System.Drawing.Size(275, 75);
            this.Btn_Cliente.TabIndex = 0;
            this.Btn_Cliente.Text = "Cliente";
            this.Btn_Cliente.UseVisualStyleBackColor = true;
            this.Btn_Cliente.Click += new System.EventHandler(this.Btn_Cliente_Click);
            // 
            // btn_Mascota
            // 
            this.btn_Mascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mascota.Location = new System.Drawing.Point(12, 198);
            this.btn_Mascota.Name = "btn_Mascota";
            this.btn_Mascota.Size = new System.Drawing.Size(275, 73);
            this.btn_Mascota.TabIndex = 1;
            this.btn_Mascota.Text = "GPS";
            this.btn_Mascota.UseVisualStyleBackColor = true;
            this.btn_Mascota.Click += new System.EventHandler(this.btn_Mascota_Click);
            // 
            // btn_Catalogo
            // 
            this.btn_Catalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Catalogo.Location = new System.Drawing.Point(292, 76);
            this.btn_Catalogo.Name = "btn_Catalogo";
            this.btn_Catalogo.Size = new System.Drawing.Size(275, 75);
            this.btn_Catalogo.TabIndex = 2;
            this.btn_Catalogo.Text = "Catalogo";
            this.btn_Catalogo.UseVisualStyleBackColor = true;
            this.btn_Catalogo.Click += new System.EventHandler(this.btn_Catalogo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(229, 419);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(124, 43);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(293, 198);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(275, 73);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.Location = new System.Drawing.Point(12, 322);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(275, 72);
            this.btnFacturas.TabIndex = 5;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnAltas
            // 
            this.btnAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltas.Location = new System.Drawing.Point(293, 322);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(275, 72);
            this.btnAltas.TabIndex = 6;
            this.btnAltas.Text = "Altas";
            this.btnAltas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 41);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 40);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(579, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAltas);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btn_Catalogo);
            this.Controls.Add(this.btn_Mascota);
            this.Controls.Add(this.Btn_Cliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cliente;
        private System.Windows.Forms.Button btn_Mascota;
        private System.Windows.Forms.Button btn_Catalogo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

