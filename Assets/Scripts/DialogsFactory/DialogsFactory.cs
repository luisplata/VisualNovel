using UnityEngine;

public class DialogsFactory
{
    private readonly DialogsConfiguration dialogsConfiguration;

    public DialogsFactory(DialogsConfiguration dialogsConfiguration)
    {
        this.dialogsConfiguration = dialogsConfiguration;
    }

    public Dialog Create(string id)
    {
        var prefab = dialogsConfiguration.GetDialogPrefabById(id);

        return Object.Instantiate(prefab);
    }

    public Dialog CreateFirst()
    {
        var prefab = dialogsConfiguration.GetFirstDialog();

        return Object.Instantiate(prefab);
    }
}