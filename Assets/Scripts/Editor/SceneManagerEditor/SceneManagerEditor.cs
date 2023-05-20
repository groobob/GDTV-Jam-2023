using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ViewManager))]
public class SceneManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox("Only Change This Field To Adjust Scene Load On Game Initialisation", MessageType.Info);
        base.OnInspectorGUI();
    }
}
