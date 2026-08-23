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
    private int piecesAmount = 11;

    [SerializeField]
    private List<Node> nodes;

    [SerializeField]
    private List<int> nodeIds;

    [SerializeField] 
    protected PoketNode nodeProfile;

    public List<NodeController> nodeControllers;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.InitGridSystem();
    }

    protected override void Start()
    {
        this.SpawnNodes();
    }

    private void InitGridSystem()
    {
        if (this.nodes.Count > 0) return;

        int currentId = 0;
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
                    nodeId = currentId,
                };
                this.nodes.Add(node);
                this.nodeIds.Add(currentId);
                currentId++;
            }
        }
    }

    protected virtual void SpawnNodes()
    {
        Vector3 pos = Vector3.zero;

        foreach(Sprite sprite in this.nodeProfile.sprites)
        {
            for (int i = 0; i < this.piecesAmount; i++)
            {
                Node node = this.GetRandomNode();
                pos.x = node.posX;
                pos.y = node.posY;
                Transform poketBlock = this.GetGridManagerController().GetBlockSpawner().Spawn(BlockSpawner.BLOCK, pos, Quaternion.identity);
                NodeController nodeController = poketBlock.GetComponent<NodeController>();
                nodeController.SetSprite(sprite);
                nodeController.SetNodeData(node);
                poketBlock.gameObject.SetActive(true);
                this.nodeControllers.Add(nodeController);
                node.nodeController = nodeController;
                this.NodeOccupied(node);
            }
        }
    }

    public virtual void NodeOccupied(Node node)
    {
        node.occupied = true;
        node.blockPlaced = true;
    }

    protected virtual Node GetRandomNode()
    {
        Node node;
        int randomId;

        randomId = Random.Range(0, this.nodeIds.Count);
        node = this.nodes[this.nodeIds[randomId]];
        this.nodeIds.RemoveAt(randomId);
        
        if (node.col == 0 || node.row == 0 || node.col == this.width - 1 || node.row == this.height - 1) return this.GetRandomNode();
        if (this.nodeIds.Count <= 0 && node == null) return null;
        return node;
    }
}
