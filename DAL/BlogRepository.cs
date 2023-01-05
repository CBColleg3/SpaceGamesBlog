using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SpaceBlogBackend.Models.Blog;

namespace SpaceBlogBackend.DAL;

public class BlogRepository: IBlogRepository, IDisposable
{
    private GamerBlogContext context;

    public BlogRepository(GamerBlogContext context)
    {
        this.context = context;
    }

    public IEnumerable<GamerBlog> GetGamerBlogs()
    {
        return context.GamerBlogs.ToList();
    }

    public GamerBlog GetGamerBlogById(int gamerBlogId)
    {
        return context.GamerBlogs.Find(gamerBlogId);
    }

    public void InsertGamerBlog(GamerBlog gamerBlog)
    {
        context.GamerBlogs.Add(gamerBlog);
    }

    public void DeleteGamerBlog(int gamerBlogId)
    {
        GamerBlog blog = context.GamerBlogs.Find(gamerBlogId);
        context.GamerBlogs.Remove(blog);
    }

    public void UpdateGamerBlog(GamerBlog gamerBlog)
    {
        context.Entry(gamerBlog).State = EntityState.Modified;
    }

    public void Save()
    {
        context.SaveChanges();
    }

    private bool _disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this._disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }

        this._disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}