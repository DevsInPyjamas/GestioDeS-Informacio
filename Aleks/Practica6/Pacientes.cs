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
    public partial class Pacientes : Form
    {
        private Usuario user;
        public Pacientes(Usuario usr)
        {
            this.user = usr;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
