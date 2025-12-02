using AutodjaOmanikud.Models;
using System;
using System.Windows.Forms;

namespace _2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}