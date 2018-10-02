using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap08.Web.MVC.Models;

namespace Fiap08.Web.MVC.Repositories
{
    public interface IDependenteRepository
    {
        void Cadastrar(Dependente dep);
        void Atualizar(Dependente dep);
        void Remover(int codigo);

        Dependente BuscarPorId();

        List<Dependente> listar();

        List<Dependente> BuscarPor(Expression<Func<Dependente, bool>> filtro);
    }
}