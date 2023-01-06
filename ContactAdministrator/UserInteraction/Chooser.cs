namespace ContactAdministrator.UserInteraction
{
  internal class Chooser
  {
    public int Show()
    {
      string choice = string.Empty;
      ShowChoices();
      choice = Console.ReadLine();

      return IfNumber(choice);
    }

    private void ShowChoices()
    {
      Console.WriteLine("Bitte Taste entsprechend Auswahl drücken.");
      Console.WriteLine("1 für Kontakt anlegen!");
      Console.WriteLine("2 für Kontakt bearbeiten!");
      Console.WriteLine("3 für Kontakt löschen!");
      Console.WriteLine("0 zum beenden des Programmes!");
    }

    private int IfNumber(string choice)
    {
      int.TryParse(choice, out int number);
      return number;
    }
  }
}