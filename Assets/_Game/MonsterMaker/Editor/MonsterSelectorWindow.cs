using System;
using UnityEditor;
using UnityEngine;

public class MonsterSelectorWindow : EditorWindow
{
    private MonsterType _selectedMonsterType = MonsterType.None;
    
    [MenuItem("Window/Monster Selector")]
    public static void ShowWindow()
    {
        GetWindow<MonsterSelectorWindow>();
    }
    
    private void OnGUI()
    {
        EditorGUILayout.Space(10);
        GUILayout.Label("Selection Filters:", EditorStyles.boldLabel);
        _selectedMonsterType = (MonsterType)EditorGUILayout.EnumPopup("MonsterType to select:", _selectedMonsterType);
    }
}
