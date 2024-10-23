using RealEstateDapper.API.DTOs.ToDoListDtos;

namespace RealEstateDapper.API.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoListAsync();
        Task<GetByIDToDoListDto> GetToDoList(int id);
        Task CreateteToDoList(CreateToDoListDto createToDoListDto);
        Task DeleteteToDoList(int id);
        Task UpdateteToDoList(UpdateToDoListDto updateToDoListDto);
    }
}
