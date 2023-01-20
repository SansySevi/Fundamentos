﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        protected int SalarioMinimo { get; set; } 

        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacío");
            this.SalarioMinimo = 1000;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetDiasVacaciones() EMPLEADO");
            return 22;
        }

        public Empleado(string nombre, string apellidos)
            :base()
        {
            Debug.WriteLine("Constructor EMPLEADO dos parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

    }
}
