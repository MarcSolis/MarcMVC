using UnityEngine;

namespace MarcTest
{
    public class MainInstaller : MonoBehaviour
    {
        [SerializeField] private Shop.ShopInstaller _shopInstaller;
        [SerializeField] private Player.PlayerInstaller _playerInstaller;

        private void Start()
        {
            var playerModel = new Player.PlayerModel(99);
            _playerInstaller.Install(playerModel);
            _shopInstaller.Install(playerModel);
        }
    }
}


