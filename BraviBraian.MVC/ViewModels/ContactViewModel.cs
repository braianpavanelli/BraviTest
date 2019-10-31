using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BraviBraian.MVC.ViewModels
{
    public class ContactViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [MinLength(3, ErrorMessage = "Minimo 3 caracteres")]
        public string Description { get; set; }

        [Display(Name = "Tipo Contato")]
        public int IdContactType { get; set; }

        public ContactTypeViewModel ContactType { get; set; }

        [Display(Name = "Pessoa")]
        public int IdPerson { get; set; }

        public virtual PersonViewModel Person { get; set; }
    }
}