using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sched.Service
{
    public class Foo : IFoo
    {
        readonly ILogger<Foo> _log;

        public Foo(ILogger<Foo> log)
        {
            _log = log;
        }

        public void FooLog()
        {
            _log.LogInformation("Scheduled operation!");
        }
    }
}
