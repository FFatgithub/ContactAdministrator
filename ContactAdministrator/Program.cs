using ContactAdministrator.UserInteraction;

try
{
  int choice = 1;
  Chooser chooser = new Chooser();
  while(choice > 0)
  {
    choice = chooser.Show();
    HandleContact(choice);
  }
}
catch(Exception ex)
{
  WriteExceptionMassage(ex);
  WriteException(ex);
}
finally
{
  Console.WriteLine("Bitte Taste drücken!!");
  Console.ReadKey();
}

void WriteExceptionMassage(Exception ex)
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("Es ist ein Fehler aufgetreten:");
  Console.ForegroundColor = ConsoleColor.Gray;
  Console.WriteLine(ex.Message + Environment.NewLine);
}

void WriteException(Exception ex)
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("Stack:");
  Console.ForegroundColor = ConsoleColor.Gray;
  Console.WriteLine(ex.Message);
}

void HandleContact(int choice)
{
  Console.Clear();
  switch(choice)
  {
    case 1:
      Console.WriteLine("Es wurde eins anlegen gedrückt!");
      Console.WriteLine("Bitte Taste drücken!!");
      Console.ReadKey();
      break;

    case 2:
      Console.WriteLine("Es wurde bearbeiten gedrückt!");
      Console.WriteLine("Bitte Taste drücken!!");
      Console.ReadKey();
      break;

    case 3:
      Console.WriteLine("Es wurde löschen gedrückt!");
      Console.WriteLine("Bitte Taste drücken!!");
      Console.ReadKey();
      break;

    default:
      break;
  }
  Console.Clear();
}