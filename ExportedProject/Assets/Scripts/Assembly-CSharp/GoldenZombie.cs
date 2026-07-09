using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200016B")]
public class GoldenZombie : MonoBehaviour
{
	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x0")]
	private static int _randomIndex;

	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x4")]
	private static int _currentIndex;

	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x8")]
	private static int _spawnCount;

	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0xC")]
	private static int _goldenSpawned;

	[Token(Token = "0x400079C")]
	private const int RANDOM_COUNT = 10;

	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0x18")]
	public Material GoldenMaterial;

	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0x20")]
	public string RewardName;

	[Token(Token = "0x400079F")]
	[FieldOffset(Offset = "0x28")]
	public SoundContainer SoundOnDeath;

	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0x30")]
	public string OverrideTagIconName;

	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x38")]
	private Character _character;

	[Token(Token = "0x6000974")]
	[Address(RVA = "0xC84208", Offset = "0xC84208", VA = "0xC84208")]
	private void ResetStaticValue()
	{
	}

	[Token(Token = "0x6000975")]
	[Address(RVA = "0xC84290", Offset = "0xC84290", VA = "0xC84290")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000976")]
	[Address(RVA = "0xC84414", Offset = "0xC84414", VA = "0xC84414")]
	protected void Choosen()
	{
	}

	[Token(Token = "0x6000977")]
	[Address(RVA = "0xC847DC", Offset = "0xC847DC", VA = "0xC847DC")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6000978")]
	[Address(RVA = "0xC84BE4", Offset = "0xC84BE4", VA = "0xC84BE4")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000979")]
	[Address(RVA = "0xC84A4C", Offset = "0xC84A4C", VA = "0xC84A4C")]
	private void GiveReward()
	{
	}

	[Token(Token = "0x600097A")]
	[Address(RVA = "0xC84624", Offset = "0xC84624", VA = "0xC84624")]
	private void ShowTrackable()
	{
	}

	[Token(Token = "0x600097B")]
	[Address(RVA = "0xC84D74", Offset = "0xC84D74", VA = "0xC84D74")]
	public GoldenZombie()
	{
	}

	[Token(Token = "0x600097D")]
	[Address(RVA = "0xC84E38", Offset = "0xC84E38", VA = "0xC84E38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x612C28", Offset = "0x612C28")]
	private bool _003CGiveReward_003Eb__15_0(RewardCustomScore r)
	{
		return default(bool);
	}
}
