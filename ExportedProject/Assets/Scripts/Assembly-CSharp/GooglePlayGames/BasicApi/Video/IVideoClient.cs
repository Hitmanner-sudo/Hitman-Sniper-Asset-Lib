using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	[Token(Token = "0x20009FB")]
	public interface IVideoClient
	{
		[Token(Token = "0x6003F45")]
		void GetCaptureCapabilities(Action<ResponseStatus, VideoCapabilities> callback);

		[Token(Token = "0x6003F46")]
		void ShowCaptureOverlay();

		[Token(Token = "0x6003F47")]
		void GetCaptureState(Action<ResponseStatus, VideoCaptureState> callback);

		[Token(Token = "0x6003F48")]
		void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback);

		[Token(Token = "0x6003F49")]
		bool IsCaptureSupported();

		[Token(Token = "0x6003F4A")]
		void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener);

		[Token(Token = "0x6003F4B")]
		void UnregisterCaptureOverlayStateChangedListener();
	}
}
