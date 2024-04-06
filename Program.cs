namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Store store = new Store();
           
                while (true)
                {
                    Console.WriteLine("1. Mehsul elave et");
                    Console.WriteLine("2. Mehsul sil");
                    Console.WriteLine("3. Mehsula bax");
                    Console.WriteLine("4. Nove gore mehsullara bax");
                    Console.WriteLine("5. Ada gore mehsullara bax");
                    Console.WriteLine("0. Proqramdan cix");

                    Console.Write("Secim edin: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddProduct(store);
                            break;
                        case "2":
                            RemoveProduct(store);
                            break;
                        case "3":
                            ViewProduct(store);
                            break;
                        case "4":
                            FilterByType(store);
                            break;
                        case "5":
                            FilterByName(store);
                            break;
                        case "0":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Duzgun secim edin!");
                            break;
                    }
                }
            }

            static void AddProduct(Store store)
            {
                Console.Write("Mehsulun adi: ");
                string name = Console.ReadLine();

                Console.Write("Qiymeti: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Novu: ");
                string type = Console.ReadLine();

                Console.Write("Sayi: ");
                int count = Convert.ToInt32(Console.ReadLine());

                Product product = new Product(name, price, type, count);
                store.AddProduct(product);
                Console.WriteLine("Mehsul elave olundu");
            }

            static void RemoveProduct(Store store)
            {
                Console.Write("Aradan qaldirilan mehsulun nomresin qeyd et: ");
                int no = Convert.ToInt32(Console.ReadLine());
                store.RemoveProductByNo(no);
                Console.WriteLine("Mehsul aradan qaldirildi");
            }

            static void ViewProduct(Store store)
            {
                Console.Write("Baxmaq üçün məhsul nömrəsini daxil edin: ");
                int no = Convert.ToInt32(Console.ReadLine());
                Product product = store.GetProduct(no);
                if (product != null)
                {
                    Console.WriteLine(product);
                }
                else
                {
                    Console.WriteLine("Mehsul tapilmadi");
                }
            }

            static void FilterByType(Store store)
            {
                Console.Write("Məhsulları filtrləmək üçün növü daxil edin: ");
                string type = Console.ReadLine();
                Product[] filteredProducts = store.FilterProductsByType(type);
                foreach (var product in filteredProducts)
                {
                    Console.WriteLine(product);
                }
            }

            static void FilterByName(Store store)
            {
                Console.Write("Enter name to filter products: ");
                string name = Console.ReadLine();
                Product[] filteredProducts = store.FilterProductsByName(name);
                foreach (var product in filteredProducts)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }


    

