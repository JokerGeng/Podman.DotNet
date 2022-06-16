using Podman.DotNet.Helper;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Podman.DotNet.Models
{
    [DataContract]
    public class ImagesListParameters // (main.ImagesListParameters)
    {
        [QueryStringParameter("all", false, typeof(BoolQueryStringConverter))]
        public bool? All { get; set; }

        [QueryStringParameter("filters", false, typeof(MapQueryStringConverter))]
        public IDictionary<string, IDictionary<string, bool>> Filters { get; set; }
    }
}
