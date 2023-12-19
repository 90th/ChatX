using System.Net.Http;

namespace ChatX.Utils {

    internal static class HttpClientInstance {
        public static HttpClient Client { get; } = new HttpClient();

        static HttpClientInstance() {
            // You can set up default properties for your HttpClient here
            // For example, timeouts, headers, etc.
        }

        public static void Dispose() {
            // Dispose of the HttpClient when your application exits
            Client.Dispose();
        }
    }
}