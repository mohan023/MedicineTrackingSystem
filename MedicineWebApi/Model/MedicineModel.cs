using System;
using System.ComponentModel.DataAnnotations;

namespace MedicineWebApi.Model
{
    public class MedicineModel
    {
        public int Id { get; set; }
        [Required]
        public string  Name { get; set; }
        [Required]
        public string Brand  { get; set; }
        [Required]

        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public float Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        public string Notes { get; set; }

    }
}
