using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMagneticDoor : MonoBehaviour, IKey
{
    // Riferimento al GameObject della porta
    public GameObject gm;

    // Variabili per memorizzare la posizione iniziale e finale della porta
    private float initPositionX;
    private float initPositionY;
    private float initPositionZ;
    private float finalPositionX;

    // Proprietà per specificare il tipo di chiave
    public string KeyType => "magneticCard"; // Specifica il tipo di chiave

    #region Unity Methods

    // Metodo chiamato all'inizio del ciclo di vita dell'oggetto
    void Start()
    {
        // Memorizza la posizione iniziale dell'oggetto
        initPositionX = transform.localPosition.x;
        initPositionY = transform.localPosition.y;
        initPositionZ = transform.localPosition.z;

        // Definisce la posizione finale della porta
        finalPositionX = -0.8f;
    }

    #endregion

    #region Custom Methods

    // Metodo chiamato quando un altro collider entra nel trigger di questo oggetto
    private void OnTriggerEnter(Collider other)
    {
        // Controlla se l'oggetto che entra nel trigger ha il tag corrispondente al tipo di chiave
        if (other.gameObject.tag.Equals(KeyType))
        {
            // Attiva la chiave e gestisce l'apertura della porta
            ActivateKey(other.gameObject, gm);
        }
    }

    // Metodo per attivare la chiave e aprire la porta
    public void ActivateKey(GameObject keyObject, GameObject target)
    {
        // Cambia il colore del materiale dell'oggetto corrente in verde
        GetComponent<MeshRenderer>().material.color = Color.green;

        // Sposta la porta alla posizione finale
        target.transform.localPosition = new Vector3(finalPositionX, initPositionY, initPositionZ);

        // Distrugge la porta se necessario
        Destroy(gm);

        // Distrugge l'oggetto chiave
        DestroyKey(keyObject);
    }

    // Metodo per distruggere l'oggetto chiave
    public void DestroyKey(GameObject keyObject)
    {
        // Distrugge l'oggetto passato come parametro
        Destroy(keyObject);
    }

    #endregion
}

//commentato con ChatGPT
