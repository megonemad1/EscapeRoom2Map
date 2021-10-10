using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;
using UnityEngine.Networking;
using System.Text.RegularExpressions;

public class getURlParam : MonoBehaviour
{
    [SerializeField]
    UnityEvent<string> onUrl;
    // Start is called before the first frame update
    void Start()
    {
        Regex param = new Regex(@"(?:\?|&|;)([^=]+)=([^&|;#]+)");
        foreach (Match p in param.Matches(Application.absoluteURL))
            onUrl.Invoke(p.ToString());
    }

}
