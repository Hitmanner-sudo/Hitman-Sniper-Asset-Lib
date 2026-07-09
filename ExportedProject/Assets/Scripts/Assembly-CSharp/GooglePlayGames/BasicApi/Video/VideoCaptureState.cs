using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	[Token(Token = "0x20009FA")]
	public class VideoCaptureState
	{
		[Token(Token = "0x40034D3")]
		[FieldOffset(Offset = "0x10")]
		private bool mIsCapturing;

		[Token(Token = "0x40034D4")]
		[FieldOffset(Offset = "0x14")]
		private VideoCaptureMode mCaptureMode;

		[Token(Token = "0x40034D5")]
		[FieldOffset(Offset = "0x18")]
		private VideoQualityLevel mQualityLevel;

		[Token(Token = "0x40034D6")]
		[FieldOffset(Offset = "0x1C")]
		private bool mIsOverlayVisible;

		[Token(Token = "0x40034D7")]
		[FieldOffset(Offset = "0x1D")]
		private bool mIsPaused;

		[Token(Token = "0x170007E4")]
		public bool IsCapturing
		{
			[Token(Token = "0x6003F3F")]
			[Address(RVA = "0x13C9E50", Offset = "0x13C9E50", VA = "0x13C9E50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007E5")]
		public VideoCaptureMode CaptureMode
		{
			[Token(Token = "0x6003F40")]
			[Address(RVA = "0x13C9E58", Offset = "0x13C9E58", VA = "0x13C9E58")]
			get
			{
				return default(VideoCaptureMode);
			}
		}

		[Token(Token = "0x170007E6")]
		public VideoQualityLevel QualityLevel
		{
			[Token(Token = "0x6003F41")]
			[Address(RVA = "0x13C9E60", Offset = "0x13C9E60", VA = "0x13C9E60")]
			get
			{
				return default(VideoQualityLevel);
			}
		}

		[Token(Token = "0x170007E7")]
		public bool IsOverlayVisible
		{
			[Token(Token = "0x6003F42")]
			[Address(RVA = "0x13C9E68", Offset = "0x13C9E68", VA = "0x13C9E68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007E8")]
		public bool IsPaused
		{
			[Token(Token = "0x6003F43")]
			[Address(RVA = "0x13C9E70", Offset = "0x13C9E70", VA = "0x13C9E70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6003F3E")]
		[Address(RVA = "0x13C9DEC", Offset = "0x13C9DEC", VA = "0x13C9DEC")]
		internal VideoCaptureState(bool isCapturing, VideoCaptureMode captureMode, VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused)
		{
		}

		[Token(Token = "0x6003F44")]
		[Address(RVA = "0x13C9E78", Offset = "0x13C9E78", VA = "0x13C9E78", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
