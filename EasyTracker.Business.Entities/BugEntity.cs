namespace EasyTracker.Business.Entities
{
    public class BugEntity
    {
        public BugEntity(BaseEnitity baseEnitity)
        {
            BaseEnitity = baseEnitity;
        }

        public BaseEnitity BaseEnitity { get; }
        public string Steps { get; set; }
        public string ExprectedResult { get; set; }
        public string ActualResult { get; set; }
    }
}
