﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel;
using System.Reflection;

namespace System.Web.Http.Internal
{
    internal static class ParameterInfoExtensions
    {
        public static bool TryGetDefaultValue(this ParameterInfo parameterInfo, out object value)
        {
            if (parameterInfo == null)
            {
                throw Error.ArgumentNull("parameterInfo");
            }

            // this will get the default value as seen by the VB / C# compilers
            // if no value was baked in, RawDefaultValue returns DBNull.Value
            object defaultValue = parameterInfo.DefaultValue;
            if (defaultValue != DBNull.Value)
            {
                value = defaultValue;
                return true;
            }

            // if the compiler did not bake in a default value, check the [DefaultValue] attribute
            DefaultValueAttribute[] attrs = (DefaultValueAttribute[])parameterInfo.GetCustomAttributes(typeof(DefaultValueAttribute), false);
            if (attrs == null || attrs.Length == 0)
            {
                value = default(object);
                return false;
            }
            else
            {
                value = attrs[0].Value;
                return true;
            }
        }
    }
}
