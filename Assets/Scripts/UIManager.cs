using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

namespace UGUI1
{ 
public class UIManager : MonoBehaviourPun
{
    public InputField usernameInp;
    public Button loginBtn;

    // Start is called before the first frame update
    void Awake()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
