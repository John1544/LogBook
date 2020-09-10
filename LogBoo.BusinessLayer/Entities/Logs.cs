using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.BusinessLayer.Entities
{
    public class Logs
    {
        public int Id { get; set; }
        public byte HasFever { get; set; }
        public byte HasCough { get; set; }
        public byte HasSoreThroat { get; set; }
        public byte HasDiarrhea { get; set; }
        public byte HasLostOfSmell { get; set; }
        public byte HasLostOfTaste { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeIn { get; set; }
        public string RecentTravels { get; set; }
        public string ContactedCovidPatient { get; set; }
        public string OtherSymptoms { get; set; }
        public float Temperature { get; set; }
        public int PersonId { get; set; }
    }
}
