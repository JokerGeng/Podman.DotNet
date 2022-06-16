using Podman.DotNet.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Podman.DotNet.Endpoints
{
    public interface IContainerOperations
    {
        Task<IList<ContainerListResponse>> ListContainersAsync(ContainersListParameters parameters, CancellationToken cancellationToken = default(CancellationToken));
    }
}
