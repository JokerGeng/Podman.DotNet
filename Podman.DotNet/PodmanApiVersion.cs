using System;
using System.Collections.Generic;
using System.Text;

namespace Podman.DotNet
{
    public enum PodmanApiType
    {
        v3,
        v4,
    }

    public static class PodmanApiVersion
    {
        public const string PodmanApiV3 = "v3.0.0/libpod";
        public const string PodmanApiV4 = "v4.0.0/libpod";
    }
}
