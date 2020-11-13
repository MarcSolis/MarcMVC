using UniRx;

namespace MarcTest.Shop
{
    public class ShopModel
    {
       public readonly Character[] characters;
       
        public ShopModel(Character[] characters)
        {
            this.characters = characters;
        }
    }
    
    public struct Character
    {
        public readonly ReactiveProperty<int> CharacterPrice;
        public readonly ReactiveProperty<int> CharacterPower;

        public Character(int price, int power)
        {
            CharacterPrice = new ReactiveProperty<int>(price);
            CharacterPower = new ReactiveProperty<int>(power);
        }
    }
}

