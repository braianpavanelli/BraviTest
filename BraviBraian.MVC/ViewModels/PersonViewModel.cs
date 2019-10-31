using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BraviBraian.MVC.ViewModels
{
    public class PersonViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo 150 caracteres")]
        [MinLength(3, ErrorMessage = "Minimo 3 caracteres")]
        public virtual string Name { get; set; }

        public virtual ICollection<ContactViewModel> Contacts { get; set; }
    }
}