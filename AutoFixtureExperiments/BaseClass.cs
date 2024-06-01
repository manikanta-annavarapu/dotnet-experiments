using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFixtureExperiments
{
    public class BaseClass
    {
        public string Text { get; set; }
        public virtual int Value { get; set; }
    }

    public class BaseImplA : BaseClass
    {
        public override int Value { get; set; } = 5;
    }

    public class BaseImplB : BaseClass
    {
        public override int Value
        {
            get { return 1; }
            set { throw new NotImplementedException(); }
        }
    }

    public class BaseImplC : BaseClass
    {
        public override int Value { get; set; } = 7;
    }
}
