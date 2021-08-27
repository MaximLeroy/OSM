﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSMaker.Classes
{
    class standbox
    {
        // This contain some unclassable fonctions names for OSMaker

        public class oscpc
        {
            // OS informations
            public string os_name;
            public string os_SystemName;
            public string MediaPath;
            public string AutorsNames;
            public string CompagnyName;
            public string CreationDate;

            // Screen dekstop
            public bool Resolution_auto;
            public string Resolution;
            public string Resolution_bit;

            public string Background_image;
            public int Background_Color_R;
            public int Background_Color_G;
            public int Background_Color_B;

            public bool DesktopIcons;


        }
        public static string Generate_OS_CPC_contentfile(oscpc OSCPC)
        {
            // This allow to create OS.CPC content file with informations

            return
                @"// ** OS.CPC file generated by OSMaker **" + "\r\n" +
                @"" + "\r\n" +
                @"// Load default gui profile (obligatory)" + "\r\n" +
                @"exe/ & %CPC.REP.KRNL%/CONFIG/ENV_GUI/env_gui.cpc" + "\r\n" +

                @"" + "\r\n" +
                @"// Screen informations" + "\r\n" +
                @"set/ SCR_Auto = " + OSCPC.Resolution_auto.ToString().ToLower() +"\r\n" +
                "if/ \"%SCR_Auto%\" == \"true\" then:" +"\r\n" +
                    "\t// set/ SCR_RES = /f:cpc.check_best_resolution()" + "\r\n" +
                    "\t// set/ SCR_BIT = /f:cpc.check_best_resolution_color()" + "\r\n" +
                @"else:" + "\r\n" +
                    "\tset/ SCR_RES = " + OSCPC.Resolution + "\r\n" +
                    "\tset/ SCR_BIT = " + OSCPC.Resolution_bit + "\r\n" +
                @"end/ if" + "\r\n" +
                @"" + "\r\n" +
                @"// Default background color" + "\r\n" +
                @"SET / SCR_COLOR = " + OSCPC.Background_Color_R.ToString("D3") + "," + OSCPC.Background_Color_G.ToString("D3") + "," + OSCPC.Background_Color_B.ToString("D3") + "\r\n" +
                @"" + "\r\n" +
                @"ccp/ /set.level = 4" + "\r\n" +
                @"" + "\r\n" +
                @"" + "\r\n" +

                @"// **************************************************" + "\r\n" +
                @"// ** [EN] Operating system informations           **" + "\r\n" +
                @"// ** [FR] Informations du systeme d'exploitation  **" + "\r\n" +
                @"// **************************************************" + "\r\n" +
                @"" + "\r\n" +
                @"set/ OS_NAME = " + OSCPC.os_name + "" + "\r\n" +
                @"set/ OS_Author = " + OSCPC.AutorsNames + "\r\n" +
                @"set/ OS_Compagny = " + OSCPC.CompagnyName + "\r\n" +
                @"set/ OS_Created = " + OSCPC.CreationDate + "\r\n" +
                @"set/ OS_Updated = " + OSCPC.CreationDate + "\r\n" +
                @"" + "\r\n" +
                @"" + "\r\n" +
                @"// ***************************************************" + "\r\n" +
                @"// ** [EN] Operating system configuration           **" + "\r\n" +
                @"// ** [FR] Configuration du systeme d'exploitation  **" + "\r\n" +
                @"// ***************************************************" + "\r\n" +
                @"" + "\r\n" +
                @"set/ HOST_OS = OS/" + OSCPC.os_SystemName + "\r\n" +
                @"set/ GUI_OS = " + OSCPC.MediaPath + "\r\n" +
                @"" + "\r\n" +
                @"// Background image" + "\r\n" +
                @"set/ SCR_IMG = " + OSCPC.Background_image + "\r\n" +
                @"" + "\r\n" +
                @"// Screenshot folder" + "\r\n" +
                @"set/ SCR_SAVE = %CPC_TEMP%/SCR" + "\r\n" +
                @"" + "\r\n" +
                @"// ******************************************************" + "\r\n" +
                @"// ** [EN] Starting Graphic User Interface             **" + "\r\n" +
                @"// ** [FR] Demarrer l'interface utilisateur graphique  **" + "\r\n" +
                @"// ******************************************************" + "\r\n" +
                @"gui/ " + "\r\n" +
                @"" + "\r\n" +
                @"// Load icon on GUI" + "\r\n" +
                @"sys/ /fileformat-gui-load" + "\r\n";
        }


        public static bool IsValidPath(string path, bool allowRelativePaths = false)
        {
            bool isValid = true;

            try
            {
                string fullPath = Path.GetFullPath(path);

                if (allowRelativePaths)
                {
                    isValid = Path.IsPathRooted(path);
                }
                else
                {
                    string root = Path.GetPathRoot(path);
                    isValid = string.IsNullOrEmpty(root.Trim(new char[] { '\\', '/' })) == false;
                }
            }
            catch (Exception ex)
            {
                isValid = false;
            }

            return isValid;
        }

        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }
    }
}
