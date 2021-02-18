using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Bell/Dialogs Configuration")]
public class DialogsConfiguration : ScriptableObject
{
    [SerializeField] private Dialog[] dialogs;
    [SerializeField] private Dialog firstDialog;
    private Dictionary<string, Dialog> idToDialog;

    private void Awake()
    {
        idToDialog = new Dictionary<string, Dialog>(dialogs.Length);
        foreach (var powerUp in dialogs)
        {
            idToDialog.Add(powerUp.Id, powerUp);
        }
    }

    public Dialog GetDialogPrefabById(string id)
    {
        if (!idToDialog.TryGetValue(id, out var powerUp))
        {
            throw new FindDialogException($"Dialog with id {id} does not exit");
        }
        return powerUp;
    }

    public Dialog GetFirstDialog()
    {
        return firstDialog;
    }
}