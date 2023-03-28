using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace FolhaDePagamento
{
    public class RepositorioFuncionario
    {
            private IList<Funcionario> funcionarios = new BindingList<Funcionario>();

            public void Inserir(Funcionario funcionario)
            {
                this.funcionarios.Add(funcionario);
            }
            public IList<Funcionario> ObterTodos()
            {
                return this.funcionarios;
            }
    }
}
