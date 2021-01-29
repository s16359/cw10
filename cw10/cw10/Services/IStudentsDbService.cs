using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw10.DTO.Requests;
using cw10.Models;

namespace cw10.Services
{
   public interface IStudentsDbService
    {
        public bool PromoteStudent(PromoteStudentRequest promoteStudentRequest);

        public StudentEnrollment EnrollStudent(EnrollStudentRequest enrollStudentRequest);

        public Studies GetStudy(string studyName);
    }
}
