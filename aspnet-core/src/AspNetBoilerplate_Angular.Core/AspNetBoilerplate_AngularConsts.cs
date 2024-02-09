using AspNetBoilerplate_Angular.Debugging;

namespace AspNetBoilerplate_Angular
{
    public class AspNetBoilerplate_AngularConsts
    {
        public const string LocalizationSourceName = "AspNetBoilerplate_Angular";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "31c7991533c24988a8c9cb0d2721a9ea";
    }
}
