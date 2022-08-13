using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceSelection : MonoBehaviour
{
    private string currentPrice;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentPrice = collision.gameObject.name;
        Debug.Log(currentPrice);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("\n");
    }

    public string GetPrice()
    {
        return currentPrice;
    }

}
