using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Laboratory.Data;
using Laboratory.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Laboratory.Controllers
{
    public class RequestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Requests
        [Authorize(Roles = "Admin, Recep")]
        public async Task<IActionResult> Index(string searchSelected, string searchString)
        {
            if (_context.Request == null)
            {
                return NotFound("Request Is Null");
            }
            var request = from m in _context.Request
                          select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                if (searchSelected == "College")
                {
                    request = request.Where(x => x.College.Contains(searchString));
                }
                else if (searchSelected == "StudentsStatus")
                {
                    request = request.Where(x => x.StudentsStatus.Contains(searchString));
                }
            }
            return View(await request.ToListAsync());

        }

        // GET: Requests/Details/5
        [Authorize(Roles = "Admin, Recep")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Request == null)
            {
                return NotFound();
            }

            var request = await _context.Request
                .FirstOrDefaultAsync(m => m.Id == id);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }

        // GET: Requests/Create
        public IActionResult Create()
        {
            //StudentCollegeVM studentCollegeVM = new StudentCollegeVM();
            //var colleges = _context.College.ToList();
            //studentCollegeVM.CollegeSelectList = new SelectList(colleges, "Name", "Name");


            //var managemnt = _context.Management.Where(x => x.Name == "limitationDays").FirstOrDefault();
            //if (managemnt is null)
            //{
            //    ViewBag.ErrorMessage = "You Need To Set The Limit In Management";
            //    return View();
            //}
            //var limitDays = managemnt.Value;
            //var dateTo = DateTime.Now.AddDays(30);
            //List<DateTime> avilableDates = new List<DateTime>();
            //for (var date = DateTime.Now; date <= dateTo; date = date.AddDays(1))
            //{
            //    if (date.DayOfWeek.ToString() == "Friday" || date.DayOfWeek.ToString() == "Saturday")
            //    {
            //        continue;
            //    }
            //    var requestsCount = _context.Request.Where(x => x.TestDate.Date == date.Date).Count();
            //    if (requestsCount >= limitDays)
            //    {
            //        continue;
            //    }
            //    avilableDates.Add(date);
            //}
            //studentCollegeVM.AvilableDates = avilableDates;
            //return View(studentCollegeVM);
        }

        // POST: Requests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NationalOrResidenceId,UniversityNumber,StudentsStatus,College,FirstNameEnglish,FatherNameEnglish,GrandFatherNameEnglish,FamilyNameEnglish,FirstNameArabic,FatherNameArabic,GrandFatherNameArabic,FamilyNameArabic,Email,PhoneNo,BirthDate,MedicalFileNo,TestDate,NationalOrResidenceIdFile,CopyOfStudentId")] Request request)
        {
            //StudentCollegeVM studentCollegeVM = new StudentCollegeVM();
            //studentCollegeVM.Request = request;
            //var colleges = _context.College.ToList();
            //studentCollegeVM.CollegeSelectList = new SelectList(colleges, "Name", "Name");
            //var managemnt = _context.Management.Where(x => x.Name == "limitationDays").FirstOrDefault();
            //if (managemnt is null)
            //{
            //    ViewBag.ErrorMessage = "You Need To Set The Limit In Management";
            //    return View(studentCollegeVM);
            //}
            //var limitDays = managemnt.Value;
            //var requestsCount = _context.Request.Where(x => x.TestDate == request.TestDate).Count();
            //if (requestsCount >= limitDays)
            //{
            //    ViewBag.ErrorMessage = "Sorry, The Limit Of Request For This Day Is Reached";
            //    return View(studentCollegeVM);
            //}
            //var residenceIdNameFile = Guid.NewGuid().ToString() + ".jpg";
            //var studentIdNameFile = Guid.NewGuid().ToString() + ".jpg";

            //var residenceIdFullPath = System.IO.Path.Combine(
            //    System.IO.Directory.GetCurrentDirectory(), "wwwroot", "UploadedFiles", residenceIdNameFile);
            //var studentIdFullPath = System.IO.Path.Combine(
            //    System.IO.Directory.GetCurrentDirectory(), "wwwroot", "UploadedFiles", studentIdNameFile);

            //using (var stream = new System.IO.FileStream(residenceIdFullPath, System.IO.FileMode.Create))
            //{
            //    await NationalOrResidenceIdFile.CopyToAsync(stream);
            //}
            //using (var stream = new System.IO.FileStream(studentIdFullPath, System.IO.FileMode.Create))
            //{
            //    await CopyOfStudentId.CopyToAsync(stream);
            //}
            //request.NationalOrResidenceIdFile = residenceIdNameFile;
            //request.CopyOfStudentId = studentIdNameFile;


            //if (ModelState.IsValid)
            //{

            //    _context.Add(request);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction("Message");
            //}
            //return View(studentCollegeVM);
        }

        //GET: Messages for Success
        public IActionResult Message()
        {
            return View();
        }

        private bool RequestExists(int id)
        {
          return (_context.Request?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
