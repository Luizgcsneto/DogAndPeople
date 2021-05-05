using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DogAndPeoples.Models
{
    public class Dog
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(100, ErrorMessage = "no máximo 100 caracteres")]
        [Display(Name = "Nome do cachorro(a)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(100, ErrorMessage = "no máximo 100 caracteres")]
        [Display(Name = "Raça do cachorro(a)")]
        public string Race { get; set; }
        [Display(Name = "Nome do dono(a)")]
        public int PeopleId { get; set; }
      
        public People People { get; set; }

    }
}