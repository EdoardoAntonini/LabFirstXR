using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Variabili private per gestire il punteggio corrente e il miglior punteggio
    private int _score;
    private int _bestScore; // Variabile per memorizzare il miglior punteggio

    #region Properties

    // Proprietà per accedere e impostare il punteggio corrente
    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            // Aggiorna il miglior punteggio se il punteggio attuale è maggiore
            if (_score > _bestScore)
            {
                _bestScore = _score;
                // Salva il miglior punteggio usando PlayerPrefs
                PlayerPrefs.SetInt("BestScore", _bestScore);
            }
        }
    }

    // Proprietà per accedere al miglior punteggio
    public int BestScore
    {
        get { return _bestScore; }
    }

    #endregion

    #region Unity Methods

    // Metodo chiamato all'inizio del ciclo di vita dell'oggetto
    void Start()
    {
        // Carica il miglior punteggio salvato da PlayerPrefs (valore di default: 0)
        _bestScore = PlayerPrefs.GetInt("BestScore", 0);
    }

    #endregion
}

//commentato con ChatGPT
