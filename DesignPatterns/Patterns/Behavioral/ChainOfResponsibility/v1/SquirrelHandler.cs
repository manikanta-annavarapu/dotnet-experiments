using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility.v1
{
    internal class SquirrelHandler : AbstractHandler<string>
    {
        public override string Handle(string? request)
        {
            if (request == "Nut")
            {
                return $"Squirrel: I'll eat the {request}.";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
