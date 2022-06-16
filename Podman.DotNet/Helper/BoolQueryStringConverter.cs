using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Podman.DotNet.Helper
{
    internal class BoolQueryStringConverter : IQueryStringConverter
    {
        public bool CanConvert(Type t)
        {
            return t == typeof(bool);
        }

        public string[] Convert(object o)
        {

            return new[] { System.Convert.ToInt32(System.Convert.ToBoolean(o)).ToString(CultureInfo.InvariantCulture) };
        }
    }
}
