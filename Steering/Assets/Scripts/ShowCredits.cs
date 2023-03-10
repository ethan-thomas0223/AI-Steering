using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCredits : MonoBehaviour

{   
    public void OnTriggerEnter(Collider collider) {

        
        if (collider.gameObject.CompareTag("MainCamera")) {
            GameManager.Instance.Credits();
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
