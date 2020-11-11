using UniRx;

namespace MarcTest.Player
{
    public class PlayerMediator
    {
        const int STARTING_COINS = 99;

        public PlayerMediator(PlayerModel model, PlayerView view)
        {
            //Init
            model.Coins.Value = STARTING_COINS;

            //Suscriptions
            model.Coins.AsObservable().Subscribe(value =>
            {
                view.SetCoinsText(value);
            });

            model.Power.AsObservable().Subscribe(value =>
            {
                view.SetPowerText(value);
            });
        }
    }
}

