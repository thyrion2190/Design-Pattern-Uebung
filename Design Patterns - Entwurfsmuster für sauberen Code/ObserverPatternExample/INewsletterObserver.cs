using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternExample
{
    public interface INewsletterObserver
    {
        void Update(Newsletter newsletter);
    }
}
