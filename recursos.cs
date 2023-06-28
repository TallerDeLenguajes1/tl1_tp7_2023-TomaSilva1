using System;
namespace recursos{

    public class Empleado{

        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }
//-----------------------
        private string apellido;
        public string Apellido { get => apellido; set => apellido = value; }
//-----------------------
        private datetime cumpleaños;
        public datetime Cumpleaños { get => cumpleaños; set => cumpleaños = value; }     
//-----------------------
        private char eCivil;
        public char ECivil { get => eCivil; set => eCivil = value; }
//-----------------------
        private char genero;
        public char Genero { get => genero; set => genero = value; }
//-----------------------
        private datetime ingresoEmpresa;
        public datetime IngresoEmpresa { get => ingresoEmpresa; set => ingresoEmpresa = value; }
//-----------------------
        private double sueldoB;
        public double SueldoB { get => sueldoB; set => sueldoB = value; }
//-----------------------
        private cargos cargo;
    }
    
}

enum cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}