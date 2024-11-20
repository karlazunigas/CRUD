namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool editar = false;
       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "No. Identificación")
            {
                txtID.Text = "";
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "No. Identificación";
            }
        }

        private void txtCarnet_Enter(object sender, EventArgs e)
        {
            if (txtCarnet.Text == "No. Carnet")
            {
                txtCarnet.Text = "";
            }
        }

        private void txtCarnet_Leave(object sender, EventArgs e)
        {
            if (txtCarnet.Text == "")
            {
                txtCarnet.Text = "No. Carnet";
            }
        }

        private void txtCarrera_Enter(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "Carrera")
            {
                txtCarrera.Text = "";
            }

        }

        private void txtCarrera_Leave(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                txtCarrera.Text = "Carrera";
            }

        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Teléfono")
            {
                txtTelefono.Text = "";
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Teléfono";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true; ;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            editar = false;

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtID.Text = "";
            txtCarnet.Text = "";
            txtCarrera.Text = "";
            txtTelefono.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante Estudiante = new Estudiante
            {
                Nombre = txtNombre.Text,
                Cédula = txtID.Text,
                Carnet = txtCarnet.Text,
                Carrera = txtCarrera.Text,
                Teléfono = txtTelefono.Text,

            };

            if (editar)
            {
                int alumno = dvgEstudiantes.SelectedCells[0].RowIndex;
                dvgEstudiantes.Rows[alumno].Cells[0].Value = Estudiante.Nombre;
                dvgEstudiantes.Rows[alumno].Cells[1].Value = Estudiante.Cédula;
                dvgEstudiantes.Rows[alumno].Cells[2].Value = Estudiante.Carnet;
                dvgEstudiantes.Rows[alumno].Cells[3].Value = Estudiante.Cédula;
                dvgEstudiantes.Rows[alumno].Cells[4].Value = Estudiante.Teléfono;

            }
            else
            {
                {
                    int nuevo = dvgEstudiantes.Rows.Add();
                    dvgEstudiantes.Rows[nuevo].Cells[0].Value = Estudiante.Nombre;
                    dvgEstudiantes.Rows[nuevo].Cells[1].Value = Estudiante.Cédula;
                    dvgEstudiantes.Rows[nuevo].Cells[2].Value = Estudiante.Carnet;
                    dvgEstudiantes.Rows[nuevo].Cells[3].Value = Estudiante.Carrera;
                    dvgEstudiantes.Rows[nuevo].Cells[4].Value = Estudiante.Teléfono;
                }
            }
            
            LimpiarCampos();
            
        }

    

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            if (dvgEstudiantes.SelectedRows.Count > 0)
            {
 
                
                    int filaSeleccionada = dvgEstudiantes.SelectedRows[0].Index;

                    
                    dvgEstudiantes.Rows.RemoveAt(filaSeleccionada);

                    
                    MessageBox.Show("Estudiante Eliminado");
                }
                 else
                {
                    
                    MessageBox.Show("Por favor, selecciona un estudiante para eliminar.");
                }
            }
        
    private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dvgEstudiantes.SelectedRows.Count > 0)
            {

                editar = true;


                var selectedRow = dvgEstudiantes.SelectedRows[0];

                txtNombre.Text = selectedRow.Cells[0].Value.ToString();
                txtID.Text = selectedRow.Cells[1].Value.ToString();
                txtCarnet.Text = selectedRow.Cells[2].Value.ToString();
                txtCarrera.Text = selectedRow.Cells[3].Value.ToString();
                txtTelefono.Text = selectedRow.Cells[4].Value.ToString();


                btnGuardar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un estudiante para editar.");
            }
        }
    }
}


        







    

