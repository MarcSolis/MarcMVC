using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace MarcTest.Shop
{
    public class ShopView : MonoBehaviour
    {
        [SerializeField] private Button _char1Button, _char2Button;
        [SerializeField] private TextMeshProUGUI _char1Text, _char2Text;

        public Button.ButtonClickedEvent Char1ButtonClickedEvent => _char1Button.onClick;
        public Button.ButtonClickedEvent Char2ButtonClickedEvent => _char2Button.onClick;

        public void Init(int priceChar1, int priceChar2)
        {
            SetCharacter1Price(priceChar1);
            SetCharacter2Price(priceChar2);
        }

        public void SetCharacter1Price(int price)
        {
            _char1Text.text = "Level 1:\n" + price.ToString() + "$";
        }

        public void SetCharacter2Price(int price)
        {
            _char2Text.text = "Level 2:\n" + price.ToString() + "$";
        }
    }
}

