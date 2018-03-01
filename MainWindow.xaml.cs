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
using System.ComponentModel;

namespace quinncareers
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lblTitle.Content = "University Info";
            lblOutput.Content = "Ryerson University\n" + 
                                "Computer Science (BSc)\n" + 
                                "OUAC code is SAB\n" + 
                                "Enrollment: 39000+\n" + 
                                "Not very competitive to get in.\n" + 
                                "Ryerson is located in downtown Toronto\n" + 
                                "Tuition costs $7575 - $9951.\n" + 
                                "Residence costs $6600 total for 32 weeks.\n";       
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "English/Anglais (ENG4U/EAE4U preferred) English/Anglais (ENG4U/EAE4U preferred)\n" +
                                "Advanced Functions (MHF4U)\n" +
                                "One of: Physics (SPH4U), Chemistry (SCH4U), Biology (SBI4U)\n" +
                                "One of: Calculus and Vectors (MCV4U) or Mathematics of Data Management (MDM4U)\n" +
                                "Grade 12 U Calculus and Vectors (MCV4U) is the preferred mathematics course.\n Completion of Grade 12 U Physics (SPH4U) is recommended.\n" +
                                "The minimum grade(s) required in the subject prerequisites (normally in the 65-70% range) will be determined subject to competition.";
            lblTitle.Content = "Course Requirements";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "Semester 1\n" +
                                "Computer Science I\n" +
                                "Computer Organization I\n" +
                                "Discrete Mathematics I\n" +
                                "Either biology chemistry or physics\n" +
                                "One lower level liberal studies course\n" +
                                "Semester 2\n" +
                                "Computer Organization II\n" +
                                "Social Issues, Ethics and Professionalism\n" +
                                "Calculus and Computational Methods I\n" +
                                "One lower level liberal studies course\n" +
                                "Total of 40 courses over 4 years";
            lblTitle.Content = "First Year Course Information";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "Application analyst\n Business analyst\n Data analyst\n Database administrator\n Games developer\n Information systems manager\n IT consultant\n Multimedia programmer\n SEO specialist\n Software engineer\n Systems analyst\n UX analyst\n Web designer\n Web developer";
            lblTitle.Content = "Careers";
        }
    }
}
