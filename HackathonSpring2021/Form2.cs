using System;
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

    public partial class Form2 : Form
    {


        public String convertNumtoCard(int num)
        {
            if (num < 11)
            {
                return Convert.ToString(num);
            }

            if (num == 11)
            {
                return "J";
            }
            else if (num == 12)
            {
                return "Q";
            }
            else if (num == 13)
            {
                return "K";
            }
            else
            {
                return "A";
            }
        }

        public int checkForNumsofVal(int val)
        {
            int numsOfVal = 0;
            for (int i = 0; i < myGlobals.fullDeck.Count; i++)
            {
                if (myGlobals.fullDeck[i].getCardValue() == val)
                {
                    numsOfVal++;
                }
            }
            return numsOfVal;
        }

        public bool checkForCardExistence(int val, string suit)
        {
            for (int i = 0; i < myGlobals.fullDeck.Count; i++)
            {
                if ((myGlobals.fullDeck[i].getCardValue() == val) && (myGlobals.fullDeck[i].getCardSuit() == suit))
                {
                    return true;
                }
            }
            return false;
        }

        public int straightProbability()
        {
            int incrementer = 0;
            if (isStraight())
            {
                int i = 0;
                for (i = 0; i < myGlobals.totalCards.Count; i++)
                {
                    if (myGlobals.totalCards[i].getCardValue() == 0)
                    {
                        break;
                    }
                }
                int num = ((myGlobals.totalCards[i - 1]).getCardValue() + 1);
                int iteratorNum = num;
                for (num = ((myGlobals.totalCards[i - 1]).getCardValue() + 1); num < (iteratorNum + (5 - myGlobals.NUM_OF_DEALT_CARDS)); num++)
                {
                    if (checkForNumsofVal(num) > 0)
                    {
                        incrementer++;
                    }
                }
            }
            return ((incrementer / myGlobals.fullDeck.Count) * (5 - myGlobals.NUM_OF_DEALT_CARDS)) * 100;
        }

        public bool isStraight()
        {
            //myGlobals.totalCards.Sort();
            List <Card> temp = new List<Card>();
            int min = 15;
            int tempIndex = 0;
            while(myGlobals.totalCards.Count > 0)
            {
                for (int i = 0; i < myGlobals.totalCards.Count; i++)
                {
                    if (myGlobals.totalCards[i].getCardValue() < min)
                    {
                        tempIndex = i;
                    }
                }
                temp.Add(myGlobals.totalCards[tempIndex]);
                myGlobals.totalCards.RemoveAt(tempIndex);
            }

            myGlobals.totalCards = temp;

            for (int i = 1; i < (myGlobals.NUM_OF_DEALT_CARDS + 2); i++)
            {
                if (!(myGlobals.totalCards[i - 1].getCardValue() == (myGlobals.totalCards[i].getCardValue()) - 1))
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkFlush()
        {
            int incrementer = 0;
            string suit = myGlobals.totalCards[0].getCardSuit();
            for (int i = 0; i < (myGlobals.NUM_OF_DEALT_CARDS + 2); i++)
            {
                if (myGlobals.totalCards[i].getCardSuit() == suit)
                {
                    incrementer++;
                }
            }
            if (incrementer == (myGlobals.NUM_OF_DEALT_CARDS + 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool doesExist(int element)
        {
            for (int i = 0; i < (myGlobals.NUM_OF_DEALT_CARDS + 2); i++)
            {
                if (myGlobals.totalCards[i].getCardValue() == element)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isRoyalFlush()
        {
            if (checkFlush() && doesExist(10) && doesExist(11) && doesExist(12) && doesExist(13) && doesExist(14))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int royalFlushProbability()
        {
            bool card1 = false;
            bool card2 = false;
            int numSuitRoyals = 0;
            int returnValue = 0;
            if (checkFlush())
            {
                for (int i = 10; i < 15; i++)
                {
                    if (myGlobals.totalCards[0].getCardValue() == i)
                    {
                        card1 = true;
                    }
                    if (myGlobals.totalCards[1].getCardValue() == i)
                    {
                        card2 = true;
                    }
                    if (checkForCardExistence(i, myGlobals.totalCards[0].getCardSuit()))
                    {
                        numSuitRoyals++;
                    }
                }
                if ((card1 == true) && (card2 == true))
                {
                    returnValue = (numSuitRoyals / myGlobals.fullDeck.Count) * (5 - myGlobals.NUM_OF_DEALT_CARDS);
                }
            }
            return returnValue;
        }

        public int flushProbability()
        {
            int incrementer = 0;
            if (checkFlush())
            {
                for (int i = 0; i < myGlobals.fullDeck.Count; i++)
                {
                    if (myGlobals.fullDeck[i].getCardSuit() == myGlobals.totalCards[0].getCardSuit())
                    {
                        incrementer++;
                    }
                }
            }
            return ((incrementer / myGlobals.fullDeck.Count) * (5 - myGlobals.NUM_OF_DEALT_CARDS)) * 100;
        }


        public Form2()
        {
            InitializeComponent();
            myGlobals.fullDeck = new List<Card>();

            card1ValLabel.Text = convertNumtoCard(myGlobals.totalCards[0].getCardValue());
            card1SuitLabel.Text = Convert.ToString(myGlobals.totalCards[0].getCardSuit());
            card2ValLabel.Text = convertNumtoCard(myGlobals.totalCards[1].getCardValue());
            card2SuitLabel.Text = Convert.ToString(myGlobals.totalCards[1].getCardSuit());

            if(myGlobals.NUM_OF_DEALT_CARDS == 3)
            {
                dealt1ValLabel.Text = convertNumtoCard(myGlobals.totalCards[2].getCardValue());
                dealt1SuitLabel.Text = Convert.ToString(myGlobals.totalCards[2].getCardSuit());
                dealt2ValLabel.Text = convertNumtoCard(myGlobals.totalCards[3].getCardValue());
                dealt2SuitLabel.Text = Convert.ToString(myGlobals.totalCards[3].getCardSuit());
                dealt3ValLabel.Text = convertNumtoCard(myGlobals.totalCards[4].getCardValue());
                dealt3SuitLabel.Text = Convert.ToString(myGlobals.totalCards[4].getCardSuit());
            }
            else if (myGlobals.NUM_OF_DEALT_CARDS == 4)
            {
                dealt1ValLabel.Text = convertNumtoCard(myGlobals.totalCards[2].getCardValue());
                dealt1SuitLabel.Text = Convert.ToString(myGlobals.totalCards[2].getCardSuit());
                dealt2ValLabel.Text = convertNumtoCard(myGlobals.totalCards[3].getCardValue());
                dealt2SuitLabel.Text = Convert.ToString(myGlobals.totalCards[3].getCardSuit());
                dealt3ValLabel.Text = convertNumtoCard(myGlobals.totalCards[4].getCardValue());
                dealt3SuitLabel.Text = Convert.ToString(myGlobals.totalCards[4].getCardSuit());
                dealt4ValLabel.Text = convertNumtoCard(myGlobals.totalCards[5].getCardValue());
                dealt4SuitLabel.Text = Convert.ToString(myGlobals.totalCards[5].getCardSuit());    
            }
            else if (myGlobals.NUM_OF_DEALT_CARDS == 4)
            {
                dealt1ValLabel.Text = convertNumtoCard(myGlobals.totalCards[2].getCardValue());
                dealt1SuitLabel.Text = Convert.ToString(myGlobals.totalCards[2].getCardSuit());
                dealt2ValLabel.Text = convertNumtoCard(myGlobals.totalCards[3].getCardValue());
                dealt2SuitLabel.Text = Convert.ToString(myGlobals.totalCards[3].getCardSuit());
                dealt3ValLabel.Text = convertNumtoCard(myGlobals.totalCards[4].getCardValue());
                dealt3SuitLabel.Text = Convert.ToString(myGlobals.totalCards[4].getCardSuit());
                dealt4ValLabel.Text = convertNumtoCard(myGlobals.totalCards[5].getCardValue());
                dealt4SuitLabel.Text = Convert.ToString(myGlobals.totalCards[5].getCardSuit());
                dealt5ValLabel.Text = convertNumtoCard(myGlobals.totalCards[6].getCardValue());
                dealt5SuitLabel.Text = Convert.ToString(myGlobals.totalCards[6].getCardSuit());
            }

            myGlobals.fullDeck.Add(new Card("2", "Spade"));
            myGlobals.fullDeck.Add(new Card("3", "Spade"));
            myGlobals.fullDeck.Add(new Card("4", "Spade"));
            myGlobals.fullDeck.Add(new Card("5", "Spade"));
            myGlobals.fullDeck.Add(new Card("6", "Spade"));
            myGlobals.fullDeck.Add(new Card("7", "Spade"));
            myGlobals.fullDeck.Add(new Card("8", "Spade"));
            myGlobals.fullDeck.Add(new Card("9", "Spade"));
            myGlobals.fullDeck.Add(new Card("10", "Spade"));
            myGlobals.fullDeck.Add(new Card("11", "Spade"));
            myGlobals.fullDeck.Add(new Card("12", "Spade"));
            myGlobals.fullDeck.Add(new Card("13", "Spade"));
            myGlobals.fullDeck.Add(new Card("14", "Spade"));

            //
            myGlobals.fullDeck.Add(new Card("2", "Club"));
            myGlobals.fullDeck.Add(new Card("3", "Club"));
            myGlobals.fullDeck.Add(new Card("4", "Club"));
            myGlobals.fullDeck.Add(new Card("5", "Club"));
            myGlobals.fullDeck.Add(new Card("6", "Club"));
            myGlobals.fullDeck.Add(new Card("7", "Club"));
            myGlobals.fullDeck.Add(new Card("8", "Club"));
            myGlobals.fullDeck.Add(new Card("9", "Club"));
            myGlobals.fullDeck.Add(new Card("10", "Club"));
            myGlobals.fullDeck.Add(new Card("11", "Club"));
            myGlobals.fullDeck.Add(new Card("12", "Club"));
            myGlobals.fullDeck.Add(new Card("13", "Club"));
            myGlobals.fullDeck.Add(new Card("14", "Club"));

            //
            myGlobals.fullDeck.Add(new Card("2", "Heart"));
            myGlobals.fullDeck.Add(new Card("3", "Heart"));
            myGlobals.fullDeck.Add(new Card("4", "Heart"));
            myGlobals.fullDeck.Add(new Card("5", "Heart"));
            myGlobals.fullDeck.Add(new Card("6", "Heart"));
            myGlobals.fullDeck.Add(new Card("7", "Heart"));
            myGlobals.fullDeck.Add(new Card("8", "Heart"));
            myGlobals.fullDeck.Add(new Card("9", "Heart"));
            myGlobals.fullDeck.Add(new Card("10", "Heart"));
            myGlobals.fullDeck.Add(new Card("11", "Heart"));
            myGlobals.fullDeck.Add(new Card("12", "Heart"));
            myGlobals.fullDeck.Add(new Card("13", "Heart"));
            myGlobals.fullDeck.Add(new Card("14", "Heart"));
            //
            myGlobals.fullDeck.Add(new Card("2", "Diamond"));
            myGlobals.fullDeck.Add(new Card("3", "Diamond"));
            myGlobals.fullDeck.Add(new Card("4", "Diamond"));
            myGlobals.fullDeck.Add(new Card("5", "Diamond"));
            myGlobals.fullDeck.Add(new Card("6", "Diamond"));
            myGlobals.fullDeck.Add(new Card("7", "Diamond"));
            myGlobals.fullDeck.Add(new Card("8", "Diamond"));
            myGlobals.fullDeck.Add(new Card("9", "Diamond"));
            myGlobals.fullDeck.Add(new Card("10", "Diamond"));
            myGlobals.fullDeck.Add(new Card("11", "Diamond"));
            myGlobals.fullDeck.Add(new Card("12", "Diamond"));
            myGlobals.fullDeck.Add(new Card("13", "Diamond"));
            myGlobals.fullDeck.Add(new Card("14", "Diamond"));


            if(isRoyalFlush())
            {
                currHandStrengthLabel.Text = "Royal Flush";
            }
            else if(isStraight() && checkFlush())
            {
                currHandStrengthLabel.Text = "Straight Flush";
            }
            else if(checkFlush())
            {
                currHandStrengthLabel.Text = "Flush";
            }
            else if(isStraight())
            {
                currHandStrengthLabel.Text = "Straight";
            }

            straightLabel.Text = "Straight: " + Convert.ToString(straightProbability()) + " %";
            royalFlushLabel.Text = "Royal Flush: " + Convert.ToString(royalFlushProbability()) + " %";
            flushLabel.Text = "Royal Flush: " + Convert.ToString(flushProbability()) + " %";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 createHand = new Form1();
            createHand.ShowDialog();
            this.Close();
        }
    }
}

