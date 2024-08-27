namespace CapaVista
{
    partial class RegistrarProducto
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label categoriaLabel;
            this.parcial01DataSet = new CapaVista.Parcial01DataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new CapaVista.Parcial01DataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new CapaVista.Parcial01DataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parcial01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // parcial01DataSet
            // 
            this.parcial01DataSet.DataSetName = "Parcial01DataSet";
            this.parcial01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.parcial01DataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.UpdateOrder = CapaVista.Parcial01DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(221, 129);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(293, 126);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(232, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(221, 155);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(293, 152);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(232, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(221, 181);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(293, 178);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(232, 20);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(221, 207);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 7;
            precioLabel.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(293, 204);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(232, 20);
            this.precioTextBox.TabIndex = 8;
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(221, 233);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(38, 13);
            stockLabel.TabIndex = 9;
            stockLabel.Text = "Stock:";
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(293, 230);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(232, 20);
            this.stockTextBox.TabIndex = 10;
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(221, 259);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 11;
            marcaLabel.Text = "Marca:";
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(293, 256);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(232, 20);
            this.marcaTextBox.TabIndex = 12;
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(221, 285);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 13;
            categoriaLabel.Text = "Categoria:";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(293, 282);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(232, 20);
            this.categoriaTextBox.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(258, 335);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(408, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Agregar Registro";
            // 
            // RegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.Name = "RegistrarProducto";
            this.Text = "RegistrarProducto";
            this.Load += new System.EventHandler(this.RegistrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parcial01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Parcial01DataSet parcial01DataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private Parcial01DataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private Parcial01DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}