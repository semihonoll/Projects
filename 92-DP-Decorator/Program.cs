// See https://aka.ms/new-console-template for more information
using _92_DP_Decorator;

Console.WriteLine("Hello, World!");

Window w1 = new LoginWindow("Sisteme Giriş");
Window w2 = new ReportWindow("Stok Raporu Ekranı");
Window w3 = new ReportWindow("Satış Raporu Ekranı");

ThemeDecorator decorator1 = new ThemeDecorator(w1, "Sisteme Giriş");
ThemeDecorator decorator2 = new ThemeDecorator(w2, "Stok Raporu Ekranı");
ThemeDecorator decorator3 = new ThemeDecorator(w3, "Satış Raporu Ekranı");

decorator1.SetTheme("Ayder Teması");
decorator2.SetTheme("Ürgüp Teması");
decorator3.SetTheme("Pamukkala Teması");