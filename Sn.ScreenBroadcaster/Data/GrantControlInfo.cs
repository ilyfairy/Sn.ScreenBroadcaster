﻿using System.Runtime.InteropServices;

namespace Sn.ScreenBroadcaster.Data;

[StructLayout(LayoutKind.Sequential)]
public struct GrantControlInfo
{
    public bool IsAdministrator;
}