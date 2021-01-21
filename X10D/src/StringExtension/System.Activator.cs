using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Remoting;

namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="Activator.CreateInstance(string,string,bool,BindingFlags,Binder,object[],CultureInfo,object[])"/>
        public static ObjectHandle? CreateInstance(
            this string assemblyName,
            string typeName,
            bool ignoreCase = false,
            BindingFlags bindingAttr = BindingFlags.Default,
            Binder? binder = null,
            object?[]? args = null,
            CultureInfo? culture = null,
            object?[]? activationAttributes = null) =>
            Activator.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);

        /// <inheritdoc cref="Activator.CreateInstance(string,string,bool,BindingFlags,Binder,object[],CultureInfo,object[])"/>
        public static ObjectHandle? CreateInstanceFrom(
            string assemblyFile,
            string typeName,
            bool ignoreCase = false,
            BindingFlags bindingAttr = BindingFlags.Default,
            Binder? binder = null,
            object?[]? args = null,
            CultureInfo? culture = null,
            object?[]? activationAttributes = null) =>
            Activator.CreateInstanceFrom(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
    }
}