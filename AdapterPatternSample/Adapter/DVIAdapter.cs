using AdapterPatternSample.DVI;
using AdapterPatternSample.HDMI;
using System;

namespace AdapterPatternSample.Adapter
{
    /// <summary>
    /// HDMI to DVI 轉接器。
    /// 繼承的介面＝要轉換的物件(DVI)
    /// </summary>
    public class DVIAdapter : IDVI
    {
        private readonly IHDMI _hdmi;

        /// <summary>
        /// 建構式參數＝要被轉換的物件(HDMI)
        /// </summary>
        public DVIAdapter(IHDMI hdmi)
        {
            _hdmi = hdmi ?? throw new ArgumentNullException(nameof(hdmi));
        }

        public bool IsConnected => _hdmi.IsConnected;

        /// <summary>
        /// 實作IDVI Connect
        /// 實際上是HDMI連接，藉此達到轉接效果
        /// </summary>
        public void Connect()
        {
            Console.WriteLine("轉接: HDMI to DVI");
            _hdmi.Connect();
        }

        public void Disconnect()
        {
            Console.WriteLine("斷開轉接: HDMI to DVI");
            _hdmi.Disconnect();
        }

        public string GetConnectionStatus()
        {
            var hdmiStatus = _hdmi.GetConnectionStatus();
            return $"轉接器狀態: {hdmiStatus} (透過HDMI to DVI轉接)";
        }
    }
}
