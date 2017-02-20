using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace AgendaClientes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            limpiarLabel();

            List<Cliente> clientes = new List<Cliente>();

            listBoxEmpresas.DisplayMember = "name";

            listBoxEmpresas.Items.Add(new Cliente("A87745124", "Allstar Asociados", "986747125", "Manuel Castro", "metales@pedrin.info"));
            listBoxEmpresas.Items.Add(new Cliente("B23467889", "Relampago Juntitos", "986744251", "Sarah Johnson", "sarah@A.info"));
            listBoxEmpresas.Items.Add(new Cliente("A12346864", "Barrio de Aquí", "986777415", "Rachele Tyler", "rachele@A.info"));
            listBoxEmpresas.Items.Add(new Cliente("A86742466", "Elegante Total", "986688522", "Charlotte Sellers", "charlotte@A.info"));
            listBoxEmpresas.Items.Add(new Cliente("A56353426", "OneClick OneKill", "986117695", "Rebecca Hunter", "rebecca@A.info"));
            listBoxEmpresas.Items.Add(new Cliente("F68642362", "Celestial Cloud", "986122778", "Scarlett McMahon", "scarlett@A.info"));
            listBoxEmpresas.Items.Add(new Cliente("E90642610", "Prosperidad Carilla", "986110782", "Jane Smith", "jane@A.info"));
        }

        private void objetoSeleccionado(object sender, EventArgs e)
        {
            Cliente c = (Cliente)listBoxEmpresas.Items[listBoxEmpresas.SelectedIndex];
            limpiarLabel();
            lbCif.Text += c.Cif;
            lbNombre.Text += c.Name;
            lbTelefono.Text += c.Phone;
            lbContacto.Text += c.Contact;
            lbEmail.Text += c.Email;


        }
        private void limpiarLabel()
        {
            lbCif.Text = "CIF: ";
            lbNombre.Text = "Nombre: ";
            lbTelefono.Text = "Teléfono: ";
            lbContacto.Text = "Persona de contacto: ";
            lbEmail.Text = "Email: ";
        }
    }
}
