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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReferenciaWeb.Service1Client svc = new ReferenciaWeb.Service1Client();
            List<ReferenciaWeb.Alumno> listaAlumnos = svc.GetAll();

            MessageBox.Show(listaAlumnos.Count.ToString());
        }
    }
}
