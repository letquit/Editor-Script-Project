using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SeparatorAttribute))]
public class SeparatorDrawer : DecoratorDrawer
{
    public override void OnGUI(Rect position)
    {
        // get a reference to the attribute.
        SeparatorAttribute separatorAttribute = attribute as SeparatorAttribute;
        // define the line to draw.
        if (separatorAttribute != null)
        {
            Rect separatorRect = new Rect(position.xMin, position.yMin + separatorAttribute.Spacing, position.width,
                separatorAttribute.Height);
            // draw it
            EditorGUI.DrawRect(separatorRect, Color.white);
        }
    }

    public override float GetHeight()
    {
        SeparatorAttribute separatorAttribute = attribute as SeparatorAttribute;
        if (separatorAttribute != null)
        {
            float totalSPacing = separatorAttribute.Spacing + separatorAttribute.Height + separatorAttribute.Spacing;
            return totalSPacing;
        }

        return 0;
    }
}
