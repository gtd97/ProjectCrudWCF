namespace ClienteWcfData
{
    partial class FormGridAlumno
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
            this.dgv_grid = new System.Windows.Forms.DataGridView();
            this.bt_añadir = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.tb_guid = new System.Windows.Forms.TextBox();
            this.bt_tcp = new System.Windows.Forms.Button();
            this.bt_http = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_grid
            // 
            this.dgv_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grid.Location = new System.Drawing.Point(12, 106);
            this.dgv_grid.Name = "dgv_grid";
            this.dgv_grid.Size = new System.Drawing.Size(698, 198);
            this.dgv_grid.TabIndex = 0;
            this.dgv_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_grid_click);
            // 
            // bt_añadir
            // 
            this.bt_añadir.Location = new System.Drawing.Point(54, 329);
            this.bt_añadir.Name = "bt_añadir";
            this.bt_añadir.Size = new System.Drawing.Size(96, 36);
            this.bt_añadir.TabIndex = 1;
            this.bt_añadir.Text = "Añadir";
            this.bt_añadir.UseVisualStyleBackColor = true;
            this.bt_añadir.Click += new System.EventHandler(this.click_Añadir);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(614, 64);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(96, 36);
            this.bt_buscar.TabIndex = 1;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.click_Buscar);
            // 
            // tb_guid
            // 
            this.tb_guid.Location = new System.Drawing.Point(361, 64);
            this.tb_guid.Multiline = true;
            this.tb_guid.Name = "tb_guid";
            this.tb_guid.Size = new System.Drawing.Size(247, 36);
            this.tb_guid.TabIndex = 2;
            // 
            // bt_tcp
            // 
            this.bt_tcp.Location = new System.Drawing.Point(388, 329);
            this.bt_tcp.Name = "bt_tcp";
            this.bt_tcp.Size = new System.Drawing.Size(98, 36);
            this.bt_tcp.TabIndex = 1;
            this.bt_tcp.Text = "Tcp";
            this.bt_tcp.UseVisualStyleBackColor = true;
            this.bt_tcp.Click += new System.EventHandler(this.click_Tcp);
            // 
            // bt_http
            // 
            this.bt_http.Location = new System.Drawing.Point(254, 329);
            this.bt_http.Name = "bt_http";
            this.bt_http.Size = new System.Drawing.Size(98, 36);
            this.bt_http.TabIndex = 1;
            this.bt_http.Text = "Http";
            this.bt_http.UseVisualStyleBackColor = true;
            this.bt_http.Click += new System.EventHandler(this.click_http);
            // 
            // FormGridAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 377);
            this.Controls.Add(this.tb_guid);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.bt_añadir);
            this.Controls.Add(this.bt_http);
            this.Controls.Add(this.bt_tcp);
            this.Controls.Add(this.dgv_grid);
            this.Name = "FormGridAlumno";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_grid;
        private System.Windows.Forms.Button bt_añadir;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox tb_guid;
        private System.Windows.Forms.Button bt_tcp;
        private System.Windows.Forms.Button bt_http;
    }
}

