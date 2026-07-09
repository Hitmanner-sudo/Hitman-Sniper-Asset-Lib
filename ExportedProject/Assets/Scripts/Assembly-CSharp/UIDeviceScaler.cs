using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200079F")]
[ExecuteInEditMode]
public class UIDeviceScaler : MonoBehaviour
{
	[Token(Token = "0x4002AEE")]
	private const float IPhoneScale = 1.1375f;

	[Token(Token = "0x4002AEF")]
	private const float SixteenByNine = 1.7777778f;

	[Token(Token = "0x4002AF0")]
	private const float FourByThree = 1.3333334f;

	[Token(Token = "0x600326E")]
	[Address(RVA = "0x1583404", Offset = "0x1583404", VA = "0x1583404")]
	public void AdjustScale()
	{
	}

	[Token(Token = "0x600326F")]
	[Address(RVA = "0x158348C", Offset = "0x158348C", VA = "0x158348C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003270")]
	[Address(RVA = "0x1583464", Offset = "0x1583464", VA = "0x1583464")]
	public static float GetScale()
	{
		return default(float);
	}

	[Token(Token = "0x6003271")]
	[Address(RVA = "0x1583490", Offset = "0x1583490", VA = "0x1583490")]
	public static bool IsPhone()
	{
		return default(bool);
	}

	[Token(Token = "0x6003272")]
	[Address(RVA = "0x15834F0", Offset = "0x15834F0", VA = "0x15834F0")]
	public UIDeviceScaler()
	{
	}
}
