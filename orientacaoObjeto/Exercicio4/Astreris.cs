using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Astreris
    {


            private int x;
            private int y;

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }

            public Astreris(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public void ExibirDados()
            {
                Console.WriteLine($"Ponto x: {this.X}\nPonto y: {this.Y}\n-----");
            }
        }
    }
}
}
