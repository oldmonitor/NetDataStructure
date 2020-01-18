using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataStructureProblems.StringProblems
{
    public class CommandParser
    {
        public int ValidateCommands(string s)
        {
            string[] commands = Regex.Split(s, "--");
            int commandCount = 0;
            bool isHelpInitiated = false;
            bool isCommandValid = true;
            int intValidCode;

            string command = "";
            foreach (string commandValue in commands)
            {
                if(commandValue == "")
                {
                    continue;
                }

                command = command + " " + commandValue;
                string commandString = commandValue.Trim().ToLower();
                string[] commandToken = commandString.Split(' ');
                string commandName = commandToken[0];
                intValidCode = 0;

                switch(commandName)
                {
                    case "count":
                       
                        intValidCode = this.handleValidateCountCommand(command);
                        commandCount++;
                        command = "";
                        break;
                    case "name":
                        if (commandToken.Length == 1)
                        {
                            continue;
                        }
                        intValidCode = this.handleValidateNameCommand(command);
                        commandCount++;
                        command = "";
                        break;
                    case "help":
                        intValidCode = this.handleValidateHelpCommand(command);
                        isHelpInitiated = true;
                        commandCount++;
                        command = "";
                        break;
                    default: //unknow command
                        intValidCode = -1;
                        break;
                }

                if (intValidCode == -1)
                {
                    isCommandValid = false;
                    break;
                }
            }

            // no command
            if(commandCount == 0)
            {
                return -1;
            }

            //invalid command
            if (isCommandValid == false)
                return -1;

            if (isHelpInitiated)
            {
                //valid with help 
                return 1;
            }
            else
            {
                //valid but no help
                return 0;
            }
            
        }

        private int handleValidateCountCommand(string command)
        {
            command = command.Trim();
            command = Regex.Replace(command, @"\s+", " ");
            string[] commandTokenList = command.Split(' ');
            if (commandTokenList.Count() != 2)
            {
                return -1;
            }

            int intCount;
            if (int.TryParse(commandTokenList[1], out intCount) == false)
            {
                return -1;
            }

            if (intCount < 9 || intCount > 100)
            {
                return -1;
            }

            return 0;
        }

        private int handleValidateNameCommand(string command)
        {
            command = command.Trim();
            string parameterValue = command.Substring("name".Length).Trim();
            if(parameterValue == "")
            {
                return -1;
            }

            if(parameterValue.Length < 3 || parameterValue.Length > 10)
            {
                return -1;
            }

            return 0;
        }

        private int handleValidateHelpCommand(string command)
        {
            command = command.Trim();
            if(command.ToLower() != "help")
            {
                return -1;
            }
            return 0;
        }
            
    }
}
