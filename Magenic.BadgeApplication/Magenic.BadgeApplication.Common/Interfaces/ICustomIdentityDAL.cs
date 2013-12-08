﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magenic.BadgeApplication.Common.Interfaces
{
    /// <summary>
    /// Data Access Layer interface to load the custom identity object
    /// </summary>
    public interface ICustomIdentityDAL
    {
        /// <summary>
        /// Logs on a Custom Identity.
        /// </summary>
        /// <param name="userName">The user name to log in with.</param>
        /// <param name="password">The unencrypted password to use.</param>
        /// <returns>A <see cref="ICustomIdentityDTO"/> with the information needed to 
        /// load the custom identity.</returns>
        Task<ICustomIdentityDTO> LogOnIdentityAsync(string userName, string password);
    }
}