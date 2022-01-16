﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSalario
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double Incremento { get; set; }



        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public Funcionario(double incremento)
        {
            Incremento = incremento;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + "$ "
                + Salario;
        }

        public void ValorIncremento(double incremento)
        {
            Salario += incremento;
        }
    }
}
