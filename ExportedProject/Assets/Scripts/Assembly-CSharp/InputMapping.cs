using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002EA")]
public abstract class InputMapping : MonoBehaviour
{
	[Token(Token = "0x4001016")]
	[FieldOffset(Offset = "0x18")]
	protected GameObject _owner;

	[Token(Token = "0x170002A4")]
	public GameObject Owner
	{
		[Token(Token = "0x60011ED")]
		[Address(RVA = "0xB13140", Offset = "0xB13140", VA = "0xB13140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60011EE")]
	[Address(RVA = "0xB13148", Offset = "0xB13148", VA = "0xB13148", Slot = "4")]
	public virtual void Activate(GameObject owner)
	{
	}

	[Token(Token = "0x60011EF")]
	[Address(RVA = "0xB0919C", Offset = "0xB0919C", VA = "0xB0919C", Slot = "5")]
	public virtual void Deactivate()
	{
	}

	[Token(Token = "0x60011F0")]
	public abstract void RegisterGestureDelegates();

	[Token(Token = "0x60011F1")]
	public abstract void UnregisterGestureDelegates();

	[Token(Token = "0x60011F2")]
	[Address(RVA = "0xB0A2D0", Offset = "0xB0A2D0", VA = "0xB0A2D0")]
	protected InputMapping()
	{
	}
}
