using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GymAppln.Models
{
    public class GymClass
    {

        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special characters  & Numbers should not be entered")]
        public string Name { get; set; }
        //[DisplayFormat(DataFormatString = "{0:hh\\:mm\\:ss}")]
        public DateTime StartTime { get; set; }

        public TimeSpan Duration { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime EndTime { get { return StartTime + Duration; } }
        [Required]
        [DisplayName("Phone No")]
        [RegularExpression(@"^[0-9'' ']+$", ErrorMessage = "Only Numbers are Allowed")]
        public string mobile { get; set; }
        public String Description { get; set; }

        public virtual ICollection<ApplicationUser> AttendingMembers { get; set; }

        //public GymClass()
        //{

        //    StartTime = DateTime.Now;
        //}


    }
}