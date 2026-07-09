using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200012A")]
public class AIEmitter : GameMonoBehaviour
{
	[Token(Token = "0x4000673")]
	[FieldOffset(Offset = "0x0")]
	private static int _distributor;

	[Token(Token = "0x4000674")]
	[FieldOffset(Offset = "0x48")]
	private int _ID;

	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B081C", Offset = "0x5B081C")]
	private bool _003CAlive_003Ek__BackingField;

	[Token(Token = "0x17000153")]
	public int ID
	{
		[Token(Token = "0x600080F")]
		[Address(RVA = "0xA95A94", Offset = "0xA95A94", VA = "0xA95A94")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000154")]
	public virtual bool Alive
	{
		[Token(Token = "0x6000811")]
		[Address(RVA = "0xA95B10", Offset = "0xA95B10", VA = "0xA95B10", Slot = "14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x612570", Offset = "0x612570")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000812")]
		[Address(RVA = "0xA95B18", Offset = "0xA95B18", VA = "0xA95B18", Slot = "15")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x612580", Offset = "0x612580")]
		set
		{
		}
	}

	[Token(Token = "0x17000155")]
	public virtual Faction Faction
	{
		[Token(Token = "0x6000813")]
		[Address(RVA = "0xA95B24", Offset = "0xA95B24", VA = "0xA95B24", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000156")]
	public virtual Faction VisibleFaction
	{
		[Token(Token = "0x6000814")]
		[Address(RVA = "0xA95B2C", Offset = "0xA95B2C", VA = "0xA95B2C", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000157")]
	public virtual Vector3 Velocity
	{
		[Token(Token = "0x6000815")]
		[Address(RVA = "0xA95B3C", Offset = "0xA95B3C", VA = "0xA95B3C", Slot = "18")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0xA95A9C", Offset = "0xA95A9C", VA = "0xA95A9C")]
	public void ChangeID()
	{
	}

	[Token(Token = "0x6000816")]
	[Address(RVA = "0xA95B44", Offset = "0xA95B44", VA = "0xA95B44")]
	public AIEmitter()
	{
	}
}
