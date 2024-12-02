using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRadio : MonoBehaviour
{
    // Riferimento al componente AudioSource per riprodurre l'audio
    private AudioSource audioSource;

    #region Unity Methods

    // Metodo chiamato all'inizio del ciclo di vita dell'oggetto
    void Start()
    {
        // Ottiene il componente AudioSource associato a questo GameObject
        audioSource = GetComponent<AudioSource>();
    }

    #endregion

    #region Custom Methods

    // Metodo per avviare la riproduzione dell'audio
    public void Radio()
    {
        // Avvia la riproduzione del file audio associato al componente AudioSource
        audioSource.Play();
    }

    #endregion
}

//commentato con ChatGPT
