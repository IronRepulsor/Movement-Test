using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
    
{
    [SerializeField]
    KeyCode MovePositive;
    [SerializeField]
    KeyCode MoveNegative;
    [SerializeField]
    KeyCode MoveVertical;
    [SerializeField]
    KeyCode Restart;
    [SerializeField]
    Vector3 MoveSpeed;
    public int JumpTime = 0;
    private void OnCollisionEnter(Collision collision)
    {
        JumpTime = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(MovePositive))
        {
            GetComponent<Rigidbody>().velocity += MoveSpeed;
        }
        if(Input.GetKey(MoveNegative))
        {
            GetComponent<Rigidbody>().velocity -= MoveSpeed;
        }
        if(JumpTime <= 2)
        {
            if(Input.GetKeyDown(MoveVertical))
            {
                GetComponent<Rigidbody>().velocity += MoveSpeed;
                JumpTime++;
            }
        }
        if(Input.GetKey(Restart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
        
 }
