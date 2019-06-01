﻿using System.ComponentModel.DataAnnotations;

namespace Parcial1_JonathanMaria.Entidades
{
    public class Inventarios
    {
        [Key]
        public int Id;
        public float Valor;

        public Inventarios()
        {
            Id = 0;
            Valor = 0;
        }

    }
}