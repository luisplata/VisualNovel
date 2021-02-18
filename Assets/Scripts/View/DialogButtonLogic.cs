using System;

public class DialogButtonLogic
{
    private Dialog concurrentDialog;
    private DialogsFactory dialogsFactory;
    private OptionsFactory optionFactory;
    private IGameController gameController;

    public DialogButtonLogic(IGameController gameController, DialogsFactory dialogsConfiguration, OptionsFactory optionsConfiguration)
    {
        dialogsFactory = dialogsConfiguration;
        optionFactory = optionsConfiguration;
        this.gameController = gameController;

        concurrentDialog = dialogsFactory.CreateFirst();

        gameController.ShowDialog();
        gameController.FillFildOfDialog(concurrentDialog);
    }

    public  void NextDialog()
    {
        concurrentDialog = concurrentDialog.GetNextDialog();

        if (concurrentDialog.isOption())
        {
            gameController.ShowOptions();
            gameController.FillFildOfOption(concurrentDialog);
            gameController.FillOptions(optionFactory.Create(concurrentDialog.Dialogs().Count));
        }
        else
        {
            gameController.ShowDialog();
            gameController.FillFildOfDialog(concurrentDialog);
        }
    }
}