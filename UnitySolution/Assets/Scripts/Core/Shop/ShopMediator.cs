using UniRx;

namespace MarcTest.Shop
{
    public class ShopMediator
    {
        public ShopMediator(
            ShopView view, 
            ShopModel model, 
            OnBuyShopCommand[] onBuyCharacterCommands
        )
        {
            int[] charactersPrices = new int [model.characters.Length];
            for (var i = 0; i < charactersPrices.Length; i++)
            {
                charactersPrices[i] = model.characters[i].CharacterPrice.Value;
            }
            
            view.Init(charactersPrices);

            for (var i = 0; i < onBuyCharacterCommands.Length; i++)
            {
                var index = i;
                
                view.CharacterButtonObservableClickedEvent(index).Subscribe(e =>
                {
                    onBuyCharacterCommands[index].Execute();
                });
        
                model.characters[index].CharacterPrice.AsObservable().Subscribe(price =>
                {
                    view.SetCharacterPrice(price, index);
                });
            }
        }
    }
}