using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    //velocidade do player, rotação e a curva//
   // Transform goal;
  //  float speed = 5.0f;
  //  float accuracy = 2f;
   // float rotSpeed = 3f;

    //declaração de gameObjects//
    public GameObject wpManager;
    GameObject[] wp;
    UnityEngine.AI.NavMeshAgent agent;

   // GameObject currentNode;
    //int currentWP = 0;
   // Graph g;


    void Start()
    {
        //pegar componente WpManager//
        wp = wpManager.GetComponent<WpManager>().waypoints;
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        //g = wpManager.GetComponent<WpManager>().graph;
       // currentNode = wp[0]; //inicia no 0//
    }



    //metodo para ir ao heliport//
    public void GotoHeliport()
    {
        agent.SetDestination(wp[1].transform.position);
        //g.AStar(currentNode, wp[1]);
        //currentWP = 0;
    }

    //metodo para ir para ruinas//
    public void GotoRuinas()
    {
        agent.SetDestination(wp[5].transform.position);
        //g.AStar(currentNode, wp[6]);
       // currentWP = 0;
    }

    //metodo para ir para tanques//
    public void Gototanques()
    {
        agent.SetDestination(wp[9].transform.position);
        //g.AStar(currentNode, wp[7]);
       // currentWP = 0;
    }



    private void LateUpdate()
    {
        /* código utilizado na tarefa anterior
        //retorno para o 0//
        if (g.getPathLength() == 0 || currentWP == g.getPathLength())
            return;


        currentNode = g.getPathPoint(currentWP); //pegando o ponto do path//


        if (Vector3.Distance(g.getPathPoint(currentWP).transform.position, transform.position) < accuracy) // distancia para as posições//
        { currentWP++; }

        if (currentWP < g.getPathLength()) 
        {
            goal = g.getPathPoint(currentWP).transform;
            Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z); //olhar e direção para o player seguir//
            Vector3 direction = lookAtGoal - this.transform.position; // direção do lookgoal//
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed); // velocidade da rotação//
            this.transform.Translate(0, 0, speed * Time.deltaTime); // velocidade x o deltatime//
        }*/
    }
}
