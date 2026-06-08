using System;
using UnityEngine;

[Serializable]
public class Node
{
    public int x = 0;
    public int y = 0;
    public int posX = 0;
    public int posY = 0;
    public bool occupied = false;
    public Node up;
    public Node down;
    public Node left;
    public Node right;
}