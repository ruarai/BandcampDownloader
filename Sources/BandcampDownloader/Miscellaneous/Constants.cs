﻿using System;
using System.IO;
using System.Reflection;

namespace BandcampDownloader {

    internal static class Constants {
        /// <summary>
        /// The maximum tries that can be done when downloading a file.
        /// </summary>
        public static readonly int DownloadMaxTries = 10;
        /// <summary>
        /// The website URL of BandcampDownloader.
        /// </summary>
        public static readonly String ProjectWebsite = "https://github.com/Otiel/BandcampDownloader";
        /// <summary>
        /// The help text displayed in the URL list textbox.
        /// </summary>
        public static readonly String UrlsHint = "Paste URLs of albums to download here.\nA Bandcamp URL looks like: http://[artist name].bandcamp.com/album/[album name]\nYou can specify multiple URLs by writing one URL per line.";
        /// <summary>
        /// The absolute path to the settings file.
        /// </summary>
        public static readonly String UserSettingsFilePath = Directory.GetParent(Assembly.GetExecutingAssembly().Location) + @"\BcDlSettings.json";
    }
}