using MDC.Server.Domain.Commons;

namespace MDC.Server.Domain.Entities.Communities;

public  class CommunityImage : Auditable<long>
{
    public long Size { get; set; }
    public string Name { get; set; }
    public string Path { get; set; }
    public string Type { get; set; }
    public string Extension { get; set; }
    public long CommunityId {  get; set; }
    public Community Community { get; set; }
}
