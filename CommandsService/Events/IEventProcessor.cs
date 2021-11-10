namespace CommandsService.Events
{
    public interface IEventProcessor
    {
        void ProccessEvent(string message);
    }
}