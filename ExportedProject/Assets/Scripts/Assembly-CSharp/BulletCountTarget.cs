using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004FB")]
public class BulletCountTarget : MonoBehaviour
{
	[Token(Token = "0x4001A9D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x4001A9E")]
	[FieldOffset(Offset = "0x20")]
	private int _count;

	[Token(Token = "0x170004BD")]
	public int Count
	{
		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0xA85BC8", Offset = "0xA85BC8", VA = "0xA85BC8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0xA85BD0", Offset = "0xA85BD0", VA = "0xA85BD0")]
		set
		{
		}
	}

	[Token(Token = "0x6001EA7")]
	[Address(RVA = "0xA85C78", Offset = "0xA85C78", VA = "0xA85C78")]
	public BulletCountTarget()
	{
	}
}
