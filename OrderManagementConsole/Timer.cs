using System;
namespace OrderManagementConsole
{
    public static class Timer
    {
        private static DateTime _startTime;
        private static DateTime _endTime;

        public static void Start()
        {
            _startTime = DateTime.Now;
        }

        public static void Stop()
        {
            _endTime = DateTime.Now;
        }

        public static string GetElapsedTime()
        {
            if (_startTime.Date != DateTime.Today || _endTime.Date != DateTime.Today)
                throw new Exception("Timer has not been started or stopped");

            var timeDiff = _endTime - _startTime;
            return $"Operation completed in {timeDiff.TotalSeconds} seconds";
        }

    }
}