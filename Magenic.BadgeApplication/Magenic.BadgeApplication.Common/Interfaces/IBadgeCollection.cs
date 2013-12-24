﻿using Csla;

namespace Magenic.BadgeApplication.Common.Interfaces
{
    /// <summary>
    /// A read only list of badge information.
    /// </summary>
    public interface IBadgeCollection : IReadOnlyListBase<IBadgeItem>
    {
    }
}
