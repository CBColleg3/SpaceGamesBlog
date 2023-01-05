using Microsoft.EntityFrameworkCore;
using SpaceBlogBackend.Models.Blog;

namespace SpaceBlogBackend.DAL;

public class GamerBlogContext: DbContext
{
    public GamerBlogContext(DbContextOptions<GamerBlogContext> options): base(options) {}
    
    public DbSet<GamerBlog> GamerBlogs { get; set; }
}