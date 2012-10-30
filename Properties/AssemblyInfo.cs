using System.Reflection;
using System.Runtime.InteropServices;
using Rhino.PlugIns;

// Plug-In title and Guid are extracted from the following two attributes
[assembly: AssemblyTitle("SelCommands")]
[assembly: Guid("a8c7f5d2-f9bb-453a-955e-1ffc38bf373f")]

// Plug-in Description Attributes - all of these are optional
[assembly: PlugInDescription(DescriptionType.Address, "3670 Woodland Park AveN\nSeattle")]
[assembly: PlugInDescription(DescriptionType.Country, "WA")]
[assembly: PlugInDescription(DescriptionType.Email, "steve@mcneel.com")]
[assembly: PlugInDescription(DescriptionType.Phone, "206-545-7000")]
[assembly: PlugInDescription(DescriptionType.Fax, "206-545-7321")]
[assembly: PlugInDescription(DescriptionType.Organization, "Robert McNeel & Associates")]
[assembly: PlugInDescription(DescriptionType.UpdateUrl, "http://updates.rhino3d.com")]
[assembly: PlugInDescription(DescriptionType.WebSite, "http://www.rhino3d.com")]

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyDescription("SelCommands")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Robert McNeel & Associates")]
[assembly: AssemblyProduct("SelCommands")]
[assembly: AssemblyCopyright("Copyright ©  2010")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyFileVersion("1.0.0.0")]
