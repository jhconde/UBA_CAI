using NLayer.Entidades;
using NLayer.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayer.Formularios
{
    public partial class ClienteInsert : Form
    {
        private ClienteServicio _clienteService;
        public ClienteInsert()
        {
            InitializeComponent();
            this._clienteService = new ClienteServicio();
            this.dateTimePicker1.MaxDate = DateTime.Now;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = this.textBox1.Text;
            string apellido = this.textBox2.Text;
            string direccion = this.textBox3.Text;
            DateTime fechaNacimiento = this.dateTimePicker1.Value;
            string email = this.textBox4.Text;
            string telefono = this.textBox5.Text;

            // validar
            if (nombre.Length == 0 || apellido.Length == 0 || direccion.Length == 0)
            {
                MessageBox.Show("Nombre, apellido y direccion son campos requeridos");
                return;
            }

            if (telefono.Length > 0)
            {
                bool telefonoValido = validarNumero(telefono);
                if (!telefonoValido)
                {
                    MessageBox.Show("Telefono solo admite numeros");
                    return;
                }
            }

            Cliente cliente = new Cliente();
            cliente.Nombre = nombre;
            cliente.Ape = apellido;
            cliente.Direccion = direccion;
            cliente.FechaNacimiento = fechaNacimiento;
            cliente.Email = email;
            cliente.Telefono = telefono;

            try
            {
                int id = _clienteService.InsertarCliente(cliente);
                MessageBox.Show("Resultado exitoso, el id del cliente insertado es " + id);
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
            
        }

        private bool validarNumero(string valor)
        {
            return int.TryParse(valor, out _);
        }

        private void clearForm()
        {
            this.textBox1.Text = ""; // nombre
            this.textBox2.Text = ""; // apellido
            this.textBox3.Text = ""; // direccion
            this.textBox4.Text = ""; // email
            this.textBox5.Text = ""; // telefono
        }

    }
}
