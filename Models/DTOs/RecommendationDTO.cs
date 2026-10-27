namespace Travel_Logger_API_api_tvrdna.Models.DTOs;

public class RecommendationDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int UserId { get; set; }
    public UserDTO? User { get; set; }
    public int CityId { get; set; }
    public CityDTO? City { get; set; }
    public string RecBody { get; set; }
}
