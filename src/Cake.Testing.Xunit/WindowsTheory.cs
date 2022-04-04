﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Cake.Core;
using Cake.Core.Polyfill;
using Xunit;

namespace Cake.Testing.Xunit
{
    public sealed class WindowsTheory : TheoryAttribute
    {
        private static readonly PlatformFamily _family;

        static WindowsTheory()
        {
            _family = EnvironmentHelper.GetPlatformFamily();
        }

        // ReSharper disable once UnusedParameter.Local
        public WindowsTheory(bool invert = false, string reason = null)
        {
            if ((_family != PlatformFamily.Windows) ^ invert)
            {
                Skip = reason ?? (invert ? "Non-Windows test" : "Windows test.");
            }
        }
    }
}