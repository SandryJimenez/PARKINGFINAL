using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tarifas
    {
        public Tarifas(int idvehiculo, string tipovehiculo, string precioxhora)
        {
            this.idvehiculo = idvehiculo;
            this.tipovehiculo = tipovehiculo;
            this.precioxhora = precioxhora;
        }

        public int idvehiculo { get; set; }
        public string tipovehiculo { get; set; }
        public string precioxhora  { get; set; }

        public Tarifas()
        {
        }
    }
}
