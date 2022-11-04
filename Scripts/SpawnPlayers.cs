using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Random = System.Random;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    private GameObject thisPlayer;

    public float minX, maxX, minY, maxY;

    private void Start()
    {
        thisPlayer = PhotonNetwork.Instantiate(playerPrefab.name, gameObject.transform.position, gameObject.transform.rotation);
    }

    [PunRPC]
    void NameNSkinForPlayer(string name, int skin)
    {
        
    }
}
