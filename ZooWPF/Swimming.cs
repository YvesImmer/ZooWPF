using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooWPF
{
    public interface Swimming
    {
        int swimSpeed { get; set; }

        void swim();
    }
}