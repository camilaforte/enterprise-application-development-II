using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.persitencia;

namespace Fiap08.Web.MVC.Repositories
{
    public class DependenteRepository : IDependenteRepository
    {
        private Aula08Context _context;

        public DependenteRepository(Aula08Context cont)
        {
            _context = cont;
        }

        public void Atualizar(Dependente dep)
        {
            throw new NotImplementedException();
        }

        public List<Dependente> BuscarPor(Expression<Func<Dependente, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        public Dependente BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Dependente dep)
        {
            throw new NotImplementedException();
        }

        public List<Dependente> listar()
        {
            throw new NotImplementedException();
        }

        public void Remover(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}