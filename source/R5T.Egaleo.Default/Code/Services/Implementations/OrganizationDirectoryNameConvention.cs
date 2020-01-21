using System;


namespace R5T.Egaleo.Default
{
    /// <summary>
    /// The default organization directory name is just the organization name.
    /// </summary>
    public class OrganizationDirectoryNameConvention : IOrganizationDirectoryNameConvention
    {
        public string GetOrganizationDirectoryName(string organizationName)
        {
            // The organization directory name is just the organization name.
            return organizationName;
        }
    }
}
