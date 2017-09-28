using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    class HelpMessage
    {
        private const string HelpMessageHeader = "\nCommand Line Todo application\n" +
            "=============================\n\n" +
            "Command line arguments:";
        private Services services;

        public HelpMessage(Services services)
        {
            this.services = services;
        }

        public override string ToString()
        {
            StringBuilder helpMessage = new StringBuilder();
            helpMessage.AppendLine(HelpMessageHeader);
            for (int i = 0; i < Services.AvailableOptions.Length; i++)
            {
                string item = Services.AvailableOptions[i];
                helpMessage.AppendLine(
                    $" -{services.ShortArgs[item]}  "+
                    $"--{item.PadRight(11)}"+
                    $"{services.Descriptions[item]}");
            }
            return helpMessage.ToString();
        }
    }
}
