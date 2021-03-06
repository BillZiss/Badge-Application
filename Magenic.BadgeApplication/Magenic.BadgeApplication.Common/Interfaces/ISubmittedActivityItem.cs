﻿using Csla;
using System;

namespace Magenic.BadgeApplication.Common.Interfaces
{
    /// <summary>
    /// A read only activity that a user has submitted.
    /// </summary>
    public interface ISubmittedActivityItem : IReadOnlyBase
    {
        /// <summary>
        /// The Id for this activity submission.
        /// </summary>
        int Id { get; }
        /// <summary>
        /// Gets the activity identifier.
        /// </summary>
        int ActivityId { get; }
        /// <summary>
        /// The name of the activity maps to type on UX mocks.
        /// </summary>
        string ActivityName { get; }
        /// <summary>
        /// The date the activity occurred, should be set and saved in UTC.
        /// </summary>
        DateTime ActivitySubmissionDate { get; }
        /// <summary>
        /// Any notes associated with this submission.
        /// </summary>
        string SubmissionNotes { get; }
        /// <summary>
        /// The employee Id of the person who this badge submission is for.  
        /// This should be the same as the name of the identity.
        /// </summary>
        int EmployeeId { get; }
        /// <summary>
        /// The current status of this activity submission.
        /// </summary>
        Enums.ActivitySubmissionStatus Status { get; }
        /// <summary>
        /// The Id of the user who approved this activity.  Blank if the 
        /// activity status is approved and no managerial approval is required.
        /// </summary>
        int ApprovedById { get; }
    }
}
