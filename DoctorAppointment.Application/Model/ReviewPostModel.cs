using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Application.Model
{
    public class ReviewPostModel
    {
        public int DoctorId { get; set; }
        public string? Content { get; set; }
        public int Rating { get; set; }
    }
}
