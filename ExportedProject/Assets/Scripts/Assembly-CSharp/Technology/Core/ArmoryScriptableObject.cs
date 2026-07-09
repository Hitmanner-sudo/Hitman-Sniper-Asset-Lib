using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C61")]
	public abstract class ArmoryScriptableObject<T> : ScriptableObjectWithPath where T : ScriptableObjectWithPath, new()
	{
		[Token(Token = "0x170009DC")]
		public static T Instance
		{
			[Token(Token = "0x6004D72")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D73")]
		public override string GetScriptableObjectPath()
		{
			return null;
		}

		[Token(Token = "0x6004D74")]
		protected ArmoryScriptableObject()
		{
		}
	}
}
