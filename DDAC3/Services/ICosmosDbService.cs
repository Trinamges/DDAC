using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDAC3.Models;

namespace DDAC3.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Book>> GetItemsAsync(string query);
        Task<Book> GetItemAsync(string id);
        Task AddItemAsync(Book book);
        Task UpdateItemAsync(string id, Book book);
        Task DeleteItemAsync(string id);
    }
}
