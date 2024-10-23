using RealEstateDapper.API.DTOs.MessageDtos;

namespace RealEstateDapper.API.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        Task<List<ResultInBoxMessageDto>> GetInboxLast3MessageListByReceiver(int id);
    }
}
