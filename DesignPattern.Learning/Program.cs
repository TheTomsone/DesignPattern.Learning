// See https://aka.ms/new-console-template for more information
using DesignPattern.Learning.Exo2;
using DesignPattern.Learning.Exo2.CanClass;
using DesignPattern.Learning.Exo2.Client;
using DesignPattern.Learning.Exo2.Client.Canards;
using DesignPattern.Learning.Exo2.FlyClass;

//Desc1 d1 = new Desc1("toto");
//Desc1 d2 = new Desc1("dede");
//Desc2 d3 = new Desc2(3);
//Desc2 d4 = new Desc2(5);

//Console.WriteLine("D1 :");
//d1.display();
//d1.display();

//Console.WriteLine("----------------------");
//Console.WriteLine("D2 :");
//d2.display();
//d2.display();

//Console.WriteLine("----------------------");
//Console.WriteLine("D3 :");
//d3.display();
//d3.display();

//Console.WriteLine("----------------------");
//Console.WriteLine("D3 :");
//d4.display();
//d4.display();

//Console.WriteLine("----------------------");
//Console.WriteLine(d1.getCpt);
//Console.WriteLine(d2.getCpt);
//Console.WriteLine(d3.getCpt);
//Console.WriteLine(d4.getCpt);

//CanCan canCan = new CanCan();
//CoinCoin coinCoin = new CoinCoin();
//AltCan<CanCan, CoinCoin> altCan = new AltCan<CanCan, CoinCoin>(canCan, coinCoin);
//BegCan<AltCan<CanCan, CoinCoin>> begCan = new BegCan<AltCan<CanCan, CoinCoin>>(altCan);

//List<Canard> cannards = new List<Canard>
//{
//    new Colvert(),
//    new Mandarin(),
//    new Leurre(),
//    new CanardPlastic(),
//};

//foreach (var canard in cannards)
//{
//    Console.WriteLine("------------------------");
//    canard.Display();
//    canard.ExecuteCanCan();
//    canard.ExecuteFly();
//    canard.Swim();

//    if (canard.GetType() == typeof(Mandarin))
//        canard.FlyBehavior = new ReactionFly();
//}

//foreach (var canard in cannards)
//{
//    Console.WriteLine("------------------------");
//    canard.Display();
//    canard.ExecuteCanCan();
//    canard.ExecuteFly();
//    canard.Swim();

//    if (canard.GetType() == typeof(Colvert))
//        canard.CanBehavior = new BegCan<BegCan<AltCan<CanCan, CoinCoin>>>(begCan);
//}

//foreach (var canard in cannards)
//{
//    Console.WriteLine("------------------------");
//    canard.Display();
//    canard.ExecuteCanCan();
//    canard.ExecuteFly();
//    canard.Swim();

//    if (canard.GetType() == typeof(Colvert))
//        canard.CanBehavior = CreateCan(coinCoin, 16);
//        //canard.CanBehavior = new BegCan<AltCan<BegCan<CoinCoin>, CoinCoin>>(new AltCan<BegCan<CoinCoin>, CoinCoin>(new BegCan<CoinCoin>(coinCoin), coinCoin));
//        //canard.CanBehavior = new AltCan<BegCan<CoinCoin>, CoinCoin>(new BegCan<CoinCoin>(new CoinCoin()), coinCoin);
//        //canard.CanBehavior = new BegCan<BegCan<BegCan<CoinCoin>>>(new BegCan<BegCan<CoinCoin>>(new BegCan<CoinCoin>(new CoinCoin())));
//}

//foreach (var canard in cannards)
//{
//    Console.WriteLine("------------------------");
//    canard.Display();
//    canard.ExecuteCanCan();
//    canard.ExecuteFly();
//    canard.Swim();
//}

Console.WriteLine("--------------------------------------------------------");
HunterTest();

void HunterTest()
{
    Hunter hunter = new Hunter();
    Colvert canard = new Colvert();
    Animal<Colvert> animal = new Animal<Colvert>(canard);

    hunter.Scope(animal);
}

ICan CreateCan(ICan can, int nb, int index = 1)
{
    ICan currentCan = can;

    if ((nb > 0) && (nb & (nb -1)) == 0)
    {
        currentCan = new BegCan<ICan>(can);

        if (index == 1)
            ++index;

        return index < nb ? CreateCan(currentCan, nb, index * 2) : currentCan;
    }

    return index < nb ? CreateCan(currentCan, nb, ++index) : currentCan;

}