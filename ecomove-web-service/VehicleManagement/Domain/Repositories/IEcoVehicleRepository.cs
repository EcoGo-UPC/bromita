using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;

namespace ecomove_web_service.VehicleManagement.Domain.Repositories;

public interface IEcoVehicleRepository : IBaseRepository<EcoVehicle>
{
    Task<EcoVehicle?> FindEcoVehicleByEcoVehicleIdAsync(int ecoVehicleId);
    
    Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesAsync();
    Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByTypeAndModelAsync(string type, string model);
    Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByTypeAsync(string type);
    Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByTypeAndStatusAsync(string type, string status);
    Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByBatteryLevelGreaterThanAsync(int batteryLevel);
}