using Project_3.Models;
using Project_3.Interfaces;
using Project_3.Services;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace Project_3
{
    public partial class StockMarketForm : Form
    {
        private Timer stockUpdateTimer;
        private int selectedStockId = -1;
        private IDatabaseService databaseService;
        private IGameService gameService;

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
 
        private int currentUserId;
        private decimal currentBalance;

        public StockMarketForm(int userId)
        {
            InitializeComponent();

            databaseService = new DatabaseService();
            gameService = new GameService();

            StockMarketChart.Series.Clear();
            gameService.InitializeStockSeries(StockMarketChart);
            StockMarketChart.ChartAreas[0].AxisX.Interval = 4;


            stockUpdateTimer = new Timer { Interval = 1000 };
            stockUpdateTimer.Tick += StockUpdateTimer_Tick;

            currentUserId = userId;
            var user = databaseService.GetUserById(currentUserId);
            currentBalance = user.Balance;
            balanceAmount.Text = $"{currentBalance} $";

            DateTime now = DateTime.Now;

            var resultAAPL = gameService.UpdateStock(currentUserId, 1, currentPriceAAPL, now);
            currentPriceAAPL = resultAAPL.Price;
            lastViewedAAPL = resultAAPL.LastSeen;
            gameService.SetCurrentPrice(1, currentPriceAAPL);

            var resultMSFT = gameService.UpdateStock(currentUserId, 2, currentPriceMSFT, now);
            currentPriceMSFT = resultMSFT.Price;
            lastViewedMSFT = resultMSFT.LastSeen;
            gameService.SetCurrentPrice(2, currentPriceMSFT);

            var resultAMZN = gameService.UpdateStock(currentUserId, 3, currentPriceAMZN, now);
            currentPriceAMZN = resultAMZN.Price;
            lastViewedAMZN = resultAMZN.LastSeen;
            gameService.SetCurrentPrice(3, currentPriceAMZN);

            var resultGOOGL = gameService.UpdateStock(currentUserId, 4, currentPriceGOOGL, now);
            currentPriceGOOGL = resultGOOGL.Price;
            lastViewedGOOGL = resultGOOGL.LastSeen;
            gameService.SetCurrentPrice(4, currentPriceGOOGL);

            var resultTSLA = gameService.UpdateStock(currentUserId, 5, currentPriceTSLA, now);
            currentPriceTSLA = resultTSLA.Price;
            lastViewedTSLA = resultTSLA.LastSeen;
            gameService.SetCurrentPrice(5, currentPriceTSLA);

            var resultMETA = gameService.UpdateStock(currentUserId, 6, currentPriceMETA, now);
            currentPriceMETA = resultMETA.Price;
            lastViewedMETA = resultMETA.LastSeen;
            gameService.SetCurrentPrice(6, currentPriceMETA);

            var resultNFLX = gameService.UpdateStock(currentUserId, 7, currentPriceNFLX, now);
            currentPriceNFLX = resultNFLX.Price;
            lastViewedNFLX = resultNFLX.LastSeen;
            gameService.SetCurrentPrice(7, currentPriceNFLX);

            var resultNVDA = gameService.UpdateStock(currentUserId, 8, currentPriceNVDA, now);
            currentPriceNVDA = resultNVDA.Price;
            lastViewedNVDA = resultNVDA.LastSeen;
            gameService.SetCurrentPrice(8, currentPriceNVDA);

            var resultINTC = gameService.UpdateStock(currentUserId, 9, currentPriceINTC, now);
            currentPriceINTC = resultINTC.Price;
            lastViewedINTC = resultINTC.LastSeen;
            gameService.SetCurrentPrice(9, currentPriceINTC);

            var resultKO = gameService.UpdateStock(currentUserId, 10, currentPriceKO, now);
            currentPriceKO = resultKO.Price;
            lastViewedKO = resultKO.LastSeen;
            gameService.SetCurrentPrice(10, currentPriceKO);

            Random random = new Random();
            int roll = random.Next(0, 10);
            if (roll == 0)
            {
                int eventIndex = random.Next(0, 10);
                string message = "";

                switch (eventIndex)
                {
                    case 0:
                        currentPriceTSLA *= 0.8m;
                        message = "World Event: Massive Tesla Recall in Europe. TSLA drops 20%.";
                        break;
                    case 1:
                        currentPriceAAPL *= 1.23m;
                        message = "World Event: Apple Unveils Mixed Reality Glasses. AAPL jumps 23%.";
                        break;
                    case 2:
                        currentPriceGOOGL *= 0.76m;
                        message = "World Event: Google Hit with EU Privacy Fine. GOOGL drops 24%.";
                        break;
                    case 3:
                        currentPriceMSFT *= 1.15m;
                        message = "World Event: Microsoft Cloud Wins Pentagon Deal. MSFT rises 15%.";
                        break;
                    case 4:
                        currentPriceAMZN *= 0.65m;
                        message = "World Event: Amazon Workers Strike Globally. AMZN down 35%.";
                        break;
                    case 5:
                        currentPriceMETA *= 1.10m;
                        message = "World Event: Meta Launches Breakthrough AI Model. META surges 10%.";
                        break;
                    case 6:
                        currentPriceINTC *= 0.84m;
                        message = "World Event: Intel Chip Delay Disrupts PC Market. INTC drops 16%.";
                        break;
                    case 7:
                        currentPriceNFLX *= 1.27m;
                        message = "World Event: Netflix Secures Olympics Streaming Rights. NFLX up 27%.";
                        break;
                    case 8:
                        currentPriceKO *= 0.75m;
                        message = "World Event: Coca-Cola Launches Global Sugar Ban Campaign. KO down 25%.";
                        break;
                    case 9:
                        currentPriceNVDA *= 1.43m;
                        message = "World Event: NVIDIA Dominates AI Chip Market. NVDA jumps 43%.";
                        break;
                }

                if (message != "")
                {
                    MessageBox.Show(message, "World Event Alert");
                }
            }
        }


        private void HandleStockSwitch(int stockId, string seriesName, DateTime lastViewed)
        {
            DateTime now = DateTime.Now;
            var series = StockMarketChart.Series[seriesName];
            series.Enabled = true;
            Random random = new Random();

            int secondsPassed = (int)(now - lastViewed).TotalSeconds;
            gameService.SetLastViewed(stockId, now);


            decimal currentPrice = gameService.GetCurrentPrice(stockId);
            decimal originalPrice = databaseService.GetStockById(stockId).OriginalPrice;

            for (int i = 0; i < secondsPassed; i++)
            {
                decimal change = (decimal)(random.Next(5, 50) / 10.0);
                if (random.Next(0, 2) == 0)
                    change *= -1;

                currentPrice += change;

                decimal min = originalPrice * 0.1m;
                decimal max = originalPrice * 2.5m;

                if (currentPrice < min)
                    currentPrice = min;
                else if (currentPrice > max)
                    currentPrice = max;

                series.Points.AddY(currentPrice);
                if (series.Points.Count > 20)
                    series.Points.RemoveAt(0);
            }

            gameService.SetCurrentPrice(stockId, currentPrice);
            selectedStockId = stockId;
            gameService.ShowSelectedSeriesOnly(StockMarketChart, seriesName);
            stockUpdateTimer.Start();
        }

        

        

        

        


        private void StockUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (selectedStockId <= 0)
            {
                return;
            }

            string seriesName = gameService.GetSeriesName(selectedStockId);
            if (seriesName == "")
            {
                return;
            }

            Series series = StockMarketChart.Series[seriesName];
            if (!series.Enabled)
            {
                return;
            }

            decimal currentPrice = gameService.GetCurrentPrice(selectedStockId);
            decimal originalPrice = databaseService.GetStockById(selectedStockId).OriginalPrice;

            Random random = new Random();
            decimal change = (decimal)(random.Next(5, 50) / 10.0);
            if (random.Next(0, 2) == 0)
                change *= -1;

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

            gameService.SetCurrentPrice(selectedStockId, currentPrice);
        }

        private void buy_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(stockName_TextBox.Text) && !string.IsNullOrWhiteSpace(quantity_TextBox.Text))
            {
                if (stockName_TextBox.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Please input valid Stock name!");
                    return;
                }
                var stock = databaseService.GetStockByName($"{stockName_TextBox.Text}");

                if (!quantity_TextBox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please input valid quantity!");
                    return;
                }
                int quantity = Convert.ToInt32(quantity_TextBox.Text);

                decimal currentPrice = gameService.GetCurrentPrice(stock.Id);

                if (currentPrice < 0)
                {
                    MessageBox.Show("This stock is not for sale currently!");
                    return;
                }

                decimal totalCost = quantity * currentPrice;

                if (currentBalance < totalCost)
                {
                    MessageBox.Show("You don't have enough money!");
                    return;
                }

                currentBalance -= totalCost;
                balanceAmount.Text = $"{currentBalance} $";
                databaseService.UpdateUserBalance(currentUserId, currentBalance);

                databaseService.SaveTransaction(new Transaction
                {
                    UserId = currentUserId,
                    StockId = stock.Id,
                    Quantity = quantity,
                    PricePerShare = currentPrice,
                    Time = DateTime.Now,
                    IsBuyingOrSelling = true
                });

                databaseService.UpdateUserHolding(currentUserId, stock.Id, quantity);
            }
            else
            {
                MessageBox.Show("Please fill all the text boxes!");
            }
        }

        private void sell_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(stockName_TextBox.Text) && !string.IsNullOrWhiteSpace(quantity_TextBox.Text))
            {
                if (stockName_TextBox.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Please input valid Stock name!");
                    return;
                }
                var stock = databaseService.GetStockByName(stockName_TextBox.Text);
                if (!quantity_TextBox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please input valid quantity!");
                    return;
                }
                int quantity = Convert.ToInt32(quantity_TextBox.Text);

                decimal currentPrice = gameService.GetCurrentPrice(stock.Id);

                if (currentPrice < 0)
                {
                    MessageBox.Show("This stock is not for sale currently!");
                    return;
                }

                decimal totalGain = quantity * currentPrice;

                var holding = databaseService.GetUserHoldingById(currentUserId, stock.Id);

                if (holding == null || holding.Quantity < quantity)
                {
                    MessageBox.Show($"You don't own enough shares to sell!\nYou own {holding.Quantity} shares!");
                    return;
                }

                currentBalance += totalGain;
                balanceAmount.Text = $"{currentBalance} $";
                databaseService.UpdateUserBalance(currentUserId, currentBalance);
                databaseService.SaveTransaction(new Transaction
                {
                    UserId = currentUserId,
                    StockId = stock.Id,
                    Quantity = quantity,
                    PricePerShare = currentPriceAAPL,
                    Time = DateTime.Now,
                    IsBuyingOrSelling = false
                });

                databaseService.UpdateUserHolding(currentUserId, stock.Id, -quantity);
            }
            else
            {
                MessageBox.Show("Please fill all the text boxes!");
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            databaseService.SaveUserStockState(currentUserId, 1, currentPriceAAPL, DateTime.Now);
            databaseService.SaveUserStockState(currentUserId, 2, currentPriceMSFT, DateTime.Now);
            databaseService.SaveUserStockState(currentUserId, 3, currentPriceAMZN, DateTime.Now);
            databaseService.SaveUserStockState(currentUserId, 4, currentPriceGOOGL, DateTime.Now);
            databaseService.SaveUserStockState(currentUserId, 5, currentPriceTSLA, DateTime.Now);
            databaseService.SaveUserStockState(currentUserId, 6, currentPriceMETA, DateTime.Now);
            databaseService.SaveUserStockState(currentUserId, 7, currentPriceNFLX, DateTime.Now);
            databaseService.SaveUserStockState(currentUserId, 8, currentPriceNVDA, DateTime.Now);
            databaseService.SaveUserStockState(currentUserId, 9, currentPriceINTC, DateTime.Now);
            databaseService.SaveUserStockState(currentUserId, 10, currentPriceKO, DateTime.Now);

            Application.Exit();
        }

        private void AAPL_button_Click(object sender, EventArgs e)
        {
            
            HandleStockSwitch(1, "AAPL", lastViewedAAPL);
            StockMarketChart.ChartAreas[0].RecalculateAxesScale();
            AAPL_button.Enabled = false;
            MSFT_button.Enabled = true;
            AMZN_button.Enabled = true;
            GOOGL_button.Enabled = true;
            TSLA_button.Enabled = true;
            META_button.Enabled = true;
            NFLX_button.Enabled = true;
            NVDA_button.Enabled = true;
            INTC_button.Enabled = true;
            KO_button.Enabled = true;
        }

        private void MSFT_button_Click(object sender, EventArgs e)
        {
            HandleStockSwitch(2, "MSFT", lastViewedMSFT);
            StockMarketChart.ChartAreas[0].RecalculateAxesScale();
            AAPL_button.Enabled = true;
            MSFT_button.Enabled = false;
            AMZN_button.Enabled = true;
            GOOGL_button.Enabled = true;
            TSLA_button.Enabled = true;
            META_button.Enabled = true;
            NFLX_button.Enabled = true;
            NVDA_button.Enabled = true;
            INTC_button.Enabled = true;
            KO_button.Enabled = true;
        }

        private void AMZN_button_Click(object sender, EventArgs e)
        {
            HandleStockSwitch(3, "AMZN", lastViewedAMZN);
            StockMarketChart.ChartAreas[0].RecalculateAxesScale();
            AAPL_button.Enabled = true;
            MSFT_button.Enabled = true;
            AMZN_button.Enabled = false;
            GOOGL_button.Enabled = true;
            TSLA_button.Enabled = true;
            META_button.Enabled = true;
            NFLX_button.Enabled = true;
            NVDA_button.Enabled = true;
            INTC_button.Enabled = true;
            KO_button.Enabled = true;
        }

        private void GOOGL_button_Click(object sender, EventArgs e)
        {
            HandleStockSwitch(4, "GOOGL", lastViewedGOOGL);
            StockMarketChart.ChartAreas[0].RecalculateAxesScale();
            AAPL_button.Enabled = true;
            MSFT_button.Enabled = true;
            AMZN_button.Enabled = true;
            GOOGL_button.Enabled = false;
            TSLA_button.Enabled = true;
            META_button.Enabled = true;
            NFLX_button.Enabled = true;
            NVDA_button.Enabled = true;
            INTC_button.Enabled = true;
            KO_button.Enabled = true;
        }

        private void TSLA_button_Click(object sender, EventArgs e)
        {
            HandleStockSwitch(5, "TSLA", lastViewedTSLA);
            StockMarketChart.ChartAreas[0].RecalculateAxesScale();
            AAPL_button.Enabled = true;
            MSFT_button.Enabled = true;
            AMZN_button.Enabled = true;
            GOOGL_button.Enabled = true;
            TSLA_button.Enabled = false;
            META_button.Enabled = true;
            NFLX_button.Enabled = true;
            NVDA_button.Enabled = true;
            INTC_button.Enabled = true;
            KO_button.Enabled = true;
        }

        private void META_button_Click(object sender, EventArgs e)
        {
            HandleStockSwitch(6, "META", lastViewedMETA);
            StockMarketChart.ChartAreas[0].RecalculateAxesScale();
            AAPL_button.Enabled = true;
            MSFT_button.Enabled = true;
            AMZN_button.Enabled = true;
            GOOGL_button.Enabled = true;
            TSLA_button.Enabled = true;
            META_button.Enabled = false;
            NFLX_button.Enabled = true;
            NVDA_button.Enabled = true;
            INTC_button.Enabled = true;
            KO_button.Enabled = true;
        }

        private void NFLX_button_Click(object sender, EventArgs e)
        {
            HandleStockSwitch(7, "NFLX", lastViewedNFLX);
            StockMarketChart.ChartAreas[0].RecalculateAxesScale();
            AAPL_button.Enabled = true;
            MSFT_button.Enabled = true;
            AMZN_button.Enabled = true;
            GOOGL_button.Enabled = true;
            TSLA_button.Enabled = true;
            META_button.Enabled = true;
            NFLX_button.Enabled = false;
            NVDA_button.Enabled = true;
            INTC_button.Enabled = true;
            KO_button.Enabled = true;
        }

        private void NVDA_button_Click(object sender, EventArgs e)
        {
            HandleStockSwitch(8, "NVDA", lastViewedNVDA);
            StockMarketChart.ChartAreas[0].RecalculateAxesScale();
            AAPL_button.Enabled = true;
            MSFT_button.Enabled = true;
            AMZN_button.Enabled = true;
            GOOGL_button.Enabled = true;
            TSLA_button.Enabled = true;
            META_button.Enabled = true;
            NFLX_button.Enabled = true;
            NVDA_button.Enabled = false;
            INTC_button.Enabled = true;
            KO_button.Enabled = true;
        }

        private void INTC_button_Click(object sender, EventArgs e)
        {
            HandleStockSwitch(9, "INTC", lastViewedINTC);
            StockMarketChart.ChartAreas[0].RecalculateAxesScale();
            AAPL_button.Enabled = true;
            MSFT_button.Enabled = true;
            AMZN_button.Enabled = true;
            GOOGL_button.Enabled = true;
            TSLA_button.Enabled = true;
            META_button.Enabled = true;
            NFLX_button.Enabled = true;
            NVDA_button.Enabled = true;
            INTC_button.Enabled = false;
            KO_button.Enabled = true;
        }

        private void KO_button_Click(object sender, EventArgs e)
        {
            HandleStockSwitch(10, "KO", lastViewedKO);
            StockMarketChart.ChartAreas[0].RecalculateAxesScale();
            AAPL_button.Enabled = true;
            MSFT_button.Enabled = true;
            AMZN_button.Enabled = true;
            GOOGL_button.Enabled = true;
            TSLA_button.Enabled = true;
            META_button.Enabled = true;
            NFLX_button.Enabled = true;
            NVDA_button.Enabled = true;
            INTC_button.Enabled = true;
            KO_button.Enabled = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                MessageBox.Show("Please use the custom close button.");
            }
        }

        
    }
}