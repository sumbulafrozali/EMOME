﻿using System;
using System.IO;
using EmoMe.Common;
using EmoMe.iOS.ServiceImplementation;
using EmoMe.Services.Interfaces;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqLiteService))]
namespace EmoMe.iOS.ServiceImplementation
{
    public class SqLiteService : ISqLiteService
    {
        public SQLiteConnection GetConnection() => new SQLiteConnection(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "..", "Library"), Constants.DatabaseFileName));
    }
}