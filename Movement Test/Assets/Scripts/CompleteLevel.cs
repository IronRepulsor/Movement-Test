using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    [SerializeField]
    string strSceneName;
    [SerializeField]
    string WinFloor;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == WinFloor)
        {
            SceneManager.LoadScene(strSceneName);
        }
            
    }
}
