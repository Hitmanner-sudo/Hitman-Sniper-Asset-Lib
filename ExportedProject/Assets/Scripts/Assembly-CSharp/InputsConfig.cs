using Il2CppDummyDll;

[Token(Token = "0x2000204")]
public class InputsConfig : BaseConfig<InputsConfig>
{
	[Token(Token = "0x4000BAB")]
	[FieldOffset(Offset = "0x30")]
	[Setting]
	public bool SnapToEnabled;

	[Token(Token = "0x4000BAC")]
	[FieldOffset(Offset = "0x34")]
	[Setting]
	public float SnapToMinDistance;

	[Token(Token = "0x4000BAD")]
	[FieldOffset(Offset = "0x38")]
	[Setting]
	public bool UseQuickPinchZoomIn;

	[Token(Token = "0x4000BAE")]
	[FieldOffset(Offset = "0x39")]
	[Setting]
	public bool UseQuickPinchZoomOut;

	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0xB1344C", Offset = "0xB1344C", VA = "0xB1344C")]
	public InputsConfig()
	{
	}
}
