using MedicineWebApi.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MedicineWebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    //[EnableCors("AllowOrigin")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        static List<MedicineModel> listMedicineContainer = null;
        const string NO_MEDICINE_FOUND = "No Medicine found";
         static MedicineController()
        {
            listMedicineContainer=new List<MedicineModel>();
        }

        // GET: api/<MedicineController>
        [HttpGet]
        public IActionResult Get()
        {
            if (listMedicineContainer.Count > 0)
            {
                return Ok(new { Value = listMedicineContainer });
            }
            else
            {
                return Ok(new { Value = NO_MEDICINE_FOUND });
            }
        }

        // GET api/<MedicineController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (listMedicineContainer.Any(p => p.Id.Equals(id)))
            {
                return Ok(new { Value = listMedicineContainer.Where(p => p.Id.Equals(id)).ToList() });
            }
            else
            {
                return Ok(new { Value = NO_MEDICINE_FOUND });
            }


        }

        // POST api/<MedicineController>
        [HttpPost]
        public void Post([FromBody] MedicineModel value)
        {
            if (ModelState.IsValid)
            {
                MedicineModel medicineModel = new MedicineModel();
                medicineModel.Id = value.Id;
                medicineModel.Name = value.Name;
                medicineModel.Brand = value.Brand;
                medicineModel.Price = Convert.ToSingle(value.Price.ToString("0.00"));
                medicineModel.Quantity = value.Quantity;
                medicineModel.ExpiryDate = value.ExpiryDate;
                medicineModel.Notes = value.Notes;

                listMedicineContainer.Add(medicineModel);

            }





        }

        // PUT api/<MedicineController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MedicineController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
