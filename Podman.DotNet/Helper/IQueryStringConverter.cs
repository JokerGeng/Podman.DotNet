using System;
using System.Collections.Generic;
using System.Text;

namespace Podman.DotNet.Helper
{
    internal interface IQueryStringConverter
    {
        bool CanConvert(Type t);

        string[] Convert(object o);
    }
}
