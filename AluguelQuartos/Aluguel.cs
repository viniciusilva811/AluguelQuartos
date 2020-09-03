﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelQuartos
{
    class Aluguel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Aluguel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
