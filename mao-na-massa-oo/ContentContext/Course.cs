using System.Collections.Generic;
using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }


        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public double DurationInMinutes { get; set; }
        public EContentLevel level { get; set; }
    }
}