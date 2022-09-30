using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_app.Core.Interfaces;
using Web_app.Data;

namespace Web_app.Domain.Services
{
    public class StudentService : IStudents
    {
        private readonly SchoolContext _context;
        public StudentService(SchoolContext context)
        {
            _context = context;
        }

        public async Task<object> GetAll()
        {
            try
            {
                var result = await _context.Students.ToListAsync();

                return result;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
