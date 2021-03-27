using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public GameObject Endscrn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Endscrn.gameObject.SetActive(true);
        }
    }

    private void Awake()
    {
        Endscrn.gameObject.SetActive(false);
    }
}
