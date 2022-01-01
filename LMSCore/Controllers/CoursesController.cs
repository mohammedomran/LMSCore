using LMSCore.Models;
using LMSCore.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        public ICourseRepo CourseRepo { get; }
        public CoursesController(ICourseRepo courseRepo)
        {
            CourseRepo = courseRepo;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetCourses()
        {
            return Ok(CourseRepo.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult<Course> GetCourse(int id)
        {
            return Ok(CourseRepo.GetById(id));
        }


        [HttpPost]
        public ActionResult<IEnumerable<Course>> InsertCourse(Course course)
        {
            var Course = CourseRepo.Insert(course);
            CourseRepo.Save();
            return Ok(Course);
        }


        [HttpPut]
        public ActionResult<IEnumerable<Course>> UpdateCourse(Course course)
        {
            var Course = CourseRepo.Update(course);
            CourseRepo.Save();
            return Ok(Course);
        }


        [HttpDelete]
        public ActionResult<IEnumerable<Course>> DeleteCourse(int id)
        {
            CourseRepo.Delete(id);
            CourseRepo.Save();
            return Ok("Course deleted successfully");
        }

    }
}
