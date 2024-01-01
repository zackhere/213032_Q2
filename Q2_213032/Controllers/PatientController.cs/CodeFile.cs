using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class PatientController : Controller
{
    private readonly AppDbContext _context;

    public PatientController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var patients = _context.Patients.ToList();
        return View(patients);
    }

    // Add other CRUD actions (Create, Edit, Delete)
}
