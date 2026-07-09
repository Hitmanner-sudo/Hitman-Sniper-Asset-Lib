using Il2CppDummyDll;

[Token(Token = "0x20001DD")]
public class ChaosBonusConfig : BaseConfig<ChaosBonusConfig>
{
	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PATH;

	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x30")]
	public AlternateGameObject[] AlternateGameObjects;

	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x38")]
	public CalenderModel.AlternateTexture[] AlternateTextures;

	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x40")]
	public CalenderModel.AlternateMaterial[] AlternateMaterials;

	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x48")]
	public CalenderModel.AlternateSoundContainer[] AlternateSoundContainers;

	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0xAF9110", Offset = "0xAF9110", VA = "0xAF9110")]
	public ChaosBonusConfig()
	{
	}
}
