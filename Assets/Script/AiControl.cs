using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiControl : MonoBehaviour
{
    public NavMeshAgent agent;
        // Use this for initialization
      void  Start ()
      {
        //pegando componente NavMesHAgent do agente
        agent= this.GetComponent<NavMeshAgent>();
      }
}
