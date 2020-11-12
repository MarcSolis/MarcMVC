using UniRx;

namespace MarcTest.Shop{
   public class ShopModel
    {
        public readonly struct Character
        {
            public readonly ReactiveProperty<int> CharacterPrice;
            public readonly ReactiveProperty<int> CharacterPower;
            
            public Character(int price, int power)
            {
                CharacterPrice = new ReactiveProperty<int>(price);
                CharacterPower = new ReactiveProperty<int>(power);
            }
        }


        public readonly  Character character1;
        public readonly  Character character2;

        public ShopModel()
        {
            character1 = new Character(10, 1);
            character2 = new Character(20, 2);
        }
    }
}

