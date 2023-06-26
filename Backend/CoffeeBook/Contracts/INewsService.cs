using CoffeeBook.Models;
using System.Collections.Generic;

namespace CoffeeBook.Contracts
{
    public interface INewsService
    {
        List<News> GetAllNews();

        News GetNewsById(int id);

        int AddNewNews(News news);

        int UpdateNews(int id, News news);

        int DeleteNews(int id);
    }
}