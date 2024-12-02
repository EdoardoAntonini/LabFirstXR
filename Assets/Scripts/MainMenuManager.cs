using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    // Riferimento al pulsante Gioca
    public Button playButton;

    #region Unity Methods

    // Metodo chiamato all'inizio del ciclo di vita dell'oggetto
    void Start()
    {
        // Controlla se il pulsante è assegnato e aggiunge un listener per il click
        if (playButton != null)
        {
            playButton.onClick.AddListener(OnPlayButtonClicked);
        }
        else
        {
            // Logga un errore se il pulsante non è stato assegnato nell'Inspector
            Debug.LogError("Pulsante Gioca non assegnato!");
        }
    }

    #endregion

    #region Custom Methods

    // Metodo chiamato quando il pulsante Gioca viene cliccato
    void OnPlayButtonClicked()
    {
        // Carica la scena "BasicScene"
        SceneManager.LoadScene("BasicScene");
    }

    #endregion
}

//commentato con ChatGPT
