using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurkishPizzaAdmin._Models
{
    public class reservationViewModel
    {
    }

    public class ReservationBLL
    {
        public int reservationID { get; set; }
        
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public int? NumberPerson { get; set; }
        public DateTime ReservationDate { get; set; }
        public string SittingArea { get; set; }
        public int StatusID { get; set; }
        public int? BrandID { get; set; }   
        public DateTime? LastUpdatedDate { get; set; }

    }
    

}
