using Podman.DotNet.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Podman.DotNet.Endpoints
{
    public interface IImageOperations
    {
        Task<IList<ImagesListResponse>> ListImagesAsync(ImagesListParameters parameters, CancellationToken cancellationToken = default(CancellationToken));
    }
}
