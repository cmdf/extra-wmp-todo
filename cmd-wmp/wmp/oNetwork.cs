using System;
using WMP = WMPLib.WindowsMediaPlayer;

namespace cmd_wmp.wmp {
	class oNetwork {

		// static method
		/// <summary>
		/// Get network bandwidth.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void BandWidth(WMP w, string[] a) {
			Console.WriteLine(w.network.bandWidth);
		}

		/// <summary>
		/// Get network bitrate.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void BitRate(WMP w, string[] a) {
			Console.WriteLine(w.network.bitRate);
		}

		/// <summary>
		/// Get buffering count.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void BufferingCount(WMP w, string[] a) {
			Console.WriteLine(w.network.bufferingCount);
		}

		/// <summary>
		/// Get buffering progress.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void BufferingProgress(WMP w, string[] a) {
			Console.WriteLine(w.network.bufferingProgress);
		}

		/// <summary>
		/// Get or set buffering time.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[time].</param>
		public static void BufferingTime(WMP w, string[] a) {
			int n = 0;
			if (a.Length == 0) Console.WriteLine(w.network.bufferingTime);
			else { int.TryParse(a[0], out n); w.network.bufferingTime = n; }
		}

		/// <summary>
		/// Get download progress.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void DownloadProgress(WMP w, string[] a) {
			Console.WriteLine(w.network.downloadProgress);
		}

		/// <summary>
		/// Get encoded frame rate.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void EncodedFrameRate(WMP w, string[] a) {
			Console.WriteLine(w.network.encodedFrameRate);
		}

		/// <summary>
		/// Get frame rate.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void FrameRate(WMP w, string[] a) {
			Console.WriteLine(w.network.frameRate);
		}

		/// <summary>
		/// Get number of frames skipped.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void FramesSkipped(WMP w, string[] a) {
			Console.WriteLine(w.network.framesSkipped);
		}

		/// <summary>
		/// Get proxy bypass for local.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">proto.</param>
		public static void GetProxyBypassForLocal(WMP w, string[] a) {
			if (a.Length > 0) Console.WriteLine(w.network.getProxyBypassForLocal(a[0]));
			else Console.Error.WriteLine("err: GetProxyBypassForLocal(<proto>) was not provided with <proto>.");
		}

		/// <summary>
		/// Get proxy exception list.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">proto.</param>
		public static void GetProxyExceptionList(WMP w, string[] a) {
			if (a.Length > 0) Console.WriteLine(w.network.getProxyExceptionList(a[0]));
			else Console.Error.WriteLine("err: GetProxyExceptionList(<proto>) was not provided with <proto>.");
		}

		/// <summary>
		/// Get proxy name.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">proto.</param>
		public static void GetProxyName(WMP w, string[] a) {
			if (a.Length > 0) Console.WriteLine(w.network.getProxyName(a[0]));
			else Console.Error.WriteLine("err: GetProxyName(<proto>) was not provided with <proto>.");
		}

		/// <summary>
		/// Get proxy port.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">proto.</param>
		public static void GetProxyPort(WMP w, string[] a) {
			if (a.Length > 0) Console.WriteLine(w.network.getProxyPort(a[0]));
			else Console.Error.WriteLine("err: GetProxyPort(<proto>) was not provided with <proto>.");
		}

		/// <summary>
		/// Get proxy settings.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">proto.</param>
		public static void GetProxySettings(WMP w, string[] a) {
			if (a.Length > 0) Console.WriteLine(w.network.getProxySettings(a[0]));
			else Console.Error.WriteLine("err: GetProxySettings(<proto>) was not provided with <proto>.");
		}

		/// <summary>
		/// Get number of lost packets.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void LostPackets(WMP w, string[] a) {
			Console.WriteLine(w.network.lostPackets);
		}

		/// <summary>
		/// Get or set maximum bandwidth.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[bandwidth].</param>
		public static void MaxBandwidth(WMP w, string[] a) {
			int n = 0;
			if (a.Length == 0) Console.WriteLine(w.network.maxBandwidth);
			else { int.TryParse(a[0], out n); w.network.maxBandwidth = n; }
		}

		/// <summary>
		/// Get maximum bitrate.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void MaxBitRate(WMP w, string[] a) {
			Console.WriteLine(w.network.maxBitRate);
		}

		/// <summary>
		/// Get number of recieved packets.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void RecievedPackets(WMP w, string[] a) {
			Console.WriteLine(w.network.receivedPackets);
		}

		/// <summary>
		/// Get reception quality.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void ReceptionQuality(WMP w, string[] a) {
			Console.WriteLine(w.network.receptionQuality);
		}

		/// <summary>
		/// Get number of recovered packets.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void RecoveredPackets(WMP w, string[] a) {
			Console.WriteLine(w.network.recoveredPackets);
		}

		/// <summary>
		/// Set proxy bypass for local.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">proto, bypass.</param>
		public static void SetProxyBypassForLocal(WMP w, string[] a) {
			bool n = false;
			if (a.Length > 1) { bool.TryParse(a[1], out n); w.network.setProxyBypassForLocal(a[0], n); }
			else Console.Error.WriteLine("err: SetProxyBypassForLocal(<proto>, <bypass>) was not provided with <proto> or <bypass>.");
		}

		/// <summary>
		/// Set proxy exception list.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">proto, list.</param>
		public static void SetProxyExceptionList(WMP w, string[] a) {
			if (a.Length > 1) w.network.setProxyExceptionList(a[0], a[1]);
			else Console.Error.WriteLine("err: SetProxyExceptionList(<proto>, <list>) was not provided with <proto> or <list>.");
		}

		/// <summary>
		/// Set proxy name.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">proto, name.</param>
		public static void SetProxyName(WMP w, string[] a) {
			if (a.Length > 1) w.network.setProxyName(a[0], a[1]);
			else Console.Error.WriteLine("err: SetProxyName(<proto>, <name>) was not provided with <proto> or <name>.");
		}

		/// <summary>
		/// Set proxy port.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">proto, port.</param>
		public static void SetProxyPort(WMP w, string[] a) {
			int n = 0;
			if (a.Length > 1) { int.TryParse(a[1], out n); w.network.setProxyPort(a[0], n); }
			else Console.Error.WriteLine("err: SetProxyPort(<proto>, <port>) was not provided with <proto> or <port>.");
		}

		/// <summary>
		/// Set proxy settings.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">proto, settings.</param>
		public static void SetProxySettings(WMP w, string[] a) {
			int n = 0;
			if(a.Length > 1) { int.TryParse(a[0], out n); w.network.setProxySettings(a[0], n); }
			else Console.Error.WriteLine("err: SetProxySettings(<proto>, <settings>) was not provided with <proto> or <settings>.");
		}

		/// <summary>
		/// Get source protocol.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">NA.</param>
		public static void SourceProtocol(WMP w, string[] a) {
			Console.WriteLine(w.network.sourceProtocol);
		}
	}
}
