using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSA
{
    public enum programmes { frontend,backend}
    public enum frontend { Teus, Wed, Thurs}

    public enum backend { Mon, Teus, Thurs}

    public abstract class Human
    {
        public abstract void Answer();

        public abstract void Ask();

        public Program? program { get; set; }

        public string Name { get; set; }


    }
}

