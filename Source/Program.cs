//----------------------------------------------------------------------------
//
// <copyright file="Program.cs" company="Aurelitec">
// Copyright (c) 2009-2017 Aurelitec
// http://www.aurelitec.com
// Licensed under the Apache License, Version 2.0. See LICENSE file in the project root for full license information.
// </copyright>
//
// Description: The main colored full screen form of InjuredPixels.
//
//---------------------------------------------------------------------------

namespace InjuredPixels
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main class of the InjuredPixels program
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
