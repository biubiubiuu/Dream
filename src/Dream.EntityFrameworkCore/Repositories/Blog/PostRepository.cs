using Dream.Domain.Blog;
using Dream.Domain.Blog.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Dream.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// PostRepository
    /// </summary>
    public class PostRepository : EfCoreRepository<DreamDbContext, Post, int>, IPostRepository
    {
        public PostRepository(IDbContextProvider<DreamDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
