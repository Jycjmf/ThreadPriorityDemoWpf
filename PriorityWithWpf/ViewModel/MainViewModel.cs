using System.Threading;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Threading;

namespace PriorityWithWpf.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private float progressFirst;

        public float ProgressFirst
        {
            get { return progressFirst; }
            set
            {
                progressFirst = value;
                RaisePropertyChanged();
            }
        }

        private float progressSec;

        public float ProgressSec
        {
            get { return progressSec; }
            set
            {
                progressSec = value;
                RaisePropertyChanged();
            }
        }
        private int maximiumValue;

        public int MaximiumValue
        {
            get { return maximiumValue; }
            set
            {
                maximiumValue = value;
                RaisePropertyChanged();
            }
        }

        private float third;

        public float Third
        {
            get => third;
            set
            {
                third = value;
                RaisePropertyChanged();
            }
        }

        private float fourth;

        public float Fourth
        {
            get { return fourth; }
            set
            {
                fourth = value;
                RaisePropertyChanged();
            }
        }

        private float fifth;

        public float Fifth
        {
            get { return fifth; }
            set
            {
                fifth = value;
                RaisePropertyChanged();
            }
        }

        private float sixth;

        public float Sixth
        {
            get { return sixth; }
            set
            {
                sixth = value;
                RaisePropertyChanged();
            }
        }

        private float seventh;

        public float Seventh
        {
            get { return seventh; }
            set
            {
                seventh = value;
                RaisePropertyChanged();
            }
        }

        private float eighth;

        public float Eighth
        {
            get { return eighth; }
            set
            {
                eighth = value;
                RaisePropertyChanged();
            }
        }

        private float ninth;

        public float Ninth
        {
            get { return ninth; }
            set
            {
                ninth = value;
                RaisePropertyChanged();
            }
        }

        private float tenth;

        public float Tenth
        {
            get { return tenth; }
            set
            {
                tenth = value;
                RaisePropertyChanged();
            }
        }
        public MainViewModel()
        {
            MaximiumValue = 500000000 / 1000000;
            DispatcherHelper.Initialize();
        }

        private RelayCommand startAllThreadCommand;

        public RelayCommand StartAllThreadCommand =>
            startAllThreadCommand
            ?? (startAllThreadCommand = new RelayCommand(
                StartAllThread));


        private void StartAllThread()
        {
            //创建10个线程
            var td1 = new Thread(Counter1);
            var td2 = new Thread(Counter2);
            var td3 = new Thread(Counter3);
            var td4 = new Thread(Counter4);
            var td5 = new Thread(Counter5);
            var td6 = new Thread(Counter6);
            var td7 = new Thread(Counter7);
            var td8 = new Thread(Counter8);
            var td9 = new Thread(Counter9);
            var td10 = new Thread(Counter10);

            //设置各线程的优先级
            td1.Priority = ThreadPriority.Highest;
            td2.Priority = ThreadPriority.Highest;
            td3.Priority = ThreadPriority.Highest;
            td4.Priority = ThreadPriority.Highest;
            td5.Priority = ThreadPriority.Highest;
            td6.Priority = ThreadPriority.Highest;
            td7.Priority = ThreadPriority.Highest;
            td8.Priority = ThreadPriority.Normal;
            td9.Priority = ThreadPriority.Highest;
            td10.Priority = ThreadPriority.Lowest;

            //启动10各线程
            td1.Start();
            td2.Start();
            td3.Start();
            td4.Start();
            td5.Start();
            td6.Start();
            td7.Start();
            td8.Start();
            td9.Start();
            td10.Start();
        }

        private  void Counter1()
        {

            for (int i = 0; i <= 500000000; i++)
            {
                if (i % 1000000 == 0)
                {
                    ProgressFirst++;
                }
            }
        }
        private void Counter2()
        {

            for (int i = 0; i <= 500000000; i++)
            {
                if (i % 1000000 == 0)
                {
                    ProgressSec++;
                }
            }
        }
        private void Counter3()
        {

            for (int i = 0; i <= 500000000; i++)
            {
                if (i % 1000000 == 0)
                {
                    Third++;
                }
            }
        }
        private void Counter4()
        {

            for (int i = 0; i <= 500000000; i++)
            {
                if (i % 1000000 == 0)
                {
                    Fourth++;
                }
            }
        }
        private void Counter5()
        {

            for (int i = 0; i <= 500000000; i++)
            {
                if (i % 1000000 == 0)
                {
                    Fifth++;
                }
            }
        }
        private void Counter6()
        {

            for (int i = 0; i <= 500000000; i++)
            {
                if (i % 1000000 == 0)
                {
                    Sixth++;
                }
            }
        }
        private void Counter7()
        {

            for (int i = 0; i <= 500000000; i++)
            {
                if (i % 1000000 == 0)
                {
                    Seventh++;
                }
            }
        }
        private void Counter8()
        {

            for (int i = 0; i <= 500000000; i++)
            {
                if (i % 1000000 == 0)
                {
                    Eighth++;
                }
            }
        }
        private void Counter9()
        {

            for (int i = 0; i <= 500000000; i++)
            {
                if (i % 1000000 == 0)
                {
                    Ninth++;
                }
            }
        }
        private void Counter10()
        {

            for (int i = 0; i <= 500000000; i++)
            {
                if (i % 1000000 == 0)
                {
                    Tenth++;
                }
            }
        }
    }

}