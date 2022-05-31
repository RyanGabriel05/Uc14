using ExoApi.Contexts;
using ExoApi.Models;
using System.Web.Http.OData;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoApiContext _context;
        public ProjetoRepository(ExoApiContext context)
        {
            _context = context;
        }

        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        public Projeto BuscarPorId(int Id)
        {
            return _context.Projetos.Find(Id);
        }

        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        public void Atualizar(int Id, Projeto projeto)
        {
            Projeto projetoBuscado = _context.Projetos.Find(Id);

            if (projetoBuscado != null)
            {
                projetoBuscado.Titulo = projeto.Titulo;
                projetoBuscado.Andamento = projeto.Andamento;
                projetoBuscado.DataInicio = projeto.DataInicio;
                projetoBuscado.Tecnologias = projeto.Tecnologias;
                projetoBuscado.Requisitos = projeto.Requisitos;
                projetoBuscado.Area = projeto.Area;
            }

            _context.Projetos.Update(projetoBuscado);
            _context.SaveChanges();
        }

        public void Deletar(int Id)
        {
            Projeto projetoBuscado = _context.Projetos.Find(Id);
            
            _context.Projetos.Remove(projetoBuscado);
            _context.SaveChanges();
        }
    }
}
