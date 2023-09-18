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

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            workers = CreateWorkers();
            activeRobots = CreateRobots();
            activeMissions = CreateMissions();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:","Good bye",MessageBoxButton.OK);
            this.Close();
        }


        //משימה 1
        // : כתבו פעולה המחזירה אוסף של 6 עובדים 
        //מנכ"ל אחד, 2 מנהלי תפעול ו-3 עובדי תפעול
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        public List<Worker> CreateWorkers()
        {
            List<Worker> newWorkers = new List<Worker>
            {
                new GeneralManager("Jess", "123456", DateTime.Now, "12345", 30500, 20),
                new OperationManager("Schmidt", "234567", DateTime.Now, "23456", 30, 160, 20),
                new OperationManager("Nick", "345678", DateTime.Now, "34567", 30, 140, 10),
                new OperationalWorker("Winston", "456789", DateTime.Now, "45678", 150, 25),
                new OperationalWorker("Cece", "567891", DateTime.Now, "56789", 120, 6),
                new OperationalWorker("Coach", "678912", DateTime.Now, "67891", 170, 35)
            };
            
            return newWorkers;
        }

        //משימה 2
        //כתבו פעולה המחזירה אוסף של 8 רובוטים
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        public List<RobotSpy> CreateRobots()
        {
            List<RobotSpy> newRobotSpies = new List<RobotSpy>
            {
                new RobotFly(),
                new RobotFly(),
                new RobotFly(),
                new RobotQuad(),
                new RobotQuad(),
                new RobotWheels(),
                new RobotWheels()
            };
            return newRobotSpies;
        }




        //משימה 3
        //כתבו פעולה המחזירה אוסף של 5 משימות
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון       
        public List<Mission> CreateMissions()
        {
            List<Mission> newMissions = new List<Mission>
            {
                new Mission(DateTime.Now, "charge robots"),
                new Mission(DateTime.Now, "clean robots"),
                new Mission(DateTime.Now, "check robots"),
                new Mission(DateTime.Now, "build a robot"),
                new Mission(DateTime.Now, "destroy robots")
            };
            return newMissions;
        }




        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //...אם מספר הזיהוי והסיסמה תואמים לעובד ברשימה, אז

            foreach (Worker worker in workers)
            {
                if (worker.GetIdNumber().Equals(tbxID.Text) && worker.GetPassword().Equals(tbxPassword.Password.ToString()))
                {
                    WndMain main = new WndMain(worker, activeMissions, activeRobots, workers);
                    main.ShowDialog();
                    Close();
                    return;
                }
            }
            MessageBox.Show("Worker Not Found");

        }
    }
}
