using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MarcTest.Player
{
    public class PlayerView : MonoBehaviour
    {

        [SerializeField] private TextMeshProUGUI _coinstText;

        public void SetCoinsText(int value)
        {
            _coinstText.text = value.ToString() + " $";
        }
    }
}

