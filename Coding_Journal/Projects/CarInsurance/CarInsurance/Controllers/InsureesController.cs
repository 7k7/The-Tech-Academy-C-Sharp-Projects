using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly InsureesContext _context;

        public InsureesController(InsureesContext context)
        {
            _context = context;
        }

        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // GET: Insurees
        // ONLY the Insuree's FirstName, LastName, EmailAddress, and Quote
        // This is for a Site Administrator 
        public async Task<IActionResult> Admin()
        {
            return View(await _context.Insurees.AsNoTracking().Select(x => new InsureeVm()
            {
                Quote = x.Quote,
                FirstName = x.FirstName,
                LastName = x.LastName,
                EmailAddress = x.EmailAddress
            }).ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Id = Guid.NewGuid();

                // Calculate the quote based on the information a user inputs

                // Insurance base: $50.00 / month
                insuree.Quote = 50.00m;

                // These datetime vars will aid in determining age of an insuree
                // to apply the appropriate added cost to their quote
                DateTime nineteenYearsAgo = DateTime.Now.AddYears(-19);
                DateTime twentysixYearsAgo = DateTime.Now.AddYears(-26);

                // If user age is <=18, add $100 to monthly total
                int compareAgeToNineteen = DateTime.Compare(insuree.DateOfBirth, nineteenYearsAgo);
                if (compareAgeToNineteen > 0) // Insuree is 18 years of age or younger
                {
                    insuree.Quote += 100.00m;
                }
                // If user age is 19 - 25, add $50 to monthly total
                int compareAgeToTwentysix = DateTime.Compare(insuree.DateOfBirth, twentysixYearsAgo);
                if (compareAgeToNineteen <= 0 && compareAgeToTwentysix > 0) // Insuree is between 19 or 25 years of age
                {
                    insuree.Quote += 50.00m;
                }
                // If user age is >=26, add $25 to monthly total
                if (compareAgeToTwentysix <= 0) // Insuree is 26 years of age or older
                {
                    insuree.Quote += 25.00m;
                }

                // Next up, applying additional costs depending on the car's year
                if (insuree.CarYear < 2000) // If Insuree's car's year is before year 2000, add $25.00 to quote
                {
                    insuree.Quote += 25.00m;
                }
                if (insuree.CarYear > 2015)// If Insuree's car's year is after year 2015, add $25.00 to quote
                {
                    insuree.Quote += 25.00m;
                }

                // Now will check whether the Insuree own a Porche to add addional costs to quote
                if (insuree.CarMake == "Porsche") // Add $25 if the car make is a Porsche
                {
                    insuree.Quote += 25.00m;
                }
                // If the Car Model is a 911 Carrera, add $25.00 to the quote
                // if it is, the Car Make is a Porsche since that model pertains to a Porsche car
                if (insuree.CarModel == "911 Carrera") // if true, add 25.00
                {
                    insuree.Quote += 25.00m;
                }

                // Add 10.00 to quote for every speeding ticket an insuree has
                // If insuree has none, it is 10.00 times 0.00 is 0.00
                // meaning no additional cost will be added to the quote
                insuree.Quote += 10.00m * Convert.ToDecimal(insuree.SpeedingTickets);

                // If an insuree ever had a DUI, add an additional 25% to quote
                if (insuree.DUI)
                {
                    insuree.Quote += insuree.Quote / 4; 
                }

                // If insuree has full coverage, add an additional 50% of the current quote
                // to the overall total
                if (insuree.CoverageType) // True = full coverage, false = liability
                {
                    insuree.Quote += insuree.Quote / 2;
                }

                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
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
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree != null)
            {
                _context.Insurees.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(Guid id)
        {
            return _context.Insurees.Any(e => e.Id == id);
        }
    }
}
