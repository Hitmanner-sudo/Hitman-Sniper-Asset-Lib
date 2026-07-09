using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007B0")]
public class WeaponSuggestionImage : MonoBehaviour
{
	[Token(Token = "0x4002B53")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _ownedVisual;

	[Token(Token = "0x4002B54")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _unownedVisual;

	[Token(Token = "0x17000681")]
	public bool Owned
	{
		[Token(Token = "0x60032C0")]
		[Address(RVA = "0x98D64C", Offset = "0x98D64C", VA = "0x98D64C")]
		set
		{
		}
	}

	[Token(Token = "0x60032C1")]
	[Address(RVA = "0x98D738", Offset = "0x98D738", VA = "0x98D738")]
	public WeaponSuggestionImage()
	{
	}
}
