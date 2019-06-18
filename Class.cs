
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Class : BaseClass
    {
        private readonly string[] _dialogueParameters =
        {
            "A",
            "B",
            "C"
        };

        protected override string[] DialogueParameters => _dialogueParameters;
    }
}
