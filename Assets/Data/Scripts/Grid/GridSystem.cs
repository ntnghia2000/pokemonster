using System.Collections.Generic;
using UnityEngine;

public class GridSystem : GridAbstract
{
    [Header("Grid System")]
    [SerializeField]
    private int width = 18;

    [SerializeField]
    private int height = 11;

    [SerializeField]
    private float offsetX = 0.2f;

    [SerializeField]
    private List<Node> nodes;
}
