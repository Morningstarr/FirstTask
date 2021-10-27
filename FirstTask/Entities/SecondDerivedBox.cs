using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Entities
{
    public class SecondDerivedBox : Box
    {
        [BoxField]
        public override string FirstField
        {
            get
            {
                return "First overriden field of SecondDerived";
            }
        }

        [BoxField]
        public override string SecondField
        {
            get
            {
                return "Second overriden field of SecondDerived";
            }
        }

        [BoxField]
        public override int ThirdField
        {
            get
            {
                return 2;
            }
        }
    }
}
