namespace Netters
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
            this.btnExportxml = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportxml
            // 
            this.btnExportxml.Location = new System.Drawing.Point(1144, 629);
            this.btnExportxml.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExportxml.Name = "btnExportxml";
            this.btnExportxml.Size = new System.Drawing.Size(328, 156);
            this.btnExportxml.TabIndex = 0;
            this.btnExportxml.Text = "Exportar XML";
            this.btnExportxml.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(680, 629);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(328, 156);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar Datos";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(216, 629);
            this.btnTest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(325, 156);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test BD";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 500);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportxml);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportxml;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

