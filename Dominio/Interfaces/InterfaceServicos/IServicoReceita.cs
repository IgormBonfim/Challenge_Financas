using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfaceServicos
{
    public interface IServicoReceita
    {
        Task AdicionaReceita(Receita receita);
        Task AtualizaReceita(Receita receita);
        Task<List<Receita>> ListarReceitas();
    }
}
