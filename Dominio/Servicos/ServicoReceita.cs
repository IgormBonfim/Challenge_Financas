using Dominio.Interfaces;
using Dominio.Interfaces.InterfaceServicos;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public class ServicoReceita : IServicoReceita
    {
        private readonly IReceita iReceita;

        public ServicoReceita(IReceita iReceita)
        {
            this.iReceita = iReceita;
        }

        public async Task AdicionaReceita(Receita receita)
        {
            throw new NotImplementedException();
        }

        public async Task AtualizaReceita(Receita receita)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Receita>> ListarReceitas()
        {
            throw new NotImplementedException();
        }
    }
}
