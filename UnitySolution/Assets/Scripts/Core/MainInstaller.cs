using UnityEngine;

namespace MarcTest
{
    public class MainInstaller : MonoBehaviour
    {
        [SerializeField] private Shop.ShopInstaller _shopInstaller;
        [SerializeField] private Player.PlayerInstaller _playerInstaller;

        private void Start()
        {
            _playerInstaller.Install();
            _shopInstaller.Install(_playerInstaller.model);
        }

    }
}


