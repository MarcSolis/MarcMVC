using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UniRx;
using System;

namespace MarcTest.Shop
{
    public class ShopView : MonoBehaviour
    {
        [SerializeField] private Button[] _charactersBuyButton;
        [SerializeField] private TextMeshProUGUI[] _charactersText;

        public void Init(int[] characterPrices)
        {
            for (var i = 0; i < characterPrices.Length; i++)
            {
                SetCharacterPrice(characterPrices[i], i);
            }
        }

        public void SetCharacterPrice(int price, int index)
        {
            _charactersText[index].text = $"Level {index+1}:\n{price}$";
        }

        public IObservable<Unit> CharacterButtonObservableClickedEvent(int index)
        {
            return _charactersBuyButton[index].onClick.AsObservable();
        }
    }
}