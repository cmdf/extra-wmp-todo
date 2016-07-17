using System;
using WMPLib;

// provide verbose mode?
namespace cmd_wmp.wmp {
	class oCommand {

		// data
		/// <summary>
		/// Windows Media Player object on which command is executed.
		/// </summary>
		public WindowsMediaPlayer Wmp;

		// constructor
		/// <summary>
		/// Create command object from Windows Media Player object.
		/// </summary>
		/// <param name="wmp">Windows Media Player object.</param>
		public oCommand(WindowsMediaPlayer wmp) {
			Wmp = wmp;
		}

		/// <summary>
		/// Get or set current item.
		/// </summary>
		/// <param name="a">[item].</param>
		public void CurrentItem(string[] a) {
			if (a.Length == 0) Console.WriteLine(Wmp.controls.currentItem);
			else Wmp.controls.currentItem = Wmp.newMedia(a[0]);
		}

		/// <summary>
		/// Get or set current marker.
		/// </summary>
		/// <param name="a">[marker].</param>
		public void CurrentMarker(string[] a) {
			int n = 0;
			if (a.Length == 0) Console.WriteLine(Wmp.controls.currentMarker);
			else { int.TryParse(a[0], out n); Wmp.controls.currentMarker = n; }
		}

		/// <summary>
		/// Get or set current position.
		/// </summary>
		/// <param name="a">[pos].</param>
		public void CurrentPosition(string[] a) {
			double n = 0;
			if (a.Length == 0) Console.WriteLine(Wmp.controls.currentPosition);
			else { double.TryParse(a[0], out n); Wmp.controls.currentPosition = n; }
		}

		/// <summary>
		/// Get current position as string.
		/// </summary>
		/// <param name="a">NA.</param>
		public void CurrentPositionString(string[] a) {
			Console.WriteLine(Wmp.controls.currentPositionString);
		}

		/// <summary>
		/// Launch specified URL.
		/// </summary>
		/// <param name="a">url.</param>
		public void LaunchUrl(string[] a) {
			if (a.Length > 0) Wmp.launchURL(a[0]);
			else Console.Error.WriteLine("err: LaunchUrl(<URL>) called without <URL>.");
		}

		/// <summary>
		/// Fast forward current media.
		/// </summary>
		/// <param name="a">NA.</param>
		public void FastForward(string[] a) {
			Wmp.controls.fastForward();
		}

		/// <summary>
		/// Fast reverse current media.
		/// </summary>
		/// <param name="a">NA.</param>
		public void FastReverse(string[] a) {
			Wmp.controls.fastReverse();
		}

		/// <summary>
		/// Indicates whether specified item is available.
		/// </summary>
		/// <param name="a">item.</param>
		public void IsAvailable(string[] a) {
			if (a.Length > 0) Console.WriteLine(Wmp.controls.isAvailable[a[0]]);
			else Console.Error.WriteLine("err: IsAvailable(<item>) called without <item>.");
		}

		/// <summary>
		/// Change to next media.
		/// </summary>
		/// <param name="a">NA.</param>
		public void Next(string[] a) {
			Wmp.controls.next();
		}

		/// <summary>
		/// Pause playing media.
		/// </summary>
		/// <param name="a">NA.</param>
		public void Pause(string[] a) {
			Wmp.controls.pause();
		}

		/// <summary>
		/// Play current media.
		/// </summary>
		/// <param name="a">[url].</param>
		public void Play(string[] a) {
			if (a.Length == 0) Wmp.controls.play();
			else PlayItem(a);
		}

		/// <summary>
		/// Play media specified by URL.
		/// </summary>
		/// <param name="a">url.</param>
		public void PlayItem(string[] a) {
			if (a.Length > 0) Wmp.controls.playItem(Wmp.newMedia(a[0]));
			else Console.Error.WriteLine("err: PlayItem(<URL>) called without <URL>.");
		}

		/// <summary>
		/// Change to previous media.
		/// </summary>
		/// <param name="a">NA.</param>
		public void Previous(string[] a) {
			Wmp.controls.previous();
		}

		/// <summary>
		/// Get current status.
		/// </summary>
		/// <param name="a">NA.</param>
		public void Status(string[] a) {
			Console.WriteLine(Wmp.status);
		}

		/// <summary>
		/// Stop playing media.
		/// </summary>
		/// <param name="a">NA.</param>
		public void Stop(string[] a) {
			Wmp.controls.stop();
		}

		/// <summary>
		/// Get or set whether to stretch to fit.
		/// </summary>
		/// <param name="a">[stretchtofit].</param>
		public void StretchToFit(string[] a) {
			bool n = false;
			if (a.Length == 0) Console.WriteLine(Wmp.stretchToFit);
			else { bool.TryParse(a[0], out n); Wmp.stretchToFit = n; }
		}

		/// <summary>
		/// Get or set UI mode.
		/// </summary>
		/// <param name="a">[uimode].</param>
		public void UiMode(string[] a) {
			if (a.Length == 0) Console.WriteLine(Wmp.uiMode);
			else Wmp.uiMode = a[0];
		}

		/// <summary>
		/// Get or set current media URL.
		/// </summary>
		/// <param name="a">[url].</param>
		public void Url(string[] a) {
			if (a.Length > 0) Wmp.URL = a[0];
			else Console.WriteLine(Wmp.URL);
		}

		/// <summary>
		/// Get version info.
		/// </summary>
		/// <param name="a">NA.</param>
		public void VersionInfo(string[] a) {
			Console.WriteLine(Wmp.versionInfo);
		}

		/// <summary>
		/// Get or set whether ot use windowless video.
		/// </summary>
		/// <param name="a">[windowless].</param>
		public void WindowlessVideo(string[] a) {
			bool n = false;
			if (a.Length == 0) Console.WriteLine(Wmp.windowlessVideo);
			else { bool.TryParse(a[0], out n); Wmp.windowlessVideo = n; }
		}
	}
}
