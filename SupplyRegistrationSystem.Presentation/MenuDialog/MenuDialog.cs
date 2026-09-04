using SupplyRegistrationSystem.Presentation.ProductSystem.Services;

namespace SupplyRegistrationSystem.Presentation.MenuDialog;

public class MenuDialog
{
    private bool isRunning = true;
    public void MenuDialogPresentation()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("### MENU ###");
            Console.WriteLine("[1] CUSTOMER");
            Console.WriteLine("[2] PRODUCTS");
            Console.WriteLine("[3] SUPPLIER");
            Console.WriteLine("[0] EXIT");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":

                    break;
                case "2":
                    
                    break;
                case "3":

                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You must choose a valid option! Press any button to continue...");
                    Console.ReadKey();
                    break;
            }
        }
        while (isRunning);
    }

}
