namespace CatalogSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            //compiler error
            //catalog.Save();

            //compiler error
            //var varCatalog = new Catalog();
            //varCatalog.Save();

            //create variable with interface type
            ISaveable saveable = new Catalog();
            saveable.Save();
            //"Saved"

            //convert Catalog to ISaveable
            ((ISaveable)catalog).Save();
            //"Saved"
        }
    }
}
