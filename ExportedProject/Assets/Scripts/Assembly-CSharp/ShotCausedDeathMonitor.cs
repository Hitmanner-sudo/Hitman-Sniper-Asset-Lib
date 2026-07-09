using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000470")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5949C0", Offset = "0x5949C0")]
public class ShotCausedDeathMonitor : FsmStateAction
{
	[Serializable]
	[Token(Token = "0x2000471")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5949F8", Offset = "0x5949F8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001846")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001847")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Damage.Hit, bool> _003C_003E9__7_0;

		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0x8BF9F0", Offset = "0x8BF9F0", VA = "0x8BF9F0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001ACC")]
		[Address(RVA = "0x8BF9F8", Offset = "0x8BF9F8", VA = "0x8BF9F8")]
		internal bool _003COnBulletDied_003Eb__7_0(Damage.Hit x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001842")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent CausedDeath;

	[Token(Token = "0x4001843")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent FailedToCauseDeath;

	[Token(Token = "0x4001844")]
	[FieldOffset(Offset = "0x60")]
	private bool _bulletCausedDeath;

	[Token(Token = "0x4001845")]
	[FieldOffset(Offset = "0x61")]
	private bool _monitorBulletDeaths;

	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x844CA8", Offset = "0x844CA8", VA = "0x844CA8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0x844CB0", Offset = "0x844CB0", VA = "0x844CB0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0x844DA8", Offset = "0x844DA8", VA = "0x844DA8")]
	private void OnShoot(object sender, Weapon.ShotFiredArgs args)
	{
	}

	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x844E20", Offset = "0x844E20", VA = "0x844E20")]
	private void OnBulletDied(object sender, Bullet.BulletDiedArgs args)
	{
	}

	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x84502C", Offset = "0x84502C", VA = "0x84502C", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001AC9")]
	[Address(RVA = "0x845120", Offset = "0x845120", VA = "0x845120")]
	public ShotCausedDeathMonitor()
	{
	}
}
