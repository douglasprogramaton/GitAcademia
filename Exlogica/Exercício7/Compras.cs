using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7
{
   public class Compras 
    {
     

        public static List<Vendedor> Vendedors { get; set; }
      
        public static List<Vendedor> Add_vendedor { get; set; }

        public void Vendedores()
        {
            Add_vendedor = new List<Vendedor>();
            Vendedors = new List<Vendedor>();
            Vendedors.Add(new Vendedor { Id = 1, Nome = "Ricardo", Codigo = 201522, Salario = 1750 });
            Vendedors.Add(new Vendedor { Id = 2, Nome = "Osvaldo", Codigo = 121022, Salario = 1750 });
            Vendedors.Add(new Vendedor { Id = 3, Nome = "Juciele", Codigo = 233922, Salario = 1650 });
            Vendedors.Add(new Vendedor { Id = 4, Nome = "David", Codigo = 200022, Salario = 1950 });
            Vendedors.Add(new Vendedor { Id = 5, Nome = "Daniel", Codigo = 010222, Salario = 2450 });



        }
        public double  AdicaoV()
        {
            double add = 0;
            for (int i = 0; i < Add_vendedor.Count; i++)
            {
                add += Add_vendedor[i].Id;
            }
            return add;
        }
        public static List<Vendedor> Vendas => Vendedors;
    }
}


