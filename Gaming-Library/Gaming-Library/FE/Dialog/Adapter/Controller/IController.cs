namespace Gaming_Library.FE.Dialog.Adapter.Controller
{
    public interface IController
    {
        public void StartGame(int index);
        public void LoadData();
        public void DeleteGame(int index);
        public void AddGame();
    }
}