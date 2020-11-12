using Command;
using MarcTest.Player;
using UniRx;

namespace MarcTest.Shop
{
    public class OnBuyShopCommand : ICommand
    {
        private readonly ShopModel _shopModel;
        private readonly PlayerModel _playerModel;
        private readonly ShopModel.Character _targetCharacter;

        public OnBuyShopCommand(ShopModel shopModel, PlayerModel playerModel, ShopModel.Character targetCharacter)
        {
            _shopModel = shopModel;
            _playerModel = playerModel;
            _targetCharacter = targetCharacter;
        }

        public void Execute()
        {
            if (_playerModel.Coins.Value < _targetCharacter.CharacterPrice.Value) return;
            _playerModel.Coins.Value -= _targetCharacter.CharacterPrice.Value;
            _targetCharacter.CharacterPrice.Value++;
            _playerModel.Power.Value += _targetCharacter.CharacterPower.Value;
        }

    }
}

