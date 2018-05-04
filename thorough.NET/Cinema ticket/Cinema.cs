using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_ticket
{

    [Serializable]
   public class Cinema
    {


       public Cinema()
       {
           seats = new Dictionary<string, Seat>();
           soldTickets = new List<Ticket>();
           schedule = new Schedule();
       }
       //座位集合属性
        private Dictionary<string, Seat> seats;
       //放映计划
        private Schedule schedule;       
       //已经售出电影票集合
        private List<Ticket> soldTickets;

        public List<Ticket> SoldTickets
        {
            get { return soldTickets; }
            set { soldTickets = value; }
        }

        public Schedule Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }

        public Dictionary<string, Seat> Seats
        {
            get { return seats; }
            set { seats = value; }
        }
    }
}
