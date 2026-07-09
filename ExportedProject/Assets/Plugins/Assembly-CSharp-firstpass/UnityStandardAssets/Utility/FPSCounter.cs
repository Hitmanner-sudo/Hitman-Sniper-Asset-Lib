using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200002B")]
	[Attribute(Name = "RequireComponent", RVA = "0x6F8F98", Offset = "0x6F8F98")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x40000EB")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x40000EF")]
		private const string display = "{0} FPS";

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x10E87A0", Offset = "0x10E87A0", VA = "0x10E87A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x10E8808", Offset = "0x10E8808", VA = "0x10E8808")]
		private void Update()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x10E890C", Offset = "0x10E890C", VA = "0x10E890C")]
		public FPSCounter()
		{
		}
	}
}
