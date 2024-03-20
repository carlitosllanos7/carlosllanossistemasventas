using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonasVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuariosVistas
{
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr=new PersonaListarVista();
            if (fr.ShowDialog()==DialogResult.OK)
            {
                Persona persona =BSS obtener(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + "" + persona.Apellido;
            }
            
        }
    }
}
