using UnityEngine;

public abstract class GridAbstract : BaseMonoBehaviour
{
    [Header("Grid Abstract")]
    
    [SerializeField]
    private GridManagerController gridController;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.SetGridManagerController();
    }

    private void SetGridManagerController()
    {
        if (this.gridController != null) return;
        this.gridController = transform.GetComponent<GridManagerController>();
    }

    public GridManagerController GetGridManagerController()
    {
        return this.gridController;
    }
}
