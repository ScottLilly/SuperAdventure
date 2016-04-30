using System;

namespace Engine
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; private set; }
        public bool AddExtraNewLine { get; private set; }

        public MessageEventArgs(string message, bool addExtraNewLine)
        {
            Message = message;
            AddExtraNewLine = addExtraNewLine;
        }
    }
}
