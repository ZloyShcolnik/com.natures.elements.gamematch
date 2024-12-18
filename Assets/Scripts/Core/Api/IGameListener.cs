namespace Core.Api
{
    public interface exemenation {}

    public interface IGameListener : exemenation {}

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