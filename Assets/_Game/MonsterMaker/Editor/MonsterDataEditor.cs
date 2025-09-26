using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MonsterData))]
public class MonsterDataEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MonsterData data = (MonsterData)target;
        EditorGUILayout.LabelField(data.Name.ToUpper(), EditorStyles.boldLabel);
        EditorGUILayout.Space(10);
        
        base.OnInspectorGUI();
        
        EditorGUILayout.LabelField("-----------");
    }
}
