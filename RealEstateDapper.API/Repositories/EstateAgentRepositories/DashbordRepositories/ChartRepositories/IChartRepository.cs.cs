using RealEstateDapper.API.DTOs.ChartDtors;

namespace RealEstateDapper.API.Repositories.EstateAgentRepositories.DashbordRepositories.ChartRepositories
{
    public interface IChartRepository
    {
        Task<List<ResultChartDto>> Get5CityForChart();
    }
}
