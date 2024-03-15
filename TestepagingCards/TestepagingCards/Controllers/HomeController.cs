using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestepagingCards.Models;

namespace TestepagingCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int page = 1, int pageSize = 4)
        {
            var accordionItems = ListarAccordItems();
            int totalItems = accordionItems.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            var paginatedItems = accordionItems.Skip((page - 1) * pageSize).Take(pageSize);
            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            ViewBag.PageSize = pageSize;
            return View(paginatedItems);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private IEnumerable<AccordionItem> ListarAccordItems()
        {
            return (new List<AccordionItem>
            {
                 new AccordionItem
                 {
                     Id = 1,
                     Title= "Test 1",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 },
                  new AccordionItem
                 {
                     Id = 2,
                     Title= "Test 2",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 },
                   new AccordionItem
                 {
                     Id = 3,
                     Title= "Test 3",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 },
                    new AccordionItem
                 {
                     Id = 4,
                     Title= "Test 4",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 },
                     new AccordionItem
                 {
                     Id = 5,
                     Title= "Test 5",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 },
                      new AccordionItem
                 {
                     Id = 6,
                     Title= "Test 6",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 }
                      ,
                      new AccordionItem
                 {
                     Id = 6,
                     Title= "Test 6",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 }
                      ,
                      new AccordionItem
                 {
                     Id = 7,
                     Title= "Test 7",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 }
                      ,
                      new AccordionItem
                 {
                     Id = 8,
                     Title= "Test 8",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 }
                      ,
                      new AccordionItem
                 {
                     Id = 9,
                     Title= "Test 9",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 }
                      ,
                      new AccordionItem
                 {
                     Id = 10,
                     Title= "Test 10",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 }
                      ,
                      new AccordionItem
                 {
                     Id = 11,
                     Title= "Test 11",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 }
                      ,
                      new AccordionItem
                 {
                     Id = 12,
                     Title= "Test 12",
                     Information="It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the"
                 }
            }).AsEnumerable();
        }
    }
}
