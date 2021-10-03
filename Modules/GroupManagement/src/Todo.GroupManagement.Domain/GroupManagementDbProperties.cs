namespace Todo.GroupManagement
{
    public static class GroupManagementDbProperties
    {
        public static string DbTablePrefix { get; set; } = "GroupManagement";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "GroupManagement";
    }
}
