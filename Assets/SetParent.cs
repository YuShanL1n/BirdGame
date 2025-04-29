using UnityEngine;
using Fungus;

[CommandInfo("Transform", "Set Parent", "Sets one GameObject as the parent of another.")]
public class SetParent : Command
{
    [Tooltip("The child GameObject")]
    public GameObject child;

    [Tooltip("The new parent GameObject")]
    public GameObject newParent;

    [Tooltip("Keep the current world position")]
    public bool worldPositionStays = true;

    public override void OnEnter()
    {
        if (child != null && newParent != null)
        {
            child.transform.SetParent(newParent.transform, worldPositionStays);
        }

        Continue();
    }

    public override string GetSummary()
    {
        return (child != null ? child.name : "None") + " ¡÷ " + (newParent != null ? newParent.name : "None");
    }
}
