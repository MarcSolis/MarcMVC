using UnityEngine;

namespace MarcTest.Shop
{
    public class MainInstaller : MonoBehaviour
    {
        [SerializeField] private ShopInstaller _shopInstaller;

        private void Start()
        {
            _shopInstaller.Install();
        }

    }
}


