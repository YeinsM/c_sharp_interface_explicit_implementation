namespace CatalogSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            /* We just need use the explicit interface implementation when we need implement
            many interfaces that have conflicting method signatures */

            Catalog catalog = new Catalog();
            //"Saved (catalog)"
            catalog.Save();

            //compiler error
            //var varCatalog = new Catalog();
            //varCatalog.Save();

            //create variable with interface type
            ISaveable saveable = catalog;
            saveable.Save();
            //"Saved (interface)"

            //convert Catalog to ISaveable
            ((ISaveable)catalog).Save();
            //"Saved (interface)"
        }
    }
}
