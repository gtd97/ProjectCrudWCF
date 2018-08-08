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
    public partial class FormAñadirAlumno : Form
    {
        public event EventHandler OnAdd;

        public FormAñadirAlumno()
        {
            InitializeComponent();
        }

        #region click_añadir
        public void click_añadir(object sender, EventArgs e)
        {
            //ReferenciaWeb.Service1Client svc = new ReferenciaWeb.Service1Client("Http");
            ReferenciaWeb.Service1Client svc = new ReferenciaWeb.Service1Client();

            Alumno alumnoNuevo = new Alumno { Guid = Guid.NewGuid(), Nombre = tb_nombre.Text, Apellidos = tb_apellido.Text, Dni = tb_dni.Text };

            Alumno alumnoRegistrado = svc.Post(alumnoNuevo);

            if( alumnoRegistrado != null && OnAdd != null)
            {
                OnAdd(this, e);
            }

            Close();
        }
        #endregion

    }
}
