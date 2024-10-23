﻿using System.ComponentModel.DataAnnotations;

namespace WebAppProva.Models
{
    public class OrderViewModel
    {
        [Display(Name = "Первое блюдо")]
        [Required(ErrorMessage = "Выберите первое блюдо")]
        public string FirstCourse { get; set; }
        public string MainCourse { get; set; }
        public string Drink { get; set; }
        public string TotalPrice { get; set; }

    }
}