using MediatR;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery:IRequest<List<Student>>
    {

    }
}
