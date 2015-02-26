using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class PrivilegieRepository : IUserSpecificPropertieRepositoryGeneric<Privilegie>
    {
        public List<Privilegie> allAdminPrivilegies;

        public PrivilegieRepository()
        {
        allAdminPrivilegies = new List<Privilegie>();
        allAdminPrivilegies.Add(new Privilegie(0, 0, "privilegie1"));
        allAdminPrivilegies.Add(new Privilegie(1, 2, "privilegie2"));
        allAdminPrivilegies.Add(new Privilegie(2, 2, "privilegie3"));
        allAdminPrivilegies.Add(new Privilegie(3, 2, "privilegie4"));
        allAdminPrivilegies.Add(new Privilegie(4, 3, "privilegie5"));
        allAdminPrivilegies.Add(new Privilegie(5, 4, "privilegie6"));
        allAdminPrivilegies.Add(new Privilegie(6, 5, "privilegie7"));
        }

        public List<Privilegie> GetAllUserSpecificPropertiesList()
        {
          return allAdminPrivilegies;
        }
    }
}