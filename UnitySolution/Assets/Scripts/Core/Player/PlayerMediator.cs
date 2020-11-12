using UniRx;

namespace MarcTest.Player
{
    public class PlayerMediator
    {
        public PlayerMediator(PlayerModel model, PlayerView view)
        {
            model.Coins.AsObservable().Subscribe(view.SetCoinsText);

            model.Power.AsObservable().Subscribe(view.SetPowerText);
        }
    }
}

