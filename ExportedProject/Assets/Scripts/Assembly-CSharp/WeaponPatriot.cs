using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003AB")]
public class WeaponPatriot : Weapon
{
	[Token(Token = "0x40014E6")]
	private const string SHOW_BULLETS_EVENT_NAME = "show_bullets";

	[Token(Token = "0x40014E7")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private GameObject _bulletsGO;

	[Token(Token = "0x40014E8")]
	[FieldOffset(Offset = "0x118")]
	private AnimationEventProxy _animEventProxy;

	[Token(Token = "0x60016C8")]
	[Address(RVA = "0x98C044", Offset = "0x98C044", VA = "0x98C044", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60016C9")]
	[Address(RVA = "0x98C1CC", Offset = "0x98C1CC", VA = "0x98C1CC", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60016CA")]
	[Address(RVA = "0x98C320", Offset = "0x98C320", VA = "0x98C320")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60016CB")]
	[Address(RVA = "0x98C410", Offset = "0x98C410", VA = "0x98C410")]
	private void OnAmmoCountChanged(int newAmmoCount)
	{
	}

	[Token(Token = "0x60016CC")]
	[Address(RVA = "0x98C43C", Offset = "0x98C43C", VA = "0x98C43C")]
	private void OnAnimEvent(object sender, AnimationEvent animEvent)
	{
	}

	[Token(Token = "0x60016CD")]
	[Address(RVA = "0x98C4D0", Offset = "0x98C4D0", VA = "0x98C4D0")]
	public WeaponPatriot()
	{
	}
}
