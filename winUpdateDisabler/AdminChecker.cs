using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;


namespace processorUpdater
{
    internal class AdminChecker
    {
        public static bool IsUserAdministrator()
        {
            bool isAdmin = false;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);//Is Admin
            }
            //Is not admin
            catch (UnauthorizedAccessException ex) { }
            catch (Exception ex) { }

            return isAdmin;
        }
    }
}
