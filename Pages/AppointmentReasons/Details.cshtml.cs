using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Doctors_Appointments.Data;
using Doctors_Appointments.Models;

namespace Doctors_Appointments.Pages.AppointmentReasons
{
    public class DetailsModel : PageModel
    {
        private readonly Doctors_Appointments.Data.Doctors_AppointmentsContext _context;

        public DetailsModel(Doctors_Appointments.Data.Doctors_AppointmentsContext context)
        {
            _context = context;
        }

        public ReasonForAppointment ReasonForAppointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ReasonForAppointment = await _context.ReasonForAppointment.FirstOrDefaultAsync(m => m.Id == id);

            if (ReasonForAppointment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
