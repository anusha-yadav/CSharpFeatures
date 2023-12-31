﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_11.StaticAbstarctMembers
{
    public interface IMeasuarable<T> where T: IMeasuarable<T>
    {
        static abstract T operator +(T a, T b);
        static abstract T operator /(T a, T b);
        static abstract T One {  get; }
        static abstract T Zero { get; }
    }
}
