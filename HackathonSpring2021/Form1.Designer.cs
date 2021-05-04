namespace HackathonSpring2021
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yourCardsLabel = new System.Windows.Forms.Label();
            this.dealtCardsLabel = new System.Windows.Forms.Label();
            this.card1ValLabel = new System.Windows.Forms.Label();
            this.card1ValComboBox = new System.Windows.Forms.ComboBox();
            this.card1SuitLabel = new System.Windows.Forms.Label();
            this.card1SuitComboBox = new System.Windows.Forms.ComboBox();
            this.card2ValLabel = new System.Windows.Forms.Label();
            this.card2SuitLabel = new System.Windows.Forms.Label();
            this.card2ValComboBox = new System.Windows.Forms.ComboBox();
            this.card2SuitComboBox = new System.Windows.Forms.ComboBox();
            this.numOfDealtCardsLabel = new System.Windows.Forms.Label();
            this.dealt1Label = new System.Windows.Forms.Label();
            this.dealt1ValComboBox = new System.Windows.Forms.ComboBox();
            this.dealt1SuitComboBox = new System.Windows.Forms.ComboBox();
            this.dealt2Label = new System.Windows.Forms.Label();
            this.numberOfDealtCardsCB = new System.Windows.Forms.ComboBox();
            this.dealt2ValComboBox = new System.Windows.Forms.ComboBox();
            this.dealt2SuitComboBox = new System.Windows.Forms.ComboBox();
            this.dealt3Label = new System.Windows.Forms.Label();
            this.dealt3ValComboBox = new System.Windows.Forms.ComboBox();
            this.dealt3SuitComboBox = new System.Windows.Forms.ComboBox();
            this.dealt4Label = new System.Windows.Forms.Label();
            this.dealt4ValComboBox = new System.Windows.Forms.ComboBox();
            this.dealt4SuitComboBox = new System.Windows.Forms.ComboBox();
            this.dealt5Label = new System.Windows.Forms.Label();
            this.dealt5ValComboBox = new System.Windows.Forms.ComboBox();
            this.dealt5SuitComboBox = new System.Windows.Forms.ComboBox();
            this.showStrengthButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.handHierarchyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yourCardsLabel
            // 
            this.yourCardsLabel.AutoSize = true;
            this.yourCardsLabel.BackColor = System.Drawing.Color.Transparent;
            this.yourCardsLabel.Font = new System.Drawing.Font("Stencil", 13F);
            this.yourCardsLabel.Location = new System.Drawing.Point(305, 9);
            this.yourCardsLabel.Name = "yourCardsLabel";
            this.yourCardsLabel.Size = new System.Drawing.Size(170, 31);
            this.yourCardsLabel.TabIndex = 0;
            this.yourCardsLabel.Text = "Your Cards";
            // 
            // dealtCardsLabel
            // 
            this.dealtCardsLabel.AutoSize = true;
            this.dealtCardsLabel.BackColor = System.Drawing.Color.Transparent;
            this.dealtCardsLabel.Font = new System.Drawing.Font("Stencil", 15F);
            this.dealtCardsLabel.Location = new System.Drawing.Point(293, 178);
            this.dealtCardsLabel.Name = "dealtCardsLabel";
            this.dealtCardsLabel.Size = new System.Drawing.Size(207, 35);
            this.dealtCardsLabel.TabIndex = 1;
            this.dealtCardsLabel.Text = "Dealt Cards";
            // 
            // card1ValLabel
            // 
            this.card1ValLabel.AutoSize = true;
            this.card1ValLabel.BackColor = System.Drawing.Color.Transparent;
            this.card1ValLabel.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic);
            this.card1ValLabel.Location = new System.Drawing.Point(104, 60);
            this.card1ValLabel.Name = "card1ValLabel";
            this.card1ValLabel.Size = new System.Drawing.Size(143, 21);
            this.card1ValLabel.TabIndex = 2;
            this.card1ValLabel.Text = "Card 1 Value: ";
            // 
            // card1ValComboBox
            // 
            this.card1ValComboBox.BackColor = System.Drawing.Color.White;
            this.card1ValComboBox.FormattingEnabled = true;
            this.card1ValComboBox.Items.AddRange(new object[] {
            "A",
            "K",
            "Q",
            "J",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2"});
            this.card1ValComboBox.Location = new System.Drawing.Point(241, 57);
            this.card1ValComboBox.Name = "card1ValComboBox";
            this.card1ValComboBox.Size = new System.Drawing.Size(121, 28);
            this.card1ValComboBox.TabIndex = 3;
            this.card1ValComboBox.Text = "select";
            this.card1ValComboBox.SelectedIndexChanged += new System.EventHandler(this.card1ValComboBox_SelectedIndexChanged);
            // 
            // card1SuitLabel
            // 
            this.card1SuitLabel.AutoSize = true;
            this.card1SuitLabel.BackColor = System.Drawing.Color.Transparent;
            this.card1SuitLabel.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic);
            this.card1SuitLabel.Location = new System.Drawing.Point(119, 124);
            this.card1SuitLabel.Name = "card1SuitLabel";
            this.card1SuitLabel.Size = new System.Drawing.Size(128, 21);
            this.card1SuitLabel.TabIndex = 4;
            this.card1SuitLabel.Text = "Card 1 Suit: ";
            // 
            // card1SuitComboBox
            // 
            this.card1SuitComboBox.FormattingEnabled = true;
            this.card1SuitComboBox.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.card1SuitComboBox.Location = new System.Drawing.Point(241, 121);
            this.card1SuitComboBox.Name = "card1SuitComboBox";
            this.card1SuitComboBox.Size = new System.Drawing.Size(121, 28);
            this.card1SuitComboBox.TabIndex = 5;
            this.card1SuitComboBox.Text = "select";
            this.card1SuitComboBox.SelectedIndexChanged += new System.EventHandler(this.card1SuitComboBox_SelectedIndexChanged);
            // 
            // card2ValLabel
            // 
            this.card2ValLabel.AutoSize = true;
            this.card2ValLabel.BackColor = System.Drawing.Color.Transparent;
            this.card2ValLabel.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic);
            this.card2ValLabel.Location = new System.Drawing.Point(414, 60);
            this.card2ValLabel.Name = "card2ValLabel";
            this.card2ValLabel.Size = new System.Drawing.Size(143, 21);
            this.card2ValLabel.TabIndex = 6;
            this.card2ValLabel.Text = "Card 2 Value: ";
            // 
            // card2SuitLabel
            // 
            this.card2SuitLabel.AutoSize = true;
            this.card2SuitLabel.BackColor = System.Drawing.Color.Transparent;
            this.card2SuitLabel.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic);
            this.card2SuitLabel.Location = new System.Drawing.Point(429, 124);
            this.card2SuitLabel.Name = "card2SuitLabel";
            this.card2SuitLabel.Size = new System.Drawing.Size(128, 21);
            this.card2SuitLabel.TabIndex = 7;
            this.card2SuitLabel.Text = "Card 2 Suit: ";
            // 
            // card2ValComboBox
            // 
            this.card2ValComboBox.FormattingEnabled = true;
            this.card2ValComboBox.Items.AddRange(new object[] {
            "A",
            "K",
            "Q",
            "J",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2"});
            this.card2ValComboBox.Location = new System.Drawing.Point(563, 57);
            this.card2ValComboBox.Name = "card2ValComboBox";
            this.card2ValComboBox.Size = new System.Drawing.Size(121, 28);
            this.card2ValComboBox.TabIndex = 8;
            this.card2ValComboBox.Text = "select";
            this.card2ValComboBox.SelectedIndexChanged += new System.EventHandler(this.card2ValComboBox_SelectedIndexChanged);
            // 
            // card2SuitComboBox
            // 
            this.card2SuitComboBox.FormattingEnabled = true;
            this.card2SuitComboBox.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.card2SuitComboBox.Location = new System.Drawing.Point(563, 117);
            this.card2SuitComboBox.Name = "card2SuitComboBox";
            this.card2SuitComboBox.Size = new System.Drawing.Size(121, 28);
            this.card2SuitComboBox.TabIndex = 9;
            this.card2SuitComboBox.Text = "select";
            this.card2SuitComboBox.SelectedIndexChanged += new System.EventHandler(this.card2SuitComboBox_SelectedIndexChanged);
            // 
            // numOfDealtCardsLabel
            // 
            this.numOfDealtCardsLabel.AutoSize = true;
            this.numOfDealtCardsLabel.BackColor = System.Drawing.Color.Transparent;
            this.numOfDealtCardsLabel.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDealtCardsLabel.Location = new System.Drawing.Point(187, 223);
            this.numOfDealtCardsLabel.Name = "numOfDealtCardsLabel";
            this.numOfDealtCardsLabel.Size = new System.Drawing.Size(243, 21);
            this.numOfDealtCardsLabel.TabIndex = 11;
            this.numOfDealtCardsLabel.Text = "Number of Dealt Cards: ";
            // 
            // dealt1Label
            // 
            this.dealt1Label.AutoSize = true;
            this.dealt1Label.BackColor = System.Drawing.Color.Transparent;
            this.dealt1Label.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealt1Label.Location = new System.Drawing.Point(40, 270);
            this.dealt1Label.Name = "dealt1Label";
            this.dealt1Label.Size = new System.Drawing.Size(114, 19);
            this.dealt1Label.TabIndex = 12;
            this.dealt1Label.Text = "Dealt Card 1";
            // 
            // dealt1ValComboBox
            // 
            this.dealt1ValComboBox.FormattingEnabled = true;
            this.dealt1ValComboBox.Items.AddRange(new object[] {
            "A",
            "K",
            "Q",
            "J",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2"});
            this.dealt1ValComboBox.Location = new System.Drawing.Point(44, 292);
            this.dealt1ValComboBox.Name = "dealt1ValComboBox";
            this.dealt1ValComboBox.Size = new System.Drawing.Size(121, 28);
            this.dealt1ValComboBox.TabIndex = 13;
            this.dealt1ValComboBox.Text = "Select Value";
            this.dealt1ValComboBox.SelectedIndexChanged += new System.EventHandler(this.dealt1ValComboBox_SelectedIndexChanged);
            // 
            // dealt1SuitComboBox
            // 
            this.dealt1SuitComboBox.FormattingEnabled = true;
            this.dealt1SuitComboBox.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.dealt1SuitComboBox.Location = new System.Drawing.Point(44, 326);
            this.dealt1SuitComboBox.Name = "dealt1SuitComboBox";
            this.dealt1SuitComboBox.Size = new System.Drawing.Size(121, 28);
            this.dealt1SuitComboBox.TabIndex = 14;
            this.dealt1SuitComboBox.Text = "Select Suit";
            this.dealt1SuitComboBox.SelectedIndexChanged += new System.EventHandler(this.dealt1SuitComboBox_SelectedIndexChanged);
            // 
            // dealt2Label
            // 
            this.dealt2Label.AutoSize = true;
            this.dealt2Label.BackColor = System.Drawing.Color.Transparent;
            this.dealt2Label.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealt2Label.Location = new System.Drawing.Point(198, 270);
            this.dealt2Label.Name = "dealt2Label";
            this.dealt2Label.Size = new System.Drawing.Size(114, 19);
            this.dealt2Label.TabIndex = 15;
            this.dealt2Label.Text = "Dealt Card 2";
            // 
            // numberOfDealtCardsCB
            // 
            this.numberOfDealtCardsCB.FormattingEnabled = true;
            this.numberOfDealtCardsCB.Items.AddRange(new object[] {
            "0",
            "3",
            "4",
            "5"});
            this.numberOfDealtCardsCB.Location = new System.Drawing.Point(436, 220);
            this.numberOfDealtCardsCB.Name = "numberOfDealtCardsCB";
            this.numberOfDealtCardsCB.Size = new System.Drawing.Size(121, 28);
            this.numberOfDealtCardsCB.TabIndex = 16;
            this.numberOfDealtCardsCB.Text = "select";
            this.numberOfDealtCardsCB.SelectedIndexChanged += new System.EventHandler(this.numberOfDealtCardsCB_SelectedIndexChanged);
            // 
            // dealt2ValComboBox
            // 
            this.dealt2ValComboBox.FormattingEnabled = true;
            this.dealt2ValComboBox.Items.AddRange(new object[] {
            "A",
            "K",
            "Q",
            "J",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2"});
            this.dealt2ValComboBox.Location = new System.Drawing.Point(202, 292);
            this.dealt2ValComboBox.Name = "dealt2ValComboBox";
            this.dealt2ValComboBox.Size = new System.Drawing.Size(121, 28);
            this.dealt2ValComboBox.TabIndex = 17;
            this.dealt2ValComboBox.Text = "Select Value";
            this.dealt2ValComboBox.SelectedIndexChanged += new System.EventHandler(this.dealt2ValComboBox_SelectedIndexChanged);
            // 
            // dealt2SuitComboBox
            // 
            this.dealt2SuitComboBox.FormattingEnabled = true;
            this.dealt2SuitComboBox.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.dealt2SuitComboBox.Location = new System.Drawing.Point(202, 326);
            this.dealt2SuitComboBox.Name = "dealt2SuitComboBox";
            this.dealt2SuitComboBox.Size = new System.Drawing.Size(121, 28);
            this.dealt2SuitComboBox.TabIndex = 18;
            this.dealt2SuitComboBox.Text = "Select Suit";
            this.dealt2SuitComboBox.SelectedIndexChanged += new System.EventHandler(this.dealt2SuitComboBox_SelectedIndexChanged);
            // 
            // dealt3Label
            // 
            this.dealt3Label.AutoSize = true;
            this.dealt3Label.BackColor = System.Drawing.Color.Transparent;
            this.dealt3Label.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealt3Label.Location = new System.Drawing.Point(347, 270);
            this.dealt3Label.Name = "dealt3Label";
            this.dealt3Label.Size = new System.Drawing.Size(114, 19);
            this.dealt3Label.TabIndex = 19;
            this.dealt3Label.Text = "Dealt Card 3";
            // 
            // dealt3ValComboBox
            // 
            this.dealt3ValComboBox.FormattingEnabled = true;
            this.dealt3ValComboBox.Items.AddRange(new object[] {
            "A",
            "K",
            "Q",
            "J",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2"});
            this.dealt3ValComboBox.Location = new System.Drawing.Point(354, 292);
            this.dealt3ValComboBox.Name = "dealt3ValComboBox";
            this.dealt3ValComboBox.Size = new System.Drawing.Size(121, 28);
            this.dealt3ValComboBox.TabIndex = 20;
            this.dealt3ValComboBox.Text = "Select Value";
            this.dealt3ValComboBox.SelectedIndexChanged += new System.EventHandler(this.dealt3ValComboBox_SelectedIndexChanged);
            // 
            // dealt3SuitComboBox
            // 
            this.dealt3SuitComboBox.FormattingEnabled = true;
            this.dealt3SuitComboBox.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.dealt3SuitComboBox.Location = new System.Drawing.Point(354, 326);
            this.dealt3SuitComboBox.Name = "dealt3SuitComboBox";
            this.dealt3SuitComboBox.Size = new System.Drawing.Size(121, 28);
            this.dealt3SuitComboBox.TabIndex = 21;
            this.dealt3SuitComboBox.Text = "Select Suit";
            this.dealt3SuitComboBox.SelectedIndexChanged += new System.EventHandler(this.dealt3SuitComboBox_SelectedIndexChanged);
            // 
            // dealt4Label
            // 
            this.dealt4Label.AutoSize = true;
            this.dealt4Label.BackColor = System.Drawing.Color.Transparent;
            this.dealt4Label.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealt4Label.Location = new System.Drawing.Point(497, 270);
            this.dealt4Label.Name = "dealt4Label";
            this.dealt4Label.Size = new System.Drawing.Size(114, 19);
            this.dealt4Label.TabIndex = 22;
            this.dealt4Label.Text = "Dealt Card 4";
            // 
            // dealt4ValComboBox
            // 
            this.dealt4ValComboBox.FormattingEnabled = true;
            this.dealt4ValComboBox.Items.AddRange(new object[] {
            "A",
            "K",
            "Q",
            "J",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2"});
            this.dealt4ValComboBox.Location = new System.Drawing.Point(501, 292);
            this.dealt4ValComboBox.Name = "dealt4ValComboBox";
            this.dealt4ValComboBox.Size = new System.Drawing.Size(121, 28);
            this.dealt4ValComboBox.TabIndex = 23;
            this.dealt4ValComboBox.Text = "Select Value";
            this.dealt4ValComboBox.SelectedIndexChanged += new System.EventHandler(this.dealt4ValComboBox_SelectedIndexChanged);
            // 
            // dealt4SuitComboBox
            // 
            this.dealt4SuitComboBox.FormattingEnabled = true;
            this.dealt4SuitComboBox.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.dealt4SuitComboBox.Location = new System.Drawing.Point(501, 326);
            this.dealt4SuitComboBox.Name = "dealt4SuitComboBox";
            this.dealt4SuitComboBox.Size = new System.Drawing.Size(121, 28);
            this.dealt4SuitComboBox.TabIndex = 24;
            this.dealt4SuitComboBox.Text = "Select Suit";
            this.dealt4SuitComboBox.SelectedIndexChanged += new System.EventHandler(this.dealt4SuitComboBox_SelectedIndexChanged);
            // 
            // dealt5Label
            // 
            this.dealt5Label.AutoSize = true;
            this.dealt5Label.BackColor = System.Drawing.Color.Transparent;
            this.dealt5Label.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealt5Label.Location = new System.Drawing.Point(642, 270);
            this.dealt5Label.Name = "dealt5Label";
            this.dealt5Label.Size = new System.Drawing.Size(114, 19);
            this.dealt5Label.TabIndex = 25;
            this.dealt5Label.Text = "Dealt Card 5";
            // 
            // dealt5ValComboBox
            // 
            this.dealt5ValComboBox.FormattingEnabled = true;
            this.dealt5ValComboBox.Items.AddRange(new object[] {
            "A",
            "K",
            "Q",
            "J",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2"});
            this.dealt5ValComboBox.Location = new System.Drawing.Point(646, 292);
            this.dealt5ValComboBox.Name = "dealt5ValComboBox";
            this.dealt5ValComboBox.Size = new System.Drawing.Size(121, 28);
            this.dealt5ValComboBox.TabIndex = 26;
            this.dealt5ValComboBox.Text = "Select Value";
            this.dealt5ValComboBox.SelectedIndexChanged += new System.EventHandler(this.dealt5ValComboBox_SelectedIndexChanged);
            // 
            // dealt5SuitComboBox
            // 
            this.dealt5SuitComboBox.FormattingEnabled = true;
            this.dealt5SuitComboBox.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.dealt5SuitComboBox.Location = new System.Drawing.Point(646, 326);
            this.dealt5SuitComboBox.Name = "dealt5SuitComboBox";
            this.dealt5SuitComboBox.Size = new System.Drawing.Size(121, 28);
            this.dealt5SuitComboBox.TabIndex = 27;
            this.dealt5SuitComboBox.Text = "Select Suit";
            this.dealt5SuitComboBox.SelectedIndexChanged += new System.EventHandler(this.dealt5SuitComboBox_SelectedIndexChanged);
            // 
            // showStrengthButton
            // 
            this.showStrengthButton.BackColor = System.Drawing.Color.Red;
            this.showStrengthButton.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStrengthButton.Location = new System.Drawing.Point(299, 373);
            this.showStrengthButton.Name = "showStrengthButton";
            this.showStrengthButton.Size = new System.Drawing.Size(195, 65);
            this.showStrengthButton.TabIndex = 28;
            this.showStrengthButton.Text = "Show Hand Strength";
            this.showStrengthButton.UseVisualStyleBackColor = false;
            this.showStrengthButton.Click += new System.EventHandler(this.showStrengthButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpButton.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(136, 382);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(111, 46);
            this.helpButton.TabIndex = 29;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // handHierarchyButton
            // 
            this.handHierarchyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.handHierarchyButton.Font = new System.Drawing.Font("Stencil", 7F);
            this.handHierarchyButton.Location = new System.Drawing.Point(537, 382);
            this.handHierarchyButton.Name = "handHierarchyButton";
            this.handHierarchyButton.Size = new System.Drawing.Size(157, 45);
            this.handHierarchyButton.TabIndex = 30;
            this.handHierarchyButton.Text = "Hand Hierarchy";
            this.handHierarchyButton.UseVisualStyleBackColor = false;
            this.handHierarchyButton.Click += new System.EventHandler(this.handHierarchyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.handHierarchyButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.showStrengthButton);
            this.Controls.Add(this.dealt5SuitComboBox);
            this.Controls.Add(this.dealt5ValComboBox);
            this.Controls.Add(this.dealt5Label);
            this.Controls.Add(this.dealt4SuitComboBox);
            this.Controls.Add(this.dealt4ValComboBox);
            this.Controls.Add(this.dealt4Label);
            this.Controls.Add(this.dealt3SuitComboBox);
            this.Controls.Add(this.dealt3ValComboBox);
            this.Controls.Add(this.dealt3Label);
            this.Controls.Add(this.dealt2SuitComboBox);
            this.Controls.Add(this.dealt2ValComboBox);
            this.Controls.Add(this.numberOfDealtCardsCB);
            this.Controls.Add(this.dealt2Label);
            this.Controls.Add(this.dealt1SuitComboBox);
            this.Controls.Add(this.dealt1ValComboBox);
            this.Controls.Add(this.dealt1Label);
            this.Controls.Add(this.numOfDealtCardsLabel);
            this.Controls.Add(this.card2SuitComboBox);
            this.Controls.Add(this.card2ValComboBox);
            this.Controls.Add(this.card2SuitLabel);
            this.Controls.Add(this.card2ValLabel);
            this.Controls.Add(this.card1SuitComboBox);
            this.Controls.Add(this.card1SuitLabel);
            this.Controls.Add(this.card1ValComboBox);
            this.Controls.Add(this.card1ValLabel);
            this.Controls.Add(this.dealtCardsLabel);
            this.Controls.Add(this.yourCardsLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "RateMyHand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yourCardsLabel;
        private System.Windows.Forms.Label dealtCardsLabel;
        private System.Windows.Forms.Label card1ValLabel;
        private System.Windows.Forms.ComboBox card1ValComboBox;
        private System.Windows.Forms.Label card1SuitLabel;
        private System.Windows.Forms.ComboBox card1SuitComboBox;
        private System.Windows.Forms.Label card2ValLabel;
        private System.Windows.Forms.Label card2SuitLabel;
        private System.Windows.Forms.ComboBox card2ValComboBox;
        private System.Windows.Forms.ComboBox card2SuitComboBox;
        private System.Windows.Forms.Label numOfDealtCardsLabel;
        private System.Windows.Forms.Label dealt1Label;
        private System.Windows.Forms.ComboBox dealt1ValComboBox;
        private System.Windows.Forms.ComboBox dealt1SuitComboBox;
        private System.Windows.Forms.Label dealt2Label;
        private System.Windows.Forms.ComboBox numberOfDealtCardsCB;
        private System.Windows.Forms.ComboBox dealt2ValComboBox;
        private System.Windows.Forms.ComboBox dealt2SuitComboBox;
        private System.Windows.Forms.Label dealt3Label;
        private System.Windows.Forms.ComboBox dealt3ValComboBox;
        private System.Windows.Forms.ComboBox dealt3SuitComboBox;
        private System.Windows.Forms.Label dealt4Label;
        private System.Windows.Forms.ComboBox dealt4ValComboBox;
        private System.Windows.Forms.ComboBox dealt4SuitComboBox;
        private System.Windows.Forms.Label dealt5Label;
        private System.Windows.Forms.ComboBox dealt5ValComboBox;
        private System.Windows.Forms.ComboBox dealt5SuitComboBox;
        private System.Windows.Forms.Button showStrengthButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button handHierarchyButton;
    }
}

