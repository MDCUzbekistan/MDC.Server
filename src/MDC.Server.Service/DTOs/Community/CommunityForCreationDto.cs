using Microsoft.AspNetCore.Http;

namespace MDC.Server.Service.DTOs.Community;

public  class CommunityForCreationDto
{
    public string Bio { get; set; }
    public string Title { get; set; }
    public long? ParentId { get; set; }
    public IFormFile Logo { get; set; }
    public IFormFile Banner { get; set; }
    public string Description { get; set; }
    
}
