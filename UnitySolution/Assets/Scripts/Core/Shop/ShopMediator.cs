using UniRx;

namespace MarcTest.Shop
{
    public class ShopMediator
    {
        public ShopMediator(ShopView view, ShopModel model)
        {
            //Initial State
            view.Init(model.Character1Price.Value, model.Character2Price.Value);

            //Suscriptions
            view.Char1ButtonClickedEvent.AsObservable().Subscribe(e =>
            {
                model.Character1Price.Value++;
            });

            model.Character1Price.AsObservable().Subscribe(value =>
            {
                view.SetChar1Price(value);
            });

            view.Char2ButtonClickedEvent.AsObservable().Subscribe(e => 
            {
                model.Character2Price.Value++;
            });

            model.Character2Price.AsObservable().Subscribe(value =>
            {
                view.SetChar2Price(value);
            });

        }
    }
}

