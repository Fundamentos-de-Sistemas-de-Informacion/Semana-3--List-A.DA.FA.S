namespace Semana_3__List_Add_DeleteAll_FindAll_Sort
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxCodigo = new TextBox();
            textBoxNombre = new TextBox();
            label2 = new Label();
            textBoxPrecio = new TextBox();
            label3 = new Label();
            numericUpDownStock = new NumericUpDown();
            label4 = new Label();
            buttonRegistrar = new Button();
            buttonEliminar = new Button();
            buttonEliminarTodo = new Button();
            buttonOrdenar = new Button();
            textBoxBuscar = new TextBox();
            label5 = new Label();
            buttonBuscar = new Button();
            buttonLimpiar = new Button();
            listViewElectrodomesticos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label6 = new Label();
            label7 = new Label();
            labelTotalRegistros = new Label();
            labelTotalStock = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 0;
            label1.Text = "CÓDIGO :";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(115, 18);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(144, 23);
            textBoxCodigo.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(404, 19);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(338, 23);
            textBoxNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(329, 21);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE :";
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(404, 53);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(107, 23);
            textBoxPrecio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(340, 55);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 4;
            label3.Text = "PRECIO :";
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(115, 53);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(87, 23);
            numericUpDownStock.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 55);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 7;
            label4.Text = "STOCK :";
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.Gainsboro;
            buttonRegistrar.FlatStyle = FlatStyle.Flat;
            buttonRegistrar.Location = new Point(80, 100);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(136, 28);
            buttonRegistrar.TabIndex = 8;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Gainsboro;
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Location = new Point(235, 100);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(136, 28);
            buttonEliminar.TabIndex = 9;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonEliminarTodo
            // 
            buttonEliminarTodo.BackColor = Color.Gainsboro;
            buttonEliminarTodo.FlatStyle = FlatStyle.Flat;
            buttonEliminarTodo.Location = new Point(388, 100);
            buttonEliminarTodo.Name = "buttonEliminarTodo";
            buttonEliminarTodo.Size = new Size(136, 28);
            buttonEliminarTodo.TabIndex = 10;
            buttonEliminarTodo.Text = "Eliminar Todo";
            buttonEliminarTodo.UseVisualStyleBackColor = false;
            buttonEliminarTodo.Click += buttonEliminarTodo_Click;
            // 
            // buttonOrdenar
            // 
            buttonOrdenar.BackColor = Color.Gainsboro;
            buttonOrdenar.FlatStyle = FlatStyle.Flat;
            buttonOrdenar.Location = new Point(544, 100);
            buttonOrdenar.Name = "buttonOrdenar";
            buttonOrdenar.Size = new Size(136, 28);
            buttonOrdenar.TabIndex = 11;
            buttonOrdenar.Text = "Ordenar";
            buttonOrdenar.UseVisualStyleBackColor = false;
            buttonOrdenar.Click += buttonOrdenar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(206, 153);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(338, 23);
            textBoxBuscar.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(50, 156);
            label5.Name = "label5";
            label5.Size = new Size(149, 17);
            label5.TabIndex = 12;
            label5.Text = "BUSCAR POR NOMBRE :";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(564, 152);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 14;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(645, 152);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(75, 23);
            buttonLimpiar.TabIndex = 15;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // listViewElectrodomesticos
            // 
            listViewElectrodomesticos.BackColor = Color.WhiteSmoke;
            listViewElectrodomesticos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewElectrodomesticos.Location = new Point(25, 203);
            listViewElectrodomesticos.Name = "listViewElectrodomesticos";
            listViewElectrodomesticos.Size = new Size(737, 213);
            listViewElectrodomesticos.TabIndex = 16;
            listViewElectrodomesticos.UseCompatibleStateImageBehavior = false;
            listViewElectrodomesticos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Stock";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Precio";
            columnHeader4.Width = 100;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(566, 429);
            label6.Name = "label6";
            label6.Size = new Size(140, 17);
            label6.TabIndex = 17;
            label6.Text = "TOTAL DE REGISTROS :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(591, 455);
            label7.Name = "label7";
            label7.Size = new Size(114, 17);
            label7.TabIndex = 18;
            label7.Text = "TOTAL EN STOCK :";
            // 
            // labelTotalRegistros
            // 
            labelTotalRegistros.AutoSize = true;
            labelTotalRegistros.Location = new Point(714, 431);
            labelTotalRegistros.Name = "labelTotalRegistros";
            labelTotalRegistros.Size = new Size(13, 15);
            labelTotalRegistros.TabIndex = 19;
            labelTotalRegistros.Text = "0";
            // 
            // labelTotalStock
            // 
            labelTotalStock.AutoSize = true;
            labelTotalStock.Location = new Point(714, 457);
            labelTotalStock.Name = "labelTotalStock";
            labelTotalStock.Size = new Size(13, 15);
            labelTotalStock.TabIndex = 20;
            labelTotalStock.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 493);
            Controls.Add(labelTotalStock);
            Controls.Add(labelTotalRegistros);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(listViewElectrodomesticos);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(label5);
            Controls.Add(buttonOrdenar);
            Controls.Add(buttonEliminarTodo);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonRegistrar);
            Controls.Add(label4);
            Controls.Add(numericUpDownStock);
            Controls.Add(textBoxPrecio);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(textBoxCodigo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCodigo;
        private TextBox textBoxNombre;
        private Label label2;
        private TextBox textBoxPrecio;
        private Label label3;
        private NumericUpDown numericUpDownStock;
        private Label label4;
        private Button buttonRegistrar;
        private Button buttonEliminar;
        private Button buttonEliminarTodo;
        private Button buttonOrdenar;
        private TextBox textBoxBuscar;
        private Label label5;
        private Button buttonBuscar;
        private Button buttonLimpiar;
        private ListView listViewElectrodomesticos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label6;
        private Label label7;
        private Label labelTotalRegistros;
        private Label labelTotalStock;
    }
}