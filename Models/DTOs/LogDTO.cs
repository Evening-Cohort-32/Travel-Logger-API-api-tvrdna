namespace Travel_Logger_API_api_tvrdna.Models.DTOs;

public class LogDTO
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public UserDTO? User { get; set; }
    public int CityId { get; set; }
    public CityDTO? City { get; set; }
    public string LogBody { get; set; }
}
