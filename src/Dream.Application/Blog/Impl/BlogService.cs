using Dream.Application.Contracts.Blog;
using Dream.Domain.Blog;
using Dream.Domain.Blog.Repositories;
using Dream.ToolKits.Base;
using Dream.ToolKits.Extensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dream.Application.Blog.Impl
{
    public class BlogService : ServiceBase, IBlogService
    {
        private readonly IPostRepository _postRepository;

        public BlogService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }


        public async Task<ServiceResult<string>> InsertPostAsync(PostDto dto)
        {
            var result = new ServiceResult<string>();

            var entity = new Post
            {
                Title = dto.Title,
                Author = dto.Author,
                Url = dto.Url,
                Html = dto.Html,
                Markdown = dto.Markdown,
                CategoryId = dto.CategoryId,
                CreationTime = dto.CreationTime
            };

            var post = await _postRepository.InsertAsync(entity);
            if (post == null)
            {
                result.IsFailed("添加失败");
                return result;
            }

            result.IsSuccess("添加成功");
            return result;
        }

        public async Task<ServiceResult> DeletePostAsync(int id)
        {
            var result = new ServiceResult();

            await _postRepository.DeleteAsync(id);

            return result;
        }

        public async Task<ServiceResult<string>> UpdatePostAsync(int id, PostDto dto)
        {
            var result = new ServiceResult<string>();

            var post = await _postRepository.GetAsync(id);
            if (post == null)
            {
                result.IsFailed("文章不存在");
                return result;
            }

            post.Title = dto.Title;
            post.Author = dto.Author;
            post.Url = dto.Url;
            post.Html = dto.Html;
            post.Markdown = dto.Markdown;
            post.CategoryId = dto.CategoryId;
            post.CreationTime = dto.CreationTime;

            await _postRepository.UpdateAsync(post);


            result.IsSuccess("更新成功");
            return result;
        }

        public async Task<ServiceResult<PostDto>> GetPostAsync(int id)
        {
            var result = new ServiceResult<PostDto>();

            var post = await _postRepository.GetAsync(id);
            if (post == null)
            {
                result.IsFailed("文章不存在");
                return result;
            }

            var dto = new PostDto
            {
                Title = post.Title,
                Author = post.Author,
                Url = post.Url,
                Html = post.Html,
                Markdown = post.Markdown,
                CategoryId = post.CategoryId,
                CreationTime = post.CreationTime
            };

            result.IsSuccess(dto);
            return result;
        }

        public async Task<ServiceResult<PostDto>> GetPostListAsync()
        {
            var result = new ServiceResult<PostDto>();
            var list = await _postRepository.GetListAsync();
            var newList = new List<PostDto>();
            list.ForEach(post =>
            {
                newList.Add(new PostDto
                {
                    Title = post.Title,
                    Author = post.Author,
                    Url = post.Url,
                    Html = post.Html,
                    Markdown = post.Markdown,
                    CategoryId = post.CategoryId,
                    CreationTime = post.CreationTime
                });
            });
            result.IsSuccess(newList.ToJson());
            return result;
        }




        //public async Task<bool> DeletePostAsync(int id)
        //{
        //    await _postRepository.DeleteAsync(id);

        //    return true;
        //}

        //public async Task<bool> InsertPostAsync(PostDto dto)
        //{
        //    var entity = new Post
        //    {
        //        Title = dto.Title,
        //        Author = dto.Author,
        //        Url = dto.Url,
        //        Html = dto.Html,
        //        Markdown = dto.Markdown,
        //        CategoryId = dto.CategoryId,
        //        CreationTime = dto.CreationTime
        //    };

        //    var post = await _postRepository.InsertAsync(entity);
        //    return post != null;
        //}

        //public async Task<bool> UpdatePostAsync(int id, PostDto dto)
        //{
        //    var post = await _postRepository.GetAsync(id);

        //    post.Title = dto.Title;
        //    post.Author = dto.Author;
        //    post.Url = dto.Url;
        //    post.Html = dto.Html;
        //    post.Markdown = dto.Markdown;
        //    post.CategoryId = dto.CategoryId;
        //    post.CreationTime = dto.CreationTime;

        //    await _postRepository.UpdateAsync(post);

        //    return true;
        //}

        //public async Task<PostDto> GetPostAsync(int id)
        //{
        //    var post = await _postRepository.GetAsync(id);

        //    return new PostDto
        //    {
        //        Title = post.Title,
        //        Author = post.Author,
        //        Url = post.Url,
        //        Html = post.Html,
        //        Markdown = post.Markdown,
        //        CategoryId = post.CategoryId,
        //        CreationTime = post.CreationTime
        //    };
        //}
    }
}