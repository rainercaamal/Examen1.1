using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class ListadeProductos : Form
    {
        public ListadeProductos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void ListadeProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            // Configurar el DataGridView para permitir la selección de filas
            // Suscribirse al evento CellEndEdit
            dataGridViewProductos.CellEndEdit += dataGridViewProductos_CellEndEdit;
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID y el nuevo título desde los controles del formulario
                if (int.TryParse(textID.Text, out int idProducto))
                {
                    string nuevoTitulo = txtTitulo.Text;

                    // Llamar al método para enviar la solicitud de actualización
                    ActualizarProductoEnServidor(idProducto, nuevoTitulo);
                }
                else
                {
                    MessageBox.Show("El ID del producto debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void CargarDatos()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "https://dummyjson.com/products";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Leer y procesar el contenido JSON
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserializar el JSON a una lista de objetos Producto
                        var resultado = JsonConvert.DeserializeObject<ProductoResult>(json);

                        // Asignar la lista de productos al DataGridView
                        dataGridViewProductos.DataSource = resultado.Products;
                    }
                    else
                    {
                        MessageBox.Show($"Error al obtener los datos. Estado de la respuesta: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "https://dummyjson.com/products/add";

                    // Crear un objeto NuevoProducto con los datos del formulario
                    NuevoProducto nuevoProducto = new NuevoProducto
                    {
                        // Intentar convertir el valor del cuadro de texto a int
                        Id = int.TryParse(textID.Text, out int id) ? id : 0,
                        Title = txtTitulo.Text,
                        // Agrega otras propiedades según la estructura del JSON
                    };

                    // Serializar el objeto NuevoProducto a JSON
                    string jsonBody = JsonConvert.SerializeObject(nuevoProducto);

                    // Configurar la solicitud POST
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    // Marcar el método como asincrónico y utilizar 'await'
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // La respuesta contiene los datos del nuevo producto
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error al agregar el producto. Estado de la respuesta: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class ProductoResult
        {
            public Producto[] Products { get; set; }
            public int Total { get; set; }
            public int Skip { get; set; }
            public int Limit { get; set; }
        }

        private void TxtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void dataGridViewProductos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                // Obtener la información de la celda editada
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                // Verificar si la edición se realizó en la columna deseada (por ejemplo, Title)
                if (columnIndex == dataGridViewProductos.Columns["Title"].Index)
                {
                    // Obtener el nuevo valor de la celda (verificar si la celda no es nula)
                    string nuevoTitulo = dataGridViewProductos.Rows[rowIndex].Cells[columnIndex].Value?.ToString();

                    // Verificar si el nuevo valor no es nulo o vacío
                    if (!string.IsNullOrEmpty(nuevoTitulo))
                    {
                        // Obtener el ID de la fila editada
                        if (dataGridViewProductos.Rows[rowIndex].Cells["Id"].Value is int idProducto)
                        {
                            // Llamar al método para enviar la solicitud de actualización
                            ActualizarProductoEnServidor(idProducto, nuevoTitulo);
                        }
                        else
                        {
                            MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nuevo título no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ActualizarProductoEnServidor(int idProducto, string nuevoTitulo)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = $"https://dummyjson.com/products/{idProducto}";

                    // Crear un objeto para la actualización del título
                    var actualizacionTitulo = new { title = nuevoTitulo };

                    // Serializar el objeto a JSON
                    string jsonBody = JsonConvert.SerializeObject(actualizacionTitulo);

                    // Configurar la solicitud PUT
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // La respuesta contiene los datos actualizados del producto
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error al actualizar el producto. Estado de la respuesta: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



