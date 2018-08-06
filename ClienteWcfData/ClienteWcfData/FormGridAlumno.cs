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
    public partial class FormGridAlumno : Form
    {
        FormAñadirAlumno formAdd;

        public FormGridAlumno()
        {
            InitializeComponent();

            // Registro del evento add, que se encarga de setear el atributo de la otra clase "class.parametroEvent += EnventHandler(Method)"
            formAdd.OnAdd += new EventHandler(Actualizar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(listaAlumnos.Count.ToString());
        }

        #region click_Añadir
        private void click_Añadir(object sender, EventArgs e)
        {
            formAdd = new FormAñadirAlumno();
            formAdd.Show();
        }
        #endregion

        #region click_Buscar
        private void click_Buscar(object sender, EventArgs e)
        {

        }
        #endregion

        #region click_http
        private void click_http(object sender, EventArgs e)
        {
            GetAllByProtocol("Http");
        }
        #endregion

        #region click_Tcp
        private void click_Tcp(object sender, EventArgs e)
        {
            GetAllByProtocol("Tcp");
        }
        #endregion

        #region GetAllByProtocol
        public void GetAllByProtocol(string protocol)
        {
            ReferenciaWeb.Service1Client svc = new ReferenciaWeb.Service1Client(protocol);

            // Rellenar Grid
            List<Alumno> listaAlumnos = svc.GetAll();
            dgv_grid.DataSource = listaAlumnos;
            AñadirButtons(dgv_grid);
        }
        #endregion

        #region AñadirButtons
        private void AñadirButtons(DataGridView grid)
        {
            // Crear Columna Editar
            DataGridViewButtonColumn buttonEdit = new DataGridViewButtonColumn();
            buttonEdit.Name = "Editar";
            buttonEdit.HeaderText = "Editar";
            buttonEdit.Text = "Editar";
            buttonEdit.UseColumnTextForButtonValue = true;

            // Crear Columna Editar
            DataGridViewButtonColumn buttonRemove = new DataGridViewButtonColumn();
            buttonRemove.Name = "Eliminar";
            buttonRemove.HeaderText = "Eliminar";
            buttonRemove.Text = "Eliminar";
            buttonRemove.UseColumnTextForButtonValue = true;
            
            // Añadir columna botones
            grid.Columns.Add(buttonEdit);
            grid.Columns.Add(buttonRemove);
        }
        #endregion

        #region Actualizar
        public void Actualizar(object sender, EventArgs e)
        {
            ReferenciaWeb.Service1Client svc = new ReferenciaWeb.Service1Client("Http");

            // Rellenar Grid
            List<Alumno> listaAlumnos = svc.GetAll();
            dgv_grid.DataSource = listaAlumnos;

            //AñadirButtons(dgv_grid);
        }
        #endregion

    }
}
