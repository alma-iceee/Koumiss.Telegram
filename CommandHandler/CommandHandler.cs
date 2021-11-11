//using System.Collections.Generic;

//namespace CommandHandler
//{
//    public class CommandHandler
//    {
//        public List<string> Arguments { get; set; }

//        public CommandHandler(Dictionary<long, string> userStates) { }

//        public string Exec(Message message)
//        {
//            var text = message.Text;

//            _messageInfo = new MessageInfo(message.Chat.Id, message.From.Username);

//            Arguments = new List<string>();

//            if (string.IsNullOrEmpty(text))
//            {
//                return "";
//            }

//            var commandName = "";

//            var arguments = text.Split(' ');

//            if (arguments.Length == 0)
//            {
//                return "";
//            }

//            for (var i = 0; i < arguments.Length; i++)
//            {
//                if (i == 0)
//                {
//                    commandName = arguments[i];
//                }
//                else
//                {
//                    Arguments.Add(arguments[i]);
//                }
//            }

//            var command = GetType().GetMethod(commandName);

//            if (command == null)
//            {
//                return "";
//            }

//            return (string)command.Invoke(this, null);
//        }
//    }
//}
