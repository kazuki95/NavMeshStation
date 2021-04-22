using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgenteManager : MonoBehaviour
{ 
    GameObject[] agents;// Use thisfor initializationvoid
   void Start () 
   {
        agents= GameObject.FindGameObjectsWithTag("AI");
   }
    // Update is called once per framevoid
   void Update () 
   {
        if(Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 200))
                {
                    foreach(GameObject a in agents)
                    a.GetComponent<AiControl>().agent.SetDestination(hit.point);
            
                }
        }
    }
}
