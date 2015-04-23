using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApplication2
{
    public interface IBaseCommentRepositoryGeneric<T>
    {
        List<T> GetAllEntitiesList();
    }
}