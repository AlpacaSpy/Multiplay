using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviourPunCallbacks
{
    public GameObject userNameScreen;
    public GameObject connectScreen;

    public Button userNameBtn;
    public InputField userNameInput;

    public Button createRoomBtn;
    public InputField createRoomInput;

    public Button joinRoomBtn;
    public InputField joinRoomInput;

    public InputField usernameInp;
    public Button loginBtn;

    // Start is called before the first frame update
    void Awake()
    {
        PhotonNetwork.ConnectUsingSettings();

        PhotonNetwork.ConnectUsingSettings();
        userNameBtn.onClick.AddListener((OnClickSubmitName);
        createRoomBtn.onClick.AddListener(()=>OnClickJoinRoom(joinRoomInput.text));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

