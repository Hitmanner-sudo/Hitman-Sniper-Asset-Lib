using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000058")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x10EF97C", Offset = "0x10EF97C", VA = "0x10EF97C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x10EF980", Offset = "0x10EF980", VA = "0x10EF980")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x10EF9FC", Offset = "0x10EF9FC", VA = "0x10EF9FC")]
		public InputAxisScrollbar()
		{
		}
	}
}
