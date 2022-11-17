using System;
namespace Alg1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meatTypes = { "Рыбная", "Говяжья", "Куриная", "Свинная" };
            Console.WriteLine("Выбери какую катлету будешь использовать:\n[1] " + meatTypes[0] + ";\n[2] " + meatTypes[1] + ";\n[3]" +
                " " + meatTypes[2] + ";\n[4] " + meatTypes[3] + ".");
            string? meat = Console.ReadLine();
            while (!((meat == "1") || (meat == "2") || (meat == "3") || (meat == "4")))
            {
                Console.WriteLine("\nЯ тебя не понял! Скажи ещё раз.");
                meat = Console.ReadLine();
            }
            switch (meat)
            {
                case "1":
                    Console.WriteLine("\nПоздравляю! Вы выбрали рыбную котлету!");
                    meat = meatTypes[0];
                    break;
                case "2":
                    Console.WriteLine("\nПоздравляю! Вы выбрали говяжью котлету!");
                    meat = meatTypes[1];
                    break;
                case "3":
                    Console.WriteLine("\nПоздравляю! Вы выбрали куриную котлету!");
                    meat = meatTypes[2];
                    break;
                case "4":
                    Console.WriteLine("\nПоздравляю! Вы выбрали свинную котлету!");
                    meat = meatTypes[3];
                    break;
            }
            bool product = false;
            string? replic;
            void CheckReplic()
            {
                while (!((replic == "1") || (replic == "2")))
                {
                    Console.WriteLine("\nЯ тебя не понял! Скажи ещё раз.");
                    replic = Console.ReadLine();
                }
            }
            while (!product)
            {
                Console.WriteLine("\nДома есть продукты из списка?!\nНеобходимые ингредиенты:\n1) 2 булки;\n2) Ломтик сыра;" +
                               "\n3) Котлета из указанного мяса;\n4) Кетчуп;\n5) Маринованный огурец;\n6) Лист салата;\n7) Подсолнечное" +
                               " масло.\n[1] -Да;\n[2] -Нет");
                replic = Console.ReadLine();
                CheckReplic();
                if (replic == "2")
                {
                    product = false;
                }
                else
                {
                    product = true;
                }
                while (!(replic == "1"))
                {
                    Console.WriteLine("\nИди в магазин и купи!\n[1] -Купил!\n[2] -Нет, я затворник и не выйду с дома");
                    replic = Console.ReadLine();
                    CheckReplic();
                }
            }
            Console.WriteLine("\nОтлично!");
            Console.WriteLine("\nНареж овощи!\n[1] -Кат-кат-кат!!!\n[2] -Я в своем познании настолько преисполнился, что я как будто" +
                " бы уже сто триллионов миллиардов лет проживаю на триллионах и триллионах таких же планет, как эта Земля, мне этот мир абсолютно" +
                " понятен, и я здесь ищу только одного - покоя, умиротворения и вот этой гармонии, от слияния с бесконечно вечным, от созерцания " +
                "великого фрактального подобия и от вот этого замечательного всеединства существа, бесконечно вечного, куда ни посмотри, хоть вглубь" +
                " - бесконечно малое, хоть ввысь - бесконечное большое, понимаешь ? ");
            replic = Console.ReadLine();
            CheckReplic();
            while (!(replic == "1"))
            {
                Console.WriteLine("\nПонимаю.\n[1] -Ладно... Кат-кат-кат!!!\n[2] -Не смотри на меня так... Я не буду резать овощи!");
                replic = Console.ReadLine();
                CheckReplic();
            }
            Console.WriteLine("\nВо избежании твоих капризов я сам поставил сковороду на плиту и включил огонь.\n[1] Налить масла на сковороду." +
                " \n[2] Ничего не делать.");
            replic = Console.ReadLine();
            CheckReplic();
            while (!(replic == "1"))
            {
                Console.WriteLine("\nПонимаю.\n[1] Налить масла на сковороду.\n[2] Ничего не делать.");
                replic = Console.ReadLine();
                CheckReplic();
            }
            Console.WriteLine("\nМасла достаточно?\n[1] Да." +
               " \n[2] Откуда мне знать?! Тебе виднее.");
            replic = Console.ReadLine();
            CheckReplic();
            while (!(replic == "1"))
            {
                Console.WriteLine("\nМасла достаточно?\n[1] -Да.\n[2] Налить ещё.");
                replic = Console.ReadLine();
                CheckReplic();
            }
            bool meatSide = false;
            bool meatHot = false;
            void fry()
            {
                while (meatHot == false)
                {
                    Console.WriteLine("\nСторона котлетки обжарилась?\n[1] -Да." +
                     " \n[2] -Нет.");
                    replic = Console.ReadLine();
                    CheckReplic();
                    if (replic == "1")
                    {
                        meatHot = true;
                    }
                    else if (replic == "2")
                    {
                        Console.WriteLine("\nЖди.");
                    }
                }
                meatHot = false;
                Console.WriteLine("\nТы обжарил с двух сторон котлетку?\n[1] -Да." +
                " \n[2] -Нет.");
                replic = Console.ReadLine();
                CheckReplic();
                while ((replic == "1") && (meatSide == false))
                {
                    Console.WriteLine("\nВрёшь.");
                    Console.WriteLine("\nТы обжарил с двух сторон котлетку?\n[1] -Да." +
                  " \n[2] -Нет.");
                    replic = Console.ReadLine();
                    CheckReplic();
                }
                while ((replic == "2") && (meatSide == true))
                {
                    Console.WriteLine("\nВрёшь.");
                    Console.WriteLine("\nТы обжарил с двух сторон котлетку?\n[1] -Да." +
                  " \n[2] -Нет.");
                    replic = Console.ReadLine();
                    CheckReplic();
                }
            }
            fry();
            while (!(replic == "1"))
            {
                Console.WriteLine("\nПереверни.\n[1] -Ок.\n[2] -Сам.");
                replic = Console.ReadLine();
                CheckReplic();
            }
            meatSide = true;
            fry();
            Console.WriteLine("\nЯ выключил огонь и достал тарелку. Твоя последняя задача" +
                " - в нужной последовательности собрать бургер. Сможешь?\n[1] -Давай покончим с этим.\n[2] -Сдаюсь.");
            replic = Console.ReadLine();
            CheckReplic();
            if (replic == "2")
            {
                Console.WriteLine("\nОставайся голодный!");
            }
            else
            {
                Console.WriteLine("\nУдачи... Введи нужную последовательность.\n1) Булка;\n2) Кетчуп;\n3) Ломтик сыра;\n" +
                    "4) "+ meat +" котлета;\n5) Маринованный огурец;\n6) Лист салата.");
                replic = Console.ReadLine();
                while (!(replic == "123456"))
                {
                    Console.WriteLine("\nНеверно.\n1) Булка;\n2) Кетчуп;\n3) Ломтик сыра;\n" +
                   "4) " + meat + " котлета;\n5) Маринованный огурец;\n6) Лист салата.");
                    replic = Console.ReadLine();
                }
                Console.WriteLine("\nТы лучший!");
            }
        }
    }
}
