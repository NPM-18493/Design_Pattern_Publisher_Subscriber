public class Subscriber
{
    private readonly string _name;

    public Subscriber(string name, Publisher publisher)
    {
        this._name = name;
        publisher.MessagePublishEventHandler += OnMessagePublished;
    }

    private void OnMessagePublished(object sender, MessageEventArgs e)
    {
        Console.WriteLine(string.Format("Message '{0}' received by {1}!", e.Message, _name));
    }
}