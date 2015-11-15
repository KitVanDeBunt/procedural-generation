using UnityEngine;

namespace Generator
{
    public class SphereQuadTop : SphereQuad
    {
        [SerializeField]
        private Material materialTop;

        [SerializeField]
        [Range(-90, 90)]
        private int xDirectionTop, yDirectionTop, zDirectionTop;
        
        
        [SerializeField]
        bool draw = false;

        [SerializeField]
        private Transform targetTop;
        
        protected override Vector3 Dir()
        {
            return new Vector3(
            Mathf.Sin(xDirectionTop * Mathf.Deg2Rad),
            Mathf.Sin(yDirectionTop * Mathf.Deg2Rad),
            Mathf.Sin(zDirectionTop * Mathf.Deg2Rad)).normalized;
        }

        void OnDrawGizmos()
        {
            /*if (draw)
            {
                Gizmos.color = Color.green;

                Vector3 dir = Dir();

                Gizmos.DrawLine(transform.position, transform.position + (radius * dir));

                Gizmos.color = Color.yellow;
                Gizmos.DrawSphere(transform.position, 1);
                Gizmos.color = Color.red;
                Gizmos.DrawSphere(transform.position + (radius * dir), 1);
            }*/
            //Debug.Log(dir);
        }

        protected override void AddSphereQuadToGameObjects(GameObject[] subQuads)
        {
            float sublevelDevider = (quadSpace.size.x / 2f);

            SphereQuad newQuad = subQuads[0].AddComponent<SphereQuad>();
            newQuad.SubQuadInit(xDirectionTop, yDirectionTop, zDirectionTop, sublevels, level, new Rect(quadSpace.position, (quadSpace.size / 2)), materialTop, targetTop);

            newQuad = subQuads[1].AddComponent<SphereQuad>();
            Rect newQuadRect = new Rect(quadSpace.position, (quadSpace.size / 2));
            newQuadRect.x += sublevelDevider;
            newQuad.SubQuadInit(xDirectionTop, yDirectionTop, zDirectionTop, sublevels, level, newQuadRect, materialTop, targetTop);

            newQuad = subQuads[2].AddComponent<SphereQuad>();
            newQuadRect.x -= sublevelDevider;
            newQuadRect.y += sublevelDevider;
            newQuad.SubQuadInit(xDirectionTop, yDirectionTop, zDirectionTop, sublevels, level, newQuadRect, materialTop, targetTop);

            newQuad = subQuads[3].AddComponent<SphereQuad>();
            newQuadRect.x += sublevelDevider;
            newQuad.SubQuadInit(xDirectionTop, yDirectionTop, zDirectionTop, sublevels, level, newQuadRect, materialTop, targetTop);
        }
    }
}
