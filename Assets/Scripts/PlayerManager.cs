using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

    // DOC SCRIPTING API:
    // https://docs.unity3d.com/Packages/com.unity.netcode.gameobjects@1.7/api/Unity.Netcode.html

public class PlayerManager : MonoBehaviour
{

    public static NetworkVariable<int> jogadoresConectados = new NetworkVariable<int>( 0 );

    // Start is called before the first frame update
    void Start()
    {
        NetworkManager.Singleton.OnClientConnectedCallback += (id) =>
        {
            jogadoresConectados.Value++;
        };
        
        NetworkManager.Singleton.OnClientDisconnectCallback += (id) =>
        {
            jogadoresConectados.Value--;
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
