using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;
using ecomove_web_service.VehicleManagement.Domain.Model.Queries;
using ecomove_web_service.VehicleManagement.Domain.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Services;

namespace ecomove_web_service.VehicleManagement.Application.Internal.QueryServices;

public class EcoVehicleQueryService(IEcoVehicleRepository ecoVehicleRepository) : IEcoVehicleQueryService
{
    public async Task<EcoVehicle?> Handle(GetEcoVehicleByEcoVehicleIdQuery query)
    {
        return await ecoVehicleRepository.FindEcoVehicleByEcoVehicleIdAsync(query.EcoVehicleId);
    }
    
    public async Task<IEnumerable<EcoVehicle>> Handle(GetAllEcoVehiclesQuery query)
    {
        return await ecoVehicleRepository.FindAllEcoVehiclesAsync();
    }
    
    public async Task<IEnumerable<EcoVehicle>> Handle(GetAllEcoVehiclesByTypeAndModelQuery query)
    {
        return await ecoVehicleRepository.FindAllEcoVehiclesByTypeAndModelAsync(query.Type, query.Model);
    }
    
    public async Task<IEnumerable<EcoVehicle>> Handle(GetAllEcoVehiclesByBatteryLevelGreaterThanQuery query)
    {
        return await ecoVehicleRepository.FindAllEcoVehiclesByBatteryLevelGreaterThanAsync(query.BatteryLevel);
    }
    
    public async Task<IEnumerable<EcoVehicle>> Handle(GetAllEcoVehiclesByTypeAndStatusQuery query)
    {
        return await ecoVehicleRepository.FindAllEcoVehiclesByTypeAndStatusAsync(query.Type, query.Status);
    }
    
    public async Task<IEnumerable<EcoVehicle>> Handle(GetAllEcoVehiclesByTypeQuery query)
    {
        return await ecoVehicleRepository.FindAllEcoVehiclesByTypeAsync(query.Type);
    }
}