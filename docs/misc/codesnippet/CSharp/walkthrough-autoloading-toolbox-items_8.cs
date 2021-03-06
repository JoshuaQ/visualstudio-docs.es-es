using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using Microsoft.Win32;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;

using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;

namespace Company.LoadToolboxMembersCS
{
    // ...
    [PackageRegistration(UseManagedResourcesOnly = true)]
    // ...
    [DefaultRegistryRoot("Software\\Microsoft\\VisualStudio\\9.0")]
    // ...
    [InstalledProductRegistration(false, "#110", "#112", "1.0", IconResourceID = 400)]
    // ...
    [ProvideLoadKey("Standard", "1.0", "Package Name", "Company", 1)]
    // ...
    [ProvideMenuResource(1000, 1)]
    [Guid(GuidList.guidLoadToolboxMembersPkgString)]
    [ProvideToolboxItems(1)]
    public sealed class LoadToolboxMembersPackage : Package
    {
        // List for the toolbox items provided by this package.
        private ArrayList ToolboxItemList;

        // Name for the Toolbox category tab for the package's toolbox items.
        private string CategoryTab = "LoadToolboxMembers Walkthrough CS";

        // ...