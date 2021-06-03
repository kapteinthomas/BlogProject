using Blog.DAL;

namespace Blog.Controllers
{
    public class BlogController
    {
        private readonly DatabaseContext _context;
        public BlogController(DatabaseContext context)
        {
            _context = context;
        }
    }
}