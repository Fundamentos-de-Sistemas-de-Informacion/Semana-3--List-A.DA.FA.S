namespace Semana_3__List_Add_DeleteAll_FindAll_Sort
{
    public partial class Form1 : Form
    {
        List<Electrodomestico> electrodomesticos = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void mostrar(List<Electrodomestico> lista)
        {
            listViewElectrodomesticos.Items.Clear();
            int stockTotal = 0;

            foreach (Electrodomestico elec in lista)
            {
                ListViewItem fila = new(elec.Codigo);
                fila.SubItems.Add(elec.Nombre);
                fila.SubItems.Add(elec.Stock.ToString());
                fila.SubItems.Add(elec.Precio.ToString());
                listViewElectrodomesticos.Items.Add(fila);
                stockTotal += elec.Stock;
            }

            //Actualizar los totales
            labelTotalRegistros.Text = lista.Count.ToString();
            labelTotalStock.Text = stockTotal.ToString();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            //Validación
            if (textBoxCodigo.Text == "" || textBoxNombre.Text == "" || textBoxPrecio.Text == "" || numericUpDownStock.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            //Verificación de código repetido
            bool exists =
                electrodomesticos.Exists(elemento => elemento.Codigo.Equals(textBoxCodigo.Text));
            if (exists)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            //Crear el objeto
            Electrodomestico elec = new()
            {
                Codigo = textBoxCodigo.Text,
                Nombre = textBoxNombre.Text,
                Stock = (int)numericUpDownStock.Value,
                Precio = double.Parse(textBoxPrecio.Text)
            };

            //Agregarlo a la lista
            electrodomesticos.Add(elec);

            //Mostrar en el ListView
            mostrar(electrodomesticos);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Validación
            if (listViewElectrodomesticos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione electrodoméstico");
                return;
            }

            //Obtener el código
            String codigo = listViewElectrodomesticos.SelectedItems[0].Text;

            //Eliminar el que tiene ese código
            electrodomesticos.RemoveAll(elemento => elemento.Codigo.Equals(codigo));

            //mostrar en el ListView
            mostrar(electrodomesticos);
        }

        private void buttonEliminarTodo_Click(object sender, EventArgs e)
        {
            electrodomesticos.Clear();

            //Mostrar en el ListView
            mostrar(electrodomesticos);
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            electrodomesticos.Sort((e1, e2) =>
            {
                if (e1.Precio < e2.Precio) return 1;
                else return -1;
            });

            //Mostrar en el ListView
            mostrar(electrodomesticos);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            //Mostrar en el ListView
            mostrar(electrodomesticos);

            //Adicional
            if (textBoxBuscar.Text != "")
            {
                textBoxBuscar.Clear();
                return;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Validación
            if (textBoxBuscar.Text == "")
            {
                MessageBox.Show("Ingresa el nombre");
                return;
            }

            //Buscar el electrodomestico
            List<Electrodomestico> elecTmp =
                electrodomesticos.FindAll(elemento => elemento.Nombre.Contains(textBoxBuscar.Text));

            //Mostrar en el ListView
            mostrar(elecTmp);
        }
    }
}