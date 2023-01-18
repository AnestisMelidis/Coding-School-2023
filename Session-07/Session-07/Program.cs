// See https://aka.ms/new-console-template for more information
using Session_07;

//Console.WriteLine("Hello, World!");

//ChoiseAction choiseAction=new ChoiseAction();
//choiseAction.Action();
//Console.ReadLine();

ActionRequest request = new ActionRequest() {
    Input = "Fotis",
    Action = ActionEnum.Uppercase
};

ActionResponse response = new ActionResponse();

ActionResolver resolver = new ActionResolver();

response = resolver.Execute(request);

// DISPLAY MESSAGES FROM LOGGER

resolver.Logger.ReadAll();

Console.ReadLine();
