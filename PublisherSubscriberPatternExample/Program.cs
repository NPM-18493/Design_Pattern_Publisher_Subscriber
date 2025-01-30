// See https://aka.ms/new-console-template for more information

Publisher publisher = new Publisher();

Subscriber first_Subscriber = new Subscriber("First_Subscriber", publisher);
Subscriber second_Subscriber = new Subscriber("Second_Subscriber", publisher);

publisher.PublishMessage("Hello Pub_Sub");

