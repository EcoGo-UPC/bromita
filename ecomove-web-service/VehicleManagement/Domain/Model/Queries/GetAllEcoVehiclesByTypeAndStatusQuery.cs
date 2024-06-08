namespace ecomove_web_service.VehicleManagement.Domain.Model.Queries;

public record GetAllEcoVehiclesByTypeAndStatusQuery(string Type, string Status);