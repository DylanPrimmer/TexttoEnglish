/*
Dylan Primmer
03/36/2018
turn text slang to proper english
*/


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

namespace txtculm_u2
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

        private void BtnRun_Click(object sender, RoutedEventArgs e)
        {
            // get 3 digits from input
            // array allows you to store more than one
            // value in array
            int[] digits = new int[3]; //array


            // check property 1
            Console.WriteLine("Last digit is )");
            //isHappy
            //            isHappy = true;
            string someString = txtInput.Text;
            if (someString == ":-)")
            {
                MessageBox.Show("Happy!");
                // check property 2
                Console.WriteLine("2nd digit is -");

                // check property 3
                Console.WriteLine("First digit is :");
            }

            // get 4 digits from input
            // array allows you to store more than one
            // value in array
            int[] letters = new int[4]; //array

            {
                // check property 4
                Console.WriteLine("Last digit is L");
                //isHappy
                //            isTalkToYouLater = true;
                string String = txtInput.Text;
                if (someString == "TTYL")
                {
                    MessageBox.Show("Talk To you Later");
                    // check property 5
                    Console.WriteLine("First and second digits are the same");

                    // check property 6
                    Console.WriteLine("Third digit is Y");
                }
                // get 3 digits from input
                // array allows you to store more than one
                // value in array
                int[] letter = new int[3]; //array

                {
                    // check property 7
                    Console.WriteLine("First and Last digits are the same");
                    //isLaughingOutLoud
                    //            isLaughingOutLoud = true;
                    string Strings = txtInput.Text;
                    if (someString == "LOL")
                    {
                        MessageBox.Show("Laughing Out Loud");
                        // check property 8
                        Console.WriteLine("Second digit is a O");

                    }

                    // get 3 digits from input
                    // array allows you to store more than one
                    // value in array
                    int[] idk = new int[3]; //array

                    // check property 9
                    Console.WriteLine("Last digit is (");
                    //isSad
                    //            isSad = true;
                    string k = txtInput.Text;
                    if (someString == ":-(")
                    {
                        MessageBox.Show("Sad..");
                        // check property 10
                        Console.WriteLine("2nd digit is -");

                        // check property 11
                        Console.WriteLine("First digit is :");
                    }
                    // get 2 digits from input
                    // array allows you to store more than one
                    // value in array
                    int[] TY = new int[2]; //array

                    // check property 12
                    Console.WriteLine("Last digit is Y");
                    //isThankYou
                    //            isThankYou = true;
                    string lolol = txtInput.Text;
                    if (someString == "TY")
                    {
                        MessageBox.Show("Thank You!");

                        // check property 13
                        Console.WriteLine("First digit is T");
                    }
                    // get 2 digits from input
                    // array allows you to store more than one
                    // value in array
                    int[] YW = new int[2];

                    // check property 14
                    Console.WriteLine("Last digit is W");
                    //isYou'reWelcome
                    //            isYou'reWelcome = true;
                    string loll = txtInput.Text;
                    if (someString == "YW")
                    {
                        MessageBox.Show("You're Welcome!");

                        // check property 15
                        Console.WriteLine("First digit is Y");
                    }
                    // get 3 digits from input
                    // array allows you to store more than one
                    // value in array
                    int[] Cuz = new int[3]; //array

                    {
                        // check property 16
                        Console.WriteLine("First digit is C");
                        //isBecause
                        //            isBecause = true;
                        string cuz = txtInput.Text;
                        if (someString == "CUZ")
                        {
                            MessageBox.Show("Because");
                            // check property 17
                            Console.WriteLine("Second digit is a U");

                            // check property 18
                            Console.WriteLine("Last digit is a Z");
                        }

                        // get 3 digits from input
                        // array allows you to store more than one
                        // value in array
                        int[] winking = new int[3]; //array

                        // check property 19
                        Console.WriteLine("Last digit is )");
                        //isWink
                        //            isWink = true;
                        string wink = txtInput.Text;
                        if (someString == ";-)")
                        {
                            MessageBox.Show("Wink");
                            // check property 20
                            Console.WriteLine("2nd digit is -");

                            // check property 21
                            Console.WriteLine("First digit is ;");
                        }
                        // get 5 digits from input
                        // array allows you to store more than one
                        // value in array
                        int[] Sleepy = new int[5]; //array

                        //isSleepy
                        //            isSleepy = true;
                        string tired = txtInput.Text;
                        if (someString == "(˜.˜)")

                        {
                            MessageBox.Show("Sleepy");
                            // check property 22
                            Console.WriteLine("second and fourth digits are the same");

                            // check property 23
                            Console.WriteLine("First and last digits are the same ");

                            // check property 24
                            Console.WriteLine("Third digit is a .");
                        }
                        // get 3 digits from input
                        // array allows you to store more than one
                        // value in array
                        int[] StickOut = new int[3]; //array

                        // check property 19
                        Console.WriteLine("Last digit is P");
                        //isStickingOutTongue
                        //            isStickingOutTongue = true;
                        string tongue = txtInput.Text;
                        if (someString == ":-P")
                        {
                            MessageBox.Show("Sticking Out Tongue");
                            // check property 20
                            Console.WriteLine("2nd digit is -");

                            // check property 21
                            Console.WriteLine("First digit is :");
                        }
                        // get 2 digits from input
                        // array allows you to store more than one
                        // value in array
                        int[] TA = new int[2]; //array

                        // check property 22
                        Console.WriteLine("Last digit is A");
                        //isTotallyAwesome
                        //            isTotallyAwesome = true;
                        string Ta = txtInput.Text;
                        if (someString == "TA")
                        {
                            MessageBox.Show("Totally Awesome!");

                            // check property 23
                            Console.WriteLine("First digit is T");
                        }
                        // get 3 digits from input
                        // array allows you to store more than one
                        // value in array
                        int[] CCC = new int[3]; //array

                        {
                            // check property 24
                            Console.WriteLine("All digits are C");
                            //isCCC
                            //            isCCC = true;
                            string ccc = txtInput.Text;
                            if (someString == "CCC")
                            {
                                MessageBox.Show("Canadian Computing Competition");
                            }
                            // get 2 digits from input
                            // array allows you to store more than one
                            // value in array
                            int[] CU = new int[2]; //array

                            // check property 25
                            Console.WriteLine("Last digit is U");
                            //isSeeYou
                            //            isSeeYou = true;
                            string cu = txtInput.Text;
                            if (someString == "CU")
                            {
                                MessageBox.Show("See You");

                                // check property 26
                                Console.WriteLine("First digit is C");
                            }
                        }
                    }
                }
            }
        }
    }
}
        


