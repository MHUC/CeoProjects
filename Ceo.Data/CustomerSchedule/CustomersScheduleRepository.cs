using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ceo.Data;
using System.Data.Entity;

namespace Ceo.Data.CustomerSchedule
{
    public class CustomersScheduleRepository
    {

        public List<tblSchedule> GetCustomersScheduleList()
        {


            using (var context = new CeoContext())
            {
                var schedule = context.tblSchedules.Include(c => c.tblCustomer)
                    .Take(500)
                    .OrderBy( o => new { o.ScheduleID}).ThenByDescending( d => d.ScheduleID)
                    .ToList();

                return schedule;

            }
        }

   
        public List<tblSchedule> GetOneoffSchedule(DateTime StartDate)
        {
            using (var context = new CeoContext())
            {
                var schedule = context.tblSchedules.Include(c => c.tblCustomer)
                    .Where( c => c.StartDate == StartDate)
                    .OrderBy(o => new { o.ScheduleID }).ThenByDescending(d => d.ScheduleID)
                    .ToList();

                return schedule;

            }

        }





    }
}