using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class getURlParam : MonoBehaviour
{
    [SerializeField]
    UnityEvent<string> onUrl;
    // Start is called before the first frame update
    void Start()
    {
       onUrl.Invoke( Application.absoluteURL);
    }

}
