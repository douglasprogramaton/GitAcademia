using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas
{/// <summary>
/// Usa dados do banco de dados para extrair os atributos através dos getter setters que  
/// (getter retorna seu valor) e (setter o define ou atualiza)
/// 
/// </summary>
    public class Meusformularios
    {
        public static frmCategoria FormsCategoria { get; set; }
        public static frmProdutos FormsProdutos { get; set; }
        public static ProdutosporCategoria produtosporCategoria { get; set; }
        public static FrmoPessoaFisica FormsPessoaFisica { get; set; }
        public static FrmVenda FrmVenda { get; set; }
    }
}
