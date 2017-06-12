using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWRP_Backupper
{
    public partial class Form1 : Form
    {

        
        
       
        

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "ZIP|*.zip|RAR|*.rar";
            
            saveFileDialog1.Title = "Save Backup";
            DialogResult result = saveFileDialog1.ShowDialog();
         
            
            if (result == DialogResult.OK)
            {
                
                string saveFile = saveFileDialog1.FileName;
                try
                {
                    if (MessageBox.Show("Do you wanna compress?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var proc = new Process
                        {
                            StartInfo = new ProcessStartInfo                                                                
                            {
                                FileName = "adb.exe",
                                Arguments = "backup " + saveFile + "--twrp system cache data boot --compress",
                                UseShellExecute = false,
                                RedirectStandardOutput = true,
                                CreateNoWindow = false
                            }
                        };
                        proc.Start();
                        while (!proc.StandardOutput.EndOfStream)
                        {
                            string line = proc.StandardOutput.ReadLine();
                            Console.WriteLine(line);
                            
                        }
                    }
                    else
                    {
                        var proc = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "adb.exe",
                                Arguments = "backup " + saveFile + "--twrp system cache data boot",
                                UseShellExecute = false,
                                RedirectStandardOutput = true,
                                CreateNoWindow = false
                            }
                        };
                        proc.Start();
                        while (!proc.StandardOutput.EndOfStream)
                        {
                            string line = proc.StandardOutput.ReadLine();
                            Console.WriteLine(line);

                        }
                    }
                    Console.WriteLine(saveFile);

                   
                   
                }
                catch (IOException)
                {
                } 
            }
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reboot to recovery?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "adb.exe",
                        Arguments = "reboot recovery",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = false
                    }
                };
                proc.Start();
                while (!proc.StandardOutput.EndOfStream)
                {
                    string line = proc.StandardOutput.ReadLine();
                    Console.WriteLine(line);

                }
            }
            else
            {
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "ZIP|*.zip|RAR|*.rar";

            saveFileDialog1.Title = "Save Backup";
            DialogResult result = saveFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {

                string saveFile = saveFileDialog1.FileName;
                try
                {
                    if (MessageBox.Show("Do you wanna compress?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var proc = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "adb.exe",
                                Arguments = "backup " + saveFile + "--twrp data --compress",
                                UseShellExecute = false,
                                RedirectStandardOutput = true,
                                CreateNoWindow = false
                            }
                        };
                        proc.Start();
                        while (!proc.StandardOutput.EndOfStream)
                        {
                            string line = proc.StandardOutput.ReadLine();
                            Console.WriteLine(line);

                        }
                    }
                    else
                    {
                        var proc = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "adb.exe",
                                Arguments = "backup " + saveFile + "--twrp data",
                                UseShellExecute = false,
                                RedirectStandardOutput = true,
                                CreateNoWindow = false
                            }
                        };
                        proc.Start();
                        while (!proc.StandardOutput.EndOfStream)
                        {
                            string line = proc.StandardOutput.ReadLine();
                            Console.WriteLine(line);

                        }
                    }
                    Console.WriteLine(saveFile);



                }
                catch (IOException)
                {
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "ZIP|*.zip|RAR|*.rar";

            saveFileDialog1.Title = "Save Backup";
            DialogResult result = saveFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {

                string saveFile = saveFileDialog1.FileName;
                try
                {
                    if (MessageBox.Show("Do you wanna compress?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var proc = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "adb.exe",
                                Arguments = "backup " + saveFile + "--twrp system --compress",
                                UseShellExecute = false,
                                RedirectStandardOutput = true,
                                CreateNoWindow = false
                            }
                        };
                        proc.Start();
                        while (!proc.StandardOutput.EndOfStream)
                        {
                            string line = proc.StandardOutput.ReadLine();
                            Console.WriteLine(line);

                        }
                    }
                    else
                    {
                        var proc = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "adb.exe",
                                Arguments = "backup " + saveFile + "--twrp system",
                                UseShellExecute = false,
                                RedirectStandardOutput = true,
                                CreateNoWindow = false
                            }
                        };
                        proc.Start();
                        while (!proc.StandardOutput.EndOfStream)
                        {
                            string line = proc.StandardOutput.ReadLine();
                            Console.WriteLine(line);

                        }
                    }
                    Console.WriteLine(saveFile);



                }
                catch (IOException)
                {
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "ZIP|*.zip|RAR|*.rar";

            saveFileDialog1.Title = "Save Backup";
            DialogResult result = saveFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {

                string saveFile = saveFileDialog1.FileName;
                try
                {
                    if (MessageBox.Show("Do you wanna compress?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var proc = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "adb.exe",
                                Arguments = "backup " + saveFile + "--twrp boot --compress",
                                UseShellExecute = false,
                                RedirectStandardOutput = true,
                                CreateNoWindow = false
                            }
                        };
                        proc.Start();
                        while (!proc.StandardOutput.EndOfStream)
                        {
                            string line = proc.StandardOutput.ReadLine();
                            Console.WriteLine(line);

                        }
                    }
                    else
                    {
                        var proc = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "adb.exe",
                                Arguments = "backup " + saveFile + "--twrp boot",
                                UseShellExecute = false,
                                RedirectStandardOutput = true,
                                CreateNoWindow = false
                            }
                        };
                        proc.Start();
                        while (!proc.StandardOutput.EndOfStream)
                        {
                            string line = proc.StandardOutput.ReadLine();
                            Console.WriteLine(line);

                        }
                    }
                    Console.WriteLine(saveFile);



                }
                catch (IOException)
                {
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "ZIP|*.zip|RAR|*.rar";

            saveFileDialog1.Title = "Save Backup";
            DialogResult result = saveFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {

                string saveFile = saveFileDialog1.FileName;
              
              
                        var proc = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "adb.exe",
                                Arguments = "restore " + saveFile,
                                UseShellExecute = false,
                                RedirectStandardOutput = true,
                                CreateNoWindow = false
                            }
                        };
                        proc.Start();
                        while (!proc.StandardOutput.EndOfStream)
                        {
                            string line = proc.StandardOutput.ReadLine();
                            Console.WriteLine(line);

                        }
                    
                   


                
              
            }
        }
    }
}
