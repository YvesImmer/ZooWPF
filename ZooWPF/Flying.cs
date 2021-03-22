using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooWPF
{
    public interface Flying
    {
        int flySpeed { get; set; }

        void fly();
    }
}