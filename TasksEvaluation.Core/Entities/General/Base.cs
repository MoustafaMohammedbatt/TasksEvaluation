namespace TasksEvaluation.Core.Entities.Common
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
