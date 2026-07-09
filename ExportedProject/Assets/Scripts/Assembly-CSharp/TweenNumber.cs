using Il2CppDummyDll;

[Token(Token = "0x2000633")]
public class TweenNumber : UITweener
{
	[Token(Token = "0x4002230")]
	[FieldOffset(Offset = "0x90")]
	public UILabel Label;

	[Token(Token = "0x4002231")]
	[FieldOffset(Offset = "0x98")]
	public int Value;

	[Token(Token = "0x4002232")]
	[FieldOffset(Offset = "0x9C")]
	public int From;

	[Token(Token = "0x4002233")]
	[FieldOffset(Offset = "0xA0")]
	public int To;

	[Token(Token = "0x4002234")]
	[FieldOffset(Offset = "0xA8")]
	public string BaseString;

	[Token(Token = "0x600281F")]
	[Address(RVA = "0xCB04EC", Offset = "0xCB04EC", VA = "0xCB04EC", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6002820")]
	[Address(RVA = "0xCB063C", Offset = "0xCB063C", VA = "0xCB063C")]
	public void SetTween(int from, int to, float duration, string baseString, EventDelegate eventDelegate)
	{
	}

	[Token(Token = "0x6002821")]
	[Address(RVA = "0xCB072C", Offset = "0xCB072C", VA = "0xCB072C")]
	public TweenNumber()
	{
	}
}
