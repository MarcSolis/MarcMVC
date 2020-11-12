using UniRx;

namespace MarcTest.Player
{
    public class PlayerModel
    {
        public readonly ReactiveProperty<int> Coins;
        public readonly ReactiveProperty<int> Power;

        public PlayerModel()
        {
            Coins = new ReactiveProperty<int>(99);
            Power = new ReactiveProperty<int>();
        }
    }
}

