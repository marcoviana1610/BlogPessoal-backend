using BlogPessoal.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogPessoal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<TopicModel> topicModels { get; set; }
    }
}
