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

            ISaveable saveable = new Catalog();
            saveable.Save();
            //"Saved"

            ((ISaveable)catalog).Save();
            //"Saved"
        }
    }
}
