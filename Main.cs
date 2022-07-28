using MelonLoader;
using HarmonyLib;
using UnityEngine;
using ABI_RC.Core.Player;
using DarkRift;
using System.IO;
using System.Net;
using RootMotion.FinalIK;
using ABI_RC.Core.Networking;
using System;
using System.Linq;

namespace CVRKeyBinds
{
    public static class BuildInfo
    {
        public const string Name = "CVRKB"; 
        public const string Description = "Mod for Testing"; 
        public const string Author = "Lenoob and CVRMG"; 
        public const string Company = "CVRMG"; 
        public const string Version = "1.0.0"; 
        public const string DownloadLink = null;
    }

    public class CVRKeyBinds : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("\n CTRL + F to fly \n CTRL + LEFTCLICK to TP");
        }
        public override void OnUpdate()
        {
           // if (Input.GetKeyDown(KeyCode.Space) && )
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Mouse1))
            {
                Ray r = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
                RaycastHit rhit;
                bool IsHit = Physics.Raycast(r, out rhit);
                if (IsHit)
                {
                   ABI_RC.Systems.MovementSystem.MovementSystem.Instance.TeleportTo(rhit.point);
                }
            }
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F))
            {
                ABI_RC.Systems.MovementSystem.MovementSystem.Instance.ToggleFlight();
            }
        }
     
    }
}
