using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooWPF
{
    public interface Diving
    {
        int maxDepth { get; set; }
        int diveSpeed { get; set; }

        void dive();
    }
}