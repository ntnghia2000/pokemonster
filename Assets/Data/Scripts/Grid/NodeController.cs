using UnityEngine;

public class NodeController : MonoBehaviour
{
    [Header("Node Ctrl")]
    [SerializeField] 
    protected SpriteRenderer spriteRender;

    [SerializeField] 
    protected Sprite sprite;

    protected Node nodeData;

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
