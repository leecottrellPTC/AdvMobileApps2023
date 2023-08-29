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
    }
}
