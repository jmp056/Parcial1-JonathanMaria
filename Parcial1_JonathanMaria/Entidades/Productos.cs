﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_JonathanMaria.Entidades
{
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public float Costo { get; set; }
        public float ValorEnInventario { get; set; }

        public Productos()
        {
            IdProducto = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            ValorEnInventario = 0;
        }
    }
}
