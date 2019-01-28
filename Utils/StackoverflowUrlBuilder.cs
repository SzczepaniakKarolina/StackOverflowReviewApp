using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;

namespace StackoverflowReviewApp.Utils
{
    public class StackoverflowUrlBuilder
    {
        private const string BASE_URL = "https://api.stackexchange.com/2.2/";

        private Dictionary<string, string> query;
        private readonly string pageKey;

        public StackoverflowUrlBuilder(string pageKey)
        {
            this.pageKey = pageKey ?? throw new ArgumentNullException(nameof(pageKey));
            query = new Dictionary<string, string>();
        }

        public void SetQuery(Dictionary<string, string> query)
        {
            this.query = query;
        }

        public void UpdateQuery(string key, string value)
        {
            if (!String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
            {
                query[key] = value;
            }
        }

        public string GetURL()
        {
            var url = String.Format("{0}{1}", BASE_URL, pageKey);
            if (query.Count > 0)
            {
                url = QueryHelpers.AddQueryString(url, query); ;
            }
            return url;
        }
    }
}
