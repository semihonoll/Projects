// See https://aka.ms/new-console-template for more information
using SOLID_5_DependencyInversion.Bad;
using SOLID_5_DependencyInversion.Good;

//Console.WriteLine("Hello, World!");

//NonSQLRepository sQLRepository = new NonSQLRepository();
//sQLRepository.Insert();


//sQLRepository.Remove();

IRepository repository = new NonSqlRepo();

repository.Add();

repository.Update();

repository.Delete();