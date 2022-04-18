using System;

namespace CatalogSaver
{
    public interface ISaveable
    {
        void Save();
    }

    public class Catalog : ISaveable
    {
        public void Save()
        {
            Console.WriteLine("Saved (catalog)");
        }
        //Don't use a modifier acess
        void ISaveable.Save()
        {
            Console.WriteLine("Saved (interface)");
        }
    }
}
