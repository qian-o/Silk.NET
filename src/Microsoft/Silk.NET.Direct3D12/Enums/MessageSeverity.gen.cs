// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MESSAGE_SEVERITY")]
    public enum MessageSeverity : int
    {
        [Obsolete("Deprecated in favour of \"Corruption\"")]
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_CORRUPTION")]
        MessageSeverityCorruption = 0x0,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_ERROR")]
        MessageSeverityError = 0x1,
        [Obsolete("Deprecated in favour of \"Warning\"")]
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_WARNING")]
        MessageSeverityWarning = 0x2,
        [Obsolete("Deprecated in favour of \"Info\"")]
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_INFO")]
        MessageSeverityInfo = 0x3,
        [Obsolete("Deprecated in favour of \"Message\"")]
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_MESSAGE")]
        MessageSeverityMessage = 0x4,
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_CORRUPTION")]
        Corruption = 0x0,
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_ERROR")]
        Error = 0x1,
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_WARNING")]
        Warning = 0x2,
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_INFO")]
        Info = 0x3,
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_MESSAGE")]
        Message = 0x4,
    }
}
