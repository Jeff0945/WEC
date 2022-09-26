using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WEC {
    internal class AccurateTimer {
        private delegate void TimerEventDel(int id, int msg, IntPtr user, int dw1, int dw2);
        private const int TIME_PERIODIC = 1;
        private const int EVENT_TYPE = TIME_PERIODIC;// + 0x100;  // TIME_KILL_SYNCHRONOUS causes a hang ?!
        [DllImport("winmm.dll")]
        private static extern int timeBeginPeriod(int msec);
        [DllImport("winmm.dll")]
        private static extern int timeEndPeriod(int msec);
        [DllImport("winmm.dll")]
        private static extern int timeSetEvent(int delay, int resolution, TimerEventDel handler, IntPtr user, int eventType);
        [DllImport("winmm.dll")]
        private static extern int timeKillEvent(int id);

        Action mAction;
        Form mForm;
        private int mTimerId;
        private TimerEventDel mHandler;  // NOTE: declare at class scope so garbage collector doesn't release it!!!
        bool running = false;

        public AccurateTimer(Form form, Action action, int delay) {
            mAction = action;
            mForm = form;
            timeBeginPeriod(1);
            mHandler = new TimerEventDel(TimerCallback);
            mTimerId = timeSetEvent(delay, 0, mHandler, IntPtr.Zero, EVENT_TYPE);
            running = true;
        }

        public void Stop() {
            int err = timeKillEvent(mTimerId);
            timeEndPeriod(1);
            running = false;
            System.Threading.Thread.Sleep(100);// Ensure callbacks are drained
        }

        public bool IsRunning { 
            get { return running; }
        }

        private void TimerCallback(int id, int msg, IntPtr user, int dw1, int dw2) {
            if (mTimerId != 0)
                mForm.BeginInvoke(mAction);
        }
    }
}