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
    public partial class LOGIN : Form
    {
        private Usuario user = null;
        public LOGIN()
        {
            InitializeComponent();
            ocultar_botones();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            try
            {
                user = new Usuario(tUser.Text, tPwd.Text);
                activa_botones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }
        }

        private void bUSUARIOS_Click(object sender, EventArgs e)
        {
            formulario_usuarios();
        }

        private void bPACIENTES_Click(object sender, EventArgs e)
        {
            formulario_pacientes();
        }

        private void bCITAS_Click(object sender, EventArgs e)
        {
            formulario_citas();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario_usuarios();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario_pacientes();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario_citas();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tUser.Text = "";
            tPwd.Text = "";
            ocultar_botones();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ocultar_botones()
        {
            label1.Visible = true;
            label2.Visible = true;
            tUser.Visible = true;
            tPwd.Visible = true;
            bLogin.Visible = true;
            bUSUARIOS.Visible = false;
            bPACIENTES.Visible = false;
            bCITAS.Visible = false;
            foreach (ToolStripItem i in menuStrip1.Items) i.Visible = false;
        }

        private void activa_botones()
        {
            label1.Visible = false;
            label2.Visible = false;
            tUser.Visible = false;
            tPwd.Visible = false;
            bLogin.Visible = false;

            bUSUARIOS.Visible = true;
            bPACIENTES.Visible = true;
            bCITAS.Visible = true;

            foreach (ToolStripItem i in menuStrip1.Items) i.Visible = true;
        }

        private void formulario_usuarios()
        {
            USUARIOS ventana = new USUARIOS(user);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;

        }

        private void formulario_pacientes()
        {
            PACIENTES ventana = new PACIENTES(user);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;

        }

        private void formulario_citas()
        {
            CITAS ventana = new CITAS(user);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;

        }
    }
}
