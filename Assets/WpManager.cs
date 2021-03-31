using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Link
{
    // criando game objects para direcionar dentro da unity//
    public enum direction { UNI, BI }
    public GameObject node1;
    public GameObject node2;
    public direction dir;

}
public class WpManager : MonoBehaviour
{
    // declaração de gameObjects da classe WpManager//
    public GameObject[] waypoints;
    public Link[] links;
    public Graph graph = new Graph();

    void Start()
    {
        // startando os valores para o tanque seguir//
        if (waypoints.Length > 0)
        {
            foreach (GameObject wp in waypoints)
            {
                graph.AddNode(wp);
            }
            foreach (Link i in links)
            {
                graph.AddEdge(i.node1, i.node2);
                if (i.dir == Link.direction.BI)
                {
                    graph.AddEdge(i.node1, i.node2);
                }
            }

        }

    }

    
    void Update()
    {
        graph.debugDraw(); // ver a linha na cena que busca do graph//
    }
}