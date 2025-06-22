using Project_3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3.Interfaces
{
    public interface IDatabaseService
    {
        List<Stock> GetAllStocks();
        Stock GetStockById(int stockId);
        Stock GetStockByName(string name);
        void SaveTransaction(Transaction transaction);
        void UpdateUserBalance(int userId, decimal newBalance);
        List<User> GetAllUserNames();
        User GetUserById(int userId);
        User GetUserByUsernameAndAge(string username, int age);
        void AddUser(User user);
        void DeleteUser(User user);
        void DeleteUserHolding(User user);
        void DeleteUserStockState(User user);
        List<UserHolding> GetUserHoldings(int userId);
        UserHolding GetUserHoldingById(int userId, int stockId);
        void UpdateUserHolding(int userId, int stockId, int quantity);
        void SaveUserStockState(int  userId, int stockId, decimal price, DateTime lastSeen);
        UserStockStateResult GetUserStockState(int userId, int stockId);
    }
}
