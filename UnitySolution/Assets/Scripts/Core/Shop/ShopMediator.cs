using UniRx;

namespace MarcTest.Shop
{
    public class ShopMediator
    {
        public ShopMediator(ShopView view, ShopModel model, OnBuyShopCommand onBuyShopCommand)
        {
            view.Init(model.Characters[0].Value, model.Characters[1].Value);
            
            view.Char1ButtonClickedEvent.AsObservable().Subscribe(e =>
            {
                onBuyShopCommand.Execute(model.Characters[0], 1);
            });

            model.Characters[0].AsObservable().Subscribe(view.SetCharacter1Price);

            view.Char2ButtonClickedEvent.AsObservable().Subscribe(e =>
            {
                onBuyShopCommand.Execute(model.Characters[1], 2);
            });

            model.Characters[1].AsObservable().Subscribe(view.SetCharacter2Price);
        }
    }
}

