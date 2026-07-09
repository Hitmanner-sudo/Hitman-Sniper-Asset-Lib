using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200062A")]
public class SetModelDataVariable : MonoBehaviour
{
	[Token(Token = "0x4002215")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _dataModelPath;

	[Token(Token = "0x4002216")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected string _variableName;

	[Token(Token = "0x4002217")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected bool _forceSet;

	[Token(Token = "0x4002218")]
	[FieldOffset(Offset = "0x30")]
	protected DataModel _dataModel;

	[Token(Token = "0x6002804")]
	[Address(RVA = "0x1040A64", Offset = "0x1040A64", VA = "0x1040A64")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002805")]
	[Address(RVA = "0x1040AEC", Offset = "0x1040AEC", VA = "0x1040AEC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002806")]
	[Address(RVA = "0x1040BE8", Offset = "0x1040BE8", VA = "0x1040BE8")]
	public SetModelDataVariable()
	{
	}
}
