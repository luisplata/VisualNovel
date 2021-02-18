using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    [SerializeField] protected string id;

    [SerializeField] protected string dialog;

    [SerializeField] protected List<Dialog> dialogs;

    [SerializeField] private bool isGameOver;

    public string Id => id;

    public string TextOfDialog => dialog;

    public List<Dialog> Dialogs()
    {
        if (!isOption())
        {
            throw new ThisIsNotSimpleDialogException($"This dialogs is simple dialog");
        }
        return dialogs;
    }

    public bool isOption()
    {
        return dialogs.Count > 1;
    }

    public Dialog GetNextDialog()
    {
        if (isOption())
        {
            throw new ThisIsNotSimpleDialogException($"This dialogs count is {dialogs.Count}");
        }
        return dialogs[0];
    }

    public bool IsGameOver => isGameOver;
}