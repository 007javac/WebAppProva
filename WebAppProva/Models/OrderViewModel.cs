using System.ComponentModel.DataAnnotations;

namespace WebAppProva.Models
{
    public class OrderViewModel
    {
        [Display(Name = "Первое блюдо")]
        [Required(ErrorMessage = "Выберите первое блюдо")]
        public string FirstCourse { get; set; }

        [Display(Name = "Второе блюдо")]
        [Required(ErrorMessage = "Выберите второе блюдо")]
        public string SecondCourse { get; set; }

        [Display(Name = "Напиток")]
        [Required(ErrorMessage = "Выберите напиток")]
        public string Drink { get; set; }
        public double TotalPrice { get; set; }

    }
}