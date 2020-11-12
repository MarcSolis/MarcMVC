using UniRx;

namespace MarcTest.Shop
{
    public class ShopMediator
    {
        public ShopMediator(ShopView view, ShopModel model, OnBuyShopCommand onBuyCharacter1Command, OnBuyShopCommand onBuyCharacter2Command)
        {

            view.Init(model.character1.CharacterPrice.Value, model.character2.CharacterPrice.Value);


            view.Char1ButtonClickedEvent.AsObservable().Subscribe(e =>
            {
                onBuyCharacter1Command.Execute();
            });

            model.character1.CharacterPrice.AsObservable().Subscribe(view.SetCharacter1Price);

            view.Char2ButtonClickedEvent.AsObservable().Subscribe(e => 
            {
                onBuyCharacter2Command.Execute();
            });

            model.character2.CharacterPrice.AsObservable().Subscribe(view.SetCharacter2Price);

        }
    }
}

