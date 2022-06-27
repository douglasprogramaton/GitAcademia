using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infos.DAL
{/// <summary>
 ///Info.Dal é da biblioteca de classes que tera as informações necessarias para o projeto sistema de vendas
 /// ou seja ira controlar todos os acessos do banco de dados.
 /// "DataContextFactory"____ fabrica de conexões.
 /// </summary>
    public class DataContextFactory
    {
        //dataContext é do tipo da classe data Context.
        private static DataClasses1DataContext dataContext;
        //ao declarar como static estou dizendo que só avera uma conexão com o banco de dados de cada vez
        public static DataClasses1DataContext DataContext 
        {
            get
            {
                if (dataContext == null)
                    dataContext= new DataClasses1DataContext();
                    return dataContext;
                
            }
        }

    }
}
