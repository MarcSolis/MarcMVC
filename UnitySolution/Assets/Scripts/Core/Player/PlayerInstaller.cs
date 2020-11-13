using UnityEngine;

namespace MarcTest.Player
{
    public class PlayerInstaller : MonoBehaviour
    {
        [SerializeField] private PlayerView _view;

        public void Install(PlayerModel model)
        { 
            new PlayerMediator(model, _view);
        }
    }
}

