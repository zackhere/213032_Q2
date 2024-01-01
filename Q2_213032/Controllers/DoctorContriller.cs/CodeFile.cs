using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class DoctorController : Controller
{
    private readonly AppDbContext _context;

    public DoctorController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var doctors = _context.Doctors.ToList();
        return View(doctors);
    }

}
