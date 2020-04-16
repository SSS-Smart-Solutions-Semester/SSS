using UnityEngine;

public class LineRendererDistance : MonoBehaviour
{

    [SerializeField] protected LineRenderer lineRend;

    [SerializeField] protected GameObject position1;
    [SerializeField] protected GameObject position2;

    protected float Round;
        
    protected LineRendererDistance(GameObject position1, GameObject position2)
    {
        this.position1 = position1;
        this.position2 = position2;
    }

    private void Start()
    {
        lineRend = GetComponent<LineRenderer>();
        lineRend.positionCount = 2;
            
        lineRend.startColor = Color.green;
        lineRend.endColor = Color.green;
    }

    private void Update()
    {
        lineRend.SetPosition(0, position1.transform.position);
        lineRend.SetPosition(1, position2.transform.position);
    }
}