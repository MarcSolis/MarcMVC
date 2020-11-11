using UniRx;

namespace MarcTest.Shop
{
    public class ShopMediator
    {
        public ShopMediator(ShopView view, ShopModel model, OnBuyShopCommand onBuyShopCommand)
        {
            //Initial State
            view.Init(model.Character1Price.Value, model.Character2Price.Value);

            //Suscriptions
            view.Char1ButtonClickedEvent.AsObservable().Subscribe(e =>
            {
                onBuyShopCommand.BuyCharacter1();
            });

            model.Character1Price.AsObservable().Subscribe(value =>
            {
                view.SetChar1Price(value);
            });

            view.Char2ButtonClickedEvent.AsObservable().Subscribe(e => 
            {
                onBuyShopCommand.BuyCharacter2();
            });

            model.Character2Price.AsObservable().Subscribe(value =>
            {
                view.SetChar2Price(value);
            });

        }
    }
}

