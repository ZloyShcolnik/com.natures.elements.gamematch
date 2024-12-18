namespace Core.Api
{
    public interface �������� {}

    public interface IGameListener : �������� {}

    public interface IUpdateListener : IGameListener
    {
        void OnUpdate();
    }

    public interface IGamePauseListener : IGameListener
    {
        void OnPause();
    }

    public interface IGameResumeListener : IGameListener
    {
        void OnResume();
    }
}