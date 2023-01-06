using ContactAdministrator.Constant;
using ContactAdministrator.Models.Contact;
using System.Text;

namespace ContactAdministrator.CSVManger
{
  internal class CSVWriter
  {
    public static void Writer(Contact contact)
    {
      WriteContact(contact);
    }

    private static void WriteContact(Contact contact)
    {
      var csv = new StringBuilder();
      var newContact = $"" +
        $"{contact.FirstName}," +
        $"{contact.LastName}," +
        $"{contact.MobileNumber}," +
        $"{contact.Number}," +
        $"{contact.Address.Street}," +
        $"{contact.Address.HouseNumber}," +
        $"{contact.Address.City}," +
        $"{contact.Address.Zip}," +
        $"{contact.Address.Land},";

      csv.Append(newContact);

      File.AppendAllText(Constants.Path, csv.ToString());
    }
  }
}