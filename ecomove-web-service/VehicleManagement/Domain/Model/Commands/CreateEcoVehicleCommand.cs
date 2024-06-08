namespace ecomove_web_service.VehicleManagement.Domain.Model.Commands;

public record CreateEcoVehicleCommand(string Model, string Type, int BatteryLevel, double Latitude, double Longitude, string Status, string ImageUrl);