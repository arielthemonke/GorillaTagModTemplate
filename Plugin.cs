using System;
using BepInEx;
using UnityEngine;

namespace GTPlugin
{
    // This is the main plugin class. It is the entry point of the plugin, put your main code here
    [BepInPlugin(PluginInfo.GUID, PluginInfo.ProjectName, PluginInfo.Version)]
    public class Plugin
    {
        bool inAllowedRoom;
        void Start()
        {
            // Just use OnGameInitialized() it is better
            Utilla.Events.GameInitialized += OnGameInitialized;
        }

        void OnGameInitialized(object sender, EventArgs e)
        {
            // This is called when the game is initialized
            Debug.Log("This example mod has been loaded!");
        }

        void Update()
        {
            // This is called every frame
            if (NetworkSystem.Instance.GameModeString.Contains("MODDED"))
            {
                inAllowedRoom = true;
            }
            else
            {
                inAllowedRoom = false;
            }


            if (inAllowedRoom == true)
            {
                // Activate your mod here
            }
            else
            {
                // Deactivate your mod here
            }
        }
    }
}
