﻿
using System.Collections.Generic;
using TurkishPizzaAdmin._Models;
using TurkishPizzaAdmin.BLL._Services;
using Microsoft.AspNetCore.Mvc;

namespace TurkishPizzaAdmin.Controllers
{
    [Route("api/[controller]")]

    public class dashboardController : ControllerBase
    {
        dashboardService _service;
        public dashboardController()
        {
            _service = new dashboardService();
        }

        [HttpGet("get/{LocationID}/{Date}")]
        public RspDashboard GetDashboardSummary(int LocationID, string Date)
        {
            return _service.GetDashboard(LocationID, System.DateTime.Now.Date.ToString());
        }

        [HttpGet("range/get/{locationID}/{FDate}/{TDate}")]
        public RspDashboard GetDashboardSummary(int LocationID, string FDate, string TDate)
        {
            return _service.GetDashboardRange(LocationID,FDate, TDate);
        }
    }
}
