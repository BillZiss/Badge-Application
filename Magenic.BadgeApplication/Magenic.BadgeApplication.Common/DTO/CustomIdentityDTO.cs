﻿using System;
using System.Collections.Generic;

namespace Magenic.BadgeApplication.Common.DTO
{
    /// <summary>
    /// Data Transfer Object for the CustomIdentity
    /// </summary>
    public sealed class CustomIdentityDTO
    {
        /// <summary>
        /// Creates a new instance of the <see cref="CustomIdentityDTO"/>.
        /// </summary>
        public CustomIdentityDTO()
        {
            this.Roles = new List<string>();
        }

        /// <summary>
        /// The Id for this identity.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The AD name for the identity.
        /// </summary>
        public string ADName { get; set; }
        /// <summary>
        /// An enumerable of <see cref="string"/> for all the roles the user is in.
        /// </summary>
        public IEnumerable<string> Roles { get; set; }

    }
}
