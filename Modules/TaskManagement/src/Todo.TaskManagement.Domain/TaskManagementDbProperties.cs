namespace Todo.TaskManagement
{
    public static class TaskManagementDbProperties
    {
        public static string DbTablePrefix { get; set; } = "TaskManagement";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "TaskManagement";
    }
}
