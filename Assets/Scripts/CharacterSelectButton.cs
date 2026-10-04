using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectButton : MonoBehaviour
{
    [SerializeField] private CharacterList CharacterForThisButton;

    public void SelectCharacter()
    {
        PlayerCharacterMAnager.Instance.SelectedCharater = CharacterForThisButton;
    }
}
