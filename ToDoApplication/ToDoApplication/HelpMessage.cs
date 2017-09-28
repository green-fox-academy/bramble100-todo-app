using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    class HelpMessage
    {
        private const string HelpMessageHeader = "Command Line Todo application\n" +
            "=============================\n\n" +
            "Command line arguments:";

        public override string ToString()
        {
            StringBuilder helpMessage = new StringBuilder();
            helpMessage.AppendLine(HelpMessageHeader);
            return helpMessage.ToString();
        }
    }
}
