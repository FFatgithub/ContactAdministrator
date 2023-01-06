using ContactAdministrator.CSVManger;
using ContactAdministrator.Models.Address;
using ContactAdministrator.Models.Contact;

namespace ContactAdministrator.ContactManipulation
{
  internal class AddContact
  {
    private static Contact contact = new Contact();

    public static void Add()
    {
      CreateContact();
      SaveContact();
    }

    private static void CreateContact()
    {
      contact.Address = new Address();

      SetFirstname();
      SetLastName();
      SetMoblieNumber();
      SetNumber();
      SetStreet();
      SetHouseNumber();
      SetCity();
      SetZip();
      SetLand();
    }

    private static void SetLand()
    {
      Console.WriteLine("Bitte Land eingeben");
      contact.Address.Land = Console.ReadLine().Trim();
    }

    private static void SetZip()
    {
      Console.WriteLine("Bitte Postleitzahl eingeben");
      contact.Address.Zip = Console.ReadLine().Trim();
    }

    private static void SetCity()
    {
      Console.WriteLine("Bitte Stadt eingeben");
      contact.Address.City = Console.ReadLine().Trim();
    }

    private static void SetHouseNumber()
    {
      Console.WriteLine("Bitte Namen eingeben");
      contact.Address.HouseNumber = Console.ReadLine().Trim();
    }

    private static void SetStreet()
    {
      Console.WriteLine("Bitte Strasse eingeben");
      contact.Address.Street = Console.ReadLine().Trim();
    }

    private static void SetNumber()
    {
      Console.WriteLine("Bitte Festnetznummer eingeben");
      contact.Number = Console.ReadLine().Trim();
    }

    private static void SetMoblieNumber()
    {
      Console.WriteLine("Bitte Moblfunknummer eingeben");
      contact.MobileNumber = Console.ReadLine().Trim();
    }

    private static void SetLastName()
    {
      Console.WriteLine("Bitte Nachnamen eingeben");
      contact.LastName = Console.ReadLine().Trim();
    }

    private static void SetFirstname()
    {
      Console.WriteLine("Bitte Namen eingeben");
      contact.FirstName = Console.ReadLine().Trim();
    }

    private static void SaveContact()
    {
      CSVWriter.Writer(contact);
    }
  }
}