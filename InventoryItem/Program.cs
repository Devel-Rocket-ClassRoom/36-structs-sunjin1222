using System;

// README.md를 읽고 코드를 작성하세요.

double TotalWeight=0;
int TotalPrice=0;
int Totalage = 0;
int MaxPrice = int.MinValue; ;
string MaxPriceitme="없음";
int MinWeight = int.MaxValue;
string MinWeightitme = "없음";
Console.WriteLine("코드를 작성하세요.");
InventoryItem[] inventoryItems = new InventoryItem[5];

inventoryItems[0].Name = "검";
inventoryItems[0].Weight = 3.5;
inventoryItems[0].Price = 1500;

inventoryItems[1].Name = "방패";
inventoryItems[1].Weight = 5.0;
inventoryItems[1].Price = 1200;

inventoryItems[2].Name = "포션";
inventoryItems[2].Weight = 0.3;
inventoryItems[2].Price = 50;

inventoryItems[3].Name = "활";
inventoryItems[3].Weight = 1.8;
inventoryItems[3].Price = 1300;

inventoryItems[4].Name = "투구";
inventoryItems[4].Weight = 2.0;
inventoryItems[4].Price = 800;

Console.WriteLine("=== 인벤토리 목록 ===");
for (int i=0;i< inventoryItems.Length;i++)
{
    Console.WriteLine($"{inventoryItems[i].Name}-무게: {inventoryItems[i].Weight}Kg" +
        $", 가격: {inventoryItems[i].Price}골드"); 
}
Console.WriteLine("=== 인벤토리 통계 ===");
for (int i = 0; i < inventoryItems.Length; i++)
{
    TotalWeight += inventoryItems[i].Weight;      
}
Console.WriteLine($"전체 무게: {TotalWeight:f1}Kg");
for (int i = 0; i < inventoryItems.Length; i++)
{
    TotalPrice += inventoryItems[i].Price;
}
Console.WriteLine($"전체 가격: {TotalPrice}골드");
for (int i = 0; i < inventoryItems.Length; i++)
{
    Totalage= (Totalage + inventoryItems[i].Price);
}
Console.WriteLine($"전체 가격: {Totalage/inventoryItems.Length}골드");
for (int i = 0; i < inventoryItems.Length; i++)
{
    if (MaxPrice < inventoryItems[i].Price)
    {
        MaxPrice = inventoryItems[i].Price;
        MaxPriceitme = inventoryItems[i].Name;
    }
}
Console.WriteLine($"가장비싼 아이템: {MaxPriceitme}");
for (int i = 0; i < inventoryItems.Length; i++)
{
    if (MinWeight > inventoryItems[i].Price)
    {
        MinWeight = inventoryItems[i].Price;
        MinWeightitme = inventoryItems[i].Name;
    }
}
Console.WriteLine($"가장가벼운 아이템: {MinWeightitme}");
