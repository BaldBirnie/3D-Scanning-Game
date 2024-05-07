using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    
    private int Cans = 0;

    public TextMeshProUGUI canText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Can")
        {
            Cans++;
            canText.text = "Cans: " + Cans.ToString() + "/8";
            Debug.Log(Cans);
            Destroy(other.gameObject);
        }
    }













}
