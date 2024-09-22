// See https://aka.ms/new-console-template for more information
using _94_DP_Mediator;

Console.WriteLine("Hello, World!");

IChatMediator chatMediator = new ChatMediator();

User user1 = new UserImp(chatMediator, "Fatih");
User user2 = new UserImp(chatMediator, "Okan");
User user3 = new UserImp(chatMediator, "Yasin");
User user4 = new UserImp(chatMediator, "Gülderen");

chatMediator.AddUser(user1);
chatMediator.AddUser(user2);
chatMediator.AddUser(user3);
chatMediator.AddUser(user4);

user1.Send("Merhaba C#");