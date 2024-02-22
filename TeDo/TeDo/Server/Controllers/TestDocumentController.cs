using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TeDo.Server.Controllers
{
    public class TestDocumentController : Controller
    {
        // GET: TestDocumentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TestDocumentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestDocumentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestDocumentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestDocumentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestDocumentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestDocumentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestDocumentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
