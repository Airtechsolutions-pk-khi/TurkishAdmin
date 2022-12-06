
using System.Collections.Generic;
using TurkishPizzaAdmin._Models;
using TurkishPizzaAdmin.BLL._Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace TurkishPizzaAdmin.Controllers
{
    [Route("api/[controller]")]
  
    public class reservationController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        reservationService _service;
        public reservationController(IWebHostEnvironment env)
        {
            _service = new reservationService();
            _env = env;
        }

        [HttpGet("all/{brandid}")]
        public List<ReservationBLL> GetAll(int brandid)
        {
            return _service.GetAll(brandid);
        }
        //[HttpGet("GetAllBrand")]
        //public List<DeliveryBLL> GetAllBrand()
        //{
        //    return _service.GetAllBrand();
        //}

        //[HttpGet("settings/{brandid}")]
        //public BrandSettingsBLL GetItemSettings(int brandid)
        //{
        //    return _service.GetItemSettings(brandid);
        //}

        [HttpGet("{id}")]
        public DeliveryBLL Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        [Route("insert")]
        public int Post([FromBody] DeliveryBLL obj)
        {
            return _service.Insert(obj);
        }

        [HttpPost]
        [Route("update")]
        public int PostUpdate([FromBody] ReservationBLL obj)
        {
            return _service.Update(obj);
        }
        [HttpPost]
        [Route("reject")]
        public int RejectUpdate([FromBody] ReservationBLL obj)
        {
            return _service.Reject(obj);
        }


        [HttpPost]
        [Route("delete")]
        public int PostDelete([FromBody] DeliveryBLL obj)
        {
            return _service.Delete(obj);
        }
    }
}
