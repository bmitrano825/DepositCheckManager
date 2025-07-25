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

        /// <summary>
        /// Checks that the DB file exists.
        /// </summary>
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


        /// <summary>
        /// Creates the DB tables if they do not already exist.
        /// </summary>
        public static void CreateDBs()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("CREATE TABLE IF NOT EXISTS  [Buildings] (  [Id] INTEGER NOT NULL UNIQUE, [BuildingName] text NOT NULL, CONSTRAINT [sqlite_master_PK_Buildings] PRIMARY KEY ([Id]));");
                cnn.Execute("CREATE TABLE IF NOT EXISTS  [Accounts] (  [Id] INTEGER NOT NULL UNIQUE, [AccountName] text NOT NULL, CONSTRAINT [sqlite_master_PK_Accounts] PRIMARY KEY ([Id]));");
                cnn.Execute("CREATE TABLE IF NOT EXISTS  [settings] (  [Id] INTEGER NOT NULL UNIQUE, [SettingsName] text NOT NULL UNIQUE, [SettingsValue] text NULL, CONSTRAINT[sqlite_master_PK_settings] PRIMARY KEY([Id]));");
            }
        }

        /// <summary>
        /// Inserts the default settings into the settings table if they don't exist.
        /// </summary>
        public static void CreateSettings()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT OR IGNORE INTO SETTINGS(settingsName, settingsValue) VALUES ('FolderLocation', NULL)");
            }
        }



        /// <summary>
        /// Gets a list of the buildings from the buildings table and returns them in a list.
        /// </summary>
        /// <returns>A list of the buildings in a list</returns>
        public static List<BuildingModel> LoadBuildings() {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())){
                var building = cnn.Query<BuildingModel>("select * from Buildings order by BuildingName ASC", new DynamicParameters());
                return building.ToList();
            }
        }

        /// <summary>
        /// Gets a list of the accounts from the accounts table and returns them in a list.
        /// </summary>
        /// <returns>A list of the accounts in a list</returns>
        public static List<AccountModel> LoadAccounts()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var account = cnn.Query<AccountModel>("select * from Accounts order by AccountName ASC", new DynamicParameters());
                return account.ToList();
            }
        }


        /// <summary>
        /// Inserts a new building into the building DB
        /// </summary>
        /// <param name="building">A building object</param>
        public static void SaveBuilding(BuildingModel building) {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Buildings(BuildingName) VALUES (@BuildingName)", building);
            }
        }

        /// <summary>
        /// Inserts a new account into the account DB
        /// </summary>
        /// <param name="account">A account object</param>
        public static void SaveAccount(AccountModel account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Accounts(AccountName) VALUES (@AccountName)", account);
            }
        }


        /// <summary>
        /// Deletes a building from the building DB
        /// </summary>
        /// <param name="building">A building object</param>
        public static void DeleteBuilding(BuildingModel building)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Buildings where BuildingName=@BuildingName", building);
            }
        }

        /// <summary>
        /// Deletes a account from the account DB
        /// </summary>
        /// <param name="account">A account object</param>
        public static void DeleteAccount(AccountModel account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Accounts where AccountName=@AccountName", account);
            }
        }


        /// <summary>
        /// Loads a specific settings value.
        /// </summary>
        /// <param name="settingName">The name of the setting to load the value for.</param>
        /// <returns></returns>
        public static List<SettingsModel> LoadSettings(string settingName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var settings = cnn.Query<SettingsModel>("select SettingsValue from settings where SettingsName=" + "'" + settingName + "'", new DynamicParameters());
                return settings.ToList();
            }

        }

        /// <summary>
        /// Updates the location of the folder to save images to in the DB
        /// </summary>
        /// <param name="folderLocation">Specified folder path</param>
        public static void UpdateFolderLocation(SettingsModel folderLocation)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = @"update settings set SettingsValue=@SettingsValue where SettingsName=@SettingsName";
                cnn.Execute(query, folderLocation);
            }
        }


        /// <summary>
        /// Builds the connection string for sqlite. Replaces the placeholder with the appdata folder of the user. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static string LoadConnectionString(string id="Default")
        {
            var conString = ConfigurationManager.ConnectionStrings[id].ConnectionString;
            return conString.Replace("%APPDATA%",
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
        }
    }
}
