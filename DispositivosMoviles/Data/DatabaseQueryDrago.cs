using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DispositivosMoviles.Models;
using SQLite;

namespace DispositivosMoviles.Data
{
    public class DatabaseQueryDrago
    {
        readonly SQLiteAsyncConnection _database;
        
        public DatabaseQueryDrago(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            _database.CreateTableAsync<UserDrago>().Wait();
            //_database.CreateTableAsync<TodoModelDrago>().Wait();

            
        }
        #region CRUD

        //Método insertar o actualizar

        public Task<int> SaveUserAsync(UserDrago user)
        {
            if(user.Id != 0) 
            { 
                return _database.UpdateAsync(user); } 
            else
            {
                return _database.InsertAsync(user);
            }
        }
        #endregion
    }
}
