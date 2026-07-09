using System;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20002EE")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x593264", Offset = "0x593264")]
public class Breakable : GameMonoBehaviour
{
	[Token(Token = "0x20002EF")]
	public class BreakEvent : EventArgs
	{
		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x10")]
		public Breakable Breakable;

		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x18")]
		public Damage Damage;

		[Token(Token = "0x6001210")]
		[Address(RVA = "0x92AEA4", Offset = "0x92AEA4", VA = "0x92AEA4")]
		public BreakEvent()
		{
		}
	}

	[NonSerialized]
	[Token(Token = "0x400101C")]
	[FieldOffset(Offset = "0x48")]
	public Health Health;

	[Token(Token = "0x400101D")]
	[FieldOffset(Offset = "0x50")]
	public AISound AISound;

	[Token(Token = "0x400101E")]
	[FieldOffset(Offset = "0x58")]
	public SoundContainer Sound;

	[Token(Token = "0x400101F")]
	[FieldOffset(Offset = "0x60")]
	public string NameId;

	[Token(Token = "0x4001020")]
	[FieldOffset(Offset = "0x68")]
	public LazyGameObject DestroyedEffectLazy;

	[Token(Token = "0x4001021")]
	[FieldOffset(Offset = "0x70")]
	public bool DisappearOnBreak;

	[Token(Token = "0x4001022")]
	[FieldOffset(Offset = "0x74")]
	public float EnableRagdollRadius;

	[Token(Token = "0x170002A6")]
	public bool IsBroken
	{
		[Token(Token = "0x6001208")]
		[Address(RVA = "0xA7FDC4", Offset = "0xA7FDC4", VA = "0xA7FDC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400004C")]
	public event EventHandler<BreakEvent> OnBreaking
	{
		[Token(Token = "0x6001202")]
		[Address(RVA = "0xA7F9CC", Offset = "0xA7F9CC", VA = "0xA7F9CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615FC4", Offset = "0x615FC4")]
		add
		{
		}
		[Token(Token = "0x6001203")]
		[Address(RVA = "0xA7FA6C", Offset = "0xA7FA6C", VA = "0xA7FA6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615FD4", Offset = "0x615FD4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400004D")]
	public event EventHandler<BreakEvent> OnBroken
	{
		[Token(Token = "0x6001204")]
		[Address(RVA = "0xA7FB0C", Offset = "0xA7FB0C", VA = "0xA7FB0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615FE4", Offset = "0x615FE4")]
		add
		{
		}
		[Token(Token = "0x6001205")]
		[Address(RVA = "0xA7FBAC", Offset = "0xA7FBAC", VA = "0xA7FBAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615FF4", Offset = "0x615FF4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400004E")]
	public static event EventHandler<BreakEvent> OnBrokenGlobal
	{
		[Token(Token = "0x6001206")]
		[Address(RVA = "0xA7FC4C", Offset = "0xA7FC4C", VA = "0xA7FC4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616004", Offset = "0x616004")]
		add
		{
		}
		[Token(Token = "0x6001207")]
		[Address(RVA = "0xA7FD08", Offset = "0xA7FD08", VA = "0xA7FD08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616014", Offset = "0x616014")]
		remove
		{
		}
	}

	[Token(Token = "0x6001209")]
	[Address(RVA = "0xA7FDE0", Offset = "0xA7FDE0", VA = "0xA7FDE0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600120A")]
	[Address(RVA = "0xA7FEAC", Offset = "0xA7FEAC", VA = "0xA7FEAC", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600120B")]
	[Address(RVA = "0xA7FFA0", Offset = "0xA7FFA0", VA = "0xA7FFA0", Slot = "14")]
	protected virtual void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x600120C")]
	[Address(RVA = "0xA803C8", Offset = "0xA803C8", VA = "0xA803C8")]
	protected void RaiseBreakableEvents(Damage damage)
	{
	}

	[Token(Token = "0x600120D")]
	[Address(RVA = "0xA80008", Offset = "0xA80008", VA = "0xA80008")]
	protected void Break(Damage damage)
	{
	}

	[Token(Token = "0x600120E")]
	[Address(RVA = "0xA804A0", Offset = "0xA804A0", VA = "0xA804A0")]
	private void EnableNearbyRagdolls(float radius)
	{
	}

	[Token(Token = "0x600120F")]
	[Address(RVA = "0xA805E8", Offset = "0xA805E8", VA = "0xA805E8")]
	public Breakable()
	{
	}
}
