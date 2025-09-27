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
        
        // fill our properties
        _name = property.FindPropertyRelative("_name");
        _damage = property.FindPropertyRelative("_damage");
        _element = property.FindPropertyRelative("_element");

        Rect foldOutBox = new Rect(position.min.x, position.min.y, position.size.x, EditorGUIUtility.singleLineHeight);
        property.isExpanded = EditorGUI.Foldout(foldOutBox, property.isExpanded, label);

        if (property.isExpanded)
        {
            // draw our properties
            DrawNameProperty(position);
            DrawDamageProperty(position);
            DrawElementProperty(position);
        }
        
        EditorGUI.EndProperty();
    }

    private void DrawNameProperty(Rect position)
    {
        float xPos = position.min.x;
        float yPos = position.min.y + EditorGUIUtility.singleLineHeight;
        float width = position.size.x;
        float height = EditorGUIUtility.singleLineHeight;
        
        Rect drawArea = new Rect(xPos, yPos, width, height);
        EditorGUI.PropertyField(drawArea, _name, new GUIContent("Name"));
    }

    private void DrawDamageProperty(Rect position)
    {
        
    }

    private void DrawElementProperty(Rect position)
    {
        
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
