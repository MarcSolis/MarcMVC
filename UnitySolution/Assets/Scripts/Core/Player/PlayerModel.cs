using UniRx;

namespace MarcTest.Player
{
    public class PlayerModel
    {
        public readonly ReactiveProperty<int> Coins;
        public readonly ReactiveProperty<int> Power;

        public PlayerModel(int startCoins)
        {
            Coins = new ReactiveProperty<int>(startCoins);
            Power = new ReactiveProperty<int>();
        }
    }
}

