using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNameClient.UI
{
    public partial class PlayerWindowForm : Form
    {

        private String Word;
        private String selectedCategory="animals";
        private StringBuilder display;
        private int score = 0;
        List<Button> KeyboardButtons;
        List <String>  Words = new List<String>();

        private void KeyBoardClick(Object Sender , EventArgs e )
        {
            Button Send =  Sender as Button;
            if (Send != null)
            {
                String Letter = Send.Text;
                Send.Enabled = false;
                PutLetter(Letter);
            }

        }

        private void PutLetter(String Letter)
        {
            bool FoundLetter = false;
            Letter = Letter.ToLower();
            char l = Letter[0];
           
            for (int i = 0; i < Word.Length; i++)
            {
                if (l == Word[i]) 
                { 
                    FoundLetter = true;

                    display[i] = l;
                }
            }
            if (!FoundLetter) 
            {
                MessageBox.Show($"{l} is a Wrong Letter =( ");

            }
            else
            {
                score++;
                Player1Score.Text=score.ToString();
            }
            SelectedWord.Text = display.ToString();

            if (!display.ToString().Contains("-"))
            {
                MessageBox.Show("WINNER!");
            }
        }
        private void buttonsInitialize()
        {
            KeyboardButtons = new List<Button>
           {
                buttonQ, buttonW, buttonE, buttonR, buttonT, buttonY, buttonU, buttonI, buttonO, buttonP,
                buttonA, buttonS, buttonD, buttonF, buttonG, buttonH, buttonJ, buttonK, buttonL,
                buttonZ, buttonX, buttonC, buttonV, buttonB, buttonN, buttonM
            };

            foreach (Button button in KeyboardButtons)
            {
                button.Click += KeyBoardClick;

            }
        }
    
        private void loadFromFile(string category)
        {
            string filepath = $"C:\\Users\\EGYPT_LAPTOP\\Source\\Repos\\Guess-the-Name---Multiplayer-Word-Guessing-Game\\GuessTheNameClient\\{category}.txt";
            if (File.Exists(filepath)) 
            { 
                Words= File.ReadAllLines(filepath).ToList() ;
                Random random = new Random();
                int ChosenWordIndex= random.Next(Words.Count) ;
                Word= Words[ChosenWordIndex] ;
                display = new StringBuilder(new string('-', Word.Length));
                SelectedWord.Text=display.ToString();
            } else
            {
                MessageBox.Show("nnn");
            }
        }

    public PlayerWindowForm()
        {
            InitializeComponent();
            loadFromFile(selectedCategory);
            
            buttonsInitialize();

            

        }

        
    }
}
