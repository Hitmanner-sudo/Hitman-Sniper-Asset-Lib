using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000136")]
public class AISound : AIMemento
{
	[Serializable]
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5925BC", Offset = "0x5925BC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40006B9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40006BA")]
		[FieldOffset(Offset = "0x8")]
		public static Func<AudioVolume, IEnumerable<AISensor>> _003C_003E9__5_0;

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x910A50", Offset = "0x910A50", VA = "0x910A50")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x910A58", Offset = "0x910A58", VA = "0x910A58")]
		internal IEnumerable<AISensor> _003CBroadcast_003Eb__5_0(AudioVolume volume)
		{
			return null;
		}
	}

	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x68")]
	public bool ByPassOcclusion;

	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x70")]
	private List<AudioVolume> _audioVolumes;

	[Token(Token = "0x6000868")]
	[Address(RVA = "0xA989A8", Offset = "0xA989A8", VA = "0xA989A8")]
	public AISound()
	{
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0xA987C4", Offset = "0xA987C4", VA = "0xA987C4")]
	public AISound(AIEmitter emitter)
	{
	}

	[Token(Token = "0x600086A")]
	[Address(RVA = "0xA98A08", Offset = "0xA98A08", VA = "0xA98A08", Slot = "10")]
	public override AIMemento Push(Memory memory)
	{
		return null;
	}

	[Token(Token = "0x600086B")]
	[Address(RVA = "0xA98A0C", Offset = "0xA98A0C", VA = "0xA98A0C", Slot = "8")]
	public override void Broadcast()
	{
	}

	[Token(Token = "0x600086C")]
	[Address(RVA = "0xA98C78", Offset = "0xA98C78", VA = "0xA98C78", Slot = "9")]
	public override bool CanBeDetectedBy(AISensor sensor)
	{
		return default(bool);
	}
}
