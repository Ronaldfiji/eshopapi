using System.Collections.Concurrent;

namespace SchoolApiv2.Util
{
    public class AppState
    {
        public string OrderNumer { get; set; } = string.Empty;
        public ConcurrentDictionary<string, object> OrderNum { get; } = new ConcurrentDictionary<string, object>(); // handles race condition

        public AppState() { }
    }
    public static class GlobalData_
    {
        //{ This needs to deal with race condition for multiple-thread accessing the same object concurrentl}
        public static Dictionary<string, object> ApplicationDic { get; set; } = new Dictionary<string, object>();
        // GlobalData.ApplicationDic.Add("A", "Tested"); // Set value
        // Re-assign value // GlobalData.ApplicationDic["A"] = "BBBB";
        // Get value // GlobalData.ApplicationDic["A"]

        public static ConcurrentDictionary<string, object> OrderNum { get; } = new ConcurrentDictionary<string, object>();

        public static string HostBaseAddress { get; set; } = string.Empty;
        public static void UseCustomFunction(this IApplicationBuilder app)
        {
        }
    }
}
