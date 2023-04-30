using HumanResourceManagement.Shared.Domain;

namespace HumanResourceManagement.Api.Models
{
  public interface ICountryRepository
  {
    IEnumerable<Country> GetAllCountries();
    Country GetCountryById(int countryId);
  }
}
