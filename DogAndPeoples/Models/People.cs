using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DogAndPeoples.Models
{
    public class People
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(100, ErrorMessage = "no máximo 100 caracteres")]
        [Display(Name = "Nome do dono do cachorro")]
        public string Name { get; set; }
        public virtual ICollection<Dog> Dogs { get; set; }

    }
}