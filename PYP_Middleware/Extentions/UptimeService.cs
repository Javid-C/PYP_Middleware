using System.Diagnostics;

namespace PYP_Middleware.Extentions
{
    public class UptimeService
    {
        private Stopwatch _time;
        public UptimeService()
        {
            _time = Stopwatch.StartNew();
        }

        public long Milliseconds
        {
            get
            {
                _time.Stop();
                return _time.ElapsedMilliseconds;
            }
        }
    }
}
