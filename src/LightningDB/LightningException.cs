﻿using System;
using System.Runtime.InteropServices;
using LightningDB.Native;

namespace LightningDB
{
    public class LightningException : Exception
    {
        private static string GetMessageByCode(int code)
        {
            var ptr = NativeMethods.Library.mdb_strerror(code);
            return Marshal.PtrToStringAnsi(ptr);
        }

        internal LightningException(int code)
            : base (GetMessageByCode(code))
        { }
    }
}
