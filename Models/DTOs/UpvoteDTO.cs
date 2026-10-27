namespace Travel_Logger_API_api_tvrdna.Models.DTOs;

public class UpvoteDTO
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public UserDTO? User { get; set; }
    public int RecommendationId { get; set; }
    public RecommendationDTO? Recommendation { get; set; }
}
