using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeBook.Services
{
    public class NewsService : INewsService
    {
        private readonly CoffeeBookDbContext _context;

        public NewsService(CoffeeBookDbContext context)
        {
            _context = context;
        }

        public List<News> GetAllNews()
        {
            return _context.News.ToList();
        }

        public News GetNewsById(int id)
        {
            try
            {
                return _context.News.Single(s => s.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public int AddNewNews(News news)
        {
            try
            {
                _context.News.Add(news);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateNews(int id, News news)
        {
            try
            {
                News n = _context.News.Single(s => s.Id == id);
                n.Title = news.Title;
                n.Thumbnail = news.Thumbnail;
                n.Content = news.Content;
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteNews(int id)
        {
            try
            {
                var deletedNews = _context.News.Single(s => s.Id == id);
                _context.News.Remove(deletedNews);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}