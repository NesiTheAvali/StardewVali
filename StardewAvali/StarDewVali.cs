
using StardewModdingAPI;
namespace StardewAvali
{
    public class ModEntry : Mod, IAssetLoader
    {
        public bool CanLoad<T>(IAssetInfo asset)
        {
            return asset.AssetNameEquals("Characters/Farmer/farmer_girl_base_bald") || asset.AssetNameEquals("Characters/Farmer/farmer_girl_base");
        }

        public override void Entry(IModHelper helper)
        {

        }

        public T Load<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Characters/Farmer/farmer_girl_base_bald") || asset.AssetNameEquals("Characters/Farmer/farmer_girl_base")) {
                return Helper.Content.Load<T>("assets/avali.png",ContentSource.ModFolder);
            }
            return default(T);
            /*
            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
            */
        }
    }
}
