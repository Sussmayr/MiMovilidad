using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProyectoVisualEventos
{
    public partial class Form1 : Form
    {
        CRUD Gestor;
        Registro FormularioRegistro;
        InnovaCard innovaCard1;


        public Form1()
        {
            InitializeComponent();

            DTPRegistrarViaje.MaxDate = DateTime.Today;
            Gestor = new CRUD();
            CargarDatos();
        }

        //Refrescar DataGridView
        public void CargarDatos()
        {
            DGVViajes.DataSource = Gestor.Seleccionar();
            
        }

        //Agregar Saldo A Tarjeta InnovaCard
        private void BtnAgregarSaldo_Click(object sender, EventArgs e)
        {

        }

        //Registrar viaje 
        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            Mostrar(null,null);

        }


        private void Mostrar(InnovaCard innovacard, Usuario usuario)
        {
            FormularioRegistro = new Registro(innovacard, usuario);

            DialogResult result = FormularioRegistro.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                CargarDatos();
            }
        }


        //Exportar a Excel
        private void BtnExportar_Click(object sender, EventArgs e)
        {
            var aplicacion = new Excel.Application();

            aplicacion.Visible = true;

            aplicacion.Workbooks.Add();

            Excel._Worksheet hoja = (Excel.Worksheet)aplicacion.ActiveSheet;

            hoja.Cells[1, "A"] = "Usuario";
            hoja.Cells[1, "B"] = "Tarjeta";
            hoja.Cells[1, "C"] = "Dia";
            hoja.Cells[1, "D"] = "Hora";
            hoja.Cells[1, "E"] = "Saldo";
            hoja.Cells[1, "F"] = "Costo Pasaje";

            var renglon = 1;
            foreach (DataGridViewRow viaje in DGVViajes.Rows)
            {
                renglon++;
                hoja.Cells[renglon, "A"] = viaje.Cells[0].Value;
                hoja.Cells[renglon, "B"] = viaje.Cells[1].Value;
                hoja.Cells[renglon, "C"] = viaje.Cells[2].Value;
                hoja.Cells[renglon, "D"] = viaje.Cells[3].Value;
                hoja.Cells[renglon, "E"] = viaje.Cells[4].Value;
                hoja.Cells[renglon, "F"] = viaje.Cells[5].Value;
            }

            hoja.Columns[1].AutoFit();
            hoja.Columns[2].AutoFit();
            hoja.Columns[3].AutoFit();
            hoja.Columns[4].AutoFit();
            hoja.Columns[5].AutoFit();
            hoja.Columns[6].AutoFit();
        }

        private void DGVViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LimpiarControles()
        {
            DTPRegistrarViaje.Value = DateTime.Today;
        }

        private void DGVViajes_DoubleClick(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void DGVViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var innovaCelda = new InnovaCard();
            if (e.RowIndex > -1)
            {
                innovaCelda.Id = Convert.ToInt32(DGVViajes[0, e.RowIndex].Value);                   //para entero
                innovaCelda.CardName = DGVViajes[1, e.RowIndex].Value.ToString();                   //para texto
                innovaCelda.Usuario = DGVViajes[2, e.RowIndex].Value.ToString();                    //para texto
                innovaCelda.FechaViaje = Convert.ToDateTime(DGVViajes[3, e.RowIndex].Value);        //para fecha
                innovaCelda.CreditoDisponible1 = Convert.ToDouble(DGVViajes[4, e.RowIndex].Value);  //para double
                innovaCelda.CostoPasaje = Convert.ToDouble(DGVViajes[5, e.RowIndex].Value);         //para texto

                Mostrar(innovaCelda,null);
            }
        }
    }
}
