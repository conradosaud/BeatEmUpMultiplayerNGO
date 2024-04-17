using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkHUD : NetworkBehaviour
{

    Button btnHost, btnServer, btnClient;
    TextMeshProUGUI textoPlayers;

    // Start is called before the first frame update
    void Start()
    {
        btnHost = transform.Find("Host").GetComponent< Button>();
        btnServer = transform.Find("Server").GetComponent< Button>();
        btnClient = transform.Find("Client").GetComponent< Button>();
        textoPlayers = transform.Find("PlayersOn").GetComponent<TextMeshProUGUI>();

        btnHost.onClick.AddListener(() => NetworkManager.Singleton.StartHost());
        btnServer.onClick.AddListener(() => NetworkManager.Singleton.StartServer());
        btnClient.onClick.AddListener(() => NetworkManager.Singleton.StartClient());

    }

    // Update is called once per frame
    void Update()
    {
        textoPlayers.text = "Players: " + PlayerManager.jogadoresConectados.Value.ToString();
    }
}
