using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000171")]
public class AnimatorControllerSeting : MonoBehaviour
{
	[Token(Token = "0x40007AB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LazyRuntimeAnimatorController _highEndDeviceAnimatorController;

	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LazyRuntimeAnimatorController _LowEndDeviceAnimatorController;

	[Token(Token = "0x600098B")]
	[Address(RVA = "0xD461D4", Offset = "0xD461D4", VA = "0xD461D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600098C")]
	[Address(RVA = "0xD46314", Offset = "0xD46314", VA = "0xD46314")]
	public LazyRuntimeAnimatorController GetSelectedController()
	{
		return null;
	}

	[Token(Token = "0x600098D")]
	[Address(RVA = "0xD4634C", Offset = "0xD4634C", VA = "0xD4634C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600098E")]
	[Address(RVA = "0xD46474", Offset = "0xD46474", VA = "0xD46474")]
	public AnimatorControllerSeting()
	{
	}
}
