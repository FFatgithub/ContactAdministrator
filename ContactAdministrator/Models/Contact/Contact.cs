namespace ContactAdministrator.Models.Contact
{
  /// <summary>
  ///   <para>A class for contacts of persons.</para>
  /// </summary>
  internal class Contact
  {
    /// <summary>Gets or sets the first name.</summary>
    /// <value>The first name.</value>
    public string FirstName { get; set; }

    /// <summary>Gets or sets the last name.</summary>
    /// <value>The last name.</value>
    public string LastName { get; set; }

    /// <summary>Gets or sets the number.</summary>
    /// <value>The number.</value>
    public string Number { get; set; }

    /// <summary>Gets or sets the address.</summary>
    /// <value>The address.</value>
    public Address.Address? Address { get; set; }
  }
}