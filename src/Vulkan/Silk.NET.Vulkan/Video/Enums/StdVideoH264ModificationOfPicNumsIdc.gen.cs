// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH264ModificationOfPicNumsIdc")]
    public enum StdVideoH264ModificationOfPicNumsIdc : int
    {
        [Obsolete("Deprecated in favour of \"ShortTermSubtract\"")]
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_SUBTRACT")]
        StdVideoH264ModificationOfPicNumsIdcShortTermSubtract = 0x0,
        [Obsolete("Deprecated in favour of \"ShortTermAdd\"")]
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_ADD")]
        StdVideoH264ModificationOfPicNumsIdcShortTermAdd = 0x1,
        [Obsolete("Deprecated in favour of \"LongTerm\"")]
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_LONG_TERM")]
        StdVideoH264ModificationOfPicNumsIdcLongTerm = 0x2,
        [Obsolete("Deprecated in favour of \"End\"")]
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_END")]
        StdVideoH264ModificationOfPicNumsIdcEnd = 0x3,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_INVALID")]
        StdVideoH264ModificationOfPicNumsIdcInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_MAX_ENUM")]
        StdVideoH264ModificationOfPicNumsIdcMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_SUBTRACT")]
        ShortTermSubtract = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_ADD")]
        ShortTermAdd = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_LONG_TERM")]
        LongTerm = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_END")]
        End = 0x3,
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
