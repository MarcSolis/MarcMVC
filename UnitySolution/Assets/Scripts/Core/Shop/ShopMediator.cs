using UniRx;

namespace MarcTest.Shop
{
    public class ShopMediator
    {
        public ShopMediator(ShopView view, ShopModel model, OnBuyShopCommand onBuyShopCommand)
        {
            view.Init(model.Character1Price.Value, model.Character2Price.Value);
            
            view.Char1ButtonClickedEvent.AsObservable().Subscribe(e =>
            {
                onBuyShopCommand.Execute(model.Character1Price, 1);
            });

            model.Character1Price.AsObservable().Subscribe(view.SetCharacter1Price);

            view.Char2ButtonClickedEvent.AsObservable().Subscribe(e =>
            {
                onBuyShopCommand.Execute(model.Character2Price, 2);
            });

            model.Character2Price.AsObservable().Subscribe(view.SetCharacter2Price);

        }
    }
}

