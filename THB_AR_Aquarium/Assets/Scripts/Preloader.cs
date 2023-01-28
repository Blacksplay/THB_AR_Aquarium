using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class Preloader : MonoBehaviour
{

    public GameObject[] Objekte;

    //Möglichkeit das Programm per Argument auf Server zu starten
    /*private void Start()
    {
        string[] args = System.Environment.GetCommandLineArgs();
        for (int i = 0; 1 < args.Length; i++)
        {
            if (args[i] == "-launch-as-client")
                OnClientClick();
            else if (args[i] == "-launch-as-server")
                OnServerClick();
        }

    }*/

    public void OnServerClick()
    {
        NetworkManager.Singleton.StartServer();
        SceneManager.LoadScene("Main");
    }

    public void OnClientClick()
    {
        NetworkManager.Singleton.StartClient();
        SceneManager.LoadScene("Main");
    }

    public void OnHostClick()
    {
        NetworkManager.Singleton.StartHost();
        SceneManager.LoadScene("Main");
    }
}

