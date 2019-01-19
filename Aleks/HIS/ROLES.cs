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
    public partial class ROLES : Form
    {
        private Rol seleccionado;

        public ROLES()
        {
            InitializeComponent();
        }

        private void ROLES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gI1819DataSet.tRol' Puede moverla o quitarla según sea necesario.
            this.tRolTableAdapter.Fill(this.gI1819DataSet.tRol);

        }

        private void bINS_Click(object sender, EventArgs e)
        {
            seleccionado = new Rol(tRolName.Text, tRolDes.Text, cEsAdmin.Checked);
            this.tRolTableAdapter.Fill(this.gI1819DataSet.tRol);
        }

        private void bUPD_Click(object sender, EventArgs e)
        {
            if (seleccionado.RolName != tRolName.Text) seleccionado.RolName = tRolName.Text;
            if (seleccionado.RolDes != tRolDes.Text) seleccionado.RolDes = tRolDes.Text;
            cEsAdmin.Checked = seleccionado.Admin;
            this.tRolTableAdapter.Fill(this.gI1819DataSet.tRol);
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            seleccionado.BorrarRol();
            seleccionado = null;
            this.tRolTableAdapter.Fill(this.gI1819DataSet.tRol);
            refrescaDatos();
        }

        private void bCLEAR_Click(object sender, EventArgs e)
        {
            seleccionado = null;
            refrescaDatos();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                string rolName = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                seleccionado = new Rol(rolName);
                refrescaDatos();
            }
        }

        private void refrescaDatos()
        {
            if (seleccionado==null)
            {
                tRolName.Text = "";
                tRolDes.Text = "";
                cEsAdmin.Checked = false;
            }
            else
            {
                tRolName.Text = seleccionado.RolName;
                tRolDes.Text = seleccionado.RolDes;
                cEsAdmin.Checked = seleccionado.Admin;
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bPermisos_Click(object sender, EventArgs e)
        {
            if (seleccionado == null) return;

            PERMISOS ventana = new PERMISOS(seleccionado);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void cEsAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tRolDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void tRolName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
