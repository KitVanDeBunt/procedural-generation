using UnityEngine;

namespace Util
{
    public class Follow : MonoBehaviour
    {
        [SerializeField]
        private bool followX;
        [SerializeField]
        private bool followY;
        [SerializeField]
        private bool followZ;

        [SerializeField]
        private Transform followTransform;
        private Transform selfTransform;

        private Vector3 newPosition = new Vector3();

        public Transform Target
        {
            set
            {
                followTransform = value;
            }
        }

        virtual public void Start()
        {
            selfTransform = transform;
        }

        virtual public void Update()
        {
            if (followTransform != null)
            {
                newPosition.x = (followX) ? followTransform.position.x : selfTransform.position.x;
                newPosition.y = (followY) ? followTransform.position.y : selfTransform.position.y;
                newPosition.z = (followZ) ? followTransform.position.z : selfTransform.position.z;
                selfTransform.position = newPosition;
            }
        }
    }
}