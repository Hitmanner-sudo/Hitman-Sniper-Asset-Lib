using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20001D8")]
public static class SoundsHandler
{
	[Token(Token = "0x4000A98")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<Target, GameTimer> _rogueLookAt;

	[Token(Token = "0x4000A99")]
	[FieldOffset(Offset = "0x8")]
	private static Target _lastLookedAt;

	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0x10")]
	private static Bullet _lastBullet;

	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0x18")]
	private static PlayingSoundContainer _communicateSoundContainer;

	[Token(Token = "0x4000A9C")]
	[FieldOffset(Offset = "0x20")]
	private static int _communicaterCount;

	[Token(Token = "0x4000A9D")]
	[FieldOffset(Offset = "0x28")]
	private static PlayingSoundContainer _guardAlertedChatter;

	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0xA6F3F8", Offset = "0xA6F3F8", VA = "0xA6F3F8")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0xA6F74C", Offset = "0xA6F74C", VA = "0xA6F74C")]
	public static void Uninitialize()
	{
	}

	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0xA6FAA0", Offset = "0xA6FAA0", VA = "0xA6FAA0")]
	private static void OnGameEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0xA6FCE0", Offset = "0xA6FCE0", VA = "0xA6FCE0")]
	private static void StopAllSounds(AudioBus bus)
	{
	}

	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0xA6FF50", Offset = "0xA6FF50", VA = "0xA6FF50")]
	private static void OnDied(object sender, Character.DeathEvent args)
	{
	}

	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0xA703D0", Offset = "0xA703D0", VA = "0xA703D0")]
	private static void OnPlayerAim(object sender, PlayerRootFSM.Sniping.AimInfo args)
	{
	}

	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0xA7096C", Offset = "0xA7096C", VA = "0xA7096C")]
	private static void OnMementoAddedGlobal(object sender, Memory.MementoAddedArgs e)
	{
	}

	[Token(Token = "0x6000BDE")]
	[Address(RVA = "0xA70DA8", Offset = "0xA70DA8", VA = "0xA70DA8")]
	private static void OnBulletHit(object sender, Bullet.BulletHitArgs args)
	{
	}

	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0xA710A8", Offset = "0xA710A8", VA = "0xA710A8")]
	private static void OnGlobalAlertChanged(object sender, AISensorManager.AlertLevelChangedArgs args)
	{
	}

	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0xA71498", Offset = "0xA71498", VA = "0xA71498")]
	public static void StartRadioCommunicate()
	{
	}

	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0xA71670", Offset = "0xA71670", VA = "0xA71670")]
	public static void StopRadioCommunicate()
	{
	}

	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0xA718C4", Offset = "0xA718C4", VA = "0xA718C4")]
	public static void OnWeaponAssembled(object sender, EventArgs args)
	{
	}
}
