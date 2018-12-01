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
    public partial class USUARIOS : Form
    {
        private Usuario user = null;
        private Usuario seleccionado = null;

        public USUARIOS(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void USUARIOS_Load(object sender, EventArgs e)
        {
            if (!user.AccesoPantalla(this.Name)) this.Close();
            if (!user.ModificaPantalla(this.Name))
            {
                bINS.Enabled = false;
                bDEL.Enabled = false;
                bUPD.Enabled = false;
            }

            // TODO: esta línea de código carga datos en la tabla 'gI1819DataSet.tUsuario' Puede moverla o quitarla según sea necesario.
            this.tUsuarioTableAdapter.Fill(this.gI1819DataSet.tUsuario);
            foreach (Rol r in Rol.ListaRoles()) lRol.Items.Add(r);


        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bINS_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado = new Usuario(tUser.Text, tPwd.Text, (Rol)lRol.SelectedItem);
                this.tUsuarioTableAdapter.Fill(this.gI1819DataSet.tUsuario);
                refrescaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bUPD_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado.Nombre != tUser.Text) seleccionado.Nombre = tUser.Text;
                if (seleccionado.Password != tPwd.Text) seleccionado.Password = tPwd.Text;
                if (!seleccionado.MyRol.Equals(lRol.SelectedItem)) 
                        user.ModiRol(seleccionado, (Rol)lRol.SelectedItem);

                this.tUsuarioTableAdapter.Fill(this.gI1819DataSet.tUsuario);
                refrescaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado.BorrarUsuario();
                seleccionado = null;
                this.tUsuarioTableAdapter.Fill(this.gI1819DataSet.tUsuario);
                refrescaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
                string nombre = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                string pwd = (string)dataGridView1.SelectedRows[0].Cells[1].Value;

                seleccionado = new Usuario(nombre, pwd);
                refrescaDatos();
            }
        }

        private void refrescaDatos()
        {
            if (seleccionado==null)
            {
                tUser.Text = "";
                tPwd.Text = "";
                lRol.SelectedItem = null;
            }
            else
            {
                tUser.Text = seleccionado.Nombre;
                tPwd.Text = seleccionado.Password;
                lRol.SelectedItem = seleccionado.MyRol;
            }
        }
    }
}
