using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// In this class we'll make the entity for every class in this project

namespace UseCase.Entity
{
    public class Audience
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeatNumber { get; set; }
        public bool IsDeleted { get; set; }

        public bool IsDeleting = false;


        // This is an empty constructor.
        public Audience()
        {

        }
    }
}