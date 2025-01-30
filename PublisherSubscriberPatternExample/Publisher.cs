public class Publisher{
    public event EventHandler<MessageEventArgs> MessagePublishEventHandler;

    public void PublishMessage(string message){
        this.OnMessagePublished(new MessageEventArgs(message));
    }

    protected virtual void OnMessagePublished(MessageEventArgs e){
        MessagePublishEventHandler.Invoke(this, e);
    }
}