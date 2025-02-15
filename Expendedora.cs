using System.Runtime.CompilerServices;

namespace ExpendedoraBase_G2_2025_II
{
    // public -> modificador de acceso
    public class Expendedora
    {
        //private -> Modificadode acceso para los atributos
        private string _marca;
        private byte _temperatura;
        private float _precio; //Los atributos toman un valor por default

        /*
        public Expendedora()
        {
            _precio = 25;
            _marca = "AMS";
            _temperatura= 14; // [°C]
            Console.WriteLine("Bienvenido");
            Console.WriteLine("{0}", _marca);
            ClearScreenTimer(1000);
            Console.WriteLine("Temperatura: {0}", _temperatura);
            ClearScreenTimer(2000);
            string codigo =MostrarProductos();
            ClearScreenTimer(3000);
            MostrarPrecio(codigo);

        }
        */
        private void ClearScreenTimer(int timer)
        {
            Thread.Sleep(timer);
            Console.Clear();
        }

        public string MostrarProductos()
        {
            Console.WriteLine("AA)Chocorroles \t BC)Barritas de Chocolate ");
            Console.WriteLine("Ingrese el código del producto a elegir");
            string codigo = Console.ReadLine();
            return codigo;
        }

        private void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "AA":
                    Console.WriteLine("El precio es : ${0}", _precio);
                    break;
                case "BC":
                    Console.WriteLine("El precio es: ${0}", _precio-=10); // _precio = precio -10
                    break;
                default:
                    Console.WriteLine("El código ingresado no corresponde a un producto");
                    break;
            }
        }

    }
}
