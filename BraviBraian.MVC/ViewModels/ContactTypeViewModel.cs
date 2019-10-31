using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BraviBraian.MVC.ViewModels
{
    public class ContactTypeViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo 50 caracteres")]
        [MinLength(3, ErrorMessage = "Minimo 3 caracteres")]
        public string Name { get; set; }

        public virtual ICollection<ContactViewModel> Contacts { get; set; }
    }
}