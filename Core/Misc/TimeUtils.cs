using System.Diagnostics;

namespace Core.Misc;
public static class TimeUtils
{
    public static long Measure(Action act)
    {
        var sw = new Stopwatch();
        sw.Start();

        act.Invoke();

        sw.Stop();

        return sw.ElapsedTicks;
    }
}
