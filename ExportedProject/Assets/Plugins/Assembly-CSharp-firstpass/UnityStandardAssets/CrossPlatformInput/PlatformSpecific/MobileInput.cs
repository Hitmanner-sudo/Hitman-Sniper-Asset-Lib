using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000064")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x10F0684", Offset = "0x10F0684", VA = "0x10F0684")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x10F0710", Offset = "0x10F0710", VA = "0x10F0710")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x10F079C", Offset = "0x10F079C", VA = "0x10F079C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x10F0840", Offset = "0x10F0840", VA = "0x10F0840", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x10F08E4", Offset = "0x10F08E4", VA = "0x10F08E4", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x10F0988", Offset = "0x10F0988", VA = "0x10F0988", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x10F0A30", Offset = "0x10F0A30", VA = "0x10F0A30", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x10F0AD8", Offset = "0x10F0AD8", VA = "0x10F0AD8", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x10F0B7C", Offset = "0x10F0B7C", VA = "0x10F0B7C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x10F0C2C", Offset = "0x10F0C2C", VA = "0x10F0C2C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x10F0CD0", Offset = "0x10F0CD0", VA = "0x10F0CD0", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x10F0D74", Offset = "0x10F0D74", VA = "0x10F0D74", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x10F0E18", Offset = "0x10F0E18", VA = "0x10F0E18", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x10DEC04", Offset = "0x10DEC04", VA = "0x10DEC04")]
		public MobileInput()
		{
		}
	}
}
