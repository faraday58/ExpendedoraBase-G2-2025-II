
namespace ExpendedoraBase_G2_2025_II
{
    class Cafe:Expendedora
    {
        public override byte Temperatura {
            get => _temperatura; 
            set
            {
                if (value < 10   || value > 70)
                {
                    _temperatura = 60;
                }
                else
                {
                    _temperatura = value;
                }
            }
        }

        #region Constructor
        public Cafe()
        {
            Console.WriteLine("Bienvenido a tu expendedora de Café");
            ClearScreenTimer(2000);
            Temperatura = 5;
            Console.WriteLine("Temperatura {0} [ºC] " ,Temperatura);
            
        }
        #endregion
    }
}
