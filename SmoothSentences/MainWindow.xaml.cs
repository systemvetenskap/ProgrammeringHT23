using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmoothSentences
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // https://edabit.com/challenge/SkY5Nw3rS7WvkQmFc
        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool result = IsSmooth("Marta appreciated deep perpendicular right trapezoids");
            result = IsSmooth("Someone is outside the doorway"); // false
            result = IsSmooth("She eats super righteously"); // true
        }
        private bool IsEqualLetters(char a, char b)
        {
            return a == b;
        }
        private bool NotEqualLetters(char a, char b)
        {
            return !IsEqualLetters(a, b);
        }
        private char GetFirstLetter(string word)
        {
            return word[0];
        }
        private char GetLastLetter(string word)
        {
            return word[word.Length - 1];
        }
        private bool IsSmooth(string sentence)
        {
            
            string[] words = sentence.Split(' ');
            //foreach (string word in words)
            //{
            //    // hitta sista bokstaven i ordet
            //    // strängar är en array of chars
            //    // alla arrayer är indexerade
            //    char lastChar = word[word.Length - 1];
            //}

            for (int i = 0; i < words.Length; i++)
            {
                if (i + 1 >= words.Length)
                {
                    break;
                }
                string firstWord = words[i];
                char endingChar = GetLastLetter(firstWord);
                string secondWord = words[i+1];
                char startingChar = GetFirstLetter(secondWord);
               // if (endingChar != startingChar)
               if(NotEqualLetters(startingChar, endingChar))
                {
                    // Åh nej, det är ingen skön mening
                    return false;
                }
            }

            return true; 
        }
        private bool IsSmooth2(string sentence)
        {
            // ternary ? : 
            for (int i = 0; i < sentence.Length - 2; i++)
            if (char.IsWhiteSpace(sentence[i + 1]))
            if (sentence[i] != sentence[i + 2])
            return false;
            return true;
        }
    }
}
