using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TouchScreen : MonoBehaviour
{
    public UnityEvent OnTouch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetButtonDown("Fire1"))
         {

         }*/
        if (Input.GetMouseButtonDown(0))
        {
            OnTouch.Invoke();
        }
    }
    

     }
