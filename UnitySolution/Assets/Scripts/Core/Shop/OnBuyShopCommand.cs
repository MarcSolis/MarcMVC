using Command;

namespace MarcTest.Shop
{
    public class OnBuyShopCommand : ICommand
    {
        private ShopModel _shopModel;
        private Player.PlayerModel _playerModel;

        public OnBuyShopCommand(ShopModel shopModel, Player.PlayerModel playerModel)
        {
            _shopModel = shopModel;
            _playerModel = playerModel;
        }

        public void Execute()
        {
            
        }

        public void BuyChar1()
        {
            if (_playerModel.Coins.Value < _shopModel.Character1Price.Value) return;
            _playerModel.Coins.Value -= _shopModel.Character1Price.Value;
            _shopModel.Character1Price.Value++;
            _playerModel.Power.Value++;
        }

        public void BuyChar2()
        {
            if (_playerModel.Coins.Value < _shopModel.Character2Price.Value) return;
            _playerModel.Coins.Value -= _shopModel.Character2Price.Value;
            _shopModel.Character2Price.Value++;
            _playerModel.Power.Value+=2;
        }

    }
}

