using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created By Anubha Vishwakarma
namespace Group3HRManagementSystem
{
    //EXAMPLE OF CO VARIANCE
    internal class Project : IEnumerable<Project>
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HoursAllocated { get; set; }
        public double Budget { get; set; }

        //Interface methods for iteration

        public IEnumerator<Project> GetEnumerator()
        {
            var projects = new List<Project>(); 

            foreach (var project in projects)
            {
                yield return project;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }//End Project Class
}//end namespace
