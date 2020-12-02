using DHTMLX.Scheduler;
using Microsoft.EntityFrameworkCore;
using Milestone1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Milestone1.Controllers
{
    public partial class SchedulerContext : DbContext
    {
        private const string V = "name=SchedulerContext";

        
        public virtual DbSet<Event> Events { get; set; }
    }
}