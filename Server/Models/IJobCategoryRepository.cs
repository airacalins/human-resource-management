using HumanResourceManagement.Shared.Domain;

namespace HumanResourceManagement.Api.Models
{
  public interface IJobCategoryRepository
  {
    IEnumerable<JobCategory> GetAllJobCategories();
    JobCategory GetJobCategoryById(int jobCategoryId);
  }
}
