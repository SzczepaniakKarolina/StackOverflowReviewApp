using Microsoft.Extensions.Caching.Memory;
using StackoverflowReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace StackoverflowReviewApp.Services
{
    public class TagsService : ITagsService
    {
        private const string TAGS_KEY = "TAGS_KEY";
        private const int TAGS_AMOUNT = 1000;

        private TagsHTTPService tagsService;
        private IMemoryCache cache;

        public TagsService(TagsHTTPService tagsService, IMemoryCache cache)
        {
            this.tagsService = tagsService;
            this.cache = cache;
        }

        public IList<TagViewModel> Get()
        {
            if (!cache.TryGetValue(TAGS_KEY, out List<TagViewModel> tagsViewModels))
            {
                var tags = tagsService.GetTagsAsync(TAGS_AMOUNT).Result;

                tagsViewModels = ConvertToTagViewModel(tags);
                if (tagsViewModels.Any())
                {
                    cache.Set(TAGS_KEY, tagsViewModels);
                }
            }
            return tagsViewModels;
        }

        private List<TagViewModel> ConvertToTagViewModel(IList<Tag> tags)
        {
            var tagsCount = tags.Sum(t => t.Count);
            return tags.Where(t => t != null)
            .Select(t => new TagViewModel()
            {
                Name = t.Name,
                Count = t.Count,
                Average = GetTagRate(tagsCount, t.Count)
            }).ToList();
        }

        private decimal GetTagRate(long globalCount, long count)
        {
            return Math.Round(Decimal.Divide(count, globalCount) * 100, 2);
        }
    }

    public interface ITagsService
    {
        IList<TagViewModel> Get();
    }
}
