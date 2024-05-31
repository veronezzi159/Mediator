using MediatorEX;

Console.WriteLine("Inicio");

ConcreteMediator mediator = new ConcreteMediator();

User user1 = new ConcreteUser(mediator, "Lucas");
User user2 = new ConcreteUser(mediator, "ALtair");
User user3 = new ConcreteUser(mediator, "ALtahell");
User user4 = new ConcreteUser(mediator, "Highway");

mediator.RegisterUser(user1);
mediator.RegisterUser(user2);
mediator.RegisterUser(user3);
mediator.RegisterUser(user4);

user1.Send("Meu novo Canal esta aberto");

user2.Send("Vejam meu video no YT");

user1.Send("5by5"); 

Console.ReadKey();  
