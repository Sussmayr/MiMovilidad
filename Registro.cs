using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVisualEventos
{
    public partial class Registro : Form
    {
        InnovaCard innovaCard;
        Usuario usuario;
        CRUD Gestor;

        public Registro()
        {
            InitializeComponent();
        }

        public Registro(InnovaCard InnovaCardConstructor, Usuario usuarioConstructor)
        {
            InitializeComponent();
            innovaCard = new InnovaCard();
            dTPFecha.MaxDate = DateTime.Today;

            if (InnovaCardConstructor != null)
            {
                txtCard.Enabled = false;

                txtUser.Text = InnovaCardConstructor.Usuario;
                txtCard.Text = InnovaCardConstructor.CardName;
                dTPFecha.Value = InnovaCardConstructor.FechaViaje.Date;
                txtCredito.Text = InnovaCardConstructor.CreditoDisponible1.ToString();
                txtCosto.Text = InnovaCardConstructor.CostoPasaje.ToString();

                innovaCard.Id = InnovaCardConstructor.Id;
            }


            Gestor = new CRUD();

        }

        //Actualizar Registro
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            innovaCard.Usuario = txtUser.Text;
            innovaCard.CardName = txtCard.Text;
            innovaCard.FechaViaje = dTPFecha.Value;
            innovaCard.CreditoDisponible1 = Convert.ToDouble(txtCredito.Text);
            innovaCard.CostoPasaje = Convert.ToDouble(txtCosto.Text);

            Gestor.Entidad = innovaCard;
            if (Gestor.Actualizar())
            {
                var mensaje = (innovaCard.Id > 0) ? " creado" : "actualizado";
                MessageBox.Show("El registro se ha " + mensaje);
                LimpiarControles();
            }
            else
            {
                var mensaje = (innovaCard.Id > 0) ? " crear" : "actualizado";
                MessageBox.Show("Error al  " + mensaje + " el registro");
            }

        }

        private void LimpiarControles()
        {
            txtCard.Clear();
            txtUser.Clear();
            dTPFecha.Value = DateTime.Today;
            txtCredito.Clear();
            txtCosto.Clear();
        }
    }
}
