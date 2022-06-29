﻿using System;
using System.IO;
using CTFAK.Utils;
using Joveler.Compression.ZLib;

namespace CTFAK
{
    public class Core
    {
        public static string parameters;
        public static string path;
        public static void Init()
        {
            ZLibInit.GlobalInit("x64\\zlibwapi.dll");


            String libraryFile = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "x64",
                "CTFAK-Native.dll");
            NativeLib.LoadLibrary(libraryFile);
        }
    }
}