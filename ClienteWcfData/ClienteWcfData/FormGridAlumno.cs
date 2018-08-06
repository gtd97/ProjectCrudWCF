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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(listaAlumnos.Count.ToString());
        }

        #region click_Añadir
        private void click_Añadir(object sender, EventArgs e)
        {
            formAdd = new FormAñadirAlumno();
            
            // Registro del evento add, que se encarga de setear el atributo de la otra clase "class.parametroEvent += EnventHandler(Method)"
            formAdd.OnAdd += new EventHandler(Actualizar);

            formAdd.Show();
        }
        #endregion

        #region click_Buscar
        private void click_Buscar(object sender, EventArgs e)
        {
            dgv_grid.DataSource = null;
            dgv_grid.Rows.Clear();
            dgv_grid.Columns.Clear();
            dgv_grid.Refresh();

            ReferenciaWeb.Service1Client svc = new ReferenciaWeb.Service1Client("Http");
            
            Alumno alumnoEntontrado = svc.GetByGuid( Guid.Parse(tb_guid.Text) );

            string[] row = new string[] {
                alumnoEntontrado.Apellidos,
                alumnoEntontrado.Dni,
                alumnoEntontrado.Guid.ToString(),
                alumnoEntontrado.Nombre
            };            
            

            dgv_grid.DataSource = row;
            AñadirButtons(dgv_grid);
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
            dgv_grid.DataSource = null;
            dgv_grid.Rows.Clear();
            dgv_grid.Columns.Clear();
            dgv_grid.Refresh();

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
            GetAllByProtocol("Http");
        }
        #endregion

        #region EliminarAlumno
        public void EliminarAlumno(Guid guid)
        {
            ReferenciaWeb.Service1Client svc = new ReferenciaWeb.Service1Client("Http");
            bool result = svc.Delete(guid);

            if (result == true)
            {
                GetAllByProtocol("Http");
            }
        }
        #endregion

        #region ClickBotones
        private void dgv_grid_click(object sender, DataGridViewCellEventArgs e)
        {
            // Editar
            if(e.ColumnIndex == 4)
            {
                Guid guid = Guid.Parse(dgv_grid.Rows[e.RowIndex].Cells[2].Value.ToString());
                string nombre = dgv_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                string apellido = dgv_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                string dni = dgv_grid.Rows[e.RowIndex].Cells[1].Value.ToString();

                FormEditarAlumno formEditar = new FormEditarAlumno(guid, nombre, apellido, dni);
                formEditar.OnEdit += new EventHandler(Actualizar);
                formEditar.Show();
            }
            // Eliminar
            else if (e.ColumnIndex == 5)
            {
                string guidString = dgv_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                Guid guid = Guid.Parse(guidString);
                EliminarAlumno(guid);
            }
        }
        #endregion


    }
}
