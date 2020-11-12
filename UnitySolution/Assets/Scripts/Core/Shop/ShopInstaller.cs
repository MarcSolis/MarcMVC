using UnityEngine;

namespace MarcTest.Shop
{
    public class ShopInstaller : MonoBehaviour
    {
        [SerializeField] private ShopView _view;

        public void Install(Player.PlayerModel playerModel)
        {
            var model = new ShopModel();
            var onBuyCharacter1Command = new OnBuyShopCommand(model, playerModel, model.characters[0] );
            var onBuyCharacter2Command = new OnBuyShopCommand(model, playerModel, model.characters[1]);
            new ShopMediator(_view, model, onBuyCharacter1Command, onBuyCharacter2Command);
        }
    }
}

