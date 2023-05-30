using UseCase.Entity;
using UseCase.Repository;

namespace UseCase.Service;

public class AudienceService : IAudienceService
{
    // Service needs a Repository, so here's we have to declare the repository into a variable called ''
    public IAudienceRepository _audienceRepository;

    // This is a constructor for the AudienceService class that used 'IAudienceRepository' object as a parameter.
    // The constructor has a function to initialize '_audienceRepository' property. When an object of the 'AudienceService'
    // class is created, the constructor is called and the provided 'IAudienceRepository' object is assigned to the 
    // '_audienceRepository property.
    public AudienceService(IAudienceRepository audienceRepository)
    {
        _audienceRepository = audienceRepository;
    }

    public AudienceService()
    {
    }

    public void Insert(Audience audience)
    {
        _audienceRepository.Insert(audience);
    }

    public void Delete(Audience audience)
    {
        _audienceRepository.Delete(audience);
    }

    public List<Audience> GetListAudience()
    {
        return this._audienceRepository.GetListAudience();
    }
}