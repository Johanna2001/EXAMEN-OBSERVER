using System;

namespace EXAMEN_OBSERVER
{
    class Program
    {
        static void Main(string[] args)
        {
            var observer1 = new Reparacion("Mabel", "USA");
            var observer2 = new Reparacion("Juan", "Rusia");

            var Modelo = new Notificacion();
            observer1.Tipo(Modelo);
            observer2.Tipo(Modelo);

            Modelo.Dispositivo(new(1, "Contador"));
            Modelo.Dispositivo(new(2, "Cantante"));

            observer1.ListaAplicacion();
            observer2.ListaAplicacion();

            observer2.UnSubcripcion();

            Console.WriteLine();
            Console.WriteLine($"{observer2.nombre} se ha eliminado su subcripcion");
            Console.WriteLine();

            Modelo.AddAplicaciones(new(3, "Sistemas"));

            observer1.ListaAplicacion();
            observer2.ListaAplicacion();
        }
    }
}
