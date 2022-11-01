﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Scoop_Store
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            Window1 window1 = new Window1();
            initScoop();
            InitializeComponent();
            mainGrid.Background = mijnKleuren.bgCol;
            mainLabel.Foreground = mijnKleuren.nordTheme.Nord10;
            officeBlock.Foreground = mijnKleuren.nordTheme.Nord10;
            prodBlock.Foreground = mijnKleuren.nordTheme.Nord10;
            kantoorBlock.Foreground = mijnKleuren.nordTheme.Nord10;
            roundedBorder.Background = mijnKleuren.bgCol;
            firefoxInstall.Background = mijnKleuren.bgCol;
            firefoxInstall.Foreground = mijnKleuren.fgCol;

            // Firefox
            if (Directory.Exists("C:\\Users\\" + Environment.UserName + "\\scoop\\apps\\firefox"))
            { firefoxInstall.Content = "Firefox: Geinstalleerd"; }
            else { firefoxInstall.Content = "Firefox: Installeer"; }
        }

        // Scoop Setup

        static void initScoop()
        {
            Window1 window1 = new Window1();
            string currentUsername = Environment.UserName;
            if (Directory.Exists("C:\\Users\\" + currentUsername + "\\scoop"))
            {
                Console.WriteLine("Test Success!");
            }
            else
            {
                window1.Show();
                var backendInstallFile = @"scripts\\installScoopBackend.ps1";
                var backendInstall = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-ExecutionPolicy RemoteSigned -file \"{backendInstallFile}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                var backendProcess = Process.Start(backendInstall);
                backendProcess.WaitForExit();

                var postInstallFile = @"scripts\\installPostDependincies.ps1";
                var postInstall = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-ExecutionPolicy RemoteSigned -file \"{postInstallFile}\"",
                    UseShellExecute = false, CreateNoWindow = true
                };
                var postProcess = Process.Start(postInstall);
                postProcess.WaitForExit();
                window1.Close();
            }

        }


        public class mijnKleuren
        {
            public static Brush bgCol = mijnKleuren.nordTheme.Nord0;
            public static Brush fgCol = mijnKleuren.nordTheme.Nord4;
            public static Brush cursorCol = mijnKleuren.nordTheme.Nord4;

            public class nordTheme
            {
                public static Brush Nord0 = new SolidColorBrush(Color.FromRgb(46, 52, 64));
                public static Brush Nord1 = new SolidColorBrush(Color.FromRgb(59, 66, 82));
                public static Brush Nord2 = new SolidColorBrush(Color.FromRgb(67, 76, 94));
                public static Brush Nord3 = new SolidColorBrush(Color.FromRgb(76, 86, 106));
                public static Brush Nord4 = new SolidColorBrush(Color.FromRgb(216, 222, 233));
                public static Brush Nord5 = new SolidColorBrush(Color.FromRgb(229, 233, 240));
                public static Brush Nord6 = new SolidColorBrush(Color.FromRgb(236, 239, 244));
                public static Brush Nord7 = new SolidColorBrush(Color.FromRgb(143, 188, 187));
                public static Brush Nord8 = new SolidColorBrush(Color.FromRgb(136, 192, 208));
                public static Brush Nord9 = new SolidColorBrush(Color.FromRgb(129, 161, 193));
                public static Brush Nord10 = new SolidColorBrush(Color.FromRgb(94, 129, 172));
                public static Brush Nord11 = new SolidColorBrush(Color.FromRgb(191, 97, 106));
                public static Brush Nord12 = new SolidColorBrush(Color.FromRgb(208, 135, 112));
                public static Brush Nord13 = new SolidColorBrush(Color.FromRgb(235, 203, 139));
                public static Brush Nord14 = new SolidColorBrush(Color.FromRgb(163, 190, 140));
                public static Brush Nord15 = new SolidColorBrush(Color.FromRgb(180, 142, 173));
            }
        }

        private void firefoxInstall_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists("C:\\Users\\" + Environment.UserName + "\\scoop\\apps\\firefox"))
            {
                firefoxInstall.Content = "Firefox: Geinstalleerd";
                var firefoxUninstall = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-ExecutionPolicy RemoteSigned scoop uninstall firefox",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                };
                Process.Start(firefoxUninstall);
                firefoxInstall.Content = "Firefox: Installeer";
            } else
            {
                var firefoxInstaller = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-ExecutionPolicy RemoteSigned scoop install firefox",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                };
                Process.Start(firefoxInstaller);
                firefoxInstall.Content = "Firefox: Geinstalleerd";
            } 
        }
   


    }

   }