using UnityEngine;
using UnityEditor;

namespace Generator
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(BaseGenarator), true)]
    public class TerainGenEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            if (GUILayout.Button("Generate"))
            {
                Object[] terains = targets;
                for (int i = 0; i < terains.Length; i++)
                {
                    BaseGenarator terain = (BaseGenarator)terains[i];
                    terain.Generate();
                }
            }
            DrawDefaultInspector();
        }
    }
}