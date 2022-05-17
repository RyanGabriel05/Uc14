using ChapterFST1.Contexts;
using ChapterFST1.Models;

namespace ChapterFST1.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;

        public LivroRepository(ChapterContext context) 
        { 
            _context = context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
    }
}
  