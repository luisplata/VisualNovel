public interface IGameController
{
    void FillFildOfDialog(Dialog concurrentDialog);
    void FillFildOfOption(Dialog concurrentDialog);
    void ShowDialog();
    void ShowOptions();
    void FillOptions(Option option);
}