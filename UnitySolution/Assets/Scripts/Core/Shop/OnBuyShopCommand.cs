using Command;
using MarcTest.Player;
using UniRx;


namespace MarcTest.Shop
{
    public class OnBuyShopCommand : ICommand
    {
        private readonly PlayerModel _playerModel;
        private readonly Character _purchasedCharacter;

        public OnBuyShopCommand(
            PlayerModel playerModel, 
            Character purchasedCharacter
        )
        {
            _playerModel = playerModel;
            _purchasedCharacter = purchasedCharacter;
        }

        public void Execute()
        {
            if (_playerModel.Coins.Value < _purchasedCharacter.CharacterPrice.Value) return;
            _playerModel.Coins.Value -= _purchasedCharacter.CharacterPrice.Value;
            _purchasedCharacter.CharacterPrice.Value++;
            _playerModel.Power.Value += _purchasedCharacter.CharacterPower.Value;
        }
    }
}

