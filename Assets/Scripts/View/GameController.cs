using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour, IGameController
{
    [SerializeField] GameObject canvasForDialogs;
    [SerializeField] GameObject canvasForOptions;
    [SerializeField] Image background;
    [SerializeField] Image imageOfCharacter;
    
    [SerializeField] DialogsConfiguration dialogConfig;
    
    [SerializeField] OptionsConfiguration optionConfig;

    [SerializeField] private Button btnContinue;

    [SerializeField] private TextMeshProUGUI textDialog;

    [SerializeField] private TextMeshProUGUI textOption;

    [SerializeField] private GameObject panelDeOpciones;

    private DialogButtonLogic logic;

    public void FillFildOfDialog(Dialog concurrentDialog)
    {
        textDialog.text = concurrentDialog.TextOfDialog;
    }

    public void FillFildOfOption(Dialog concurrentDialog)
    {
        textOption.text = concurrentDialog.TextOfDialog;
    }

    public void FillOptions(Option option)
    {
        option.transform.SetParent(panelDeOpciones.transform);
        var rect = (RectTransform)option.transform;
        
    }

    public void ShowDialog()
    {
        Debug.Log("Show dialog");
        canvasForDialogs.SetActive(true);
        canvasForOptions.SetActive(false);
    }

    public void ShowOptions()
    {
        canvasForDialogs.SetActive(false);
        canvasForOptions.SetActive(true);
    }

    private void Start()
    {
        logic = new DialogButtonLogic(this ,new DialogsFactory(Instantiate(dialogConfig)), new OptionsFactory(Instantiate(optionConfig)));

        btnContinue.onClick.AddListener(delegate{ logic.NextDialog(); });
    }
}
