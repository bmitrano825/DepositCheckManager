using Dapper;
using PdfSharpCore.Pdf.Content.Objects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace DepositCheckManager
{
    public class SqliteDataAccess
    {

        public static void CheckDB()
        {
            if (File.Exists("CheckManager.db")) {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static void CreateDBs()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("CREATE TABLE IF NOT EXISTS  [Buildings] (  [Id] bigint NOT NULL UNIQUE, [BuildingName] text NOT NULL, CONSTRAINT [sqlite_master_PK_Buildings] PRIMARY KEY ([Id]));");
                cnn.Execute("CREATE TABLE IF NOT EXISTS  [settings] (  [Id] bigint NOT NULL UNIQUE, [SettingsName] text NOT NULL UNIQUE, [SettingsValue] text NULL, CONSTRAINT[sqlite_master_PK_settings] PRIMARY KEY([Id]));");
            }
        }

        public static void CreateSettings()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT OR IGNORE INTO SETTINGS(settingsName, settingsValue) VALUES ('FolderLocation', NULL)");
            }
        }



        public static List<BuildingModel> LoadBuildings() {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())){
                var building = cnn.Query<BuildingModel>("select * from Buildings order by BuildingName ASC", new DynamicParameters());
                return building.ToList();
            }

        } 

        public static void SaveBuilding(BuildingModel building) {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Buildings(BuildingName) VALUES (@BuildingName)", building);
            }
        }

        public static void DeleteBuilding(BuildingModel building)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Buildings where BuildingName=@BuildingName", building);
            }
        }

        public static List<SettingsModel> LoadSettings(string settingName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var settings = cnn.Query<SettingsModel>("select SettingsValue from settings where SettingsName=" + "'" + settingName + "'", new DynamicParameters());
                return settings.ToList();
            }

        }

        public static void UpdateFolderLocation(SettingsModel folderLocation)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = @"update settings set SettingsValue=@SettingsValue where SettingsName=@SettingsName";
                cnn.Execute(query, folderLocation);
            }
        }

        private static string LoadConnectionString(string id="Default")
        {
            var conString = ConfigurationManager.ConnectionStrings[id].ConnectionString;
            return conString.Replace("%APPDATA%",
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
        }
    }
}
