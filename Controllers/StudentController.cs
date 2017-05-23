using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentApi
{
    public class StudentController : ApiController
    {

        public class Student
        {
            public int Id;
            public string FullName;
            public string Mobile;
        }

        int id = 0;
        private Student GetStudent(string name, string mob)
        {
            id++;
            return new Student
            {
                Id = id,
                FullName = name,
                Mobile = mob
            };
        }


        // GET api/<controller>
        public IEnumerable<Student> Get()
        {
            List<Student> students = new List<Student>();

            var s = GetStudent("A", "9");
            students.Add(s);

            s = GetStudent("B", "9");
            students.Add(s);

            s = GetStudent("C", "8");
            students.Add(s);

            s = GetStudent("D", "7");
            students.Add(s);

            s = GetStudent("E", "6");
            students.Add(s);

            return students;
            //return Json(students, JsonRequestBehavior.AllowGet);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}