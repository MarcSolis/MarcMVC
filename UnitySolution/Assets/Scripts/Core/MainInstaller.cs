using UnityEngine;
using MarcTest.Player;
using MarcTest.Shop;
using MarcTest.Server;

namespace MarcTest
{
    public class MainInstaller : MonoBehaviour
    {
        [SerializeField] private ShopInstaller _shopInstaller;
        [SerializeField] private PlayerInstaller _playerInstaller;
        [SerializeField] private ServerDataScriptableObject serverData;

        private void Start()
        {
            var playerModel = new PlayerModel(serverData.PlayerCoins);
            _playerInstaller.Install(playerModel);
            _shopInstaller.Install(serverData.GetCharactersInfoFromServer(), playerModel);
        }
    }
}