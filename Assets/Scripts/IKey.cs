using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public interface IKey
{
    // Proprietà per identificare il tipo di chiave (ad esempio, "key", "magneticCard").
    string KeyType { get; }

    // Metodo per attivare la chiave.
    void ActivateKey(GameObject keyObject, GameObject target);

    // Metodo opzionale per distruggere o disabilitare la chiave.
    void DestroyKey(GameObject keyObject);
}

