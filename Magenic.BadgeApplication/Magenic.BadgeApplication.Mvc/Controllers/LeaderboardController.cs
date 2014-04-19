﻿using Magenic.BadgeApplication.BusinessLogic.AccountInfo;
using Magenic.BadgeApplication.BusinessLogic.Activity;
using Magenic.BadgeApplication.BusinessLogic.Badge;
using Magenic.BadgeApplication.Common.Enums;
using Magenic.BadgeApplication.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Magenic.BadgeApplication.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public partial class LeaderboardController
        : BaseController
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<ActionResult> Index()
        {
            var leaderboardCollection = await LeaderboardCollection.GetLeaderboardAsync();
            var leaderboardIndexViewModel = new LeaderboardIndexViewModel();
            var allBadges = await BadgeCollection.GetAllBadgesByTypeAsync(BadgeType.Unset);

            leaderboardIndexViewModel.TopTenCorporateBadgeHolders = leaderboardCollection
                .OrderByDescending(li => li.EarnedCorporateBadgeCount)
                .Take(10);

            leaderboardIndexViewModel.TopTenCommunityBadgeHolders = leaderboardCollection
                .OrderByDescending(li => li.EarnedCommunityBadgeCount)
                .Take(10);

            leaderboardIndexViewModel.TotalCorporateBadgeCount = allBadges
                .Where(bi => bi.Type == BadgeType.Corporate)
                .Count();

            if (leaderboardIndexViewModel.TotalCorporateBadgeCount == 0)
            {
                leaderboardIndexViewModel.TotalCorporateBadgeCount = 1;
            }

            leaderboardIndexViewModel.TotalCommunityBadgeCount = allBadges
                .Where(bi => bi.Type == BadgeType.Community)
                .Count();

            if (leaderboardIndexViewModel.TotalCommunityBadgeCount == 0)
            {
                leaderboardIndexViewModel.TotalCommunityBadgeCount = 1;
            }

            return View(leaderboardIndexViewModel);
        }

        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<ActionResult> Rank()
        {
            var leaderboardCollection = await LeaderboardCollection.GetLeaderboardAsync();
            var leaderboardRankViewModel = new LeaderboardRankViewModel();
            var allBadges = await BadgeCollection.GetAllBadgesByTypeAsync(BadgeType.Unset);

            leaderboardRankViewModel.CorporateBadgeHolders = leaderboardCollection
                .OrderByDescending(li => li.EarnedCorporateBadgeCount);

            leaderboardRankViewModel.CommunityBadgeHolders = leaderboardCollection
                .OrderByDescending(li => li.EarnedCommunityBadgeCount);

            leaderboardRankViewModel.TotalCorporateBadgeCount = allBadges
                .Where(bi => bi.Type == BadgeType.Corporate)
                .Count();

            if (leaderboardRankViewModel.TotalCorporateBadgeCount == 0)
            {
                leaderboardRankViewModel.TotalCorporateBadgeCount = 1;
            }

            leaderboardRankViewModel.TotalCommunityBadgeCount = allBadges
                .Where(bi => bi.Type == BadgeType.Community)
                .Count();

            if (leaderboardRankViewModel.TotalCommunityBadgeCount == 0)
            {
                leaderboardRankViewModel.TotalCommunityBadgeCount = 1;
            }

            return View(leaderboardRankViewModel);
        }

        /// <summary>
        /// Searches this instance.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <returns></returns>
        [HttpPost]
        public virtual async Task<ActionResult> Search(string searchText)
        {
            var leaderboardItems = await LeaderboardCollection.SearchLeaderboardAsync(searchText);
            if (leaderboardItems.Count() == 1)
            {
                var leaderboardItem = leaderboardItems.First();
                return RedirectToAction("Show", new { userName = leaderboardItem.EmployeeADName });
            }

            return View(leaderboardItems);
        }

        /// <summary>
        /// Views the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        public virtual async Task<ActionResult> Show(string userName)
        {
            var leaderboardItem = await LeaderboardItem.GetLeaderboardForUserName(userName);
            return View(leaderboardItem);
        }

        /// <summary>
        /// Compares the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        public virtual async Task<ActionResult> Compare(string userName)
        {
            var leftLeaderboardItem = await LeaderboardItem.GetLeaderboardForUserName(AuthenticatedUser.UserName);
            var rightLeaderboardItem = await LeaderboardItem.GetLeaderboardForUserName(userName);
            var allBadges = await BadgeCollection.GetAllBadgesByTypeAsync(BadgeType.Unset);
            var allActivities = await ActivityCollection.GetAllActivitiesAsync(false);

            var leaderboardCompareViewModel = new LeaderboardCompareViewModel();
            leaderboardCompareViewModel.LeftLeaderboardItem = leftLeaderboardItem;
            leaderboardCompareViewModel.RightLeaderboardItem = rightLeaderboardItem;
            leaderboardCompareViewModel.AllBadges = allBadges;
            leaderboardCompareViewModel.AllActivities = allActivities;

            return View(leaderboardCompareViewModel);
        }
    }
}