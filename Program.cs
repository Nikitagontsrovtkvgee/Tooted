using AutodjaOmanikud.Models;
using System;
using System.Windows.Forms;

namespace AutodjaOmanikud.Models
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