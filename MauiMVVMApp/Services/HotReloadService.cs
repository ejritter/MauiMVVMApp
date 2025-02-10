#if DEBUG
[assembly:System.Reflection.Metadata.MetadataUpdateHandlerAttribute(typeof(MauiMVVMApp.Services.HotReloadService))]
namespace MauiMVVMApp.Services;
public static class HotReloadService
{
    public static event Action<Type[]?>? UpdateApplicationEvent;

    internal static void ClearCache(Type[]? types) { }

    internal static void UpdateApplication(Type[]? types)
    {
        UpdateApplicationEvent?.Invoke(types);
    }
}
#endif