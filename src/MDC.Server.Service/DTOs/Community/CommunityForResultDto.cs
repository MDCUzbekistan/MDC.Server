namespace MDC.Server.Service.DTOs.Community;

public  class CommunityForResultDto
{
    public long  Id { get; set; }
    public string Bio { get; set; }
    public string Logo { get; set; }
    public string Title { get; set; }
    public string Banner { get; set; }
    public long? ParentId { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
   
}
