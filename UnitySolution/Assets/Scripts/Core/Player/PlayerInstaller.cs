
using UnityEngine;

namespace MarcTest.Player
{
    public class PlayerInstaller : MonoBehaviour
    {
        [SerializeField] private PlayerView _view;
       

        public void Install()
        {
            var model = new PlayerModel();
            var mediator = new PlayerMediator(model, _view);
        }

        public void Install(PlayerModel model)
        {
            var mediator = new PlayerMediator(model, _view);
        }
    }
}

