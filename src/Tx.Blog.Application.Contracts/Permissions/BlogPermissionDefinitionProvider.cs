using Tx.Blog.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Tx.Blog.Permissions;

public class BlogPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BlogPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(BlogPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(BlogPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(BlogPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(BlogPermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = myGroup.AddPermission(BlogPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(BlogPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(BlogPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(BlogPermissions.Authors.Delete, L("Permission:Authors.Delete"));
        
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BlogPermissions.MyPermission1, L("Permission:MyPermission1"));
        var personsPermission = myGroup.AddPermission(BlogPermissions.Persons.Default, L<PersonResource>("Permission:Persons"));
        personsPermission.AddChild(BlogPermissions.Persons.Create, L<PersonResource>("Permission:Persons.Create"));
        personsPermission.AddChild(BlogPermissions.Persons.Edit, L<PersonResource>("Permission:Persons.Edit"));
        personsPermission.AddChild(BlogPermissions.Persons.Delete, L<PersonResource>("Permission:Persons.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BlogResource>(name);
    }

    private static LocalizableString L<T>(string name)
    {
        return LocalizableString.Create<T>(name);
    }
}
