namespace Project_3
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.stockMarketSimulator_label = new System.Windows.Forms.Label();
            this.continueJourney_button = new System.Windows.Forms.Button();
            this.newSimulation_button = new System.Windows.Forms.Button();
            this.registration_label = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.registration_username_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.start_button_ForNewSimulation = new System.Windows.Forms.Button();
            this.Password_label = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.start_Button_ForContinueMyJourney = new System.Windows.Forms.Button();
            this.logIn_Label = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stockMarketSimulator_label
            // 
            this.stockMarketSimulator_label.AutoSize = true;
            this.stockMarketSimulator_label.BackColor = System.Drawing.Color.Transparent;
            this.stockMarketSimulator_label.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockMarketSimulator_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stockMarketSimulator_label.Location = new System.Drawing.Point(33, 48);
            this.stockMarketSimulator_label.Name = "stockMarketSimulator_label";
            this.stockMarketSimulator_label.Size = new System.Drawing.Size(530, 46);
            this.stockMarketSimulator_label.TabIndex = 0;
            this.stockMarketSimulator_label.Text = "STOCK MARKET SIMULATOR";
            // 
            // continueJourney_button
            // 
            this.continueJourney_button.BackColor = System.Drawing.Color.DarkOrange;
            this.continueJourney_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.continueJourney_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueJourney_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueJourney_button.ForeColor = System.Drawing.Color.Transparent;
            this.continueJourney_button.Location = new System.Drawing.Point(341, 309);
            this.continueJourney_button.Name = "continueJourney_button";
            this.continueJourney_button.Size = new System.Drawing.Size(233, 84);
            this.continueJourney_button.TabIndex = 1;
            this.continueJourney_button.Text = "Continue My Journey";
            this.continueJourney_button.UseVisualStyleBackColor = false;
            this.continueJourney_button.Click += new System.EventHandler(this.continueJourney_button_Click);
            // 
            // newSimulation_button
            // 
            this.newSimulation_button.BackColor = System.Drawing.Color.Orange;
            this.newSimulation_button.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.newSimulation_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newSimulation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSimulation_button.ForeColor = System.Drawing.Color.Transparent;
            this.newSimulation_button.Location = new System.Drawing.Point(59, 309);
            this.newSimulation_button.Name = "newSimulation_button";
            this.newSimulation_button.Size = new System.Drawing.Size(233, 84);
            this.newSimulation_button.TabIndex = 2;
            this.newSimulation_button.Text = "Start a New Simulation";
            this.newSimulation_button.UseVisualStyleBackColor = false;
            this.newSimulation_button.Click += new System.EventHandler(this.newSimulation_button_Click);
            // 
            // registration_label
            // 
            this.registration_label.AutoSize = true;
            this.registration_label.BackColor = System.Drawing.Color.Transparent;
            this.registration_label.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registration_label.Location = new System.Drawing.Point(211, 55);
            this.registration_label.Name = "registration_label";
            this.registration_label.Size = new System.Drawing.Size(245, 37);
            this.registration_label.TabIndex = 3;
            this.registration_label.Text = "REGISTRATION";
            this.registration_label.Visible = false;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(218, 151);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(194, 22);
            this.userNameTextBox.TabIndex = 4;
            this.userNameTextBox.Visible = false;
            // 
            // registration_username_label
            // 
            this.registration_username_label.AutoSize = true;
            this.registration_username_label.BackColor = System.Drawing.Color.Transparent;
            this.registration_username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_username_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registration_username_label.Location = new System.Drawing.Point(58, 144);
            this.registration_username_label.Name = "registration_username_label";
            this.registration_username_label.Size = new System.Drawing.Size(139, 29);
            this.registration_username_label.TabIndex = 5;
            this.registration_username_label.Text = "Username:";
            this.registration_username_label.Visible = false;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.BackColor = System.Drawing.Color.Transparent;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.age_label.Location = new System.Drawing.Point(131, 183);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(66, 29);
            this.age_label.TabIndex = 6;
            this.age_label.Text = "Age:";
            this.age_label.Visible = false;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(218, 190);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(194, 22);
            this.ageTextBox.TabIndex = 7;
            this.ageTextBox.Visible = false;
            // 
            // start_button_ForNewSimulation
            // 
            this.start_button_ForNewSimulation.BackColor = System.Drawing.Color.Orange;
            this.start_button_ForNewSimulation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.start_button_ForNewSimulation.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.start_button_ForNewSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button_ForNewSimulation.Font = new System.Drawing.Font("Stencil", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button_ForNewSimulation.ForeColor = System.Drawing.Color.Transparent;
            this.start_button_ForNewSimulation.Location = new System.Drawing.Point(218, 360);
            this.start_button_ForNewSimulation.Name = "start_button_ForNewSimulation";
            this.start_button_ForNewSimulation.Size = new System.Drawing.Size(196, 62);
            this.start_button_ForNewSimulation.TabIndex = 8;
            this.start_button_ForNewSimulation.Text = "Start";
            this.start_button_ForNewSimulation.UseVisualStyleBackColor = false;
            this.start_button_ForNewSimulation.Visible = false;
            this.start_button_ForNewSimulation.Click += new System.EventHandler(this.start_button_ForNewSimulation_Click);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.BackColor = System.Drawing.Color.Transparent;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Password_label.Location = new System.Drawing.Point(62, 222);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(135, 29);
            this.Password_label.TabIndex = 9;
            this.Password_label.Text = "Password:";
            this.Password_label.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(218, 229);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 22);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.Visible = false;
            // 
            // start_Button_ForContinueMyJourney
            // 
            this.start_Button_ForContinueMyJourney.BackColor = System.Drawing.Color.DarkOrange;
            this.start_Button_ForContinueMyJourney.Cursor = System.Windows.Forms.Cursors.Default;
            this.start_Button_ForContinueMyJourney.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.start_Button_ForContinueMyJourney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_Button_ForContinueMyJourney.Font = new System.Drawing.Font("Stencil", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_Button_ForContinueMyJourney.ForeColor = System.Drawing.Color.Transparent;
            this.start_Button_ForContinueMyJourney.Location = new System.Drawing.Point(218, 360);
            this.start_Button_ForContinueMyJourney.Name = "start_Button_ForContinueMyJourney";
            this.start_Button_ForContinueMyJourney.Size = new System.Drawing.Size(196, 62);
            this.start_Button_ForContinueMyJourney.TabIndex = 11;
            this.start_Button_ForContinueMyJourney.Text = "Start";
            this.start_Button_ForContinueMyJourney.UseVisualStyleBackColor = false;
            this.start_Button_ForContinueMyJourney.Visible = false;
            this.start_Button_ForContinueMyJourney.Click += new System.EventHandler(this.start_Button_ForContinueMyJourney_Click);
            // 
            // logIn_Label
            // 
            this.logIn_Label.AutoSize = true;
            this.logIn_Label.BackColor = System.Drawing.Color.Transparent;
            this.logIn_Label.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logIn_Label.Location = new System.Drawing.Point(262, 55);
            this.logIn_Label.Name = "logIn_Label";
            this.logIn_Label.Size = new System.Drawing.Size(118, 37);
            this.logIn_Label.TabIndex = 12;
            this.logIn_Label.Text = "Log In";
            this.logIn_Label.Visible = false;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.back_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(512, 11);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 51);
            this.back_btn.TabIndex = 13;
            this.back_btn.Text = "🔙";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Visible = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.logIn_Label);
            this.Controls.Add(this.start_Button_ForContinueMyJourney);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.start_button_ForNewSimulation);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.registration_username_label);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.registration_label);
            this.Controls.Add(this.newSimulation_button);
            this.Controls.Add(this.continueJourney_button);
            this.Controls.Add(this.stockMarketSimulator_label);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stockMarketSimulator_label;
        private System.Windows.Forms.Button continueJourney_button;
        private System.Windows.Forms.Button newSimulation_button;
        private System.Windows.Forms.Label registration_label;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label registration_username_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Button start_button_ForNewSimulation;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button start_Button_ForContinueMyJourney;
        private System.Windows.Forms.Label logIn_Label;
        private System.Windows.Forms.Button back_btn;
    }
}

