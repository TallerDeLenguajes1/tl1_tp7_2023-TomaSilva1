namespace Calculadora
{
    public class calculadora
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

        public void Sumar(double termino){
            dato = dato + termino;
        }

        public void Restar(double termino){
            dato = dato - termino;
        }
    
        public void Producto(double termino){
            dato = dato * termino;
        }

        public void Cociente(double termino){
            if (termino != 0)
            {
                dato = dato/termino;
            }else{
                Console.WriteLine("ERROR: La division de un numero en 0 no esta definida.");
            }
        }
        
        public void limpiar(){
            dato = 0;
        }
    }
}
