using System;
using System.Collections.Generic;
using System.Text;

namespace Podman.DotNet.Helper
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class QueryStringParameterAttribute : Attribute
    {
        public string Name { get; private set; }

        public bool IsRequired { get; private set; }

        public Type ConverterType { get; private set; }

        public QueryStringParameterAttribute(string name, bool required) : this(name, required, null)
        {
        }

        public QueryStringParameterAttribute(string name, bool required, Type converterType)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (converterType != null && converterType.GetInterface(nameof(IQueryStringConverter)) == null)
            {
                throw new ArgumentException($"Provided query string converter type is not {typeof(IQueryStringConverter).FullName}", nameof(converterType));
            }

            this.Name = name;
            this.IsRequired = required;
            this.ConverterType = converterType;
        }
    }

}
