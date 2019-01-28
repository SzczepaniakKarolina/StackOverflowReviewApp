using Newtonsoft.Json;
using System.Collections.Generic;

namespace StackoverflowReviewApp.Models
{
    public class Request<T>
    {
        public IList<T> Items { get; set; }

        [JsonProperty(PropertyName = "has_more")]
        public bool HasMore { get; set; }
    }
}
