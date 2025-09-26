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

        float difficulty = data.Health + data.Damage + data.Speed; 
        ProgressBar(difficulty / 100, "Difficulty");
        
        base.OnInspectorGUI();
        
        EditorGUILayout.LabelField("-----------");

        if (data.Name == string.Empty)
        {
            EditorGUILayout.HelpBox("Caution: No name specified. Please name the monster!", MessageType.Warning);
        }

        if (data.MonsterType == MonsterType.None)
        {
            EditorGUILayout.HelpBox("No MonsterType selected", MessageType.Warning);
        }
        
        if (data.Health < 0)
        {
            EditorGUILayout.HelpBox("Should not have negative Health", MessageType.Warning);
        }
    }

    private void ProgressBar(float value, string label)
    {
        Rect rect = GUILayoutUtility.GetRect(18, 18, "TextField");
        EditorGUI.ProgressBar(rect, value, label);
        EditorGUILayout.Space(10);
    }
}
