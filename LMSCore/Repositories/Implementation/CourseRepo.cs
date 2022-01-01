using LMSCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCore.Repositories
{
    public class CourseRepo : Repo<Course>, ICourseRepo
    {
        public LMSContext LMSContext { get; }
        public CourseRepo(LMSContext lMSContext):base(lMSContext)
        {

        }

    }
}
