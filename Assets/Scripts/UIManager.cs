using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{

    public GameObject popupPanel;
    public TMP_Text contentText;

    public PriceSelection m_PriceSelection;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopUp()
    {
        contentText.text = "You have won " + m_PriceSelection.GetPrice() + " coins";
        popupPanel.SetActive(true);
    }
}
