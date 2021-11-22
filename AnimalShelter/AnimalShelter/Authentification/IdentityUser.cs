﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Authentification
{
    public class IdentityUser<T> where T : IEquatable<T>
    {
        [PersonalData]
        public virtual T Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string NormalizedUserName { get; set; }

        [ProtectedPersonalData]
        public virtual string Email { get; set; }
        public virtual string NormalizedEmail { get; set; }
        [PersonalData]
        public virtual bool EmailConfirmed { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual string ConcurrencyStamp { get; set;}
        [ProtectedPersonalData]
        public virtual string PhoneNumber { get; set; }
        [PersonalData]
        public virtual bool PhoneNumberConfirmed { get; set; }
        [PersonalData]
        public virtual bool TwoFactorEnabled { get; set; }
        public virtual DateTimeOffset? LockoutEnd { get; set; }
        public virtual bool LockoutEnabled { get; set; }
        public virtual int AccessFailedCount { get; set; }
    }
}
