using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TriggerZone>().onEnterEvent.AddListener(Insidetrash);
    }
    public void Insidetrash(GameObject go)
    {
        go.SetActive(false);
    }
}
