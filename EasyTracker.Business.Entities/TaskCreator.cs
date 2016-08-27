namespace EasyTracker.Business.Entities
{
    public static class TaskCreator
    {
        public static BaseEnitity CreateEntity()
        {
            return new BaseEnitity
            {
                Id = 1,
                Author = "Max",
                Description = "New desc",
                Name = "New entity"
            };
        }

        public static BaseEnitity CreateTask()
        {
            return new BaseEnitity
            {
                Id = 1,
                Author = "Max",
                Description = "New desc",
                Name = "New entity"
            };
        }

        public static BugEntity CreateBug()
        {
            return new BugEntity(CreateTask())
            {
                BaseEnitity = { Id = 2 },
                Steps = "Some Steps.",
                ExprectedResult = "It works!",
                ActualResult = "In progress..."
            };
        }
    }
}