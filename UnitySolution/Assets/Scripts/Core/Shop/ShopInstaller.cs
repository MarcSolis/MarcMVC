using UnityEngine;


namespace MarcTest.Shop
{
    
    public class ShopInstaller : MonoBehaviour
    {
        [SerializeField] private ShopView _view;

        public void Install(Player.PlayerModel playerModel)
        {
            var model = new ShopModel();
            var command = new OnBuyShopCommand(model, playerModel);
            var mediator = new ShopMediator(_view, model, command);
        }

    }
}

