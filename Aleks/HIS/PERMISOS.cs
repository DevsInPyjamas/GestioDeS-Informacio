using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HIS
{
    public partial class PERMISOS : Form
    {
        private Rol rol;
        private Permiso seleccionado;

        public PERMISOS(Rol r)
        {
            InitializeComponent();
            rol = r;
        }

        private void PERMISOS_Load(object sender, EventArgs e)
        {

            label1.Text += rol.RolName.ToUpper();
            cargarGrid();
        }

        private void cargarGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Permiso p in Permiso.ListaPermisosRol(rol.RolName)) 
                dataGridView1.Rows.Add(p.Pantalla, p.Acceso, p.Modificacion);
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                string pantalla = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                seleccionado = new Permiso(rol.RolName, pantalla);
                refrescaDatos();
            }
        }

        private void refrescaDatos()
        {
            if (seleccionado==null)
            {
                tPantalla.Text = "";
                checkAcceso.Checked=false;
                checkModificacion.Checked = false;
            }
            else
            {
                tPantalla.Text = seleccionado.Pantalla;
                checkAcceso.Checked = seleccionado.Acceso;
                checkModificacion.Checked = seleccionado.Modificacion;
            }
        }

        private void bCLEAR_Click(object sender, EventArgs e)
        {
            seleccionado = null;
            refrescaDatos();
        }

        private void bINS_Click(object sender, EventArgs e)
        {
            seleccionado = new Permiso(rol.RolName, tPantalla.Text, checkAcceso.Checked, checkModificacion.Checked);
            cargarGrid();
        }

        private void bUPD_Click(object sender, EventArgs e)
        {
            if (seleccionado.Pantalla != tPantalla.Text) seleccionado.Pantalla = tPantalla.Text;
            if (seleccionado.Acceso != checkAcceso.Checked) seleccionado.Acceso = checkAcceso.Checked;
            if (seleccionado.Modificacion != checkModificacion.Checked) seleccionado.Modificacion = checkModificacion.Checked;
            cargarGrid();

        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            if (seleccionado == null) return;
            seleccionado.BorrarPermiso();
            seleccionado = null;
            cargarGrid();
            refrescaDatos();
        }
    }
}
