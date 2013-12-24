﻿using Magenic.BadgeApplication.Common.Interfaces;
using System;

namespace Magenic.BadgeApplication.Common.DTO
{
    /// <summary>
    /// Class for data transfer persist operations.
    /// </summary>
    [Serializable]
    public class EarnedBadgeItemDTO : IEarnedBadgeItemDTO
    {
        /// <summary>
        /// The id of the badge.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of a badge.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The type of the badge, corporate or community.
        /// </summary>
        public Enums.BadgeType Type { get; set; }
        /// <summary>
        /// The path to where the badge's image resides.
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// A quip or funny phrase about the badge.
        /// </summary>
        public string Tagline { get; set; }
        /// <summary>
        /// The date the badge was awarded.
        /// </summary>
        public DateTime AwardDate { get; set; }
        /// <summary>
        /// The number of points, if any, awarded with this badge.
        /// </summary>
        public int AwardPoints { get; set; }
        /// <summary>
        /// Indicates if the award points have been paid out.
        /// </summary>
        public bool PaidOut { get; set; }
    }
}
