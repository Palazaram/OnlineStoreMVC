using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;


namespace OnlineStore.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Не вказано назву продукту")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Довжина назви має бути від 3 до 100 символів")]
        [Display(Name = "Назва продукту")]
        public string? ProductName { get; set; }

        [Display(Name = "Опис продукту")]
        [StringLength(450, MinimumLength = 0, ErrorMessage = "Довжина опису має бути від 5 до 450 символів")]
        public string? ProductDescription { get; set; }

        [Required(ErrorMessage = "Ціна товару не вказана")]
        [Display(Name = "Ціна продукту")]
        [Range(0, 100000, ErrorMessage = "Ціна не може бути менше 0 та більше 100000")]
        public decimal ProductPrice { get; set; }

        [NotMapped]
        public IFormFile? ProductImage { get; set; }

        public string? ProductImageName { get; set; }

        [Required(ErrorMessage = "Не вказано категорію продукту")]
        [Display(Name = "Категорія продукту")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        [Required(ErrorMessage = "Не вказано постачальника продукту")]
        [Display(Name = "Постачальник продукту")]
        public int SupplierId { get; set; }
        public virtual Supplier? Supplier { get; set; }



        public virtual ICollection<OrderList>? OrderList { get; set; }

        public virtual ICollection<CartDetail>? CartDetails { get; set; }
    }
}