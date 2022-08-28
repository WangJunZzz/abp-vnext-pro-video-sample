namespace MyLion.Erp.Permissions
{
    public class ErpPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {

            var blog = context.AddGroup(ErpPermissions.BlogManagementGroupName, L("博客"));
            var blogManagement = blog.AddPermission(ErpPermissions.BlogManagement.Default, L("博客管理"));
            blogManagement.AddChild(ErpPermissions.BlogManagement.Blog.Created, L("创建"));
            blogManagement.AddChild(ErpPermissions.BlogManagement.Blog.Update, L("编辑"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ErpResource>(name);
        }
    }
}