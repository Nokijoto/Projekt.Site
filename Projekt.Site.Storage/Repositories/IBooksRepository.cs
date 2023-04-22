using Projekt.Site.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Site.Storage.Repositories
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetAll();
        Book GetById(Guid id);
        void Add(Book book);
        void Update(Book book);
        void Remove(Guid id);
        bool IsBookExist(string name, int year);
        bool IsShelftExist(string name);
        Book GetBookDetails(Guid bookid);
        IEnumerable<Book> GetBooksBySerie(Guid serieId);

    }
}
