using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GameManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions {MaxPlayers=3}, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("On joined room");
        PhotonNetwork.Instantiate("Player", new Vector2(Random.Range(-4, 4), Random.Range(-4, 4)), Quaternion.identity);
    }
}
