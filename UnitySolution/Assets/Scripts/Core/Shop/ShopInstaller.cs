using UnityEngine;
using MarcTest.Player;

namespace MarcTest.Shop
{
    public class ShopInstaller : MonoBehaviour
    {
        [SerializeField] private ShopView _view;

        public void Install(PlayerModel playerModel)
        {
            var model = new ShopModel(new [] { new Character(10, 1), new Character(20, 2)});

            var onBuyCharacterCommands = new OnBuyShopCommand[model.characters.Length];
            for (int i = 0; i < onBuyCharacterCommands.Length; i++)
            {
                onBuyCharacterCommands[i] = new OnBuyShopCommand(playerModel, model.characters[i]);
            }
            new ShopMediator(_view, model, onBuyCharacterCommands);
        }
    }
}

