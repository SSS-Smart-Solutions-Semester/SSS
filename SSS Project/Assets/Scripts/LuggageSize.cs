using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class LuggageSize : LineRendererDistance
{
    [SerializeField] private Text text;
    

    private void Update()
    {
        Round = Mathf.Round((position1.transform.position - position2.transform.position).magnitude * 10f) / 10f;
        
        text.text = Round.ToString(CultureInfo.InvariantCulture) + " CM";
    }

    protected LuggageSize(GameObject position1, GameObject position2) : base(position1, position2){}
}
