using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OOPlab3.Data;
using OOPlab3.Models;

namespace OOPlab3.Controllers
{
    public class DoctorsToPatientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoctorsToPatientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DoctorsToPatients
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DoctorToPatient.Include(d => d.Doctor).Include(d => d.Patient);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DoctorsToPatients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DoctorToPatient == null)
            {
                return NotFound();
            }

            var doctorsToPatients = await _context.DoctorToPatient
                .Include(d => d.Doctor)
                .Include(d => d.Patient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doctorsToPatients == null)
            {
                return NotFound();
            }

            return View(doctorsToPatients);
        }

        // GET: DoctorsToPatients/Create
        public IActionResult Create()
        {
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Id");
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Id");
            return View();
        }

        // POST: DoctorsToPatients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DoctorId,PatientId")] DoctorsToPatients doctorsToPatients)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctorsToPatients);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Id", doctorsToPatients.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Id", doctorsToPatients.PatientId);
            return View(doctorsToPatients);
        }

        // GET: DoctorsToPatients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DoctorToPatient == null)
            {
                return NotFound();
            }

            var doctorsToPatients = await _context.DoctorToPatient.FindAsync(id);
            if (doctorsToPatients == null)
            {
                return NotFound();
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Id", doctorsToPatients.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Id", doctorsToPatients.PatientId);
            return View(doctorsToPatients);
        }

        // POST: DoctorsToPatients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DoctorId,PatientId")] DoctorsToPatients doctorsToPatients)
        {
            if (id != doctorsToPatients.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctorsToPatients);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorsToPatientsExists(doctorsToPatients.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Id", doctorsToPatients.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Id", doctorsToPatients.PatientId);
            return View(doctorsToPatients);
        }

        // GET: DoctorsToPatients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DoctorToPatient == null)
            {
                return NotFound();
            }

            var doctorsToPatients = await _context.DoctorToPatient
                .Include(d => d.Doctor)
                .Include(d => d.Patient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doctorsToPatients == null)
            {
                return NotFound();
            }

            return View(doctorsToPatients);
        }

        // POST: DoctorsToPatients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DoctorToPatient == null)
            {
                return Problem("Entity set 'ApplicationDbContext.DoctorToPatient'  is null.");
            }
            var doctorsToPatients = await _context.DoctorToPatient.FindAsync(id);
            if (doctorsToPatients != null)
            {
                _context.DoctorToPatient.Remove(doctorsToPatients);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorsToPatientsExists(int id)
        {
          return (_context.DoctorToPatient?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
