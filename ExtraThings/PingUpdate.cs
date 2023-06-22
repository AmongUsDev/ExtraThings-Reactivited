using HarmonyLib;

namespace ExtraThings
{
    [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
    public static class PingUpdateTracker
    {
        public static void Postfix(PingTracker __instance)
        {
            if (!MeetingHud.Instance)
            {
                __instance.text.text += $"\n<color=#00fff3>ExtraThings v{ExtraThingsPlugin.Version} created by Om3ga continued by AmongUsDev</color>";
            }

             if (LobbyBehaviour.Instance)
           {
                 __instance.text.text += $"\n<color=#ff0000>Continued by AmongUsDev</color>";   
                 __instance.text.UpdateFontAsset();
           }            
        }
    }
}
