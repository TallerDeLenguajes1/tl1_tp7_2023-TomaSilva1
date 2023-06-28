using System;
namespace recursos{

    public class Empleado{

        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }
//-----------------------
        private string apellido;
        public string Apellido { get => apellido; set => apellido = value; }
//-----------------------
        private DateTime cumpleaños;
        public DateTime Cumpleaños { get => cumpleaños; set => cumpleaños = value; }     
//-----------------------
        private char eCivil;
        public char ECivil { get => eCivil; set => eCivil = value; }
//-----------------------
        private char genero;
        public char Genero { get => genero; set => genero = value; }
//-----------------------
        private DateTime ingresoEmpresa;
        public DateTime IngresoEmpresa { get => ingresoEmpresa; set => ingresoEmpresa = value; }
//-----------------------
        private double sueldoB;
        public double SueldoB { get => sueldoB; set => sueldoB = value; }
//-----------------------
        private cargos cargo;
        internal cargos Cargo { get => cargo; set => cargo = value; }
//-----------------------
        private int edad;
        public int Edad { get => edad; set => edad = value; }
//-----------------------
        private int antiguedad;
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }     
        //-----------------------
        private int jubilacion;
        public int Jubilacion { get => jubilacion; set => jubilacion = value; }

        private double adicional;
        public double Adicional { get => adicional; set => adicional = value; }

        private double salario;
        public double Salario { get => salario; set => salario = value; }
        
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