using UniRx;

namespace MarcTest.Player
{
    public class PlayerModel
    {
        public ReactiveProperty<int> Coins;

        public PlayerModel()
        {
            Coins = new ReactiveProperty<int>();
        }

    }
}

