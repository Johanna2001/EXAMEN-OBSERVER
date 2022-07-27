using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_OBSERVER
{
    class Reparacion : IObserver<ClienteNegocio>
    {
        private IDisposable TipoDispositivo;
        public string nombre { get; set; }
        public string PaisFabricacion { get; set; }
        public List<ClienteNegocio> notificacion { get; set; }

        public Reparacion(string nombre, string PaisFabricacion)
        {
            this.nombre = nombre;
            this.PaisFabricacion= PaisFabricacion;
            notificacion = new();
        }
        public virtual void Tipo(Notificacion Modelo)
        {
            TipoDispositivo = Modelo.Tipo(this);
        }
        public void Notifica()
        {
            Console.WriteLine($"Hola, {nombre}! no estamos aceptando ninguna aplicacion más");
        }

        public void OnError(Exception error)
        {

        }

        public void OnNext(ClienteNegocio value)
        {
            notificacion.Add(value);
        }

        public void Dispositivo()
        {
            if (notificacion.Any())
            {
                foreach (var nott in notificacion)
                {
                    Console.WriteLine($"Hola, {nombre}! {nott} acaba de solicitar el trabajo no. {nott.IMEIDispositivo}");
                }
            }
            else
            {
                Console.WriteLine($"Hola, {nombre}! Aún no hay Dispositivos");
            }
        }
    }
}

