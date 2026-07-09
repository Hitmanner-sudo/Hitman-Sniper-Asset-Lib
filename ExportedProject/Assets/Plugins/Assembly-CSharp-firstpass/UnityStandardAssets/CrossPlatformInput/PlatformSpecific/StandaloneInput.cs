using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000065")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x10F1E28", Offset = "0x10F1E28", VA = "0x10F1E28", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x10F1E3C", Offset = "0x10F1E3C", VA = "0x10F1E3C", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x10F1E48", Offset = "0x10F1E48", VA = "0x10F1E48", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x10F1E54", Offset = "0x10F1E54", VA = "0x10F1E54", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x10F1E60", Offset = "0x10F1E60", VA = "0x10F1E60", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x10F1EB4", Offset = "0x10F1EB4", VA = "0x10F1EB4", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x10F1F08", Offset = "0x10F1F08", VA = "0x10F1F08", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x10F1F5C", Offset = "0x10F1F5C", VA = "0x10F1F5C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x10F1FB0", Offset = "0x10F1FB0", VA = "0x10F1FB0", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x10F2004", Offset = "0x10F2004", VA = "0x10F2004", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x10F2058", Offset = "0x10F2058", VA = "0x10F2058", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x10DEC0C", Offset = "0x10DEC0C", VA = "0x10DEC0C")]
		public StandaloneInput()
		{
		}
	}
}
