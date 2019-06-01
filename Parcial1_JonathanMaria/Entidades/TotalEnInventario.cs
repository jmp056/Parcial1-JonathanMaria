using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial1.Entidades
{
    public class ValorTotalDeInventario
    {
        [Key]
        int Id;
        float VValorTotalDeInventario;

        ValorTotalDeInventario()
        {
            Id = 0;
            VValorTotalDeInventario = 0;
        }

    }
}
