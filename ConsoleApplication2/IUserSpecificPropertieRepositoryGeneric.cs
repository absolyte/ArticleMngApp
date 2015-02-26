using System.Collections.Generic;

namespace ConsoleApplication2
{
    public interface IUserSpecificPropertieRepositoryGeneric<T>
    {
        List<T> GetAllUserSpecificPropertiesList();
    }
}