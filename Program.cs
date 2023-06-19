//Create console application where you imitate shopping basket. 
//You should be able to add, remove or list items. 
//Your should know the total of the basket. Use OOP. 
//Create at least 3 different types of products.


namespace SGT2_Basket_006_0619
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var foodProduct = new FoodProduct
            {
                Id = 1,
                Name = "Milk",
                Description = "Soy Milk",
                Price = 1.34M,
                
            };

            var garment = new Garment
            {
                Id= 2,
                Name = "Dress",
                Description = "Short, yellow, with black stripes",
                Price = 39.8M,
            };


            var techGadget = new TechGadget
            {
                Id = 3,
                Name = "Apple Laptop",
                Price = 700M,
            };


            var techGadget2 = new TechGadget
            {
                Id = 4,
                Name = "Smart Phone",
                Price = 780,
            };


            var repo = new BasketRepository();

            repo.Add(foodProduct);
            repo.Add(garment);
            repo.Add(techGadget);

            foreach (var item in repo.BasketItems)
            {
                Console.WriteLine($"Id: {item.Id} - Title: {item.Name} - Price: {item.Price} - Total: {repo.TotalBasketAmount}");

            }
        }
    }
}