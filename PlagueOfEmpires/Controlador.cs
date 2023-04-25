using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Gaming.Input;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace PlagueOfEmpires
{
    internal class Controlador
    {
        private readonly object myLock = new object();
        private List<Gamepad> myGamepads = new List<Gamepad>();
        private Gamepad mainGamepad = null;
        public GamepadReading reading, prereading;
        private GamepadVibration vibration;

        DispatcherTimer GamePadTimer;
        MainPage miPagina = null;

        public Controlador(Page MP)
        {

            miPagina = MP as MainPage;

            Gamepad.GamepadAdded += (object sender, Gamepad e) =>
            {
                lock (myLock)
                {
                    bool gamepadInList = myGamepads.Contains(e);

                    if (!gamepadInList)
                    {
                        myGamepads.Add(e);
                        mainGamepad = myGamepads[0];
                    }
                }
            };

            Gamepad.GamepadRemoved += (object sender, Gamepad e) =>
            {
                lock (myLock)
                {
                    int indexRemoved = myGamepads.IndexOf(e);
                    if (indexRemoved > -1)
                    {
                        if (mainGamepad == myGamepads[indexRemoved])
                        {
                            mainGamepad = null;
                        }

                        myGamepads.RemoveAt(indexRemoved);
                    }
                }
            };

            GamePadTimerSetup();
        }

        public void GamePadTimerSetup()
        {
            GamePadTimer = new DispatcherTimer();
            GamePadTimer.Tick += GamePadTimer_Tick;
            GamePadTimer.Interval = new TimeSpan(100000);
            GamePadTimer.Start();
        }

        void GamePadTimer_Tick(object sender, object e)
        {
            if (mainGamepad != null)
            {
                LeeMando();
                ZMMando();
                //miPagina.ActualizaIU();
                FeedBack();
            }
        }

        private void LeeMando()
        {
            if (mainGamepad != null)
            {
                prereading = reading;
                reading = mainGamepad.GetCurrentReading();
            }
        }

        public void ZMMando()
        {
            if (reading.RightThumbstickX < -0.1) reading.RightThumbstickX += 0.1;
            else if (reading.RightThumbstickX > 0.1) reading.RightThumbstickX -= 0.1;
            else reading.RightThumbstickX = 0;

            if (reading.RightThumbstickY < -0.1) reading.RightThumbstickY += 0.1;
            else if (reading.RightThumbstickY > 0.1) reading.RightThumbstickY -= 0.1;
            else reading.RightThumbstickY = 0;
        }

        public void FeedBack()
        {
            //if (mainGamepad != null)
            //{
            //    // ... set vibration levels on vibration struct here
            //    if ((reading.RightThumbstickX != 0) | (reading.RightThumbstickY != 0))
            //        if (reading.RightThumbstickX * reading.RightThumbstickX > reading.RightThumbstickY * reading.RightThumbstickY)
            //            vibration.RightMotor = reading.RightThumbstickX * reading.RightThumbstickX;
            //        else
            //            vibration.RightMotor = reading.RightThumbstickY * reading.RightThumbstickY;
            //    else
            //        vibration.RightMotor = 0;

            //    if ((reading.LeftTrigger != 0) | (reading.RightTrigger != 0))
            //        if (reading.LeftTrigger > reading.RightTrigger)
            //            vibration.LeftMotor = reading.LeftTrigger;
            //        else
            //            vibration.LeftMotor = reading.RightTrigger;
            //    else
            //        vibration.LeftMotor = 0;
            //    // copy the GamepadVibration struct to the gamepad
            //    mainGamepad.Vibration = vibration;
            //}
        }

    }
}
