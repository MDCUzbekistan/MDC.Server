using MDC.Server.Domain.Commons;

namespace MDC.Server.Domain.Entities.Communities;

public  class CommunityImage : Auditable<long>
{
   
    public  string Image {  get; set; }
    public long CommunityId {  get; set; }
    public Community Community { get; set; }

}
