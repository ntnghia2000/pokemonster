using System.Collections.Generic;
using UnityEngine;

public class NodeController : MonoBehaviour
{
    [Header("Node Ctrl")]
    [SerializeField] 
    protected SpriteRenderer spriteRender;

    [SerializeField] 
    protected Sprite sprite;

    public Node nodeData;
    public List<NodeController> neighbors = new List<NodeController>();

    public virtual void SetSprite(Sprite sprite)
    {
        if (this.sprite != null)
        {
            this.sprite = sprite;
        }
        if (this.spriteRender != null)
        {
            this.spriteRender.sprite = sprite;
        }
    }

    public virtual void SetNodeData(Node data)
    {
        this.nodeData = data;
    }
}
