public class HighEfficiencyVendingMachine : IVendingMachine
{
    private IMenuLoader _menuLoader;

    public HighEfficiencyVendingMachine(IMenuLoader menuLoader)
    {
        this._menuLoader = menuLoader;
    }


    public void DisplayMenu()
    {
        // read menu
        var products = _menuLoader.LoadMenu();

        // show menu
        foreach (var product in products)
        {
            Console.WriteLine(product.ToString());
        }
    }

    public void Start()
    {
        DisplayMenu();
    }
}
