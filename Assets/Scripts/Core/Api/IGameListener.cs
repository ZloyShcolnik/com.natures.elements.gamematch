namespace Core.Api
{
    public interface גאנגאûנג {}

    public interface IGameListener : גאנגאûנג {}

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