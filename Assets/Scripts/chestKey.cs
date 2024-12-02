using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestKey : MonoBehaviour
{
    // Riferimento all'oggetto che deve essere spostato
    public GameObject gm;

    // Variabili per memorizzare la posizione iniziale e finale
    private float initPositionX;
    private float initPositionY;
    private float initPositionZ;
    private float finalPositionX;
    private float finalPositionY;
    private float finalPositionZ;

    // Velocità di movimento
    public float speed = 2.0f;

    #region Unity Methods

    // Metodo chiamato all'inizio del ciclo di vita dell'oggetto
    void Start()
    {
        // Memorizza la posizione iniziale dell'oggetto
        initPositionX = transform.localPosition.x;
        initPositionY = transform.localPosition.y;
        initPositionY = transform.localPosition.z;

        // Definisce la posizione finale a cui spostare l'oggetto gm
        finalPositionX = -51.42f;
        finalPositionY = -1.16f;
        finalPositionZ = 12.01f;
    }

    // Metodo chiamato quando un altro collider entra nel trigger di questo oggetto
    private void OnTriggerEnter(Collider other)
    {
        // Controlla se l'oggetto che entra nel trigger ha il tag "key"
        if (other.gameObject.tag.Equals("key"))
        {
            // Cambia il colore del materiale dell'oggetto corrente in rosso
            GetComponent<MeshRenderer>().material.color = Color.red;

            // Sposta l'oggetto gm alla posizione finale specificata
            gm.transform.localPosition = new Vector3(finalPositionX, finalPositionY, finalPositionZ);

            // Distrugge l'oggetto con il tag "key" che ha attivato il trigger
            Destroy(other.gameObject);
        }
    }

    #endregion
}

//commentato con ChatGPT
