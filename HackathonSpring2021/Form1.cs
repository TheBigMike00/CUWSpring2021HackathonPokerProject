using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HackathonSpring2021
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox1 = new PictureBox();
        public void changeVisibility()
        {
            if(myGlobals.NUM_OF_DEALT_CARDS == 0)
            {
                dealt1Label.Visible = false;
                dealt1ValComboBox.Visible = false;
                dealt1SuitComboBox.Visible = false;

                dealt2Label.Visible = false;
                dealt2ValComboBox.Visible = false;
                dealt2SuitComboBox.Visible = false;

                dealt3Label.Visible = false;
                dealt3ValComboBox.Visible = false;
                dealt3SuitComboBox.Visible = false;

                dealt4Label.Visible = false;
                dealt4ValComboBox.Visible = false;
                dealt4SuitComboBox.Visible = false;

                dealt5Label.Visible = false;
                dealt5ValComboBox.Visible = false;
                dealt5SuitComboBox.Visible = false;
            }
            else if(myGlobals.NUM_OF_DEALT_CARDS == 3)
            {
                dealt1Label.Visible = true;
                dealt1ValComboBox.Visible = true;
                dealt1SuitComboBox.Visible = true;

                dealt2Label.Visible = true;
                dealt2ValComboBox.Visible = true;
                dealt2SuitComboBox.Visible = true;

                dealt3Label.Visible = true;
                dealt3ValComboBox.Visible = true;
                dealt3SuitComboBox.Visible = true;

                dealt4Label.Visible = false;
                dealt4ValComboBox.Visible = false;
                dealt4SuitComboBox.Visible = false;

                dealt5Label.Visible = false;
                dealt5ValComboBox.Visible = false;
                dealt5SuitComboBox.Visible = false;
            }
            else if (myGlobals.NUM_OF_DEALT_CARDS == 4)
            {
                dealt1Label.Visible = true;
                dealt1ValComboBox.Visible = true;
                dealt1SuitComboBox.Visible = true;

                dealt2Label.Visible = true;
                dealt2ValComboBox.Visible = true;
                dealt2SuitComboBox.Visible = true;

                dealt3Label.Visible = true;
                dealt3ValComboBox.Visible = true;
                dealt3SuitComboBox.Visible = true;

                dealt4Label.Visible = true;
                dealt4ValComboBox.Visible = true;
                dealt4SuitComboBox.Visible = true;

                dealt5Label.Visible = false;
                dealt5ValComboBox.Visible = false;
                dealt5SuitComboBox.Visible = false;
            }
            else
            {
                dealt1Label.Visible = true;
                dealt1ValComboBox.Visible = true;
                dealt1SuitComboBox.Visible = true;

                dealt2Label.Visible = true;
                dealt2ValComboBox.Visible = true;
                dealt2SuitComboBox.Visible = true;

                dealt3Label.Visible = true;
                dealt3ValComboBox.Visible = true;
                dealt3SuitComboBox.Visible = true;

                dealt4Label.Visible = true;
                dealt4ValComboBox.Visible = true;
                dealt4SuitComboBox.Visible = true;

                dealt5Label.Visible = true;
                dealt5ValComboBox.Visible = true;
                dealt5SuitComboBox.Visible = true;
            }
        }

        public void loadCards()
        {
            if (myGlobals.NUM_OF_DEALT_CARDS == 0)
            {
                if (myGlobals.totalCards != null)
                {
                    myGlobals.totalCards.Clear();
                }
                Card card1 = new Card(card1ValComboBox.Text, card1SuitComboBox.Text);
                Card card2 = new Card(card2ValComboBox.Text, card2SuitComboBox.Text);
                myGlobals.totalCards.Add(card1);
                myGlobals.totalCards.Add(card2);

            }
            else if (myGlobals.NUM_OF_DEALT_CARDS == 3)
            {
                if (myGlobals.totalCards != null)
                {
                    myGlobals.totalCards.Clear();
                }
                Card card1 = new Card(card1ValComboBox.Text, card1SuitComboBox.Text);
                Card card2 = new Card(card2ValComboBox.Text, card2SuitComboBox.Text);
                Card dealt1 = new Card(dealt1ValComboBox.Text, dealt1SuitComboBox.Text);
                Card dealt2 = new Card(dealt2ValComboBox.Text, dealt2SuitComboBox.Text);
                Card dealt3 = new Card(dealt3ValComboBox.Text, dealt3SuitComboBox.Text);
                myGlobals.totalCards.Add(card1);
                myGlobals.totalCards.Add(card2);
                myGlobals.totalCards.Add(dealt1);
                myGlobals.totalCards.Add(dealt2);
                myGlobals.totalCards.Add(dealt3);
            }
            else if (myGlobals.NUM_OF_DEALT_CARDS == 4)
            {
                if (myGlobals.totalCards != null)
                {
                    myGlobals.totalCards.Clear();
                }
                Card card1 = new Card(card1ValComboBox.Text, card1SuitComboBox.Text);
                Card card2 = new Card(card2ValComboBox.Text, card2SuitComboBox.Text);
                Card dealt1 = new Card(dealt1ValComboBox.Text, dealt1SuitComboBox.Text);
                Card dealt2 = new Card(dealt2ValComboBox.Text, dealt2SuitComboBox.Text);
                Card dealt3 = new Card(dealt3ValComboBox.Text, dealt3SuitComboBox.Text);
                Card dealt4 = new Card(dealt4ValComboBox.Text, dealt4SuitComboBox.Text);
                myGlobals.totalCards.Add(card1);
                myGlobals.totalCards.Add(card2);
                myGlobals.totalCards.Add(dealt1);
                myGlobals.totalCards.Add(dealt2);
                myGlobals.totalCards.Add(dealt3);
                myGlobals.totalCards.Add(dealt4);
            }
            else
            {
                if (myGlobals.totalCards != null)
                {
                    myGlobals.totalCards.Clear();
                }
                Card card1 = new Card(card1ValComboBox.Text, card1SuitComboBox.Text);
                Card card2 = new Card(card2ValComboBox.Text, card2SuitComboBox.Text);
                Card dealt1 = new Card(dealt1ValComboBox.Text, dealt1SuitComboBox.Text);
                Card dealt2 = new Card(dealt2ValComboBox.Text, dealt2SuitComboBox.Text);
                Card dealt3 = new Card(dealt3ValComboBox.Text, dealt3SuitComboBox.Text);
                Card dealt4 = new Card(dealt4ValComboBox.Text, dealt4SuitComboBox.Text);
                Card dealt5 = new Card(dealt5ValComboBox.Text, dealt5SuitComboBox.Text);
                myGlobals.totalCards.Add(card1);
                myGlobals.totalCards.Add(card2);
                myGlobals.totalCards.Add(dealt1);
                myGlobals.totalCards.Add(dealt2);
                myGlobals.totalCards.Add(dealt3);
                myGlobals.totalCards.Add(dealt4);
                myGlobals.totalCards.Add(dealt5);
            }
        }

        public bool allInputsSet()
        {
            if(card1ValComboBox.Text == "select" || card2ValComboBox.Text == "select"
                || card1SuitComboBox.Text == "select" || card2SuitComboBox.Text == "select")
            {
                return false;
            }
            if(numberOfDealtCardsCB.Text == "select")
            {
                return false;
            }

            if(myGlobals.NUM_OF_DEALT_CARDS == 3)
            {
                if(dealt1ValComboBox.Text == "Select Value" || dealt1SuitComboBox.Text == "Select Suit"
                    || dealt2ValComboBox.Text == "Select Value" || dealt2SuitComboBox.Text == "Select Suit"
                    || dealt3ValComboBox.Text == "Select Value" || dealt3SuitComboBox.Text == "Select Suit")
                {
                    return false;
                }
            }
            else if (myGlobals.NUM_OF_DEALT_CARDS == 4)
            {
                if(dealt1ValComboBox.Text == "Select Value" || dealt1SuitComboBox.Text == "Select Suit"
                    || dealt2ValComboBox.Text == "Select Value" || dealt2SuitComboBox.Text == "Select Suit"
                    || dealt3ValComboBox.Text == "Select Value" || dealt3SuitComboBox.Text == "Select Suit"
                    || dealt4ValComboBox.Text == "Select Value" || dealt4SuitComboBox.Text == "Select Suit")
                {
                    return false;
                }
            }
            else if (myGlobals.NUM_OF_DEALT_CARDS == 5)
            {
                if (dealt1ValComboBox.Text == "Select Value" || dealt1SuitComboBox.Text == "Select Suit"
                    || dealt2ValComboBox.Text == "Select Value" || dealt2SuitComboBox.Text == "Select Suit"
                    || dealt3ValComboBox.Text == "Select Value" || dealt3SuitComboBox.Text == "Select Suit"
                    || dealt4ValComboBox.Text == "Select Value" || dealt4SuitComboBox.Text == "Select Suit"
                    || dealt5ValComboBox.Text == "Select Value" || dealt5SuitComboBox.Text == "Select Suit")
                {
                    return false;
                }
            }
         return true;
        }

        public Form1()
        {
            InitializeComponent();
            myGlobals.NUM_OF_DEALT_CARDS = 0;
            myGlobals.totalCards = new List <Card>();
            changeVisibility();
            
        }

        private void numberOfDealtCardsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            myGlobals.NUM_OF_DEALT_CARDS = Convert.ToInt32(numberOfDealtCardsCB.Text);
            changeVisibility();
            if(allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void card1ValComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }

        }

        private void card1SuitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void card2ValComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void card2SuitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void dealt1ValComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void dealt1SuitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void dealt2ValComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void dealt2SuitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void dealt3ValComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void dealt3SuitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void dealt4ValComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void dealt4SuitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void dealt5ValComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void dealt5SuitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void showStrengthButton_Click(object sender, EventArgs e)
        {
            if (allInputsSet())
            {
                loadCards();
                showStrengthButton.BackColor = Color.Green;
                this.Hide();
                Form2 showStrengthForm = new Form2();
                showStrengthForm.ShowDialog();
                this.Close();
            }
            else
            {
                showStrengthButton.BackColor = Color.Red;
            }
        }

        private void handHierarchyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 handChart = new Form3();
            handChart.ShowDialog();
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Poker Hand Strength Generator!!!\n\n" +
                "Insert your poker hand and dealt cards using the drop down\n" +
                "menus provided.\n\n" +
                "Show Hand Strength: Examine the strength of your hand given the scenario you" +
                "have provided. \n(Red-inputs are invalid, Green-you're ready to view your hand!\n\n" +
                "Hand Hierarchy: Learn which hands are best!", "Help Menu");
        }
    }

    
}

public class Card
{
    //Mapping...
    //J -> 11, Q -> 12, K -> 13, A -> 14
    private string suit = "Empty";
    private int value = 0;

    public Card(String value, String suit)
    {
        if (value != "J" && value != "Q" && value != "K" && value != "A")
        {
            this.value = Convert.ToInt32(value);
        }
        else
        {
            if (value == "J")
            {
                this.value = 11;
            }
            else if (value == "Q")
            {
                this.value = 12;
            }
            else if (value == "K")
            {
                this.value = 13;
            }
            else
            {
                this.value = 14;
            }
        }
        this.suit = suit;
    }

    public int getCardValue()
    {
        return this.value;
    }

    public String getCardSuit()
    {
        return this.suit;
    }
}
public static class myGlobals
{
    public static List <Card> totalCards;
    public static List<Card> fullDeck;
    public static int NUM_OF_DEALT_CARDS;
}