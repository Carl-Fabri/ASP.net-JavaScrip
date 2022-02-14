using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Models
{
    public class ServiciosModel
    {
        public string Nombre { get; set; }

        public int Cantidad { get; set ; }
        
        public int Index { get; set; }

        public string Demo { get; set; }

        public int Nueva { get; set; }

    }
}
