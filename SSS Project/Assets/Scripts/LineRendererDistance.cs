using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class LineRendererDistance : MonoBehaviour
    {

        [SerializeField] protected LineRenderer _lineRend;

        [SerializeField] protected GameObject _position1;
        [SerializeField] protected GameObject _position2;
        
        protected LineRendererDistance(GameObject position1, GameObject position2)
        {
            _position1 = position1;
            _position2 = position2;
        }

        private void Start()
        {
            _lineRend = GetComponent<LineRenderer>();
            _lineRend.positionCount = 2;
        }

        private void Update()
        {
            _lineRend.SetPosition(0,_position1.transform.position);
            _lineRend.SetPosition(1,_position2.transform.position);
        }
    }
}
