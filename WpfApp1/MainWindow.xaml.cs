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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int cCount1 = 0;
        private int fCount1 = 0;

        private int cCount2 = 0;
        private int fCount2 = 0;

        private int cCount3 = 0;
        private int fCount3 = 0;

        private int cCount4 = 0;
        private int fCount4 = 0;

        private int cCount5 = 0;
        private int fCount5 = 0;

        private int cCount6 = 0;
        private int fCount6 = 0;

        private int cCount7 = 0;
        private int fCount7 = 0;

        private int cCount8 = 0;
        private int fCount8 = 0;

        private int cCount9 = 0;
        private int fCount9 = 0;

        private int cCount10 = 0;
        private int fCount10 = 0;

        private int finalVoteC = 0;
        private int finalVoteF = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void p1F_Checked(object sender, RoutedEventArgs e)
        {
            trinbahnB.Opacity = 0;
            trinbahnF.Opacity = 100;
            trinbahnC.Opacity = 0;

            cCount1 = 0;
            fCount1 = 17;

            finalVotes();
        }

        private void p1B_Checked(object sender, RoutedEventArgs e)
        {
            trinbahnB.Opacity = 100;
            trinbahnF.Opacity = 0;
            trinbahnC.Opacity = 0;

            cCount1 = 0;
            fCount1 = 0;

            finalVotes();
        }

        private void p1C_Checked(object sender, RoutedEventArgs e)
        {
            trinbahnB.Opacity = 0;
            trinbahnF.Opacity = 0;
            trinbahnC.Opacity = 100;

            cCount1 = 17;
            fCount1 = 0;

            finalVotes();
        }
        //Next Province
        private void p2F_Checked(object sender, RoutedEventArgs e)
        {
            richlandB.Opacity = 0;
            richlandF.Opacity = 100;
            richlandC.Opacity = 0;
            
            cCount2 = 0;
            fCount2 = 14;

            finalVotes();
        }

        private void p2B_Checked(object sender, RoutedEventArgs e)
        {
            richlandB.Opacity = 100;
            richlandF.Opacity = 0;
            richlandC.Opacity = 0;
            
            cCount2 = 0;
            fCount2 = 0;

            finalVotes();
        }

        private void p2C_Checked(object sender, RoutedEventArgs e)
        {
            richlandB.Opacity = 0;
            richlandF.Opacity = 0;
            richlandC.Opacity = 100;

            cCount2 = 14;
            fCount2 = 0;

            finalVotes();
        }
        //Next Province
        private void p3F_Checked(object sender, RoutedEventArgs e)
        {
            henryB.Opacity = 0;
            henryF.Opacity = 100;
            henryC.Opacity = 0;

            cCount3 = 0;
            fCount3 = 9;

            finalVotes();
        }

        private void p3B_Checked(object sender, RoutedEventArgs e)
        {
            henryB.Opacity = 100;
            henryF.Opacity = 0;
            henryC.Opacity = 0;

            cCount3 = 0;
            fCount3 = 0;

            finalVotes();
        }

        private void p3C_Checked(object sender, RoutedEventArgs e)
        {
            henryB.Opacity = 0;
            henryF.Opacity = 0;
            henryC.Opacity = 100;
            
            cCount3 = 9;
            fCount3 = 0;

            finalVotes();
        }
        //Next Province
        private void p4F_Checked(object sender, RoutedEventArgs e)
        {
            squireB.Opacity = 0;
            squireF.Opacity = 100;
            squireC.Opacity = 0;

            cCount4 = 0;
            fCount4 = 11;

            finalVotes();
        }

        private void p4B_Checked(object sender, RoutedEventArgs e)
        {
            squireB.Opacity = 100;
            squireF.Opacity = 0;
            squireC.Opacity = 0;

            cCount4 = 0;
            fCount4 = 0;

            finalVotes();
        }

        private void p4C_Checked(object sender, RoutedEventArgs e)
        {
            squireB.Opacity = 0;
            squireF.Opacity = 0;
            squireC.Opacity = 100;

            cCount4 = 11;
            fCount4 = 0;

            finalVotes();
        }
        //Next Province
        private void p5F_Checked(object sender, RoutedEventArgs e)
        {
            mackenzieB.Opacity = 0;
            mackenzieF.Opacity = 100;
            mackenzieC.Opacity = 0;

            cCount5 = 0;
            fCount5 = 11;

            finalVotes();
        }

        private void p5B_Checked(object sender, RoutedEventArgs e)
        {
            mackenzieB.Opacity = 100;
            mackenzieF.Opacity = 0;
            mackenzieC.Opacity = 0;

            cCount5 = 0;
            fCount5 = 0;

            finalVotes();
        }

        private void p5C_Checked(object sender, RoutedEventArgs e)
        {
            mackenzieB.Opacity = 0;
            mackenzieF.Opacity = 0;
            mackenzieC.Opacity = 100;

            cCount5 = 11;
            fCount5 = 0;

            finalVotes();
        }
        //Next Province
        private void p6F_Checked(object sender, RoutedEventArgs e)
        {
            middlingtonB.Opacity = 0;
            middlingtonF.Opacity = 100;
            middlingtonC.Opacity = 0;

            cCount6 = 0;
            fCount6 = 9;

            finalVotes();
        }
        //Next Province
        private void p6B_Checked(object sender, RoutedEventArgs e)
        {
            middlingtonB.Opacity = 100;
            middlingtonF.Opacity = 0;
            middlingtonC.Opacity = 0;

            cCount6 = 0;
            fCount6 = 0;

            finalVotes();
        }

        private void p6C_Checked(object sender, RoutedEventArgs e)
        {
            middlingtonB.Opacity = 0;
            middlingtonF.Opacity = 0;
            middlingtonC.Opacity = 100;

            cCount6 = 9;
            fCount6 = 0;

            finalVotes();
        }
        //Next Province
        private void p7F_Checked(object sender, RoutedEventArgs e)
        {
            shaqerB.Opacity = 0;
            shaqerF.Opacity = 100;
            shaqerC.Opacity = 0;

            cCount7 = 0;
            fCount7 = 16;

            finalVotes();
        }

        private void p7B_Checked(object sender, RoutedEventArgs e)
        {
            shaqerB.Opacity = 100;
            shaqerF.Opacity = 0;
            shaqerC.Opacity = 0;

            cCount7 = 0;
            fCount7 = 0;

            finalVotes();
        }

        private void p7C_Checked(object sender, RoutedEventArgs e)
        {
            shaqerB.Opacity = 0;
            shaqerF.Opacity = 0;
            shaqerC.Opacity = 100;

            cCount7 = 16;
            fCount7 = 0;

            finalVotes();
        }
        //Next Province
        private void p8F_Checked(object sender, RoutedEventArgs e)
        {
            fredaB.Opacity = 0;
            fredaF.Opacity = 100;
            fredaC.Opacity = 0;

            cCount8 = 0;
            fCount8 = 5;

            finalVotes();
        }

        private void p8B_Checked(object sender, RoutedEventArgs e)
        {
            fredaB.Opacity = 100;
            fredaF.Opacity = 0;
            fredaC.Opacity = 0;

            cCount8 = 0;
            fCount8 = 0;

            finalVotes();
        }

        private void p8C_Checked(object sender, RoutedEventArgs e)
        {
            fredaB.Opacity = 0;
            fredaF.Opacity = 0;
            fredaC.Opacity = 100;

            cCount8 = 5;
            fCount8 = 0;

            finalVotes();
        }
        //Next Province
        private void p9F_Checked(object sender, RoutedEventArgs e)
        {
            madisenB.Opacity = 0;
            madisenF.Opacity = 100;
            madisenC.Opacity = 0;

            cCount9 = 0;
            fCount9 = 6;

            finalVotes();
        }

        private void p9B_Checked(object sender, RoutedEventArgs e)
        {
            madisenB.Opacity = 100;
            madisenF.Opacity = 0;
            madisenC.Opacity = 0;

            cCount9 = 0;
            fCount9 = 0;

            finalVotes();
        }

        private void p9C_Checked(object sender, RoutedEventArgs e)
        {
            madisenB.Opacity = 0;
            madisenF.Opacity = 0;
            madisenC.Opacity = 100;

            cCount9 = 6;
            fCount9 = 0;

            finalVotes();
        }

        private void p10F_Checked(object sender, RoutedEventArgs e)
        {
            
            northwesternB.Opacity = 0;
            northwesternF.Opacity = 100;
            northwesternC.Opacity = 0;

            cCount10 = 0;
            fCount10 = 2;

            finalVotes();
         
        }

        private void p10B_Checked(object sender, RoutedEventArgs e)
        {
            northwesternB.Opacity = 100;
            northwesternF.Opacity = 0;
            northwesternC.Opacity = 0;

            cCount10 = 0;
            fCount10 = 0;

            finalVotes();
        }

        private void p10C_Checked(object sender, RoutedEventArgs e)
        {
            northwesternB.Opacity = 0;
            northwesternF.Opacity = 0;
            northwesternC.Opacity = 100;

            cCount10 = 2;
            fCount10 = 0;

            finalVotes();
        }
        private void finalVotes()
        {
            finalVoteC = cCount1 + cCount2 + cCount3 + cCount4 + cCount5 + cCount6 + cCount7 + cCount8 + cCount9 + cCount10;
            finalVoteF = fCount1 + fCount2 + fCount3 + fCount4 + fCount5 + fCount6 + fCount7 + fCount8 + fCount9 + fCount10;

            lblC.Content = $"Compleat: {Convert.ToString(finalVoteC)}";
            lblF.Content = $"Forward: {Convert.ToString(finalVoteF)}";
        }
    }
}