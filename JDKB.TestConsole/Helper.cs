using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.TestConsole
{
    public static class Helper
    {
        public static Func<T, bool> And<T>(this Func<T, bool> left, Func<T, bool> right) => a => left(a) && right(a);

        public static Func<T, bool> Or<T>(this Func<T, bool> left, Func<T, bool> right) => a => left(a) || right(a);
    }
}
