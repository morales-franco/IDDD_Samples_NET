﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaaSOvation.Common.Domain.Model;
using SaaSOvation.Collaboration.Domain.Model.Tenants;
using SaaSOvation.Collaboration.Domain.Model.Collaborators;

namespace SaaSOvation.Collaboration.Domain.Model.Forums
{
    public class ForumModeratorChanged : IDomainEvent
    {
        public ForumModeratorChanged(Tenant tenantId, ForumId forumId, Moderator moderator,string exclusiveOwner)
        {
            this.TenantId = tenantId;
            this.ForumId = forumId;
            this.Moderator = moderator;
            this.ExclusiveOwner = exclusiveOwner;
        }

        public Tenant TenantId { get; private set; }
        public ForumId ForumId { get; private set; }
        public Moderator Moderator { get; private set; }
        public string ExclusiveOwner { get; private set; }

        public int EventVersion { get; set; }
        public DateTime OccurredOn { get; set; }
    }
}
