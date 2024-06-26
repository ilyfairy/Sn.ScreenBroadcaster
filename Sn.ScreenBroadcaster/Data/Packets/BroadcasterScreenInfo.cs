﻿using System.Runtime.InteropServices;

namespace Sn.ScreenBroadcaster.Data.Packets
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BroadcasterScreenInfo
    {
        public int Width;
        public int Height;
        public int CodecID;
        public int PixelFormat;
    }
}
