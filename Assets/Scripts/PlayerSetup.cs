using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private ErishikgalStats erishikgalStats;

    public ErishikgalStats CurrentStats { get; private set; }

    private void Start()
    {
        CharacterList selectedCharacter = CharacterList.Erishikgal;

        if (PlayerCharacterMAnager.Instance != null)
        {
            selectedCharacter = PlayerCharacterMAnager.Instance.SelectedCharater;
        }
        else
        {
            Debug.LogWarning(
                "No PlayerCharacterMAnager found. Defaulting to Erishikgal.");
        }

        CreatePlayer(selectedCharacter);
    }

    private void CreatePlayer(CharacterList character)
    {
        GameObject player = Instantiate(
            playerPrefab,
            Vector3.zero,
            Quaternion.identity);

        if (character == CharacterList.Erishikgal)
        {
            player.name = "Erishikgal";

            if (erishikgalStats == null)
            {
                Debug.LogError(
                    "The ErishikgalStats asset has not been assigned to PlayerSetup.");
                return;
            }

            CurrentStats = Instantiate(erishikgalStats);
            CurrentStats.CurrentHealth = 0;

            Debug.Log(
                $"Created {CurrentStats.ErishikgalName} with " +
                $"{CurrentStats.CurrentHealth}/{CurrentStats.MaxHealth} health.");
        }
    }
}
