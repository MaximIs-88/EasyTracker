namespace EasyTracker.Business.Entities
{
    public static class TaskCreator
    {
        public static BaseEnitity CreateTask()
        {
            return new BaseEnitity
            {
                Id = 1,
                Author = "Max",
                Description = "New desc",
                Name = "New task"
            };
        }
    }
}