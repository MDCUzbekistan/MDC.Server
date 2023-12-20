﻿using MDC.Server.Domain.Commons;
using MDC.Server.Domain.Entities.Communities;
using MDC.Server.Domain.Entities.Events;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC.Server.Domain.Entities.Users
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public UserDetail UserDetail { get; set; }

        public ICollection<UserCommunity> UserCommunities { get; set; }
        public ICollection<UserEvent> Events { get; set; }
        public ICollection<UserLanguage> Languages { get; set; }    
    }
}
