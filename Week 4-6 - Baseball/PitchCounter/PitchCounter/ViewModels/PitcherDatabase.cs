using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using PitchCounter.Models;
using System.ComponentModel;

namespace PitchCounter.ViewModels
{
    public class PitcherDatabase
    {
        private SQLiteConnection _connection;
        private string _dbPath;
        private void Init()
        {   //build the connection to the database
            if(_connection != null)
            {
                return;
            }
            _connection = new SQLiteConnection(_dbPath);
            _connection.CreateTable<PlayerClass>();

        }
        public PitcherDatabase(string dbPath)
        {
            _dbPath = dbPath;//set database name
        }

        public async void InsertPitcher(PlayerClass newPitcher)
        {
            int result = 0;
            try
            {
                Init();
                if (string.IsNullOrEmpty(newPitcher.Name)){
                    //protect my data
                    throw new Exception("Name Required");
                }//end if
                //check everything that could be an issue
                result = _connection.Insert(newPitcher);
            }//end try
            catch(Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("DB Error", ex.ToString(), "OK");
            }
        }
    }
}
