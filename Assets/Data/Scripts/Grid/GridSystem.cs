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
    private float offsetY = 0.2f;

    [SerializeField]
    private List<Node> nodes;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.InitGridSystem();
    }

    protected override void Start()
    {
        this.SpawnBlock();
    }

    private void InitGridSystem()
    {
        if (this.nodes.Count > 0) return;

        for (int col = 0; col < this.width; col++)
        {
            for (int row = 0; row < this.height; row++)
            {
                Node node = new Node
                {
                    col = col,
                    row = row,
                    posX = col - (this.offsetX * col),
                    posY = row - (this.offsetY * row),
                };
                this.nodes.Add(node);
            }
        }
    }

    protected virtual void SpawnBlock()
    {
        Vector3 pos = Vector3.zero;

        foreach(Node node in this.nodes)
        {
            if (node.col == 0) continue;
            if (node.row == 0) continue;
            if (node.col == this.width - 1) continue;
            if (node.row == this.height - 1) continue;

            pos.x = node.posX;
            pos.y = node.posY;
            Transform poketBlock = this.GetGridManagerController().GetBlockSpawner().Spawn(BlockSpawner.BLOCK, pos, Quaternion.identity);
            poketBlock.gameObject.SetActive(true);
        }
    }
}
