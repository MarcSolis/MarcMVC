using UnityEngine;


namespace MarcTest.Shop
{
    
    public class ShopInstaller : MonoBehaviour
    {
        [SerializeField] private ShopView _view;

        public void Install()
        {
            var model = new ShopModel();
            var mediator = new ShopMediator(_view, model);
        }

    }
}

