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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label label2;
            this.parcial01DataSet = new CapaVista.Parcial01DataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new CapaVista.Parcial01DataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new CapaVista.Parcial01DataSetTableAdapters.TableAdapterManager();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parcial01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(147, 140);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(59, 16);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(147, 166);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(82, 16);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(147, 192);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(49, 16);
            precioLabel.TabIndex = 7;
            precioLabel.Text = "Precio:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.Location = new System.Drawing.Point(147, 218);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(44, 16);
            stockLabel.TabIndex = 9;
            stockLabel.Text = "Stock:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.Location = new System.Drawing.Point(147, 244);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(48, 16);
            marcaLabel.TabIndex = 11;
            marcaLabel.Text = "Marca:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaLabel.Location = new System.Drawing.Point(147, 270);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(69, 16);
            categoriaLabel.TabIndex = 13;
            categoriaLabel.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(147, 114);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(23, 16);
            label2.TabIndex = 18;
            label2.Text = "ID:";
            label2.Visible = false;
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
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(235, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(235, 162);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(232, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Precio", true));
            this.txtPrecio.Location = new System.Drawing.Point(235, 188);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(232, 20);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Stock", true));
            this.txtStock.Location = new System.Drawing.Point(235, 214);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(232, 20);
            this.txtStock.TabIndex = 10;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Marca", true));
            this.txtMarca.Location = new System.Drawing.Point(235, 240);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(232, 20);
            this.txtMarca.TabIndex = 12;
            // 
            // txtCategoria
            // 
            this.txtCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Categoria", true));
            this.txtCategoria.Location = new System.Drawing.Point(235, 266);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(232, 20);
            this.txtCategoria.TabIndex = 14;
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(150, 328);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(372, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Id", true));
            this.txtId.Location = new System.Drawing.Point(235, 110);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(232, 20);
            this.txtId.TabIndex = 19;
            this.txtId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Agregar Producto";
            // 
            // RegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.txtCategoria);
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
    }
}