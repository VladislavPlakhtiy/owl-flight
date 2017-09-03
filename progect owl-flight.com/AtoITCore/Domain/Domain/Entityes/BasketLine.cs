using System.ComponentModel.DataAnnotations;

namespace Domain.Entityes
{
        public class BasketLine
        {
            public Product Product { get; set; }

        [Display(Name = "Оберіть розмір")]
        [Required(ErrorMessage = "Будь ласка, оберіть розмір футболки")]
         public string Size { get; set; }
        }
}
