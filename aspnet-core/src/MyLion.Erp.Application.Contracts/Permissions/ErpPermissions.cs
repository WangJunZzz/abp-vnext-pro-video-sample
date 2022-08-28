namespace MyLion.Erp.Permissions
{
    public static class ErpPermissions
    {

        public const string BlogManagementGroupName = "Blog";

        public static class BlogManagement
        {
            public const string Default = BlogManagementGroupName + ".BlogManagement";

            public static class Blog
            {
                /// <summary>
                /// 新增
                /// </summary>
                public const string Created = Default + ".Created";

                /// <summary>
                ///  编辑
                /// </summary>
                public const string Update = Default + ".Update";
            }
        }
    }
}