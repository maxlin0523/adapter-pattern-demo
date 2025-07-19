using AdapterPatternSample.Adapter;
using AdapterPatternSample.DVI;
using AdapterPatternSample.HDMI;
using AdapterPatternSample.Host;

namespace AdapterPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Adapter Pattern 示例 ===\n");

            // 創建新的HDMI螢幕
            var newScreen = new NewScreen();
            Console.WriteLine($"HDMI螢幕初始狀態: {newScreen.GetConnectionStatus()}\n");

            // 創建DVI轉接器
            var adapter = new DVIAdapter(newScreen);
            Console.WriteLine($"轉接器初始狀態: {adapter.GetConnectionStatus()}\n");

            // 創建主機並連接轉接器
            var myHost = new MyHost(adapter);
            Console.WriteLine();

            // 開機並檢查狀態
            myHost.Open();
            Console.WriteLine();

            myHost.CheckStatus();
            Console.WriteLine();

            // 演示關機流程
            myHost.Shutdown();
            Console.WriteLine();

            // 檢查關機後狀態
            myHost.CheckStatus();
            Console.WriteLine();

            // 比較：直接使用故障的DVI螢幕
            Console.WriteLine("=== 比較：使用故障的DVI螢幕 ===");
            var brokenScreen = new MyScreen();
            var hostWithBrokenScreen = new MyHost(brokenScreen);
            hostWithBrokenScreen.Open();
            hostWithBrokenScreen.CheckStatus();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
