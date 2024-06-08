namespace ecomove_web_service.VehicleManagement.Interfaces.REST.Resources;

public record CreateEcoVehicleResource(string Model, string Type, int BatteryLevel, double Latitude, double Longitude, string Status, string ImageUrl);