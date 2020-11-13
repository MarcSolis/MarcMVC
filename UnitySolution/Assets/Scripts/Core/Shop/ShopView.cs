using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UniRx;

namespace MarcTest.Shop
{
    public class ShopView : MonoBehaviour
    {
        [SerializeField] private Button[] _charactersBuyButton;
        [SerializeField] private TextMeshProUGUI[] _charactersText;

        public void Init(int[] characterPrices)
        {
            for (int i = 0; i < characterPrices.Length; i++)
            {
                SetCharacterPrice(characterPrices[i], i);
            }
        }

        public void SetCharacterPrice(int price, int level)
        {
            _charactersText[level].text = $"Level {level.ToString()}:\n{price.ToString()}$";
        }

        public System.IObservable<UniRx.Unit> CharacterButtonObservableClickedEvent(int index)
        {
            return _charactersBuyButton[index].onClick.AsObservable();
        }
    }
}

