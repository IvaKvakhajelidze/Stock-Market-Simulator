using Project_3.Interfaces;
using Project_3.Models;
using Project_3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project_3
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        IDatabaseService databaseService = new DatabaseService();

        private void newSimulation_button_Click(object sender, EventArgs e)
        {
            registration_label.Visible = true;
            stockMarketSimulator_label.Visible = false;
            continueJourney_button.Visible = false;
            newSimulation_button.Visible = false;
            start_button_ForNewSimulation.Visible = true;
            userNameTextBox.Visible = true;
            registration_username_label.Visible = true;
            ageTextBox.Visible = true;
            age_label.Visible = true;
            Password_label.Visible = true;
            passwordTextBox.Visible = true;
            back_btn.Visible = true;
        }

        private void continueJourney_button_Click(object sender, EventArgs e)
        {
            logIn_Label.Visible = true;
            stockMarketSimulator_label.Visible = false;
            continueJourney_button.Visible = false;
            newSimulation_button.Visible = false;
            start_Button_ForContinueMyJourney.Visible = true;
            userNameTextBox.Visible = true;
            registration_username_label.Visible = true;
            ageTextBox.Visible = true;
            age_label.Visible = true;
            Password_label.Visible = true;
            passwordTextBox.Visible = true;
            back_btn.Visible = true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            logIn_Label.Visible = false;
            registration_label.Visible = false;
            start_Button_ForContinueMyJourney.Visible = false;
            start_button_ForNewSimulation.Visible = false;
            stockMarketSimulator_label.Visible = true;
            continueJourney_button.Visible = true;
            newSimulation_button.Visible = true;
            start_Button_ForContinueMyJourney.Visible = false;
            userNameTextBox.Visible = false;
            registration_username_label.Visible = false;
            ageTextBox.Visible = false;
            age_label.Visible = false;
            Password_label.Visible = false;
            passwordTextBox.Visible = false;
            back_btn.Visible = false;
        }

        private void start_button_ForNewSimulation_Click(object sender, EventArgs e)
        {
            try
            {
                string username = userNameTextBox.Text;
                int age = Convert.ToInt32(ageTextBox.Text);
                var User = databaseService.GetUserByUsernameAndAge(username, age);

                if (age < 16)
                {
                    MessageBox.Show("You must be 16 or older to play!");
                }
                else if (passwordTextBox.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Password can only contain numbers!");
                }
                else
                {
                    List<User> users = databaseService.GetAllUserNames();
                    bool userExists = false;

                    foreach (User user in users)
                    {
                        if (user.Username == userNameTextBox.Text)
                        {
                            userExists = true;
                            break;
                        }
                    }

                    if (userExists)
                    {
                        MessageBox.Show("Username already exists");

                    }
                    else
                    {
                        User newUser = new User()
                        {
                            Username = userNameTextBox.Text,
                            Age = Convert.ToInt32(ageTextBox.Text),
                            Balance = 10000,
                            Password = Convert.ToInt32(passwordTextBox.Text),
                            JourneyCreationDate = DateTime.Now
                        };
                        databaseService.AddUser(newUser);
                        MessageBox.Show(
                            "📈 Welcome to the Virtual Stock Market Simulator! 📊\n\n" +
                            "Your mission is simple: grow your wealth beyond the $10,000 you start with. 🤑\n\n" +
                            "You’ll be trading shares from the world’s top companies — like Apple (AAPL), Microsoft (MSFT), Amazon (AMZN), Tesla (TSLA), and more.\n\n" +
                            "💡 Watch the prices carefully, buy low, sell high, and make smart decisions." +
                            "There will be world events too, which will change stock prices dramatically.\n\n" +
                            "You'll have 5 days and after those days pass your journey will come to an end." +
                            "Whether you're cautious or a risk-taker, every choice shapes your fortune!\n\n" +
                            "This simulator is more than a game — it sharpens your financial thinking, decision-making skills, and teaches you how real investing works, without any real risk.\n\n" +
                            "Ready to become a stock market master?\nLet the trading begin! 🚀",
                            "Welcome to the Market!"
                        );

                        User insertedUser = databaseService.GetUserByUsernameAndAge(newUser.Username, newUser.Age);
                        StockMarketForm stockMarketForm = new StockMarketForm(insertedUser.Id);
                        stockMarketForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid information.");
            }
        }

        private void start_Button_ForContinueMyJourney_Click(object sender, EventArgs e)
        {
            try
            {
                string username = userNameTextBox.Text;
                int age = Convert.ToInt32(ageTextBox.Text);
                int inputedPassword = Convert.ToInt32(passwordTextBox.Text);

                var user = databaseService.GetUserByUsernameAndAge(username, age);

                if (user != null)
                {
                    if (user.Password == inputedPassword)
                    {
                        if ((DateTime.Now - user.JourneyCreationDate).TotalDays > 5)
                        {
                            string profitLossSign;
                            if (user.Balance - 10000 >= 0)
                            {
                                profitLossSign = "+";
                            }
                            else
                            {
                                profitLossSign = "-";
                            }
                            MessageBox.Show(
                                $"📅 5 Days Have Passed!\n\n" +
                                $"Your journey in the market has come to an end.\n\n" +
                                $"💰 Final Balance: ${user.Balance:N2}\n" +
                                $"🎯 Profit/Loss: {profitLossSign}${Math.Abs(user.Balance - 10000):N2}\n\n" +
                                "You’ve navigated the ups and downs of a dynamic market, made critical decisions, and tested your financial instincts.\n\n" +
                                "Whether you made a fortune or took a few losses, you’ve gained something priceless — experience! 🧠📊\n\n" +
                                "Ready to challenge the market again?\nReinvest, refine your strategy, and climb higher! 🚀",
                                "Market Session Complete!"
                            );

                            databaseService.DeleteUser(user);
                            databaseService.DeleteUserHolding(user);
                            databaseService.DeleteUserStockState(user);
                            Application.Exit();
                        }
                        StockMarketForm stockMarketForm = new StockMarketForm(user.Id);
                        stockMarketForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.");
                    }
                }
                else
                {
                    MessageBox.Show("User not found. Please register first.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for age and password.");
            }
        }
    }
}
