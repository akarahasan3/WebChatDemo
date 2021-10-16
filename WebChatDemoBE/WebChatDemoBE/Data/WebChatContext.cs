using Microsoft.EntityFrameworkCore;
using WebChatDemoBE.Models;

namespace WebChatDemoBE.Data
{
    public class WebChatContext : DbContext
    {
        public WebChatContext(DbContextOptions<WebChatContext> opt) : base(opt)
        {
            
        }

        public DbSet<LoginModel> LoginModels { get; set; }
    }
}