using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWheel : MonoBehaviour
{
    private bool spin = false;
    private float spinTime = 5f;
    private float waitTillTime = -0.5f;
    private float clock = 0f;
    private float rotZ = 0f;
    private float spinRate;
    
    public UIManager m_UIManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spin)
        {
            if(clock >= 0)
            {
                clock -= Time.deltaTime;
                if (clock > 0)
                    spinRate = clock;
                else
                    spinRate = 0;
                /*var rot = transform.rotation;
                rot += Quaternion.Euler(0, 0, 5);*/
                transform.Rotate(0f, 0f, transform.rotation.z + (3f * spinRate), Space.Self);
                //rotZ += 5f;
                //Debug.Log(transform.rotation.z);
            }
            else
            {
                if (clock >= waitTillTime)
                    clock -= Time.deltaTime;
                else
                {
                    spin = false;
                    SpinComplete();
                }
            }
        }
    }

    private void SpinComplete()
    {
        m_UIManager.PopUp();
    }
    public void StartSpin()
    {
        spin = true;
        spinTime = Random.Range(2f, 3f);
        clock = spinTime;
    }
    
}
