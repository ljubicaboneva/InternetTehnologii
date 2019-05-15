using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_Lab_3.Models
{
    public class Friend
    {
        public int id { get; set; }

        [Required(ErrorMessage ="Id is required!")]
        [Range(0,200,ErrorMessage ="Id must be between 0 and 200")]
        public int ID_{ get; set; }

        [Required(ErrorMessage ="Name is required!")]
        public string Ime { get; set; }

        [Required(ErrorMessage ="Place is required!")]
        public string MestoZiveenje { get; set; }
        
        
    }
}