using ClienteWcfData.ReferenciaWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWcfData
{
    public partial class FormEditarAlumno : Form
    {
        public event EventHandler ok;

        public FormEditarAlumno()
        {
            InitializeComponent();
        }

        private void click_editar(object sender, EventArgs e)
        {
            ReferenciaWeb.Service1Client svc = new ReferenciaWeb.Service1Client("Http");

            Alumno alumnoNuevo = new Alumno { Guid = Guid.Parse(tb_guid.Text), Nombre = tb_nombre.Text, Apellidos = tb_apellido.Text, Dni = tb_dni.Text };

            Alumno alumnoObtenido = svc.Put(Guid.Parse(tb_guid.Text), alumnoNuevo);

            ok("Alumno añadido", null);
        }
    }
}
