using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFilhoDoPatrao
{
    class Usuario
    {
        #region Propriedades
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Nivel Nivel { get; set; }


        #endregion


        #region Função para gerar usuarios
        public static List<Usuario> GerarUsuarios ()
        {
            List<Usuario> list = new List<Usuario>
            {
                new Usuario{ Nome = "Sysadmin", Senha = "123", Nivel = Nivel.SysAdmin},
                new Usuario{Nome = "Antonio", Senha = "123", Nivel = Nivel.Dono},
                new Usuario{Nome = "Henrique" , Senha ="123", Nivel = Nivel.Funcionario}
            };
            
            return list;
        }
        #endregion

    }
}
