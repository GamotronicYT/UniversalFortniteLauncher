using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using FortniteUniversalLauncher.injector;
using System.Collections;
using System.Threading;
using System.Text.RegularExpressions;
using FortniteUniversalLauncher.Properties;
namespace FortniteUniversalLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Settings.Default.fn;
            textBox2.Text = Settings.Default.dll1;
            textBox3.Text = Settings.Default.dll2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (textBox2.Text == null)
                {
                    MessageBox.Show("You Need to give a Dll1 patch");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("You Need to give a Dll1 patch");
                }
                else
                {
                    if (textBox1.Text == null)
                    {
                        Settings.Default["fn"] = textBox1.Text;
                        Settings.Default.Save();
                        Settings.Default["fns1"] = textBox4.Text;
                        Settings.Default.Save();
                        Settings.Default["dll1"] = textBox2.Text;
                        Settings.Default.Save();
                        Settings.Default["dll2"] = textBox3.Text;
                        Settings.Default.Save();
                        Process process3 = StartProcess(textBox4.Text + "/FortniteClient-Win64-Shipping.exe", false, "");
                        process3.WaitForInputIdle();
                        base.Hide();
                        if (textBox2.Text == null)
                        {
                            inject.InjectDll(process3.Id, textBox2.Text);
                            MessageBox.Show("Injected Dll1");
                        }
                        else if (textBox2.Text == "")
                        {
                            inject.InjectDll(process3.Id, textBox2.Text);
                            MessageBox.Show("Injected Dll1");
                        }
                        else
                        {
                            inject.InjectDll(process3.Id, textBox2.Text);
                            inject.InjectDll(process3.Id, textBox3.Text);
                            MessageBox.Show("Injected Dll1 and Dll2");
                        }

                        process3.WaitForExit();
                        base.Show();
                    }
                    else if (textBox1.Text == "")
                    {
                        Settings.Default["fn"] = textBox1.Text;
                        Settings.Default.Save();
                        Settings.Default["fns1"] = textBox4.Text;
                        Settings.Default.Save();
                        Settings.Default["dll1"] = textBox2.Text;
                        Settings.Default.Save();
                        Settings.Default["dll2"] = textBox3.Text;
                        Settings.Default.Save();
                        Process process3 = StartProcess(textBox4.Text + "/FortniteClient-Win64-Shipping.exe", false, "");
                        process3.WaitForInputIdle();
                        base.Hide();
                        if (textBox2.Text == null)
                        {
                            inject.InjectDll(process3.Id, textBox2.Text);
                            MessageBox.Show("Injected Dll1");
                        }
                        else if (textBox2.Text == "")
                        {
                            inject.InjectDll(process3.Id, textBox2.Text);
                            MessageBox.Show("Injected Dll1");
                        }
                        else
                        {
                            inject.InjectDll(process3.Id, textBox2.Text);
                            inject.InjectDll(process3.Id, textBox3.Text);
                            MessageBox.Show("Injected Dll1 and Dll2");
                        }

                        process3.WaitForExit();
                        base.Show();
                    }
                    else
                    {
                        Settings.Default["fn"] = textBox1.Text;
                        Settings.Default.Save();
                        Settings.Default["fns1"] = textBox1.Text;
                        Settings.Default.Save();
                        Settings.Default["dll1"] = textBox2.Text;
                        Settings.Default.Save();
                        Settings.Default["dll2"] = textBox3.Text;
                        Settings.Default.Save();
                        Process process = StartProcess(textBox1.Text + "/FortniteGame/Binaries/Win64/FortniteLauncher.exe", true, "-NOSSLPINNING");
                        Process process2 = StartProcess(textBox1.Text + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping_BE.exe", true, "");
                        Process process3 = StartProcess(textBox1.Text + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping.exe", false, "");
                        process3.WaitForInputIdle();
                        base.Hide();
                        if (textBox2.Text == null)
                        {
                            inject.InjectDll(process3.Id, textBox2.Text);
                            MessageBox.Show("Injected Dll1");
                        }
                        else if (textBox2.Text == "")
                        {
                            inject.InjectDll(process3.Id, textBox2.Text);
                            MessageBox.Show("Injected Dll1");
                        }
                        else
                        {
                            inject.InjectDll(process3.Id, textBox2.Text);
                            inject.InjectDll(process3.Id, textBox3.Text);
                            MessageBox.Show("Injected Dll1 and Dll2");
                        }

                        process3.WaitForExit();
                        process.Kill();
                        process2.Kill();
                        base.Show();
                    }
                }
        }
        public static Process StartProcess(string path, bool shouldFreeze, string extraArgs = "")
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = path,
                    Arguments = $"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -noeac -fromfl=be -fltoken=5dh74c635862g575778132fb -skippatchcheck" + extraArgs
                }
            };
            process.Start();
            if (shouldFreeze)
            {
                foreach (object obj in process.Threads)
                {
                    ProcessThread thread = (ProcessThread)obj;
                    Win32.SuspendThread(Win32.OpenThread(2, false, thread.Id));
                }
            }
            return process;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("MicrosoftEdge.exe", "https://discord.gg/kzDTDsSmEs");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
