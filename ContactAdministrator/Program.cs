try
{
  throw new Exception("Fehler");
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