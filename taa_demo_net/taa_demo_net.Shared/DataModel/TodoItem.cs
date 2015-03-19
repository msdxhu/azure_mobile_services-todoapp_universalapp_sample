using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace taa_demo_net
{
    public class TodoItem
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }
        
        [JsonProperty(PropertyName = "duedate")]
        public DateTime? DueDate { get; set; }

        [JsonProperty(PropertyName = "overdue")]
        public bool Overdue { get; set; }

        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }

        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }

        [JsonProperty(PropertyName = "sasQueryString")]
        public string SasQueryString { get; set; }

        [JsonProperty(PropertyName = "imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty(PropertyName = "userId")]        
        public string UserId { get; set; }
    }
}
