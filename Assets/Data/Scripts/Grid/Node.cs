using System;
using UnityEngine;

[Serializable]
public class Node
{
    public int col = 0;
    public int row = 0;
    public float posX = 0;
    public float posY = 0;
    public int nodeId = 0;
    public bool occupied = false;
    public bool blockPlaced = false;
    public Node up;
    public Node down;
    public Node left;
    public Node right;
    public NodeController nodeController;
}