using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_OBSERVER
{
    class ClienteNegocio
    { 
    public int IMEIDispositivo { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string SistemaOperativo { get; set; }

        public ClienteNegocio(int IMEIDispositivo, string Marca, string Modelo, string SistemaOperativo)
        {
            this.IMEIDispositivo = IMEIDispositivo;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.SistemaOperativo = SistemaOperativo;
        }
    }
}

       
