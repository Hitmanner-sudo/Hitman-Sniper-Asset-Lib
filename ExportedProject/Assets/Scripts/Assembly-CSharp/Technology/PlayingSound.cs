using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A4D")]
	public class PlayingSound
	{
		[Token(Token = "0x2000A4E")]
		public enum SoundInstanceType
		{
			[Token(Token = "0x40035B8")]
			SOUNDINSTANCE = 0,
			[Token(Token = "0x40035B9")]
			PLAYINGSOUNDCONTAINER = 1
		}

		[Token(Token = "0x40035B4")]
		[FieldOffset(Offset = "0x10")]
		public SoundInstanceType InstanceType;

		[Token(Token = "0x40035B5")]
		[FieldOffset(Offset = "0x18")]
		public SoundInstance SoundInstance;

		[Token(Token = "0x40035B6")]
		[FieldOffset(Offset = "0x20")]
		public PlayingSoundContainer PlayingContainer;

		[Token(Token = "0x17000852")]
		public bool isValid
		{
			[Token(Token = "0x6004143")]
			[Address(RVA = "0xABF634", Offset = "0xABF634", VA = "0xABF634")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000853")]
		public bool isFinished
		{
			[Token(Token = "0x6004144")]
			[Address(RVA = "0xABF664", Offset = "0xABF664", VA = "0xABF664")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000854")]
		public bool IsStopped
		{
			[Token(Token = "0x6004145")]
			[Address(RVA = "0xABF6A0", Offset = "0xABF6A0", VA = "0xABF6A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004141")]
		[Address(RVA = "0xABF5D0", Offset = "0xABF5D0", VA = "0xABF5D0")]
		public PlayingSound(SoundInstance soundInstance)
		{
		}

		[Token(Token = "0x6004142")]
		[Address(RVA = "0xABF600", Offset = "0xABF600", VA = "0xABF600")]
		public PlayingSound(PlayingSoundContainer playingContainer)
		{
		}

		[Token(Token = "0x6004146")]
		[Address(RVA = "0xABF7FC", Offset = "0xABF7FC", VA = "0xABF7FC")]
		public void Stop(bool immediate = false)
		{
		}

		[Token(Token = "0x6004147")]
		[Address(RVA = "0xABF964", Offset = "0xABF964", VA = "0xABF964")]
		public void Fade(float wantedVolume, float duration)
		{
		}
	}
}
