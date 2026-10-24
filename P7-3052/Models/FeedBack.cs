using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P7_3052_Models
{
    public class FeedBack
    {
        public int EnrollmentNumber { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
    }
}