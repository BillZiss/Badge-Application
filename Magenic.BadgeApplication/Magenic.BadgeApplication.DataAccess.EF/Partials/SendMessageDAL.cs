﻿using System.Collections.Generic;

namespace Magenic.BadgeApplication.DataAccess.EF
{
#if DEBUG
    public partial class SendMessageDAL
    {
        internal IList<string> _GetEmailAddresses( IList<Employee> peopleToEmail, IList<Employee> employees )
            => getEmailAddresses( peopleToEmail, employees );

        internal void _AddEmailAddress( IList<Employee> employees, int? managerId, IList<string> emailAddresses )
            => addEmailAddress( employees, managerId, emailAddresses );

        internal IList<Employee> _GetEmployees( Entities context )
            => getEmployees( context );

        internal IList<Employee> _GetPeopleToEmail( Entities context )
            => getPeopleToEmail( context );
    }
#endif
}