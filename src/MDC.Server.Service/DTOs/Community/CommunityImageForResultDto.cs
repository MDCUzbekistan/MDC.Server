namespace MDC.Server.Service.DTOs.Community;

public  class CommunityImageForResultDto
{
    public long Id { get; set; }
    public long Size { get; set; }
    public string Name { get; set; }
    public string Path { get; set; }
    public string Type { get; set; }
    public long ChannelId { get; set; }
    public string Extension { get; set; }
}
