using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x2000A01")]
	public interface IConflictResolver
	{
		[Token(Token = "0x6003F57")]
		void ChooseMetadata(ISavedGameMetadata chosenMetadata);

		[Token(Token = "0x6003F58")]
		void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData);
	}
}
