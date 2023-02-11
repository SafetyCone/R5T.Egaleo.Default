using System;using R5T.T0064;


namespace R5T.Egaleo.Default
{
    /// <summary>
    /// The default organization directory name is just the organization name.
    /// </summary>
    [ServiceImplementationMarker]
    public class OrganizationDirectoryNameConvention : IOrganizationDirectoryNameConvention,IServiceImplementation
    {
        public string GetOrganizationDirectoryName(string organizationName)
        {
            // The organization directory name is just the organization name.
            return organizationName;
        }
    }
}
