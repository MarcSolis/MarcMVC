
using UnityEngine;

namespace MarcTest.Player
{
    public class PlayerInstaller : MonoBehaviour
    {
        [SerializeField] private PlayerView _view;
        public PlayerModel model;

        public void Install()
        {
            model = new PlayerModel();
            var mediator = new PlayerMediator(model, _view);
        }
    }
}

