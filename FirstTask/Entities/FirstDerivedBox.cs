using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Entities
{
    public class FirstDerivedBox : Box
    {
        [BoxField]
        public override string FirstField
        {
            get
            {
                return "First overriden field of FirstDerived";
            }
        }

        [BoxField]
        public override string SecondField
        {
            get
            {
                return "Second overriden field of FirstDerived";
            }
        }

        [BoxField]
        public override int ThirdField
        {
            get
            {
                return 1;
            }
        }
    }
}
