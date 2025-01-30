//Event Handler delegate EventHandler<TEventArgs> expects the event argument to inherit from EventArgs
public class MessageEventArgs : EventArgs
{
    public string Message {get;set;}

    public MessageEventArgs(string message){
        Message = message;
    }
}