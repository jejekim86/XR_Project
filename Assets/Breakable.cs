using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakablePieces;
    public float timeTobreak = 2;
    private float timer = 0;

    private void Start()
    {
        foreach (var item in breakablePieces)
            item.SetActive(false);
    }

    public void Break()
    {
        timer += Time.deltaTime;

        if (timer > timeTobreak)
        {
            foreach (var item in breakablePieces)
            {
                item.SetActive(true);
                item.transform.parent = null;
            }

            gameObject.SetActive(false);
        }
    }
}
