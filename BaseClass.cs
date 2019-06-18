using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class BaseClass
    {
        private readonly string[] _dialogueParameters =
        {
            "A",
            "B",
            "C",
            "D",
            "E"
        };

        protected virtual string[] DialogueParameters => _dialogueParameters;

        public string[] GetParams()
        {
            return DialogueParameters;
        }
    }
}
