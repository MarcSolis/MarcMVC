using Command;
using MarcTest.Player;
using UniRx;

namespace MarcTest.Shop
{
    public class OnBuyShopCommand
    {
        private readonly ShopModel _shopModel;
        private readonly PlayerModel _playerModel;

        public OnBuyShopCommand(ShopModel shopModel, PlayerModel playerModel)
        {
            _shopModel = shopModel;
            _playerModel = playerModel;
        }

        public void Execute(ReactiveProperty<int> purchasedCharacterPrice, int purchasedCharacterPower)
        {
            if (_playerModel.Coins.Value < purchasedCharacterPrice.Value) 
                return;
            _playerModel.Coins.Value -= purchasedCharacterPrice.Value;
            purchasedCharacterPrice.Value++;
            _playerModel.Power.Value += purchasedCharacterPower;
        }
    }
}

