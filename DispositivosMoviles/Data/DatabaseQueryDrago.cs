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

        public Task<List<UserDrago>> GetTodoModel()
        {
            return _database.Table<UserDrago>().ToListAsync();
        }

        //Metod Select
        public Task<List<UserDrago>> GetUsers()
        {
            return _database.QueryAsync<UserDrago>("SELECT * FROM User");
        }
        // Método Select por Id

        public Task<UserDrago> GetUserById(int id)
        {

            return _database.Table<UserDrago>().Where(a => a.Id == id).FirstOrDefaultAsync();

        }


        // Método Eliminar
        public Task<int> DeleteUserAsync(UserDrago user)
        {
            return _database.DeleteAsync(user);
        }

        // Metodo para validar usuario y password

        public Task<List<UserDrago>> GetUsersValidate(string email, string password)
        {
            // return _database.QueryAsync<User>("SELECT * FROM User WHERE Email = '" + email + "'AND Password = '" + password + "'");
            return _database.QueryAsync<UserDrago>("Select * from User Where Email=? and Password=?", email, password);

        }
        // Método obtener Password




        public Task<UserDrago> GetUserPassword(string email)
        {

            return _database.Table<UserDrago>().Where(a => a.Email == email).FirstOrDefaultAsync();



        }



        #endregion
    }
}
