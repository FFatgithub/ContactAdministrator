using ContactAdministrator.Constant;

namespace ContactAdministrator.CSVManger
{
  internal static class CSVReader
  {
    public static List<string> ReadContactsAsList()
    {
      return File
        .ReadAllLines(Constants.Path)
        .Where(x => !String.IsNullOrEmpty(x))
        .ToList();
    }
  }
}