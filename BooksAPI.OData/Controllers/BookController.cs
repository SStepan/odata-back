using System.Linq;
using System.Web.Http.Cors;
using BooksAPI.OData.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.OData.Controllers
{
    [EnableCors("MyPolicy", headers: "*", methods: "*")]
    [Produces("application/json")]
    public class BookController : ODataController
    {
        private readonly BooksContext context;

        public BookController(BooksContext context) => this.context = context;

        // GET: odata/Book
        [EnableQuery]
        public IQueryable<Book> Get() => context.Books.AsQueryable();
    }
}