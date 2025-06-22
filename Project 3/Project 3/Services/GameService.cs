using Project_3.Interfaces;
using Project_3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_3.Services
{
    public class GameService : IGameService
    {

        private IDatabaseService databaseService = new DatabaseService();

        private decimal currentPriceAAPL;
        private decimal currentPriceMSFT;
        private decimal currentPriceAMZN;
        private decimal currentPriceGOOGL;
        private decimal currentPriceTSLA;
        private decimal currentPriceMETA;
        private decimal currentPriceNFLX;
        private decimal currentPriceNVDA;
        private decimal currentPriceINTC;
        private decimal currentPriceKO;
        private DateTime lastViewedAAPL;
        private DateTime lastViewedMSFT;
        private DateTime lastViewedAMZN;
        private DateTime lastViewedGOOGL;
        private DateTime lastViewedTSLA;
        private DateTime lastViewedMETA;
        private DateTime lastViewedNFLX;
        private DateTime lastViewedNVDA;
        private DateTime lastViewedINTC;
        private DateTime lastViewedKO;


        


        public void InitializeStockSeries(Chart chart)
        {
            string[] stockSymbols = { "AAPL", "MSFT", "AMZN", "GOOGL", "TSLA", "META", "NFLX", "NVDA", "INTC", "KO" };

            foreach (string symbol in stockSymbols)
            {
                Series series = new Series(symbol)
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.Orange,
                    BorderWidth = 3,
                    Enabled = false
                };
                chart.Series.Add(series);
            }
        }

        public void ShowSelectedSeriesOnly(Chart chart, string seriesName)
        {
            foreach (var series in chart.Series)
            {
                if (series.Name == seriesName)
                {
                    series.Enabled = true;
                }
                else
                {
                    series.Enabled = false;
                }
            }
        }

        public decimal UpdatePriceAfterStockSwitch(int seconds, decimal currentPrice, decimal originalPrice, Random random, Series series)
        {
            for (int i = 0; i < seconds; i++)
            {
                decimal change = (decimal)(random.Next(5, 50) / 10.0);
                if (random.Next(0, 2) == 0)
                    change = -change;

                currentPrice += change;

                decimal minPrice = originalPrice * 0.1m;
                decimal maxPrice = originalPrice * 2.5m;

                if (currentPrice < minPrice)
                    currentPrice = minPrice;
                else if (currentPrice > maxPrice)
                    currentPrice = maxPrice;

                series.Points.AddY(currentPrice);

                if (series.Points.Count > 20)
                    series.Points.RemoveAt(0);
            }
            return currentPrice;
        }

        public string GetSeriesName(int id)
        {
            switch (id)
            {
                case 1: return "AAPL";
                case 2: return "MSFT";
                case 3: return "AMZN";
                case 4: return "GOOGL";
                case 5: return "TSLA";
                case 6: return "META";
                case 7: return "NFLX";
                case 8: return "NVDA";
                case 9: return "INTC";
                case 10: return "KO";
                default: return "";
            }
        }

        public decimal GetCurrentPrice(int id)
        {
            switch (id)
            {
                case 1: return currentPriceAAPL;
                case 2: return currentPriceMSFT;
                case 3: return currentPriceAMZN;
                case 4: return currentPriceGOOGL;
                case 5: return currentPriceTSLA;
                case 6: return currentPriceMETA;
                case 7: return currentPriceNFLX;
                case 8: return currentPriceNVDA;
                case 9: return currentPriceINTC;
                case 10: return currentPriceKO;
                default: return 0;
            }
        }

        public void SetCurrentPrice(int stockId, decimal price)
        {
            switch (stockId)
            {
                case 1: currentPriceAAPL = price; break;
                case 2: currentPriceMSFT = price; break;
                case 3: currentPriceAMZN = price; break;
                case 4: currentPriceGOOGL = price; break;
                case 5: currentPriceTSLA = price; break;
                case 6: currentPriceMETA = price; break;
                case 7: currentPriceNFLX = price; break;
                case 8: currentPriceNVDA = price; break;
                case 9: currentPriceINTC = price; break;
                case 10: currentPriceKO = price; break;
            }
        }

        public void SetLastViewed(int stockId, DateTime time)
        {
            switch (stockId)
            {
                case 1: lastViewedAAPL = time; break;
                case 2: lastViewedMSFT = time; break;
                case 3: lastViewedAMZN = time; break;
                case 4: lastViewedGOOGL = time; break;
                case 5: lastViewedTSLA = time; break;
                case 6: lastViewedMETA = time; break;
                case 7: lastViewedNFLX = time; break;
                case 8: lastViewedNVDA = time; break;
                case 9: lastViewedINTC = time; break;
                case 10: lastViewedKO = time; break;
            }
        }

        public StockUpdateResult UpdateStock(int userId, int stockId, decimal currentPrice, DateTime now)
        {
            var state = databaseService.GetUserStockState(userId, stockId);
            DateTime lastSeen;
            Random random = new Random();
            if (state.Found)
            {
                currentPrice = state.lastPrice;
                lastSeen = state.lastSeen;

                int secondsPassed = (int)(now - lastSeen).TotalSeconds;
                for (int i = 0; i < secondsPassed; i++)
                {
                    decimal change = (decimal)(random.Next(5, 50) / 10.0);
                    if (random.Next(0, 2) == 0)
                        change *= -1;
                    currentPrice += change;
                }

                var result = new StockUpdateResult
                {
                    Price = currentPrice,
                    LastSeen = now
                };
                return result;
            }
            else
            {
                currentPrice = databaseService.GetStockById(stockId).OriginalPrice;
                var result = new StockUpdateResult
                {
                    Price = currentPrice,
                    LastSeen = now
                };
                return result;
            }
        }

    }
}
