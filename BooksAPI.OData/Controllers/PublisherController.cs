using System.Linq;
using System.Web.Http.Cors;
using BooksAPI.OData.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.OData.Controllers
{
    [EnableCors(origins: "http://localhost:3000/", headers: "*", methods: "*")]
    [Produces("application/json")]
    public class PublisherController : ODataController
    {
        private readonly BooksContext context;

        public PublisherController(BooksContext context) => this.context = context;

        // GET: odata/Publisher
        [EnableQuery]
        public IQueryable<Publisher> Get() => context.Publishers.AsQueryable();
    }
}