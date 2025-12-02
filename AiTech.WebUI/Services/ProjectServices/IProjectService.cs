using AiTech.WebUI.DTOs.ProjectDtos;

namespace AiTech.WebUI.Services.ProjectServices
{
    public interface IProjectService
    {
        Task<List<ResultProjectDto>> GetAllAsync();
        Task<UpdateProjectDto> GettByIdAsync(int id);
        Task CreateAsync(CreateProjectDto projectDto);
        Task UpdateAsync(UpdateProjectDto projectDto);
        Task DeleteAsync(int id);
    }
}
