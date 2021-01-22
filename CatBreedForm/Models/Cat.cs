using System;
using System.Collections.Generic;
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
        public string OwnerName { get; set; }

        /// <summary>
        /// The cat's name
        /// </summary>
        public string CatName { get; set; }

        /// <summary>
        /// The cat's birth date (guesstimates are valid)
        /// </summary>
        public DateTime CatBirthDate { get; set; }

        /// <summary>
        /// The cat's specific breed
        /// </summary>
        public string CatBreed { get; set; }
    }
}