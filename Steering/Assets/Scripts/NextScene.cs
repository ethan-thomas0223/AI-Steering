using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextScene : MonoBehaviour
{
    public string scene;

    

    
    public void OnTriggerEnter(Collider collider) {
        print("Entered..");
        
        if (collider.gameObject.CompareTag("MainCamera")) {
            GameManager.Instance.ChangeScene(scene);
        }
        
        
    }
    
    /*
    public void OnTriggerExit(Collider collider) {
        if (GetComponent<Collider>().gameObject.CompareTag("Player")) {
        }
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
