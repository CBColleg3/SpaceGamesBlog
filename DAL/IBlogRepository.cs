using System;
using System.Collections.Generic;
using SpaceBlogBackend.Models.Blog;

namespace SpaceBlogBackend.DAL;

public interface IBlogRepository: IDisposable
{
    IEnumerable<GamerBlog> GetGamerBlogs();
    GamerBlog GetGamerBlogById(int gamerBlogId);
    void InsertGamerBlog(GamerBlog gamerBlog);
    void DeleteGamerBlog(int gamerBlogId);
    void UpdateGamerBlog(GamerBlog gamerBlog);
    void Save();
}