using UniRx;

namespace MarcTest.Player
{
    public class PlayerModel
    {

        public ReactiveProperty<int> Coins, Power;

        public PlayerModel()
        {
            Coins = new ReactiveProperty<int>();
            Power = new ReactiveProperty<int>();
        }

    }
}

