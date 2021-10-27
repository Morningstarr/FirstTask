using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Entities
{
    public class Box
    {
        [BoxField]
        public virtual string FirstField { get; }

        [BoxField]
        public virtual string SecondField { get;  }

        [BoxField]
        public virtual int ThirdField { get;  }

    }
}
