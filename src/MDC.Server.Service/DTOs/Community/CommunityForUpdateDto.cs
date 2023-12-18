namespace MDC.Server.Service.DTOs.Community;

public  class CommunityForUpdateDto
{
    public string Bio { get; set; }
    public string Title { get; set; }
    public long? ParentId { get; set; }
    public string Description { get; set; }
}
