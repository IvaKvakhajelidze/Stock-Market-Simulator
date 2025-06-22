using Project_3.Interfaces;
using Project_3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly string _connectionString = "Server=DESKTOP-O39I5IF\\SQLEXPRESS;Database=StockSimulator;Trusted_Connection=True;TrustServerCertificate=True";

        public List<Stock> GetAllStocks()
        {
            List<Stock> stocks = new List<Stock>();
            using (SqlConnection connection = new SqlConnection(_connectionString)) 
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [StockSimulator].[dbo].[Stock]", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stocks.Add(new Stock()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Symbol = reader["Symbol"].ToString(),
                        OriginalPrice = Convert.ToDecimal(reader["OriginalPrice"])
                    });
                }
                connection.Close();
            }
            return stocks;
        }

        public Stock GetStockById(int stockId)
        {
            Stock stock = new Stock();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM [StockSimulator].[dbo].[Stock] WHERE Id = {stockId}", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stock.Id = Convert.ToInt32(reader["Id"]);
                    stock.Name = reader["Name"].ToString();
                    stock.Symbol = reader["Symbol"].ToString();
                    stock.OriginalPrice = Convert.ToDecimal(reader["OriginalPrice"]);
                }
                connection.Close();
            }
            return stock;
        }
        public Stock GetStockByName(string name)
        {
            Stock stock = new Stock();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM [StockSimulator].[dbo].[Stock] WHERE Symbol = '{name}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stock.Id = Convert.ToInt32(reader["Id"]);
                    stock.Name = reader["Name"].ToString();
                    stock.Symbol = reader["Symbol"].ToString();
                    stock.OriginalPrice = Convert.ToDecimal(reader["OriginalPrice"]);
                }
                connection.Close();
            }
            return stock;
        }
    
        public void SaveTransaction(Transaction transaction)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                int buyOrSell = 0;
                if (transaction.IsBuyingOrSelling)
                {
                    buyOrSell = 1;
                }

                string pricePerShareStr = transaction.PricePerShare.ToString(System.Globalization.CultureInfo.InvariantCulture);

                SqlCommand command = new SqlCommand(
                    $"INSERT INTO [StockSimulator].[dbo].[Transaction] " +
                    $"([UserId], [StockId], [Quantity], [PricePerShare], [Time], [IsBouyingOrSelling]) " +
                    $"VALUES ({transaction.UserId}, {transaction.StockId}, {transaction.Quantity}, {pricePerShareStr}, " +
                    $"'{transaction.Time:yyyy-MM-dd HH:mm:ss}', {buyOrSell})",
                    connection);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateUserBalance(int userId, decimal newBalance)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"UPDATE [StockSimulator].[dbo].[User] SET [Balance] = {newBalance} WHERE Id = {userId}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<User> GetAllUserNames()
        {
            List<User> users = new List<User>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [StockSimulator].[dbo].[User]", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User()
                    {
                        Username = reader["UserName"].ToString()
                    });
                }
                connection.Close();
            }
            return users;
        }

        public User GetUserById(int userId)
        {
            User user = new User();
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM [StockSimulator].[dbo].[User] WHERE Id = {userId}", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.Id = Convert.ToInt32(reader["Id"]);
                    user.Username = reader["UserName"].ToString();
                    user.Age = Convert.ToInt32(reader["Age"]);
                    user.Balance = Convert.ToDecimal(reader["Balance"]);
                    user.JourneyCreationDate = Convert.ToDateTime(reader["JourneyCreationDate"]);
                }
            }
            return user;
        }

        public User GetUserByUsernameAndAge(string username, int age)
        {
            User user = new User();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM [StockSimulator].[dbo].[User] WHERE UserName = '{username}' AND Age = {age}", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.Id = Convert.ToInt32(reader["Id"]);
                    user.Username = reader["UserName"].ToString();
                    user.Age = Convert.ToInt32(reader["Age"]);
                    user.Balance = Convert.ToDecimal(reader["Balance"]);
                    user.Password = Convert.ToInt32(reader["Password"]);
                    user.JourneyCreationDate = Convert.ToDateTime(reader["JourneyCreationDate"]);
                }
                connection.Close();
            }
            return user;
        }

        public List<UserHolding> GetUserHoldings(int userId)
        {
            List<UserHolding> userHoldings = new List<UserHolding>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [StockSimulator].[dbo].[UserHolding]", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    userHoldings.Add(new UserHolding()
                    {
                        UserId = Convert.ToInt32(reader["UserId"]),
                        StockId = Convert.ToInt32(reader["StockId"]),
                        Quantity = Convert.ToInt32(reader["Quantity"])
                    });
                }
                connection.Close();
            }
            return userHoldings;
        }

        public UserHolding GetUserHoldingById(int userId, int stockId)
        {
            UserHolding holding = new UserHolding();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM [StockSimulator].[dbo].[UserHolding] WHERE UserId = {userId} AND StockId = {stockId}", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    holding.UserId = Convert.ToInt32(reader["UserId"]);
                    holding.StockId = Convert.ToInt32(reader["StockId"]);
                    holding.Quantity = Convert.ToInt32(reader["Quantity"]);
                }
                connection.Close();
            }
            return holding;
        }

        public void AddUser(User user)
        {
            if (user.Balance == 0)
            {
                user.Balance = 10000;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO [StockSimulator].[dbo].[User] ([Username], [Age], [Balance], [Password], [JourneyCreationDate]) " +
                    $"VALUES ('{user.Username}', {user.Age}, {user.Balance}, '{user.Password}', '{user.JourneyCreationDate:yyyy-MM-dd HH:mm:ss}')",
                    connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void DeleteUser(User user)
        {
            using (SqlConnection connection = new SqlConnection( _connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"DELETE FROM [StockSimulator].[dbo].[User] WHERE UserName = '{user.Username}'", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void DeleteUserHolding(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"DELETE FROM [StockSimulator].[dbo].[UserHolding] WHERE UserId = {user.Id}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteUserStockState(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"DELETE FROM [StockSimulator].[dbo].[UserStockState] WHERE UserId = {user.Id}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateUserHolding(int userId, int stockId, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand($"UPDATE [StockSimulator].[dbo].[UserHolding] SET Quantity = Quantity + {quantity} WHERE UserId = {userId} AND StockId = {stockId}", connection);
                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    SqlCommand insertCommand = new SqlCommand($"INSERT INTO [StockSimulator].[dbo].[UserHolding] (UserId, StockId, Quantity) VALUES ({userId}, {stockId}, {quantity})", connection);
                    insertCommand.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand checkCommand = new SqlCommand($"SELECT Quantity FROM [StockSimulator].[dbo].[UserHolding] WHERE UserId = {userId} AND StockId = {stockId}", connection);
                    SqlDataReader reader = checkCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        int newQuantity = reader.GetInt32(0);
                        reader.Close();

                        if (newQuantity == 0)
                        {
                            SqlCommand deleteCommand = new SqlCommand($"DELETE FROM [StockSimulator].[dbo].[UserHolding] WHERE UserId = {userId} AND StockId = {stockId}", connection);
                            deleteCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        reader.Close();
                    }
                }
                connection.Close();
            }
        }

        public UserStockStateResult GetUserStockState(int userId, int stockId)
        {
            UserStockStateResult userStockStateResult = new UserStockStateResult();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT LastPrice, LastSeen FROM [StockSimulator].[dbo].[UserStockState] WHERE UserId = {userId} AND StockId = {stockId}", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    userStockStateResult.Found = true;
                    userStockStateResult.lastPrice = Convert.ToDecimal(reader["LastPrice"]);
                    userStockStateResult.lastSeen = Convert.ToDateTime(reader["LastSeen"]);
                }
                connection.Close();
            }
            return userStockStateResult;
        }

        public void SaveUserStockState(int userId, int stockId, decimal price, DateTime lastSeen)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand($"UPDATE UserStockState SET LastPrice = {price}, LastSeen = '{lastSeen:yyyy-MM-dd HH:mm:ss}' WHERE UserId = {userId} AND StockId = {stockId}", connection);

                int rowsEffected = updateCommand.ExecuteNonQuery();

                if (rowsEffected == 0)
                {
                    SqlCommand insertCommand = new SqlCommand($"INSERT INTO UserStockState (UserId, StockId, LastPrice, LastSeen) VALUES ({userId}, {stockId}, {price}, '{lastSeen:yyyy-MM-dd HH:mm:ss}')", connection);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
