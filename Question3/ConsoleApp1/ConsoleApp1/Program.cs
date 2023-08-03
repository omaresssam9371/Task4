
using static System.Reflection.Metadata.BlobBuilder;

class Program
{
    public class Product
    {
        public string name { set; get; }
        public int price { set; get; }
        public int quantity { set; get; }
        public Product(string name,int price, int quantity)
        {
            this.name=name;
            this.price = price;
            this.quantity = quantity;
        }
        public void Display_objects()
        {
            Console.WriteLine($"Name is: {name}, Price is: {price}, Quantity is: {quantity}");
        }
    }

    static void Main(string[] args)
    {

        List<Product> product2 = new List<Product>();
       
        Console.WriteLine("Write the number of operations you want to perform");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int k=0;k<number;k++) { 
        Console.WriteLine("Please Select if you want to add,remove or update the inventory" +
            "Write 0 if you want to add" +
            "Write 1 if you want to remove"
            + "Write 2 if you want to update");
        switch (Convert.ToInt32(Console.ReadLine()))
        {


            case 0:
                Console.WriteLine("Write the properties to add to the inventory");
                string name1=Convert.ToString(Console.ReadLine());
                int price1=Convert.ToInt32(Console.ReadLine());
                int quantity1=Convert.ToInt32(Console.ReadLine());
                Product new_product = new Product(name1, price1, quantity1);
                product2.Add(new_product);
                Console.WriteLine("The product is added");
                break;


            case 1:
                Console.WriteLine("Select the item name to remove");
                string removed_item_name=Convert.ToString(Console.ReadLine());
                for (int i = 0; i < product2.Count; i++)
                {
                    if (product2[i].name == removed_item_name)
                    {
                        product2.RemoveAt(i);
                        break; 
                    }
                }
                break;

            case 2:
                Console.WriteLine("Please enter the name of the product you want to update");
                string name_update=Convert.ToString(Console.ReadLine());
                Console.WriteLine("Update the Inventory  " +
                    "if you want to update name Write 0" +
                    "if price write 1" +
                    "if quantity write 2");

                    
                        for (int i = 0; i < product2.Count; i++)
                        {
                            if (product2[i].name == name_update)
                            {
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 0:

                                    product2[i].name=Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Updated name:" + product2[i].name);
                                    break;
                            case 1:
                                product2[i].price = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Updated price:" + product2[i].price);
                                break;
                            case 2:
                                product2[i].quantity = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Updated quantity:" + product2[i].quantity);
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine("After updating: ");
                        product2[i].Display_objects();
                        }


                }
                        break;


        default:
                Console.WriteLine("You entered wrong input");
                break; 
        }

        }



    }

}