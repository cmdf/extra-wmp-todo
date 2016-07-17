using System;
using WMP = WMPLib.WindowsMediaPlayer;

namespace cmd_wmp.wmp {
	class oSettings {

		// static method
		/// <summary>
		/// Get or set auto play.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[auto].</param>
		public static void AutoStart(WMP w, string[] a) {
			bool n = false;
			if (a.Length == 0) Console.WriteLine(w.settings.autoStart);
			else { bool.TryParse(a[0], out n); w.settings.autoStart = n; }
		}

		/// <summary>
		/// Get or set stereo balance.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[val].</param>
		public static void Balance(WMP w, string[] a) {
			int n = 0;
			if (a.Length == 0) Console.WriteLine(w.settings.balance);
			else { int.TryParse(a[0], out n); w.settings.balance = n; }
		}

		/// <summary>
		/// Get or set base URL.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[url].</param>
		public static void BaseUrl(WMP w, string[] a) {
			if (a.Length == 0) Console.WriteLine(w.settings.baseURL);
			else w.settings.baseURL = a[0];
		}

		/// <summary>
		/// Get or set default frame.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[frame].</param>
		public static void DefaultFrame(WMP w, string[] a) {
			if (a.Length == 0) Console.WriteLine(w.settings.defaultFrame);
			else w.settings.defaultFrame = a[0];
		}

		/// <summary>
		/// Get or set whether error dialogs are enabled.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[enable].</param>
		public static void EnableErrorDialogs(WMP w, string[] a) {
			bool n = false;
			if (a.Length == 0) Console.WriteLine(w.settings.enableErrorDialogs);
			else { bool.TryParse(a[0], out n); w.settings.enableErrorDialogs = n; }
		}

		/// <summary>
		/// Get mode.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">prop.</param>
		public static void GetMode(WMP w, string[] a) {
			if (a.Length > 0) Console.WriteLine(w.settings.getMode(a[0]));
			else Console.Error.WriteLine("err: GetMode(<prop>) called wihout <prop>.");
		}

		/// <summary>
		/// Get or set whether to invoke URLs.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[invoke].</param>
		public static void InvokeUrls(WMP w, string[] a) {
			bool n = false;
			if (a.Length == 0) Console.WriteLine(w.settings.invokeURLs);
			else { bool.TryParse(a[0], out n); w.settings.invokeURLs = n; }
		}

		/// <summary>
		/// Get whether item is available.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">item.</param>
		public static void IsAvailable(WMP w, string[] a) {
			if (a.Length > 0) Console.WriteLine(w.settings.isAvailable[a[0]]);
			else Console.Error.WriteLine("err: IsAvailable(<item>) called without <item>.");
		}

		/// <summary>
		/// Get or set mute.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[mute].</param>
		public static void Mute(WMP w, string[] a) {
			bool n = false;
			if (a.Length == 0) Console.WriteLine(w.settings.mute);
			else { bool.TryParse(a[0], out n); w.settings.mute = n; }
		}

		/// <summary>
		/// Get or set play count.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[count].</param>
		public static void PlayCount(WMP w, string[] a) {
			int n = 1;
			if (a.Length == 0) Console.WriteLine(w.settings.playCount);
			else { int.TryParse(a[0], out n); w.settings.playCount = n; }
		}

		/// <summary>
		/// Get or set play rate.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[rate].</param>
		public static void Rate(WMP w, string[] a) {
			double n = 1;
			if (a.Length == 0) Console.WriteLine(w.settings.rate);
			else { double.TryParse(a[0], out n); w.settings.rate = n; }
		}

		/// <summary>
		/// Set mode.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">prop, val.</param>
		public static void SetMode(WMP w, string[] a) {
			bool n = false;
			if (a.Length > 1) { bool.TryParse(a[1], out n); w.settings.setMode(a[0], n); }
			else Console.Error.WriteLine("err: SetMode(<prop>, <val>) called without <prop> or <val>.");
		}

		/// <summary>
		/// Get or set volume.
		/// </summary>
		/// <param name="w">WMP object.</param>
		/// <param name="a">[vol].</param>
		public static void Volume(WMP w, string[] a) {
			int n = 50;
			if (a.Length == 0) Console.WriteLine(w.settings.volume);
			else { int.TryParse(a[0], out n); w.settings.volume = n; }
		}
	}
}
