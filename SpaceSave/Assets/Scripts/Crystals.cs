using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystals : MonoBehaviour
{
    public Text crystalText;
    private int totalCrystals;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCrystalText();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hit) {
        if(hit.CompareTag("Crystal")){
            totalCrystals++;
            UpdateCrystalText();
            Destroy(hit.gameObject);
        }
    }

    private void UpdateCrystalText(){
        string crystalMessage = "Crystals = " + totalCrystals;
        crystalText.text = crystalMessage;
    }
}
