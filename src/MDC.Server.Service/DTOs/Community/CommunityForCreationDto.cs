namespace MDC.Server.Service.DTOs.Community;

public  class CommunityForCreationDto
{
    public string Bio { get; set; }
    public string Logo { get; set; }
    public string Title { get; set; }
    public string Banner { get; set; }
    public long ?ParentId { get; set; }
    public string Description { get; set; }
}
