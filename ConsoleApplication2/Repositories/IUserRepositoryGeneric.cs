using System.Collections.Generic;

namespace ConsoleApplication2
{
    public interface IUserRepositoryGeneric<T>
    {
        List<T> GetAllUserList();
    }
}