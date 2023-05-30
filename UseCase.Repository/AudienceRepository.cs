using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Entity;

namespace UseCase.Repository
{
    public class AudienceRepository : IAudienceRepository
    {
        // Create list for the Audiences
        //_listAudiences can store a collection of 'Audience' objects
        public List<Audience> _listAudience;

        // This is a constructor for the AudienceRepository class that is called when an object of a class is created.
        public AudienceRepository()
        {
            // It has a function to create a new instance of List<Audience> using the new keyword and assign it to '_listAudience'
            _listAudience = new List<Audience>();

            //Audience audience1 = new Audience { Id = "1", Name = "Veli", SeatNumber = "001" };
            //Audience audience2 = new Audience { Id = "2", Name = "Felix", SeatNumber = "002" };
            //Audience audience3 = new Audience { Id = "3", Name = "Winnie", SeatNumber = "003" };
            Audience audience1 = new Audience { Id = 1, Name = "Veli", SeatNumber = 001 };
            Audience audience2 = new Audience { Id = 2, Name = "Felix", SeatNumber = 002 };
            Audience audience3 = new Audience { Id = 3, Name = "Winnie", SeatNumber = 003 };

            // Adding the audience object to the list of '_listAudience'
            _listAudience.Add(audience1);
            _listAudience.Add(audience2);
            _listAudience.Add(audience3);
        }

        public void Insert(Audience audience)
        {
            _listAudience.Add(audience);
        }

        public void Delete(Audience audience)
        {
            _listAudience.Remove(audience);
        }

        public List<Audience> GetListAudience()
        {
            return _listAudience;
        }
    }
}
