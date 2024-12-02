using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistruggiOggetto : MonoBehaviour
{
    // Riferimento al GameManager
    public GameObject gameManager;

    // Riferimento al componente TextMeshProUGUI per mostrare il punteggio e il messaggio
    public TextMeshProUGUI textComponentTMP;

    #region Unity Methods

    // Metodo chiamato all'inizio del ciclo di vita dell'oggetto
    void Start()
    {
        // Trova il GameManager nella scena
        gameManager = GameObject.Find("GameManager");
    }

    #endregion

    #region Custom Methods

    // Metodo per distruggere l'oggetto corrente e aggiornare il punteggio
    public void Distruggi()
    {
        // Ottiene il componente ScoreManager dal GameManager
        var scoreManager = gameManager.GetComponent<ScoreManager>();

        // Incrementa il punteggio
        scoreManager.Score++;

        // Aggiorna il testo per visualizzare messaggi e punteggi
        textComponentTMP.text = "Obiettivo: trovare le chiavi per aprire, porte e bauli.\r\n\r\n\r\n" +
                                "Attenzione che non tutte le chiavi sono normali.\r\n\r\n\r\n" +
                                "Per aumentare il punteggio si devono trovare delle stelle e un pollo gigante.\r\n\r\n" +
                                "Punteggio attuale: " + scoreManager.Score + "\r\n" +
                                "Punteggio Migliore: " + scoreManager.BestScore;

        // Distrugge l'oggetto corrente
        Destroy(gameObject);
    }

    #endregion
}

//commentato con ChatGPT
