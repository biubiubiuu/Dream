using Dream.Domain.Blog;
using Dream.Domain.Blog.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
namespace Dream.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// CategoryRepository
    /// </summary>
    public class CategoryRepository : EfCoreRepository<DreamDbContext, Category, int>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<DreamDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}