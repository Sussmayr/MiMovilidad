using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVisualEventos
{
    public class CRUD
    {
        public InnovaCard Entidad { get; set; }
        public Usuario Entidad1 { get; set; }

        public CRUD()
            {
            }


        //Insertar 
        public bool Insertar()
        {
            using (var context = new ProyectoInnovaCardEntities1())
            {
                context.InnovaCard.Add(Entidad);
                return context.SaveChanges() > 0;
            }
        }

        //Actualizar Registros
        public bool Actualizar()
        {
            using (var context = new ProyectoInnovaCardEntities1())
            {
                var registro = context.InnovaCard.Find(Entidad.Id);
                if (registro == null)
                {
                    return Insertar();
                }
               context.Entry(registro).CurrentValues.SetValues(Entidad);
               return context.SaveChanges() > 0;
            }
        }

        //seleccionar en DataGridView
        public InnovaCard[] Seleccionar()
        {
            using (var context = new ProyectoInnovaCardEntities1())
            {
                return context.InnovaCard.ToArray();
            }
        }

        public InnovaCard[] SeleccionarConFiltro(object filtro)
        {
            using (var context = new ProyectoInnovaCardEntities1())
            {
                if (filtro.GetType() == typeof(string))
                {
                    var credito = Convert.ToString(filtro.ToString());
                    var costo = Convert.ToInt32(filtro);

                    return context.InnovaCard.Where
                        (x => x.CardName.Contains(filtro.ToString()) || x.Usuario.Contains(filtro.ToString()) || x.CreditoDisponible1.ToString().Contains(filtro.ToString()) || x.CostoPasaje.ToString().Contains(filtro.ToString())).ToArray();
                    
                }
                else
                {
                    var fecha = Convert.ToDateTime(filtro);
                    return context.InnovaCard.Where(x => DateTime.Now.Year - x.FechaViaje.Year == DateTime.Now.Year - fecha.Year).ToArray();

                }
            }
        }


        //Validacion Usuario y contraseña
        public bool Acceso(string usuario, string contrasena)
        {
            using (var context = new ProyectoInnovaCardEntities1())
            {
                var result = context.validarAcceso(usuario, contrasena).FirstOrDefault();
                return result.HasValue ? result.Value == 1 : false;
            }
        }

    }
}
