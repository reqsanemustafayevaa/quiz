using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
//    BlogService static classdir
//============================
//AddBlog(Blog blog) - Blogdatabase classin static List<Blog>a elave edir
//RemoveBlog(int id) - id'li blogu listden silir
//GetBlogById(int id) - id'li blogu qaytarir
//GetAllBlogs() - Butun bloglari qaytarir
//GetBlogsByValue(string value) - qebul etdiyi valueya uygun gelen bloglari qaytarir(title,desctiptioninda varsa bu value)
    public static class BlogService
    {
        public static List<Blog> Blogs = new List<Blog>();
        public static List<Blog> AddBlog(Blog blog) 
        {
            foreach(Blog blg in Blogs)
            Blogs.Add(blog);
            return Blogs;
        }
        
        public static List<Blog> RemoveBlog(int id)
        {
            Blog wantedblog=Blogs.Find(blog=>blog.Id.ToLower()==id.ToString());
            if(wantedblog!=null)Blogs.Remove(wantedblog);
            return Blogs;
        }
        public static List<Blog> GetBlogById(int Id)
        {
            return Blogs.FindAll(blog =>blog.Id.ToLower()==Id.ToString());
        }
        public static List<Blog> GetAllBlogs()
        {
            return Blogs.FindAll(blog => blog == blog);
        }
        public static List<Blog>GetBlogByValue(string value)
        {
            return Blogs.FindAll(Blog.Title.ToLower()(value.ToLower));
        }




    }
}
