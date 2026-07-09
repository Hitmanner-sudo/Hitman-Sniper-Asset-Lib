using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000054")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000055")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000199")]
			Hardware = 0,
			[Token(Token = "0x400019A")]
			Touch = 1
		}

		[Token(Token = "0x2000056")]
		public class VirtualAxis
		{
			[Token(Token = "0x400019B")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F94E8", Offset = "0x6F94E8")]
			private string _003Cname_003Ek__BackingField;

			[Token(Token = "0x400019C")]
			[FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x400019D")]
			[FieldOffset(Offset = "0x1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F94F8", Offset = "0x6F94F8")]
			private bool _003CmatchWithInputManager_003Ek__BackingField;

			[Token(Token = "0x17000021")]
			public string name
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x18BEFC8", Offset = "0x18BEFC8", VA = "0x18BEFC8")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA600", Offset = "0x6FA600")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x18BEFD0", Offset = "0x18BEFD0", VA = "0x18BEFD0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA610", Offset = "0x6FA610")]
				private set
				{
				}
			}

			[Token(Token = "0x17000022")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x18BEFD8", Offset = "0x18BEFD8", VA = "0x18BEFD8")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA620", Offset = "0x6FA620")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x18BEFE0", Offset = "0x18BEFE0", VA = "0x18BEFE0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA630", Offset = "0x6FA630")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public float GetValue
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x18BF034", Offset = "0x18BF034", VA = "0x18BF034")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000024")]
			public float GetValueRaw
			{
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x18BF03C", Offset = "0x18BF03C", VA = "0x18BF03C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x18BB850", Offset = "0x18BB850", VA = "0x18BB850")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x18BEFEC", Offset = "0x18BEFEC", VA = "0x18BEFEC")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x18BBAC4", Offset = "0x18BBAC4", VA = "0x18BBAC4")]
			public void Remove()
			{
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x18BF02C", Offset = "0x18BF02C", VA = "0x18BF02C")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000057")]
		public class VirtualButton
		{
			[Token(Token = "0x400019E")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9508", Offset = "0x6F9508")]
			private string _003Cname_003Ek__BackingField;

			[Token(Token = "0x400019F")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9518", Offset = "0x6F9518")]
			private bool _003CmatchWithInputManager_003Ek__BackingField;

			[Token(Token = "0x40001A0")]
			[FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40001A1")]
			[FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40001A2")]
			[FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000025")]
			public string name
			{
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x18BF044", Offset = "0x18BF044", VA = "0x18BF044")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA640", Offset = "0x6FA640")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0x18BF04C", Offset = "0x18BF04C", VA = "0x18BF04C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA650", Offset = "0x6FA650")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0x18BF054", Offset = "0x18BF054", VA = "0x18BF054")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA660", Offset = "0x6FA660")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0x18BF05C", Offset = "0x18BF05C", VA = "0x18BF05C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA670", Offset = "0x6FA670")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public bool GetButton
			{
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x18BF1BC", Offset = "0x18BF1BC", VA = "0x18BF1BC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000028")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x18BF1C4", Offset = "0x18BF1C4", VA = "0x18BF1C4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000029")]
			public bool GetButtonUp
			{
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x18BF1F4", Offset = "0x18BF1F4", VA = "0x18BF1F4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x18BF068", Offset = "0x18BF068", VA = "0x18BF068")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x18BF0A4", Offset = "0x18BF0A4", VA = "0x18BF0A4")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x18BF0EC", Offset = "0x18BF0EC", VA = "0x18BF0EC")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x18BF128", Offset = "0x18BF128", VA = "0x18BF128")]
			public void Released()
			{
			}

			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x18BF154", Offset = "0x18BF154", VA = "0x18BF154")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000020")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x10DF244", Offset = "0x10DF244", VA = "0x10DF244")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x10DEB50", Offset = "0x10DEB50", VA = "0x10DEB50")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x10DEC14", Offset = "0x10DEC14", VA = "0x10DEC14")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x10DC72C", Offset = "0x10DC72C", VA = "0x10DC72C")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x10DECC0", Offset = "0x10DECC0", VA = "0x10DECC0")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x10DC7A4", Offset = "0x10DC7A4", VA = "0x10DC7A4")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x10DED38", Offset = "0x10DED38", VA = "0x10DED38")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x10DEDB0", Offset = "0x10DEDB0", VA = "0x10DEDB0")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x10DEE74", Offset = "0x10DEE74", VA = "0x10DEE74")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x10DC81C", Offset = "0x10DC81C", VA = "0x10DC81C")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x10DEEEC", Offset = "0x10DEEEC", VA = "0x10DEEEC")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x10DEFDC", Offset = "0x10DEFDC", VA = "0x10DEFDC")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x10DEF50", Offset = "0x10DEF50", VA = "0x10DEF50")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x10DF040", Offset = "0x10DF040", VA = "0x10DF040")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x10DF0BC", Offset = "0x10DF0BC", VA = "0x10DF0BC")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x10DF138", Offset = "0x10DF138", VA = "0x10DF138")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x10DCC34", Offset = "0x10DCC34", VA = "0x10DCC34")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x10DCD14", Offset = "0x10DCD14", VA = "0x10DCD14")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x10DCDF4", Offset = "0x10DCDF4", VA = "0x10DCDF4")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x10DCFB4", Offset = "0x10DCFB4", VA = "0x10DCFB4")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x10DCED4", Offset = "0x10DCED4", VA = "0x10DCED4")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x10DF1B4", Offset = "0x10DF1B4", VA = "0x10DF1B4")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x10DF2BC", Offset = "0x10DF2BC", VA = "0x10DF2BC")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x10DF33C", Offset = "0x10DF33C", VA = "0x10DF33C")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x10DF3BC", Offset = "0x10DF3BC", VA = "0x10DF3BC")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
}
