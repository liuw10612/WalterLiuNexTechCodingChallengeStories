﻿using NexTechCodingChallengeStories.Web.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NexTechCodingChallengeStories.Web.Services.CacheService
{
    public interface ICachedData
    {
        void SetCachedDataOnePage(List<StoryTitle>? _cachedStories);
        List<StoryTitle>? GetCachedStoresOnePage(int _pageNumber, int _pageSize);
        void SetCachedDataAllIds(List<int> _cachedStoriesAllIds);
        List<int> GetCachedStoresAllIds();
        void RemoveOneStory(int storyId);
        public bool NotBadUrlId(int storyId);
    }
}
