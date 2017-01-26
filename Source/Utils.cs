//----------------------------------------------------------------------------
//
// <copyright file="Utils.cs" company="Aurelitec">
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
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Static utility methods.
    /// </summary>
    internal static class Utils
    {
        /// <summary>
        /// The random number generator for generating the random colors.
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// Multi-monitor support: gets the bounds of the selected screen, or of all connected screens.
        /// </summary>
        /// <param name="curScreen">The screen to cover.</param>
        /// <returns>The screen bounds.</returns>
        public static Rectangle GetScreenBounds(Screen curScreen)
        {
            Rectangle scrBounds;
            if (curScreen == null)
            {
                scrBounds = default(Rectangle);

                // If we have multiple displays (multi-monitor support)
                foreach (Screen screen in Screen.AllScreens)
                {
                    scrBounds = Rectangle.Union(scrBounds, screen.Bounds);
                }
            }
            else
            {
                scrBounds = curScreen.Bounds;
            }

            return new Rectangle(scrBounds.Left, scrBounds.Top, scrBounds.Width, scrBounds.Height);
        }

        /// <summary>
        /// Generates a random color.
        /// </summary>
        /// <returns>A random color value.</returns>
        public static Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        }

        /// <summary>
        /// Returns the configuration file pathname.
        /// </summary>
        /// <param name="configName">The name of the configuration file.</param>
        /// <param name="executablePath">The path of the executable file.</param>
        /// <param name="appDataPath">The path of the Application data subdirectory for this application.</param>
        /// <returns>The configuration file pathname.</returns>
        public static string GetConfigFileName(string configName, string executablePath, string appDataPath)
        {
            // First check if we have a config file in the directory where the program main executable
            // file is located (to support portable programs)
            string configFileName = Path.Combine(Path.GetDirectoryName(executablePath), configName);

            // If no config file is found, try the program data directory from the ApplicationData
            // special directory for the current roaming user
            if (!File.Exists(configFileName))
            {
                configFileName = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    appDataPath + @"\" + configName);

                // If again no config file is found, we will not load or save any configuration
                if (!File.Exists(configFileName))
                {
                    configFileName = string.Empty;
                }
            }

            return configFileName;
        }

        /// <summary>
        /// Writes a message to the log.
        /// </summary>
        /// <param name="title">The title of the message.</param>
        /// <param name="message">The contents of the message.</param>
        public static void LogMessage(string title, string message)
        {
            Trace.WriteLine(string.Format(
                CultureInfo.CurrentCulture,
                Properties.Resources.LogMessage,
                DateTime.Now.ToString(CultureInfo.InvariantCulture),
                title,
                message));
        }
    }
}
