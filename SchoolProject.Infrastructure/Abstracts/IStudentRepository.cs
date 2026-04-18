using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Infrastructure.Abstracts
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetStudentsListAsync();
    }
}
