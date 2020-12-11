namespace OrigendeDatos
{
    partial class FormInventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pruebabd1DataSet = new OrigendeDatos.pruebabd1DataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new OrigendeDatos.pruebabd1DataSetTableAdapters.usuariosTableAdapter();
            this.pruebabd1DataSet1 = new OrigendeDatos.pruebabd1DataSet1();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new OrigendeDatos.pruebabd1DataSet1TableAdapters.inventarioTableAdapter();
            this.tableAdapterManager = new OrigendeDatos.pruebabd1DataSet1TableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebabd1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebabd1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombrepDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pruebabd1DataSet
            // 
            this.pruebabd1DataSet.DataSetName = "pruebabd1DataSet";
            this.pruebabd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.pruebabd1DataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // pruebabd1DataSet1
            // 
            this.pruebabd1DataSet1.DataSetName = "pruebabd1DataSet1";
            this.pruebabd1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "inventario";
            this.inventarioBindingSource.DataSource = this.pruebabd1DataSet1;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inventarioTableAdapter = this.inventarioTableAdapter;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OrigendeDatos.pruebabd1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombrepDataGridViewTextBoxColumn
            // 
            this.nombrepDataGridViewTextBoxColumn.DataPropertyName = "nombrep";
            this.nombrepDataGridViewTextBoxColumn.HeaderText = "nombrep";
            this.nombrepDataGridViewTextBoxColumn.Name = "nombrepDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 254);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebabd1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebabd1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private pruebabd1DataSet pruebabd1DataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private pruebabd1DataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private pruebabd1DataSet1 pruebabd1DataSet1;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private pruebabd1DataSet1TableAdapters.inventarioTableAdapter inventarioTableAdapter;
        private pruebabd1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
    }
}