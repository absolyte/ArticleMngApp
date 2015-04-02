using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class PrivilegieRepository : IUserSpecificPropertieRepositoryGeneric<Privilegie>
    {
        public List<Privilegie> AllAdminPrivilegies;

        public PrivilegieRepository()
        {
        AllAdminPrivilegies = new List<Privilegie>();
        AllAdminPrivilegies.Add(new Privilegie(0, 0, "privilegie1"));
        AllAdminPrivilegies.Add(new Privilegie(1, 2, "privilegie2"));
        AllAdminPrivilegies.Add(new Privilegie(2, 2, "privilegie3"));
        AllAdminPrivilegies.Add(new Privilegie(3, 2, "privilegie4"));
        AllAdminPrivilegies.Add(new Privilegie(4, 3, "privilegie5"));
        AllAdminPrivilegies.Add(new Privilegie(5, 4, "privilegie6"));
        AllAdminPrivilegies.Add(new Privilegie(6, 5, "privilegie7"));
        }

        public List<Privilegie> GetAllUserSpecificPropertiesList()
        {
          return AllAdminPrivilegies;
        }
    }
}