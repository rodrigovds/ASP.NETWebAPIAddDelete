﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Cliente
    {
         public string Nome { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }
    }
}