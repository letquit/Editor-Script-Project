using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(MonsterAbility))]
public class MonsterAbilityDrawer : PropertyDrawer
{
    private SerializedProperty _name;
    private SerializedProperty _damage;
    private SerializedProperty _element;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        Rect foldOutBox = new Rect(position.min.x, position.min.y, position.size.x, EditorGUIUtility.singleLineHeight);
        property.isExpanded = EditorGUI.Foldout(foldOutBox, property.isExpanded, label);
        
        // draw our properties
        
        EditorGUI.EndProperty();
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        int totalLines = 1;

        // increase our height if we expand arrow
        if (property.isExpanded)
        {
            totalLines += 3;
        }
        
        return (EditorGUIUtility.singleLineHeight * totalLines);
    }
}
