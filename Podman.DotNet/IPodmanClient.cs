using Podman.DotNet.Endpoints;
using System;
using System.Collections.Generic;
using System.Text;

namespace Podman.DotNet
{
    public interface IPodmanClient
    {
        IContainerOperations Containers { get; }

        IImageOperations Images { get; }

    }
}
