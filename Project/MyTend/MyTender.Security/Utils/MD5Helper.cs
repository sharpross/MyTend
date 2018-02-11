namespace MyTender.Security.Utils
{
    using System.Web.Security;

    public static class MD5Helper
    {
        public static string GetMD5String(string password)
        {
            var md5string = string.Empty;

            md5string = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");

            return md5string;
        }
    }
}
