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

        public void Execute(ReactiveProperty<int> character, int power)
        {
            if (_playerModel.Coins.Value < character.Value) return;
            _playerModel.Coins.Value -= character.Value;
            character.Value++;
            _playerModel.Power.Value += power;
        }

        public void BuyCharacter1()
        {
            if (_playerModel.Coins.Value < _shopModel.Character1Price.Value) return;
            _playerModel.Coins.Value -= _shopModel.Character1Price.Value;
            _shopModel.Character1Price.Value++;
            _playerModel.Power.Value++;
        }

        public void BuyCharacter2()
        {
            if (_playerModel.Coins.Value < _shopModel.Character2Price.Value) return;
            _playerModel.Coins.Value -= _shopModel.Character2Price.Value;
            _shopModel.Character2Price.Value++;
            _playerModel.Power.Value+=2;
        }

    }
}

