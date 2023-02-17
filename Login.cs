using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoVisualEventos
{
    public partial class Login : Form
    {
        CRUD gestor;

        public Login()
        {
            InitializeComponent();
            gestor = new CRUD();
        }


        //Ingresar al sistema
        //validacion de Usuario y Contraseña
        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            if (gestor.Acceso(txtUsuario.Text, txtPassword.Text))
            {
                Form1 sForm = new Form1(); //Form1(this);
                sForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error en Usuario y/o Contraseña");
            }
        }

        private void LinkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.mibici.net/es/registro/");
        }
    }
}
