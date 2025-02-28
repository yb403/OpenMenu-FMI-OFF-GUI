using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using idaaxopenmenu;
using idaaxopenmenu.Properties;



namespace openmenuAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string v = this.version();
            bool flag = v != "_";
            if (flag)
            {
                if (v=="ERROR"){MessageBox.Show("ERROR , connecting to the server failed!"); Environment.Exit(0); }

                MessageBox.Show("Update available , please download latest Version!");
                openLink(v);
                Environment.Exit(0);
            }
            this.InitializeComponent();
            Form1.RunAntiDebug();
            this.startWatch();
        }

        private string version()
        {
            string text3;
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = ValidateServerCertificate;
                string text = "https://api.idaaxtools.com/config?v=1";
                HttpWebRequest httpWebRequest = WebRequest.CreateHttp(text);
                httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                httpWebRequest.Timeout = -1;
                string text2;
                using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        text2 = streamReader.ReadToEnd();
                    }
                }
                text3 = text2;
            }
            catch
            {
                text3 = "ERROR";
            }
            return text3;
        }
        private ManagementEventWatcher managementEventWatcher_1;
        private ManagementEventWatcher managementEventWatcher_2;
        public void startWatch()
        {
            WqlEventQuery wqlEventQuery1 = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
            WqlEventQuery wqlEventQuery2 = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
            this.managementEventWatcher_1 = new ManagementEventWatcher(wqlEventQuery1);
            this.managementEventWatcher_1.EventArrived += this.readhello_DoWork;
            this.managementEventWatcher_1.Start();
            this.managementEventWatcher_2 = new ManagementEventWatcher(wqlEventQuery2);
            this.managementEventWatcher_2.EventArrived += this.readhello_DoWork;
            this.managementEventWatcher_2.Start();
            this.readhello_DoWork();

        }

        public string DeviceInfo(string Info)
        {
            string text = "@echo off\nwinx64\\ideviceinfo.exe | winx64\\grep.exe -w " + Info + " | winx64\\awk.exe '{printf $NF}'";
            File.WriteAllText("winx64\\Info.cmd", text);
            Process process = new Process();
            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "winx64\\Info.cmd",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            process.Start();
            StreamReader standardOutput = process.StandardOutput;
            return standardOutput.ReadToEnd();
        }

        public static void AntiDebug(object object_0)
        {
            string[] array = new string[]
            {
                "codecracker", "x32dbg", "HTTP Toolkit","x64dbg", "charles", "dnspy", "simpleassembly", "peek", "httpanalyzer", "httpdebug",
                "fiddler", "wireshark", "devirt", "logger", "usbtrace", "usbmonitor", "serialmonitor", "ilspy", "charlesproxy", "fiddler",
                "postman", "extremedumper", "ollydbg", "softice", "dotpeek", "jetbrains", "proxysite", "Postman", "WireShark", "Charles",
                "Progress Telerik Fiddler Web Debugger", "Fiddler", "Fiddler Everywhere", "HTTPDebuggerUI", "KsDumperClient", "ExtremeDumper", "Proxifier", "dotPeek32", "dotPeek64", "JetBrains dotPeek",
                "HttpAnalyzerStdV7", "Proxifier", "x32dbg", "x64dbg", "Simple Assembly Explorer", "logger", "USBTrace", "ChmDecompiler",
                "PE Explorer", "VBDecompiler", "Docklight", "Reflector", "ExtremeDumper", "ILSpy", "OLLYDBG", "SoftICE", "softice", "jetbrains",
                "Codecracker", "Proxysite", "Spices.Net", "JustDecompile", "Cutter", "DbgX.Shell", "The debugger", "Easy Proxy Finder", "Proxy Finder Premium", "Proxy Finder",
                "Proxy Finder Premium", "Proxy Finder Enterprise", "Easy Proxy Finder", "Proxifier Portable", "Proxy Finder Premium", "ProxyFinder", "Jackett", "winfoom", "LightProxy", "winfoom",
                "Jackett", "Clashy", "GSA Proxy Scraper", "XX-Net", "Go dispatch proxy", "Proxifier", "Reversee", "LocalXpose", "SniffingProxies", "Forum Proxy Leecher",
                "RSocks Proxy Checker", "SQLi Dumper", "URL Analyzer", "Dump SQL", "File Dumper", "HEADMasterSEO", "WinAutomation Professional Plus", "ChrisPC Anonymous Proxy Pro", "AS3 Sorcerer", "Oxygen XML Editor",
                "JP Software Take Command", "IntraWeb Ultimate Edition", "Devart LINQ Insigh", "MAMP PRO", "HTTPDebuggerUI", "Debugger", "CMDebug IDE/Debugger", "CMDebug", "Python ida", "python",
                "pythonw",  "powershell", "putty", "WebSurge", "WebSurge", "MIHTool Pro", "EKFiddle", "HookDump", "hookdump",
                "Debugging Generic Web", "Debug Configurations", "Debugging web services", "firebug", "Firefox", "FireBug", "GDB", "Syser Debugger", "advanced_ip_scanner", "ipscan221",
                "Angry IP Scanner", "fping", "fping 5.0", "Pinkie", "npcap", "npcap_wfp", "Network Performance Monitoring", "OpManager Monitoring", "OpManager", "PingPlotter",
                "fbserver", "iphostmonitor", "Monitor. Visualize. Relax.", "Monitor Visualize", "PRTG Network Monitor", "Network Monitor", "Engineer's Toolset", "engineers-toolset", "toolset", "NetScanTools Pro",
                "NMapWin", "superpinger", "nbthostmonitor", "BlueCat Address Manager", "Angry IP Scanner", "Solarwinds IP Control Bundle", "Solarwinds", "Nessus", "Nessus-8", "OpenVAS",
                "openvas", "advanced IP manager", "IP Address Manager", "TCP Port Scan", "ipscan", "netscanner", "spiceworks", "SolarWinds Port Scanner", "solarWinds", "ManageEngine OpUtils",
                "manageengine", "SolarWinds Ping Sweep", "SolarWinds", "MyLAN Viewer", "MyLAN", "oid2name", "postgres", "opsrv", "pg_archivecleanup", "pg_basebackup",
                "pg_config", "pg_controldata", "pg_ctl", "pg_dump", "pg_dumpall", "pg_isolation_regress", "pg_isready", "pg_receivexlog", "pg_recvlogical", "pg_regress",
                "pg_regress_ecpg", "pg_resetxlog", "pg_restore", "pg_rewind", "pg_standby", "pg_test_fsync", "pg_test_timing", "pg_upgrade", "pg_xlogdump", "pgAdmin3",
                "pgbench", "psql", "postgres", "reindexdb", "vacuumdb", "vacuumlo", "zic", "clusterdb", "createdb", "createlang",
                "createuser", "dropdb", "droplang", "dropuser", "ecpg", "initdb", "isolationtester", "CV", "netscan", "Privacy Reviver",
                "PortForwardNetworkUtilities", "Nsauditor", "MyLanViewer", "findmac", "IP Scan", "gsam", "Complete Internet Repair", "idevicedebug", "procmon64", "codecracker",
                "x96dbg", "pizza", "pepper", "reverse", "reversal", "de4dot", "pc-ret", "crack", "ILSpy", "x32dbg",
                "sharpod", "x64dbg", "x32_dbg", "x64_dbg", "dbg", "strongod", "PhantOm", "titanHide", "scyllaHide", "ilspy",
                "graywolf", "simpleassemblyexplorer", "MegaDumper", "megadumper", "X64NetDumper", "x64netdumper", "HxD", "hxd", "PETools", "petools",
                "Protection_ID", "protection_id", "die", "process hacker 2", "process", "hacker", "ollydbg", "x32dbg", "x64dbg",
                "charles", "dnspy", "simpleassembly", "peek", "httpanalyzer", "httpdebug", "fiddler", "wireshark", "proxifier", "mitmproxy",
                "process hacker", "process monitor", "process hacker 2", "system explorer", "systemexplorer", "systemexplorerservice", "WPE PRO", "ghidra", "folderchangesview", "pc-ret",
                "folder", "dump", "web proxy", "de4dotmodded", "StringDecryptor", "Centos", "SAE", "monitor", "brute", "checker",
                "zed", "sniffer", "http", "debugger", "james", "exeinfope", "codecracker", "x32dbg", "x64dbg", "ollydbg",
                 "charles", "dnspy", "simpleassembly", "peek", "httpanalyzer", "httpdebug", "fiddler", "wireshark", "dbx",
                "mdbg", "gdb", "windbg", "dbgclr", "kdb", "kgdb", "mdb", "PrivacyReviver", "PacDbg", "taskmgr",
                "Task Manager DeLuxe"
            };
            for (; ; )
            {
                try
                {
                    foreach (Process process in Process.GetProcesses())
                    {
                        bool flag = process != Process.GetCurrentProcess();
                        if (flag)
                        {
                            for (int j = 0; j < array.Length; j++)
                            {
                                int id = Process.GetCurrentProcess().Id;
                                bool flag2 = process.ProcessName.ToLower().Contains(array[j]);
                                if (flag2)
                                {
                                    process.Kill();
                                }
                                bool flag3 = process.MainWindowTitle.ToLower().Contains(array[j]);
                                if (flag3)
                                {
                                    process.Kill();
                                }
                            }
                            bool flag4 = process.ProcessName == "Task Manager DeLuxe x64" || process.ProcessName.Contains("Task Manager DeLuxe");
                            if (flag4)
                            {
                                process.Kill();
                            }
                            bool flag5 = process.ProcessName == "WireShark" || process.ProcessName.Contains("WinSCP");
                            if (flag5)
                            {
                                process.Kill();
                            }
                            bool flag6 = process.ProcessName == "CMDebug" || process.ProcessName.Contains("ipscan");
                            if (flag6)
                            {
                                process.Kill();
                            }
                            bool flag7 = process.ProcessName == "Progress Telerik Fiddler Web Debugger" || process.ProcessName == "Fiddler Everywhere";
                            if (flag7)
                            {
                                process.Kill();
                            }
                            bool flag8 = process.ProcessName == "WebSurge" || process.ProcessName.Contains("httpdebug");
                            if (flag8)
                            {
                                process.Kill();
                            }
                            bool flag9 = process.ProcessName == "advanced_ip_scanner" || process.ProcessName.Contains("ipscan221");
                            if (flag9)
                            {
                                process.Kill();
                            }
                            bool flag10 = process.ProcessName == "Pinkie" || process.ProcessName.Contains("PingPlotter");
                            if (flag10)
                            {
                                process.Kill();
                            }
                            bool flag11 = process.ProcessName == "CV" || process.ProcessName.Contains("netscan");
                            if (flag11)
                            {
                                process.Kill();
                            }
                            bool flag12 = process.ProcessName == "Privacy Reviver" || process.ProcessName.Contains("PrivacyReviver");
                            if (flag12)
                            {
                                process.Kill();
                            }
                            bool flag13 = process.ProcessName == "PortForwardNetworkUtilities" || process.ProcessName.Contains("RouterLogin");
                            if (flag13)
                            {
                                process.Kill();
                            }
                            bool flag14 = process.ProcessName == "PortForwardScreenshot" || process.ProcessName.Contains("PFStaticIP");
                            if (flag14)
                            {
                                process.Kill();
                            }
                            bool flag15 = process.ProcessName == "PFScreenshotMessage" || process.ProcessName.Contains("PFRSG");
                            if (flag15)
                            {
                                process.Kill();
                            }
                            bool flag16 = process.ProcessName == "PFRouterDetector" || process.ProcessName.Contains("PFPortChecker");
                            if (flag16)
                            {
                                process.Kill();
                            }
                            bool flag17 = process.ProcessName == "PFConfigSupportTool" || process.ProcessName.Contains("PFConfigHelper");
                            if (flag17)
                            {
                                process.Kill();
                            }
                            bool flag18 = process.ProcessName == "PFConfig" || process.ProcessName.Contains("Nsauditor");
                            if (flag18)
                            {
                                process.Kill();
                            }
                            bool flag19 = process.ProcessName == "MyLanViewer" || process.ProcessName.Contains("dm.st");
                            if (flag19)
                            {
                                process.Kill();
                            }
                            bool flag20 = process.ProcessName == "Turbo Virtual Machine" || process.ProcessName.Contains("Turbo Virtual Machine Executable");
                            if (flag20)
                            {
                                process.Kill();
                            }
                            bool flag21 = process.ProcessName == "ComIntRep" || process.ProcessName.Contains("ComIntRep_X64");
                            if (flag21)
                            {
                                process.Kill();
                            }
                            bool flag22 = process.ProcessName == "WireShark" || process.MainWindowTitle.Contains("httpanalyzer");
                            if (flag22)
                            {
                                process.Kill();
                            }
                            bool flag23 = process.ProcessName == "CharlesProxy" || process.MainWindowTitle.Contains("CharlesProxy");
                            if (flag23)
                            {
                                process.Kill();
                            }
                            bool flag24 = process.MainWindowTitle == "Progress Telerik Fiddler Web Debugger" || process.ProcessName == "Fiddler Everywhere";
                            if (flag24)
                            {
                                process.Kill();
                            }
                            bool flag25 = process.ProcessName == "Fiddler" || process.MainWindowTitle.Contains("httpdebug");
                            if (flag25)
                            {
                                process.Kill();
                            }
                            bool flag26 = process.ProcessName == "VirtualBox" || process.MainWindowTitle.Contains("VBoxSVC");
                            if (flag26)
                            {
                                process.Kill();
                            }
                            bool flag27 = process.ProcessName == "VBoxSDS" || process.MainWindowTitle.Contains("VBoxSDL");
                            if (flag27)
                            {
                                process.Kill();
                            }
                            bool flag28 = process.ProcessName == "vmware" || process.MainWindowTitle.Contains("VMware Workstation (32 bit)");
                            if (flag28)
                            {
                                process.Kill();
                            }
                            bool flag29 = process.ProcessName == "VMware Workstation" || process.MainWindowTitle.Contains("VMware Workstation (64 bit)");
                            if (flag29)
                            {
                                process.Kill();
                            }
                            bool flag30 = process.ProcessName == "vmplayer" || process.MainWindowTitle.Contains("vmnat");
                            if (flag30)
                            {
                                process.Kill();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
                Thread.Sleep(800);
            }
        }

        public static void RunAntiDebug()
        {
            new Thread(new ParameterizedThreadStart(Form1.AntiDebug)).Start(Thread.CurrentThread);
        }

        private void Checkpair()
        {
            string text = this.libiMobile_0.checkPair();
            bool flag = text.Contains("trust");
            if (flag)
            {
                this.bool_3 = true;
                MessageBox.Show("Turn on the device screen, press the home button or swipe up and press Trust.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.bool_3 = false;
            }
            else
            {
                bool flag2 = text.Contains("passcode");
                if (flag2)
                {
                    this.bool_3 = true;
                    MessageBox.Show("Input the passcode of the device in the device.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.bool_3 = false;
                }
                bool flag3 = text.Contains("with host") || text.Contains("code -7") || text.Contains("unhandled");
                if (flag3)
                {
                    this.bool_3 = true;
                    MessageBox.Show("Turn on the device screen, press the home button or swipe up and press Trust.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.bool_3 = false;
                }
                bool flag4 = text.Contains("not pair");
                if (flag4)
                {
                    this.bool_3 = true;
                    MessageBox.Show("Please reconnect the device to computer then turn on the device screen, press the home button or swipe up and press Trust. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.bool_3 = false;
                }
            }
            try
            {
                Form1.killProcess("idevicepair");
            }
            catch
            {
            }
        }

        public static void killProcess(string process)
        {
            try
            {
                Process[] processesByName = Process.GetProcessesByName(process);
                for (int i = 0; i < processesByName.Length; i++)
                {
                    processesByName[i].Kill();
                }
            }
            catch
            {
            }
        }

        public static bool temz = false;

        public void loadImagetoPicDevice()
        {
            string imageServerApple = this.libiMobile_0.getImageServerApple(this.product);
            try
            {
                using (WebClient webClient = new WebClient())
                {

                    using (MemoryStream memoryStream = new MemoryStream(webClient.DownloadData(imageServerApple)))
                    {
                        this.picDevice.Image = Image.FromStream(memoryStream);
                    }
                }
            }
            catch { }
            using (WebClient webClient = new WebClient())
            {
               
                    using (MemoryStream memoryStream = new MemoryStream(webClient.DownloadData(imageServerApple)))
                    {
                        this.picDevice.Image = Image.FromStream(memoryStream);
                    }
                
              
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _elapsedTime = _elapsedTime.Add(TimeSpan.FromSeconds(1));
            this.Invoke((MethodInvoker)UpdateDisplay);
        }
        private void UpdateDisplay()
        {
            label1.Text = _elapsedTime.ToString(@"hh\:mm\:ss");
        }
        public void StartTimer()
        {
            _elapsedTime = TimeSpan.Zero; // Reset elapsed time
            _timer.Start(); // Start the timer
        }

        public void StopTimer()
        {
            _timer.Stop(); // Stop the timer
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string text = Path.Combine(Environment.CurrentDirectory, "winx64", "img.png");
            pictureBox1.ImageLocation = text;
        }
        private void SafeInvoke(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private async void readhello_DoWork(object sender = null, EventArrivedEventArgs e = null)
        {
            bool flag = this.DeviceInfo("SerialNumber") != "";
            if (flag)
            {
                this.Checkpair();
                this.serial = this.DeviceInfo("SerialNumber");
                this.product = this.DeviceInfo("ProductType");
                this.ios = this.DeviceInfo("ProductVersion");
                this.model = this.libiMobile_0.getDeviceName(this.product);
                this.udid = this.DeviceInfo("UniqueDeviceID");
                this.loadImagetoPicDevice();


                SafeInvoke(() => this.modellb.Text = this.model);
                SafeInvoke(() => this.seriallb.Text = this.serial);
                SafeInvoke(() => this.ioslb.Text = this.ios);
                SafeInvoke(() => this.productlb.Text = this.product);
                SafeInvoke(() => this.udidlb.Text = this.udid);
 
                    SafeInvoke(() => this.button.Enabled = true);
                
 
                    SafeInvoke(() => this.siticoneGradientButton1.Enabled = true);
                double totalgb = libiMobile_0.getTotalDiskCapacityInGB();
                double usedgb = libiMobile_0.getTotalDataAvailableInGB();
                SafeInvoke(() => this.gbUsed.Text = $"{(totalgb - usedgb)}Gb");
                SafeInvoke(() => this.gbTotal.Text = $"{totalgb}Gb");
            }
            else
            {
                string vr = "No Device";
                SafeInvoke(() => this.modellb.Text = vr);
                SafeInvoke(() => this.seriallb.Text = vr);
                SafeInvoke(() => this.ioslb.Text = vr);
                SafeInvoke(() => this.productlb.Text = vr);
                SafeInvoke(() => this.udidlb.Text = vr);
                SafeInvoke(() => this.button.Enabled = false);
                SafeInvoke(() => this.siticoneGradientButton1.Enabled = false);
                SafeInvoke(() => this.gbUsed.Text = "");
                SafeInvoke(() => this.gbTotal.Text = "");
            }
        }

        static string ComputeSha256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        static string enc(string input, string key)
        {
            StringBuilder output = new StringBuilder();
            int keyLength = key.Length;
            for (int i = 0; i < input.Length; i++)
            {
                char inputChar = input[i];
                char keyChar = key[i % keyLength];
                char encryptedChar = (char)(inputChar ^ keyChar);
                output.Append(encryptedChar);
            }
            return output.ToString();
        }

        public static string StringToHexString(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            StringBuilder hexString = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                hexString.AppendFormat("{0:X2}", b);
            }
            return hexString.ToString();
        }
        private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {   string[] TrustedThumbprints =
            {
                "0FC4A21AEFC171F5EDA76DEA48F58D3BE4A23AF1",
                "09B6274C9CDCE988B117A4BE2DB248B90646D334"
            };
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                var cert = certificate as X509Certificate2;
                if (cert != null)
                {
                    foreach (var thumbprint in TrustedThumbprints)
                    {
                        if (cert.Thumbprint.Equals(thumbprint, StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                }
            }

            // Log or handle the validation failure as needed
            return false;
        }
     

        public async Task<string> gsm_check(string c,string TLA = "NULL")
        {
            string sn = this.DeviceInfo("SerialNumber");
            string udid = this.DeviceInfo("UniqueDeviceID");
            long Y = (long)(DateTimeOffset.UtcNow - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds;
            int X = (int)(Y % 100000);
            string encrypted = enc($"{udid}|{sn}|{Y}", $"void main(int x, int y){X}");
            
            string encrbas6 = Convert.ToBase64String(Encoding.UTF8.GetBytes(encrypted));
            using (HttpClient client_T = new HttpClient())
            {
                try
                {
                    ServicePointManager.ServerCertificateValidationCallback = ValidateServerCertificate;
                    string url = "https://api.idaaxtools.com/device";
                    FormUrlEncodedContent formData = new FormUrlEncodedContent(new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("SYN", StringToHexString(encrbas6)),
                        new KeyValuePair<string, string>("ACK", ComputeSha256Hash(encrypted)),
                        new KeyValuePair<string, string>("TLA", TLA),
                    });
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url)
                    {
                        Content = formData
                    };
                    request.Headers.Add("Content", $"{X}");
                    request.Headers.Add("Cache-Control", $"{c}");
                    HttpResponseMessage httpResponseMessage = await client_T.SendAsync(request);
                    HttpResponseMessage response = httpResponseMessage;
                    httpResponseMessage = null;
                    string text = await response.Content.ReadAsStringAsync();
                    string responseBody = text;
                    text = null;
                    if (response.IsSuccessStatusCode)
                    {
                        if (c == "max")
                        {
                           
                            string __ = enc(Encoding.UTF8.GetString(Convert.FromBase64String(responseBody.ToString())), "text.Invoke(new Action(() => text.AppendText(text + Environment.NewLine)));");
                            MessageBox.Show(__.ToString().Replace("<br/>", Environment.NewLine),"FMI OFF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return "";
                        }
                        else if (responseBody == ComputeSha256Hash($"{StringToHexString(encrbas6)} zz@ {ComputeSha256Hash(encrypted)}"))
                            return "idaax99";
                        
                    }
                    else
                    {
                        MessageBox.Show("Error while conecting to servers , Check your network", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    url = null;
                    formData = null;
                    response = null;
                    responseBody = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception throwed while conecting to servers , Check your network", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return "An error occurred: " + ex.Message;
                }
            }
            return "";
        }

        private async void fmioff_DoWork(object sender, DoWorkEventArgs e)
        {
            _timer = new System.Timers.Timer();
            _timer.Interval = 1000; // Timer ticks every 1 second
            _timer.Elapsed += Timer_Tick;

            _elapsedTime = TimeSpan.Zero; // Start with zero elapsed time

             SafeInvoke(() => this.button.Enabled = false);

            SafeInvoke(() => this.siticoneGradientButton1.Enabled = false); 


            StartTimer();

            this.clean();
            bool flag = this.DeviceInfo("SerialNumber") != "";
            if (flag)
            {
                string xaa = await this.gsm_check("no-cache");
                if (xaa == "idaax99")
                {
                    MessageBox.Show("STEPS TO FOLLOW : \nDelete All Photo&App from iPhone \n\n1) Turn OFF & TURN ON Game Center From ICloud\n\n2) Turn ON AirPlane Mode (Disconect Internet From Device)\n\n3) PRESS ok Button", "Please Follow These Steps!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Form1.killProcess("idevicebackup2");
                    string texta = this.libiMobile_0.unsetPWDBackup("123");
                    if (texta.Contains("Invalid password"))
                    {

                        MessageBox.Show("Please change the back up password to 123");
                        SafeInvoke(() => this.button.Enabled = true);
                        StopTimer();
                        SafeInvoke(() => this.siticoneGradientButton1.Enabled = true);
                        return;
                    }


                    Form1.killProcess("idevicebackup2");
                    string text4 = this.libiMobile_0.setPWDBackup();
                    Form1.killProcess("idevicebackup2");
                    Form1.killProcess("plist.dll");
                    bool flag3 = text4.Contains("Backup encryption is already enabled") || text4.Contains("successfully");
                    if (flag3)
                    {


                        this.timer1.Start();
                        this.siticoneProgressBar1.Value = 30;
                        this.backup();
                    }
                    else
                    {
                        bool flag4 = text4.Contains("Device locked");
                        if (flag4)
                        {
                            SafeInvoke(() => this.button.Enabled = true);
                            StopTimer();
                            SafeInvoke(() => this.siticoneGradientButton1.Enabled = true);
                            MessageBox.Show("Please pay attention to the screen and enter the screen lock password to unlock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            MessageBox.Show(text4, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
                else
                {
     
                        SafeInvoke(() => this.button.Enabled = true);
                        SafeInvoke(() => this.siticoneGradientButton1.Enabled = true);
                        StopTimer();
                        MessageBox.Show("Please Register Your Device First with Idaax resellers!!", "not authorized", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        openLink("https://t.me/IdaaxTools");
                }
            }
            else
            {
                MessageBox.Show("No Device Conected ! Please Connect Your Device And Press Trust!");
            }
        }

        private void AppendText(string text)
        {
            if (text != null)
            {
                if (richTextBox1.InvokeRequired)
                {
                    richTextBox1.Invoke(new Action(() => richTextBox1.AppendText(text + Environment.NewLine)));
                }
                else
                {
                    richTextBox1.AppendText(text + Environment.NewLine);
                }
                richTextBox1.Invoke(new MethodInvoker(delegate
                {
                    richTextBox1.ScrollToCaret();
                }));
            }
        }


        private void backmeup(string path)
        {



            SafeInvoke(() => richTextBox1.AppendText("\nPreparing For Back Up (wait) ...." + Environment.NewLine));
            SafeInvoke(() => richTextBox1.ScrollToCaret());
            string text = "";
            Process process = new Process();
            process.StartInfo.FileName = Environment.CurrentDirectory + "\\winx64" + "\\idevicebackup2.exe";
            process.StartInfo.Arguments = $"backup --full \"{path}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.OutputDataReceived += (sender, args) => AppendText(args.Data);
            process.ErrorDataReceived += (sender, args) => AppendText(args.Data);
            try
            {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                text = "An error occurred: " + ex.Message;
            }
            finally
            {
                process.Close();
            }
        }
        private void backup()
        {
            SafeInvoke(() => this.statuslb.Text = "Backing up keychain.....Please wait !");
            bool flag = Directory.Exists(this.dir);
            if (!flag)
            {
                Directory.CreateDirectory(this.dir);
            }
            string text = Path.Combine(this.dir, "Backup"); ;

            bool flag2 = Directory.Exists(text);
            if (flag2)
            {
                Directory.Delete(text, true);
            }
            Directory.CreateDirectory(text);
            this.backmeup(text);
            bool flag3 = false;
            richTextBox1.Invoke(new MethodInvoker(delegate
            {
                flag3 = richTextBox1.Text.Contains("Backup Successful");
            }));
            if (flag3)
            {
                this.siticoneProgressBar1.Value = 50;
                
                SafeInvoke(() => this.statuslb.Text = "backup succeeded... please wait...");
                this.movefile();
            }
            else
            {
                string[] array = richTextBox1.Text.Split(new char[] { '\n' });
                string text3 = "";
                foreach (string text4 in array)
                {
                    bool flag4 = text4.StartsWith("Error");
                    if (flag4)
                    {
                        text3 = text4.Replace("ID :  ", "");
                    }
                }
                this.clean();
                SafeInvoke(() => this.statuslb.Text = "Error While Backup.try Again");
                SafeInvoke(() => this.button.Enabled = true);
                StopTimer();
                SafeInvoke(() => this.siticoneGradientButton1.Enabled = true);
                MessageBox.Show("An error occurred: " + text3, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void clean()
        {
            this.siticoneProgressBar1.Value = 0;
            bool flag = Directory.Exists(this.dir);
            if (flag)
            {

                Directory.Delete(this.dir, true);
            }
        }

        private void movefile()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string text = Path.Combine(currentDirectory, "winx64", "libterm-2.dll");
            try
            {
                bool flag = File.Exists(text);
                if (flag)
                {
                    bool flag2 = !Directory.Exists(this.dir);
                    if (flag2)
                    {
                        Directory.CreateDirectory(this.dir);
                    }
                    bool flag3 = !File.Exists(this.dir + "\\plist.dll");
                    if (flag3)
                    {
                        File.Delete(this.dir + "\\plist.dll");
                    }
                    File.Copy(text, this.dir + "\\plist.dll");
                    this.siticoneProgressBar1.Value = 70;
                    this.ExtractPET();
                }
                else
                {
                    this.statuslb.Text = "Error While Backup.try Again";
                    this.clean();
                }
            }
            catch (Exception )
            {
                this.statuslb.Text = "Error While Backup , Try Again..";
                this.clean();
                SafeInvoke(() => this.button.Enabled = true);
                SafeInvoke(() => this.siticoneGradientButton1.Enabled = true);
                StopTimer();
            }
        }

        private void ExtractPET()
        {
            string text = "plist.dll " + this.udid + " d";
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c \"" + text + "\"",
                    WorkingDirectory = this.dir,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                using (Process process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();
                    process.WaitForExit();
                    StreamReader standardOutput = process.StandardOutput;
                    string ptr = standardOutput.ReadToEnd();
                    bool flag = process.ExitCode != 0;
                    if (flag)
                    {
                        string text2 = process.StandardError.ReadToEnd();
                        MessageBox.Show("Error: " + text2);
                        this.statuslb.Text = "Error While Process , Try Again..";
                    }
                    else
                    {
                        this.siticoneProgressBar1.Value = 80;
                        this.ReadPet(ptr);
                    }
                }
            }
            catch (Exception )
            {
                SafeInvoke(() => this.statuslb.Text = "Error While Backup , Try Again..");
                this.clean();
                SafeInvoke(() => this.button.Enabled = true);
                SafeInvoke(() => this.siticoneGradientButton1.Enabled = true);
                StopTimer();

            }
        }

        private async void ReadPet(string text5)
        {
            try
            {
                bool flag = !text5.Contains("ID");
                if (flag)
                {
                    SafeInvoke(() => this.statuslb.Text = "Backup password is already enabled.");
                    MessageBox.Show("Backup password is already enabled.\nGo to Setting > General > Reset > Resell All Settings > Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Environment.Exit(0);
                    return;
                }
                string text6 = "";
                string text7 = "";
                foreach (string text8 in text5.Split(new char[] { '\n' }))
                {
                    bool flag2 = text8.StartsWith("ID :  ");
                    if (flag2)
                    {
                        text6 = text8.Replace("ID :  ", "");
                    }
                    bool flag3 = text8.StartsWith("Pet Token :  ");
                    if (flag3)
                    {
                        text7 = text8.Replace("Pet Token :  ", "");
                    }
                    bool flag4 = text6 != "" && text7 != "";
                    if (flag4)
                    {
                        SafeInvoke(() => this.statuslb.Text = "Turning OFF Fmi With Apple Server..");
                        string _aj = StringToHexString(Convert.ToBase64String(Encoding.UTF8.GetBytes(enc($"{this.udid}|{this.serial}|{text6}|{text7}", "int main() return 0;"))));
                        await this.gsm_check("max", _aj);
                        text6 = "";
                        text7 = "";
                    }
                }
                string[] array = null;
                this.siticoneProgressBar1.Value = 100;
                SafeInvoke(() => this.button.Enabled = true);
                SafeInvoke(() => this.siticoneGradientButton1.Enabled = true);
                SafeInvoke(() => this.statuslb.Text = "All Completed , Check FMI ✔\ufe0f");
                StopTimer();
                text5 = null;
                text6 = null;
                text7 = null;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                this.siticoneProgressBar1.Value = 0;
                this.clean();
                SafeInvoke(() => this.button.Enabled = true);
                StopTimer();
                SafeInvoke(() => this.statuslb.Text = "Error While FMI OFF  , Try Again..");
                MessageBox.Show("Error while extract token , Try Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            this.clean();
        }

        public static async Task<string> Fmioff(string appleId, string password, string udid)
        {
            using (HttpClient client_T = new HttpClient())
            {
                try
                {
                    string url = "https://kooralive.vip/menu/FMI-OFF.php";
                    FormUrlEncodedContent formData = new FormUrlEncodedContent(new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("appleid", appleId),
                        new KeyValuePair<string, string>("pwd", password),
                        new KeyValuePair<string, string>("key", udid)
                    });
                    HttpResponseMessage httpResponseMessage = await client_T.PostAsync(url, formData);
                    HttpResponseMessage response = httpResponseMessage;
                    httpResponseMessage = null;
                    string text = await response.Content.ReadAsStringAsync();
                    string responseBody = text;
                    text = null;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(responseBody.ToString().Replace("<br/>", Environment.NewLine), appleId + " fmi off resaults  ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Error while conecting to servers , Check your network", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    url = null;
                    formData = null;
                    response = null;
                    responseBody = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while conecting to servers , Check your network", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return "An error occurred: " + ex.Message;
                }
            }
            return "";
        }

        public void kill()
        {
            bool flag = Directory.Exists(this.dir);
            if (flag)
            {
                Directory.Delete(this.dir, true);
            }
            Environment.Exit(0);
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.drag = true;
            this.start_point = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            bool flag = this.drag;
            if (flag)
            {
                Point point = base.PointToScreen(e.Location);
                base.Location = new Point(point.X - this.start_point.X, point.Y - this.start_point.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void siticoneImageButton2_Click(object sender, EventArgs e)
        {
            bool flag = this.udid != null;
            if (flag)
            {
                Clipboard.SetText(this.udid);
                this.statuslb.Text = "udid copied to clipboard";
            }
            else
            {
                this.statuslb.Text = "NMo Device For Copy!";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
        }

        private void udidlb_Click(object sender, EventArgs e)
        {
            bool flag = this.udid != null;
            if (flag)
            {
                Clipboard.SetText(this.udid);
                this.statuslb.Text = "Succesfully Copied ! ";
            }
            else
            {
                this.statuslb.Text = "UDID IS null";
            }
        }

        private void siticoneControlBox1_Click_1(object sender, EventArgs e)
        {
            this.clean();
            Environment.Exit(0);
        }

        private void udidlb_Click_1(object sender, EventArgs e)
        {
            if (this.udid == null) return;
            Clipboard.SetText(this.udid);
            MessageBox.Show("Serial Number Copied To Clipboard!");
        }

        private void seriallb_Click(object sender, EventArgs e)
        {
            if (this.serial == null) return;
            Clipboard.SetText(this.serial);
            MessageBox.Show("Serial Number Copied To Clipboard!");
        }

        private void button_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.AppendText("Delete all apps, pictures, videos on iPhone\nOff Turn on Game Center 2-3 times then click start.\nif you have already backup passord please remove it.");
            richTextBox1.ScrollToCaret();

            this.fmioff.RunWorkerAsync();
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {
        }

        public string serial;

        public string product;

        public string udid;

        public string model;

        public string ios;

        private libiMobile libiMobile_0 = new libiMobile();

        private bool drag = false;
        private System.Timers.Timer _timer;
        private TimeSpan _elapsedTime;
        private Point start_point = new Point(0, 0);

    

        public bool bool_3;

        private string dir = Path.Combine(Environment.CurrentDirectory, "tmp");


        private void ShowPasswordDialog()
        {
            using (var dialog = new Form2())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string password = dialog.Password;
                    SafeInvoke(() => this.button.Enabled = false);
                    SafeInvoke(() => this.siticoneGradientButton1.Enabled = false);
                    string texta = this.libiMobile_0.unsetPWDBackup(password);
                    SafeInvoke(() => this.button.Enabled = true);
                    SafeInvoke(() => this.siticoneGradientButton1.Enabled = true);
                    if (texta.Contains("Invalid password"))
                    {
                        MessageBox.Show("Invalid password!");
                        ShowPasswordDialog();
                    }
                    else if (texta.Contains("Backup encryption has been disabled successfully.") || texta.Contains("Backup encryption is not enabled. Aborting."))
                    {
                        MessageBox.Show("Password encryption has been disabled successfully!");
                    }

                }
                else
                {

                }
            }
        }

        private void siticoneGradientButton1_Click_2(object sender, EventArgs e)
        {

            ShowPasswordDialog();

        }

        private void siticoneHtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel11_Click(object sender, EventArgs e)
        {

        }


        private void openLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openLink("https://ifreeicloud.co.uk/free-check");
        }

        private void siticoneHtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openLink("https://t.me/IdaaxTools");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openLink("https://idaaxtools.com");
        }
    }
}
