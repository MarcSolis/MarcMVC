using UniRx;

namespace MarcTest.Shop{
   public class ShopModel
    {
        public readonly ReactiveProperty<int>[] Characters;

        public ShopModel()
        {
            Characters = new[] {new ReactiveProperty<int>(10), new ReactiveProperty<int>(20)};
        }
    }
}

