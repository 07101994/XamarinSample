﻿// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using JetBrains.Annotations;
using UIKit;

namespace XamarinSample.iOS
{
    [UsedImplicitly]
    public class Application
    {
        private static void Main(string[] args)
        {
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
