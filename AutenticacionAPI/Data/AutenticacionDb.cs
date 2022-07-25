using AutenticacionAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AutenticacionAPI.Data
{
    public class AutenticacionDb : DbContext
    {

        public AutenticacionDb(DbContextOptions<AutenticacionDb> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios => Set<Usuario>();
    }
}
