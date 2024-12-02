using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    #region Unity Methods

    // Metodo chiamato quando un altro collider entra nel trigger di questo oggetto.
    // Parametri:
    // - other: Il collider dell'oggetto che entra nella zona del trigger.
    private void OnTriggerEnter(Collider other)
    {
        // Controlla se l'oggetto che entra nel trigger ha il tag "Player"
        if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Player detected, loading scene 'Menu'");

            // Carica la scena "Menu"
            SceneManager.LoadScene("Menu");
        }
    }

    #endregion
}

//commentato con ChatGPT
