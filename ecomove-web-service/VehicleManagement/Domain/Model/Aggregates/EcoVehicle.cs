using ecomove_web_service.BookingReservation.Domain.Model.Aggregates;
using ecomove_web_service.VehicleManagement.Domain.Model.Commands;
using ecomove_web_service.VehicleManagement.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;

public partial class EcoVehicle
{
    public EcoVehicle()
    {
        Model = string.Empty;
        Type = string.Empty;
        BatteryLevel = 0;
        Location = new Location(0, 0);
        Status = string.Empty;
        ImageUrl = string.Empty;
    }
    
    public EcoVehicle(string model, string type, int batteryLevel, double latitude, double longitude, string status, string imageUrl)
    {
        Model = model;
        Type = type;
        BatteryLevel = batteryLevel;
        Location = new Location(latitude, longitude);
        Status = status;
        ImageUrl = imageUrl;
    }

    public EcoVehicle(CreateEcoVehicleCommand command)
    {
        Model = command.Model;
        Type = command.Type;
        BatteryLevel = command.BatteryLevel;
        Location = new Location(command.Latitude, command.Longitude);
        Status = command.Status;
        ImageUrl = command.ImageUrl;
    }
    
    public int EcoVehicleId { get; private set; }
    public string Model { get; private set; }
    public string Type { get; private set; }
    public int BatteryLevel { get; private set; }
    public Location Location { get; private set; }
    public string Status { get; private set; }
    public string ImageUrl { get; private set; }
    
    public object FullLocation => Location.GetLocationObject();
    
    public ICollection<Booking> Bookings { get; }
    
}