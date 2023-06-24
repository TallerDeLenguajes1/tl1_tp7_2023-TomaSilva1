using System;
namespace Calculadora
{
    public class Calculador
    {
        private double dato;

        public double Resultado
        {
            get => dato;
            
            set
            {
                dato = value;
            }
        }

        public double Sumar(double termino){
            dato = dato + termino;
            return dato;
        }

        public double Restar(double termino){
            dato = dato - termino;
            return dato;
        }
    
        public double Producto(double termino){
            dato = dato * termino;
            return dato;
        }

        public double Cociente(double termino){
            if (termino != 0)
            {
                dato = dato/termino;
                return dato;
            }else{
                Console.WriteLine("ERROR: La division de un numero en 0 no esta definida.");
                return dato;
            }
        }
        
        public double limpiar(){
            dato = 0;
            return dato;
        }
    }
}
