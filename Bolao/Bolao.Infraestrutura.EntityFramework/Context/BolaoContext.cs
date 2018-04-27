using Microsoft.EntityFrameworkCore;

namespace Bolao.Infraestrutura.EntityFramework.Context
{
    public class BolaoContext: DbContext
    {
        public BolaoContext(DbContextOptions<BolaoContext> options)
            :base(options)
        { }
    }
}