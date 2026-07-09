using System;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200062E")]
public class ToggleWidget : GameMonoBehaviour
{
	[Token(Token = "0x200062F")]
	public enum State
	{
		[Token(Token = "0x4002228")]
		Unchecked = 0,
		[Token(Token = "0x4002229")]
		Checked = 1
	}

	[Serializable]
	[Token(Token = "0x2000630")]
	public struct StateData
	{
		[Token(Token = "0x400222A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private State _forState;

		[Token(Token = "0x400222B")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Transform _anchor;

		[Token(Token = "0x400222C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ColorModel.ColorModelEnum _color;

		[Token(Token = "0x17000545")]
		public State ForState
		{
			[Token(Token = "0x6002815")]
			[Address(RVA = "0xA374E4", Offset = "0xA374E4", VA = "0xA374E4")]
			get
			{
				return default(State);
			}
		}

		[Token(Token = "0x17000546")]
		public Transform Anchor
		{
			[Token(Token = "0x6002816")]
			[Address(RVA = "0xA374EC", Offset = "0xA374EC", VA = "0xA374EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000547")]
		public Color Color
		{
			[Token(Token = "0x6002817")]
			[Address(RVA = "0xA374F4", Offset = "0xA374F4", VA = "0xA374F4")]
			get
			{
				return default(Color);
			}
		}
	}

	[Token(Token = "0x2000631")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595690", Offset = "0x595690")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x400222D")]
		[FieldOffset(Offset = "0x10")]
		public State state;

		[Token(Token = "0x6002818")]
		[Address(RVA = "0xA374C8", Offset = "0xA374C8", VA = "0xA374C8")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6002819")]
		[Address(RVA = "0xA374D0", Offset = "0xA374D0", VA = "0xA374D0")]
		internal bool _003CSetState_003Eb__0(StateData d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400221F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private State _initialState;

	[Token(Token = "0x4002220")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private StateData[] _stateDatas;

	[Token(Token = "0x4002221")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform _handle;

	[Token(Token = "0x4002222")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UIWidget _backgroundColorWidget;

	[Token(Token = "0x4002223")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ButtonHandler _button;

	[Token(Token = "0x4002224")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float _tweenDuration;

	[Token(Token = "0x4002226")]
	[FieldOffset(Offset = "0x80")]
	private State _state;

	[Token(Token = "0x17000544")]
	public State CurrentState
	{
		[Token(Token = "0x600280E")]
		[Address(RVA = "0xAD01B0", Offset = "0xAD01B0", VA = "0xAD01B0")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x14000091")]
	public event Action<State> StateChanged
	{
		[Token(Token = "0x600280C")]
		[Address(RVA = "0xAD0070", Offset = "0xAD0070", VA = "0xAD0070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D700", Offset = "0x61D700")]
		add
		{
		}
		[Token(Token = "0x600280D")]
		[Address(RVA = "0xAD0110", Offset = "0xAD0110", VA = "0xAD0110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D710", Offset = "0x61D710")]
		remove
		{
		}
	}

	[Token(Token = "0x600280F")]
	[Address(RVA = "0xAD01B8", Offset = "0xAD01B8", VA = "0xAD01B8", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002810")]
	[Address(RVA = "0xAD0440", Offset = "0xAD0440", VA = "0xAD0440", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002811")]
	[Address(RVA = "0xAD04EC", Offset = "0xAD04EC", VA = "0xAD04EC")]
	private void OnButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6002812")]
	[Address(RVA = "0xAD0274", Offset = "0xAD0274", VA = "0xAD0274")]
	private void SetState(State state)
	{
	}

	[Token(Token = "0x6002813")]
	[Address(RVA = "0xAD04FC", Offset = "0xAD04FC", VA = "0xAD04FC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x61D720", Offset = "0x61D720")]
	private void VerifyPreconditions()
	{
	}

	[Token(Token = "0x6002814")]
	[Address(RVA = "0xAD0514", Offset = "0xAD0514", VA = "0xAD0514")]
	public ToggleWidget()
	{
	}
}
