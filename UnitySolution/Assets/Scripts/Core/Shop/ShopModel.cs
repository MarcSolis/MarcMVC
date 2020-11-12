using UniRx;

namespace MarcTest.Shop{
   public class ShopModel
    {
        public readonly ReactiveProperty<int> Character1Price;
        public readonly ReactiveProperty<int> Character2Price;

        public ShopModel()
        {
            Character1Price = new ReactiveProperty<int>(10);
            Character2Price = new ReactiveProperty<int>(20);
        }


    }
}

