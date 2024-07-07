using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility.v1
{
    internal abstract class AbstractHandler<T> : IHandler<T>
    {
        private IHandler<T>? _nextHandler;

        public virtual T? Handle(T? request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return default;
            }
        }

        public IHandler<T> SetNext(IHandler<T> handler)
        {
            if(handler != null) { 
                _nextHandler = handler;
                return handler;
            }
            throw new ArgumentNullException();
        }
    }
}
