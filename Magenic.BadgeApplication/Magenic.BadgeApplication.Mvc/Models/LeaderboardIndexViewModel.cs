﻿using Magenic.BadgeApplication.Common.Interfaces;
using System.Collections.Generic;

namespace Magenic.BadgeApplication.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class LeaderboardIndexViewModel
    {
        /// <summary>
        /// Gets or sets the top ten corporate badges.
        /// </summary>
        public IEnumerable<ILeaderboardItem> TopTenCorporateBadgeHolders { get; set; }

        /// <summary>
        /// Gets or sets the top ten community badges.
        /// </summary>
        public IEnumerable<ILeaderboardItem> TopTenCommunityBadgeHolders { get; set; }

        /// <summary>
        /// Gets or sets the total corporate badge count.
        /// </summary>
        public int TotalCorporateBadgeCount { get; set; }

        /// <summary>
        /// Gets or sets the total community badge count.
        /// </summary>
        public int TotalCommunityBadgeCount { get; set; }
    }
}