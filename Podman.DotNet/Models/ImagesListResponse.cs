using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Podman.DotNet.Models
{
    [DataContract]
    public class ImagesListResponse // (types.ImageSummary)
    {
        [DataMember(Name = "ConfigDigest", EmitDefaultValue = false)]
        public string ConfigDigest { get; set; }

        [DataMember(Name = "Containers", EmitDefaultValue = false)]
        public long Containers { get; set; }

        [DataMember(Name = "Created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        [DataMember(Name = "Dangling", EmitDefaultValue = false)]
        public bool Dangling { get; set; }

        [DataMember(Name = "Digest", EmitDefaultValue = false)]
        public string Digest { get; set; }

        [DataMember(Name = "History", EmitDefaultValue = false)]
        public IList<string> History { get; set; }

        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string ID { get; set; }

        [DataMember(Name = "Labels", EmitDefaultValue = false)]
        public IDictionary<string, string> Labels { get; set; }

        [DataMember(Name = "Names", EmitDefaultValue = false)]
        public IList<string> Names { get; set; }

        [DataMember(Name = "ParentId", EmitDefaultValue = false)]
        public string ParentID { get; set; }

        [DataMember(Name = "ReadOnly", EmitDefaultValue = false)]
        public bool ReadOnly { get; set; }

        [DataMember(Name = "RepoDigests", EmitDefaultValue = false)]
        public IList<string> RepoDigests { get; set; }

        [DataMember(Name = "RepoTags", EmitDefaultValue = false)]
        public IList<string> RepoTags { get; set; }

        [DataMember(Name = "SharedSize", EmitDefaultValue = false)]
        public long SharedSize { get; set; }

        [DataMember(Name = "Size", EmitDefaultValue = false)]
        public long Size { get; set; }

        [DataMember(Name = "VirtualSize", EmitDefaultValue = false)]
        public long VirtualSize { get; set; }
    }
}
