using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200036C")]
public class AttachmentInfo : MonoBehaviour
{
	[Token(Token = "0x40012E6")]
	[FieldOffset(Offset = "0x18")]
	private Attachment[] _attachments;

	[Token(Token = "0x1700030E")]
	public Attachment[] Attachments
	{
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0xC03FC0", Offset = "0xC03FC0", VA = "0xC03FC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60014C9")]
	[Address(RVA = "0xC0402C", Offset = "0xC0402C", VA = "0xC0402C")]
	public AttachmentInfo()
	{
	}
}
