using UnityEngine;
using TMPro;

namespace MarcTest.Player
{
    public class PlayerView : MonoBehaviour
    {

        [SerializeField] private TextMeshProUGUI _coinsText;
        [SerializeField] private TextMeshProUGUI _powerText;

        public void SetCoinsText(int value)
        {
            _coinsText.text = value.ToString() + " $";
        }

        public void SetPowerText(int value)
        {
            _powerText.text = "Power: " + value.ToString();
        }
    }
}

