using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000148")]
public class EmitFilteredMemento : GameMonoBehaviour
{
	[Token(Token = "0x40006F7")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private FilteredMemento _memento;

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0xE0CC88", Offset = "0xE0CC88", VA = "0xE0CC88", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60008CA")]
	[Address(RVA = "0xE0CCB0", Offset = "0xE0CCB0", VA = "0xE0CCB0")]
	private void Emit()
	{
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0xE0CDA0", Offset = "0xE0CDA0", VA = "0xE0CDA0")]
	public EmitFilteredMemento()
	{
	}
}
