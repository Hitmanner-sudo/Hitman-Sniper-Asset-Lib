using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A4F")]
	public class PlayingSoundContainer
	{
		[Token(Token = "0x40035BA")]
		[FieldOffset(Offset = "0x10")]
		private bool _isStopping;

		[Token(Token = "0x40035BB")]
		[FieldOffset(Offset = "0x18")]
		private List<PlayingSound> Sounds;

		[Token(Token = "0x17000855")]
		public bool IsStopping
		{
			[Token(Token = "0x6004148")]
			[Address(RVA = "0xABF994", Offset = "0xABF994", VA = "0xABF994")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000856")]
		public bool IsFinished
		{
			[Token(Token = "0x6004149")]
			[Address(RVA = "0xAB9C3C", Offset = "0xAB9C3C", VA = "0xAB9C3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000857")]
		public bool IsStopped
		{
			[Token(Token = "0x600414A")]
			[Address(RVA = "0xABF6D4", Offset = "0xABF6D4", VA = "0xABF6D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600414B")]
		[Address(RVA = "0xABF99C", Offset = "0xABF99C", VA = "0xABF99C")]
		public void Add(PlayingSound playingSound)
		{
		}

		[Token(Token = "0x600414C")]
		[Address(RVA = "0xABFA34", Offset = "0xABFA34", VA = "0xABFA34")]
		public bool Remove(PlayingSound playingSound)
		{
			return default(bool);
		}

		[Token(Token = "0x600414D")]
		[Address(RVA = "0xABF83C", Offset = "0xABF83C", VA = "0xABF83C")]
		public void Stop(bool immediate = false)
		{
		}

		[Token(Token = "0x600414E")]
		[Address(RVA = "0xAB9D64", Offset = "0xAB9D64", VA = "0xAB9D64")]
		public void Fade(float wantedVolume, float duration)
		{
		}

		[Token(Token = "0x600414F")]
		[Address(RVA = "0xABA134", Offset = "0xABA134", VA = "0xABA134")]
		public PlayingSoundContainer()
		{
		}
	}
}
