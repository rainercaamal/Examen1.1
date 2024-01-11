namespace Examen
{
    partial class ListadeProductos
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
            dataGridViewProductos = new DataGridView();
            Titulo = new Label();
            txtTitulo = new TextBox();
            BtnAceptar = new Button();
            TxtCancelar = new Button();
            textID = new TextBox();
            label1 = new Label();
            BtnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(2, 196);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowTemplate.Height = 25;
            dataGridViewProductos.Size = new Size(786, 242);
            dataGridViewProductos.TabIndex = 0;
            dataGridViewProductos.CellEndEdit += dataGridViewProductos_CellEndEdit;
            dataGridViewProductos.SelectionChanged += dataGridViewProductos_SelectionChanged;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(142, 52);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(37, 15);
            Titulo.TabIndex = 5;
            Titulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(225, 52);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(257, 23);
            txtTitulo.TabIndex = 4;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(142, 115);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(118, 44);
            BtnAceptar.TabIndex = 3;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // TxtCancelar
            // 
            TxtCancelar.Location = new Point(344, 115);
            TxtCancelar.Name = "TxtCancelar";
            TxtCancelar.Size = new Size(118, 44);
            TxtCancelar.TabIndex = 6;
            TxtCancelar.Text = "Cancelar";
            TxtCancelar.UseVisualStyleBackColor = true;
            TxtCancelar.Click += TxtCancelar_Click;
            // 
            // textID
            // 
            textID.Location = new Point(225, 10);
            textID.Name = "textID";
            textID.Size = new Size(257, 23);
            textID.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 13);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 8;
            label1.Text = "Id";
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(544, 115);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(112, 53);
            BtnActualizar.TabIndex = 9;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // ListadeProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnActualizar);
            Controls.Add(label1);
            Controls.Add(textID);
            Controls.Add(TxtCancelar);
            Controls.Add(Titulo);
            Controls.Add(txtTitulo);
            Controls.Add(BtnAceptar);
            Controls.Add(dataGridViewProductos);
            Name = "ListadeProductos";
            Text = "ListadeProductos";
            Load += ListadeProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProductos;
        private Label Titulo;
        private TextBox txtTitulo;
        private Button BtnAceptar;
        private Button TxtCancelar;
        private TextBox textID;
        private Label label1;
        private Button BtnActualizar;
    }
}