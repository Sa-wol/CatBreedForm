using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatBreedForm.Models
{
    public class Cat
    {
        /// <summary>
        /// The unique identifier for a owner's cat
        /// </summary>
        public int CatId { get; set; }

        /// <summary>
        /// The owner's first and last name
        /// </summary>
        [Display(Name = "Owner's Name")]
        [Required(ErrorMessage = "Please enter valid first and last name. Ex: John Doe")]
        public string OwnerName { get; set; }

        /// <summary>
        /// The cat's name
        /// </summary>
        [Display(Name = "Cat's Name")]
        [Required(ErrorMessage = "Please enter valid name for cat. Ex: Meow Meow")]
        public string CatName { get; set; }

        /// <summary>
        /// The cat's birth date (guesstimates are valid)
        /// </summary>
        [Display(Name = "Cat's Date of Birth")]
        public DateTime CatBirthDate { get; set; }

        /// <summary>
        /// The cat's specific breed
        /// </summary>
        [Display(Name = "Cat Breed")]
        [Required(ErrorMessage = "Please enter valid cat breed. Ex: Bengal")]
        public string CatBreed { get; set; }
    }
}