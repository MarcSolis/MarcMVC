using MarcTest.Shop;
using UnityEngine;
using System;

namespace MarcTest.Server
{
    [CreateAssetMenu(fileName = "ServerData", menuName = "ScriptableObjects/ServerData")]
    public class ServerDataScriptableObject : ScriptableObject
    {
        [SerializeField] private ServerCharacter[] _serverCharacters;
        [SerializeField] private int _playerCoins;
        
        public int PlayerCoins { get => _playerCoins; }
        
        public Character[] GetCharactersInfoFromServer()
        {
            Character[] convertedCharacters = new Character[_serverCharacters.Length];
            for (int i = 0; i < convertedCharacters.Length; i++)
            {
                convertedCharacters[i] = new Character(_serverCharacters[i].CharacterPrice, _serverCharacters[i].CharacterPower);
            }
            return convertedCharacters;
        }
    }
    
    [Serializable] struct ServerCharacter
    {
        public int CharacterPrice;
        public int CharacterPower;
    }
}