using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scensemove : MonoBehaviour
{
    // Start is called before the first frame update
    

    public void OnStartGame(string scenneName)
    {
        Application.LoadLevel(scenneName);
    }
}
