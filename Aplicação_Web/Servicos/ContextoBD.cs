using Microsoft.EntityFrameworkCore;

namespace Aplicação_Web.Servicos
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions options) : base(options)
        {
        }

        protected ContextoBD()
        {
        }
    }
}
