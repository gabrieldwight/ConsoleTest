using System;

namespace Console.DB
{
    public interface IDataInterface
    {
        // Abstract methods
        void insert(string query);
        void update(string query);
        void select(string query);
    }
}
