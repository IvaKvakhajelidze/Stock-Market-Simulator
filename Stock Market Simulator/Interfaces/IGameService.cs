using Project_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_3.Interfaces
{
    public interface IGameService
    {
        void InitializeStockSeries(Chart chart);
        void ShowSelectedSeriesOnly(Chart chart, string seriesName);
        decimal UpdatePriceAfterStockSwitch(int seconds, decimal currentPrice, decimal originalPrice, Random random, Series series);
        string GetSeriesName(int id);
        decimal GetCurrentPrice(int id);
        void SetCurrentPrice(int id, decimal newPrice);
        void SetLastViewed(int stockId, DateTime time);

        StockUpdateResult UpdateStock(int userId, int stockId, decimal currentPrice, DateTime now);
    }
}
