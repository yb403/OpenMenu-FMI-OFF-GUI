using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;


namespace openmenuAuto
{
    public class libiMobile
    {
        public string getImageServerApple(string product)
        {
            string text = "";
            bool flag = product.Contains("iPhone");
            if (flag)
            {
                text = "iPhone";
            }
            bool flag2 = product.Contains("iPad");
            if (flag2)
            {
                text = "iPad";
            }
            bool flag3 = product.Contains("iPod");
            if (flag3)
            {
                text = "iPod";
            }
            return string.Concat(new string[] { "https://statici.icloud.com/fmipmobile/deviceImages-9.0/", text, "/", product, "/online-infobox__3x.png" });
        }

        public string getColoriDevice(string colorcode)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "1", "Black" },
                { "2", "White" },
                { "3", "Gold" },
                { "4", "Rose Gold" },
                { "5", "Jet Black" },
                { "6", "Red" },
                { "7", "Yellow" },
                { "8", "Coral" },
                { "9", "Blue" },
                { "#e4e7e8", "Rose Gold" },
                { "#3b3b3c", "White" }
            };
            string text;
            bool flag = !dictionary.TryGetValue(colorcode, out text);
            string text2;
            if (flag)
            {
                foreach (KeyValuePair<string, string> keyValuePair in dictionary)
                {
                    bool flag2 = keyValuePair.Value.Equals(colorcode, StringComparison.OrdinalIgnoreCase);
                    if (flag2)
                    {
                        return keyValuePair.Value;
                    }
                }
                text2 = string.Empty;
            }
            else
            {
                text2 = text;
            }
            return text2;
        }

        public string getPathLibiMobileDevice()
        {
            return Environment.CurrentDirectory + "\\winx64";
        }

        public string checkPair()
        {
            string text = "";
            using (Process process = new Process())
            {
                process.StartInfo.FileName = this.getPathLibiMobileDevice() + "\\idevicepair.exe";
                process.StartInfo.Arguments = "pair";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                text = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
            return text;
        }

        public double getTotalDataAvailableInGB()
        {
            try
            {
                using (Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = this.getPathLibiMobileDevice() + "\\ideviceinfo.exe",
                    Arguments = "-q com.apple.disk_usage.factory -k TotalDataAvailable",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }))
                {
                    string text = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    long num;
                    bool flag = long.TryParse(text.Trim(), out num);
                    if (flag)
                    {
                        return Math.Round((double)num / 1073741824.0, 2);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return 0.0;
        }

        public double getTotalDiskCapacityInGB()
        {
            try
            {
                using (Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = this.getPathLibiMobileDevice() + "\\ideviceinfo.exe",
                    Arguments = "-q com.apple.disk_usage.factory -k TotalDiskCapacity",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }))
                {
                    string text = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    long num;
                    bool flag = long.TryParse(text.Trim(), out num);
                    if (flag)
                    {
                        return Math.Round((double)num / 1073741824.0, 2);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return 0.0;
        }

        internal static uint smethod_0(string string_0)
        {
            uint num = 0U;
            bool flag = string_0 != null;
            if (flag)
            {
                num = 2166136261U;
                for (int i = 0; i < string_0.Length; i++)
                {
                    num = ((uint)string_0[i] ^ num) * 16777619U;
                }
            }
            return num;
        }

        public string getDeviceName(string productType)
        {
            uint num = libiMobile.smethod_0(productType);
            bool flag = num <= 1613858532U;
            if (flag)
            {
                bool flag2 = num <= 493807482U;
                if (flag2)
                {
                    bool flag3 = num <= 268341164U;
                    if (flag3)
                    {
                        bool flag4 = num <= 201230688U;
                        if (flag4)
                        {
                            bool flag5 = num <= 137893251U;
                            if (flag5)
                            {
                                bool flag6 = num > 80824001U;
                                if (flag6)
                                {
                                    bool flag7 = num != 121115632U;
                                    if (flag7)
                                    {
                                        bool flag8 = num == 137893251U;
                                        if (flag8)
                                        {
                                            bool flag9 = productType == "iPad13,6";
                                            if (flag9)
                                            {
                                                return "iPad Pro 11 inch 5th Gen";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag10 = productType == "iPad13,7";
                                        if (flag10)
                                        {
                                            return "iPad Pro 11 inch 5th Gen";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag11 = num != 13713525U;
                                    if (flag11)
                                    {
                                        bool flag12 = num == 80824001U;
                                        if (flag12)
                                        {
                                            bool flag13 = productType == "iPad6,8";
                                            if (flag13)
                                            {
                                                return "iPad Pro (12.9 inch, WiFi+LTE)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag14 = productType == "iPad6,4";
                                        if (flag14)
                                        {
                                            return "iPad Pro (9.7 inch, WiFi+LTE)";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag15 = num <= 171448489U;
                                if (flag15)
                                {
                                    bool flag16 = num != 154670870U;
                                    if (flag16)
                                    {
                                        bool flag17 = num == 171448489U;
                                        if (flag17)
                                        {
                                            bool flag18 = productType == "iPad13,4";
                                            if (flag18)
                                            {
                                                return "iPad Pro 11 inch 5th Gen";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag19 = productType == "iPad13,5";
                                        if (flag19)
                                        {
                                            return "iPad Pro 11 inch 5th Gen";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag20 = num != 194068216U;
                                    if (flag20)
                                    {
                                        bool flag21 = num == 201230688U;
                                        if (flag21)
                                        {
                                            bool flag22 = productType == "iPad7,2";
                                            if (flag22)
                                            {
                                                return "iPad Pro 2nd Gen (WiFi+Cellular)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag23 = productType == "iPhone5,1";
                                        if (flag23)
                                        {
                                            return "iPhone 5 (GSM)";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            bool flag24 = num <= 227623454U;
                            if (flag24)
                            {
                                bool flag25 = num <= 218008307U;
                                if (flag25)
                                {
                                    bool flag26 = num != 205003727U;
                                    if (flag26)
                                    {
                                        bool flag27 = num == 218008307U;
                                        if (flag27)
                                        {
                                            bool flag28 = productType == "iPad7,3";
                                            if (flag28)
                                            {
                                                return "iPad Pro 10.5-inch 2nd Gen";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag29 = productType == "iPad13,2";
                                        if (flag29)
                                        {
                                            return "iPad Air 4th Gen (WiFi+Cellular)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag30 = num != 221781346U;
                                    if (flag30)
                                    {
                                        bool flag31 = num == 227623454U;
                                        if (flag31)
                                        {
                                            bool flag32 = productType == "iPhone5,3";
                                            if (flag32)
                                            {
                                                return "iPhone 5C (GSM)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag33 = productType == "iPad13,1";
                                        if (flag33)
                                        {
                                            return "iPad Air 4th Gen (WiFi)";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag34 = num <= 240921132U;
                                if (flag34)
                                {
                                    bool flag35 = num != 235638739U;
                                    if (flag35)
                                    {
                                        bool flag36 = num == 240921132U;
                                        if (flag36)
                                        {
                                            bool flag37 = productType == "iPad6,12";
                                            if (flag37)
                                            {
                                                return "iPad (2017)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag38 = productType == "iPhone4,1";
                                        if (flag38)
                                        {
                                            return "iPhone 4S";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag39 = num != 244401073U;
                                    if (flag39)
                                    {
                                        bool flag40 = num != 251563545U;
                                        if (flag40)
                                        {
                                            bool flag41 = num == 268341164U;
                                            if (flag41)
                                            {
                                                bool flag42 = productType == "iPad7,6";
                                                if (flag42)
                                                {
                                                    return "iPad 6th Gen (WiFi+Cellular)";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag43 = productType == "iPad7,1";
                                            if (flag43)
                                            {
                                                return "iPad Pro 2nd Gen (WiFi)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag44 = productType == "iPhone5,2";
                                        if (flag44)
                                        {
                                            return "iPhone 5 (GSM+CDMA)";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        bool flag45 = num <= 372779917U;
                        if (flag45)
                        {
                            bool flag46 = num <= 318674021U;
                            if (flag46)
                            {
                                bool flag47 = num <= 291253989U;
                                if (flag47)
                                {
                                    bool flag48 = num != 277956311U;
                                    if (flag48)
                                    {
                                        bool flag49 = num == 291253989U;
                                        if (flag49)
                                        {
                                            bool flag50 = productType == "iPad6,11";
                                            if (flag50)
                                            {
                                                return "iPad (2017)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag51 = productType == "iPhone5,4";
                                        if (flag51)
                                        {
                                            return "iPhone 5C (Global)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag52 = num != 301896402U;
                                    if (flag52)
                                    {
                                        bool flag53 = num == 318674021U;
                                        if (flag53)
                                        {
                                            bool flag54 = productType == "iPad7,5";
                                            if (flag54)
                                            {
                                                return "iPad 6th Gen (WiFi)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag55 = productType == "iPad7,4";
                                        if (flag55)
                                        {
                                            return "iPad Pro 10.5-inch 2nd Gen";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag56 = num <= 342808911U;
                                if (flag56)
                                {
                                    bool flag57 = num != 326031292U;
                                    if (flag57)
                                    {
                                        bool flag58 = num == 342808911U;
                                        if (flag58)
                                        {
                                            bool flag59 = productType == "iPad8,8";
                                            if (flag59)
                                            {
                                                return "iPad Pro 12.9 inch 3rd Gen (1TB, WiFi+Cellular)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag60 = productType == "iPad8,9";
                                        if (flag60)
                                        {
                                            return "iPad Pro 11 inch 4th Gen (WiFi)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag61 = num != 350181282U;
                                    if (flag61)
                                    {
                                        bool flag62 = num != 356002298U;
                                        if (flag62)
                                        {
                                            bool flag63 = num == 372779917U;
                                            if (flag63)
                                            {
                                                bool flag64 = productType == "iPad13,8";
                                                if (flag64)
                                                {
                                                    return "iPad Pro 12.9 inch 5th Gen";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag65 = productType == "iPad13,9";
                                            if (flag65)
                                            {
                                                return "iPad Pro 12.9 inch 5th Gen";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag66 = productType == "iPhone11,8";
                                        if (flag66)
                                        {
                                            return "iPhone XR";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            bool flag67 = num <= 417291758U;
                            if (flag67)
                            {
                                bool flag68 = num <= 393141768U;
                                if (flag68)
                                {
                                    bool flag69 = num != 383736520U;
                                    if (flag69)
                                    {
                                        bool flag70 = num == 393141768U;
                                        if (flag70)
                                        {
                                            bool flag71 = productType == "iPad8,5";
                                            if (flag71)
                                            {
                                                return "iPad Pro 12.9 inch 3rd Gen (WiFi)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag72 = productType == "iPhone11,6";
                                        if (flag72)
                                        {
                                            return "iPhone XS Max Global";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag73 = num != 409919387U;
                                    if (flag73)
                                    {
                                        bool flag74 = num == 417291758U;
                                        if (flag74)
                                        {
                                            bool flag75 = productType == "iPhone11,4";
                                            if (flag75)
                                            {
                                                return "iPhone XS Max";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag76 = productType == "iPad8,4";
                                        if (flag76)
                                        {
                                            return "iPad Pro 11 inch 3rd Gen (1TB, WiFi+Cellular)";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag77 = num <= 443474625U;
                                if (flag77)
                                {
                                    bool flag78 = num != 426697006U;
                                    if (flag78)
                                    {
                                        bool flag79 = num == 443474625U;
                                        if (flag79)
                                        {
                                            bool flag80 = productType == "iPad8,6";
                                            if (flag80)
                                            {
                                                return "iPad Pro 12.9 inch 3rd Gen (1TB, WiFi)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag81 = productType == "iPad8,7";
                                        if (flag81)
                                        {
                                            return "iPad Pro 12.9 inch 3rd Gen (WiFi+Cellular)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag82 = num != 450846996U;
                                    if (flag82)
                                    {
                                        bool flag83 = num != 460252244U;
                                        if (flag83)
                                        {
                                            bool flag84 = num == 493807482U;
                                            if (flag84)
                                            {
                                                bool flag85 = productType == "iPad8,3";
                                                if (flag85)
                                                {
                                                    return "iPad Pro 11 inch 3rd Gen (WiFi+Cellular)";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag86 = productType == "iPad8,1";
                                            if (flag86)
                                            {
                                                return "iPad Pro 11 inch 3rd Gen (WiFi)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag87 = productType == "iPhone11,2";
                                        if (flag87)
                                        {
                                            return "iPhone XS";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    bool flag88 = num <= 897947417U;
                    if (flag88)
                    {
                        bool flag89 = num <= 693515438U;
                        if (flag89)
                        {
                            bool flag90 = num <= 576072105U;
                            if (flag90)
                            {
                                bool flag91 = num <= 519927770U;
                                if (flag91)
                                {
                                    bool flag92 = num != 510585101U;
                                    if (flag92)
                                    {
                                        bool flag93 = num == 519927770U;
                                        if (flag93)
                                        {
                                            bool flag94 = productType == "iPod4,1";
                                            if (flag94)
                                            {
                                                return "4th Gen iPod";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag95 = productType == "iPad8,2";
                                        if (flag95)
                                        {
                                            return "iPad Pro 11 inch 3rd Gen (1TB, WiFi)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag96 = num != 559294486U;
                                    if (flag96)
                                    {
                                        bool flag97 = num == 576072105U;
                                        if (flag97)
                                        {
                                            bool flag98 = productType == "iPad13,11";
                                            if (flag98)
                                            {
                                                return "iPad Pro 12.9 inch 5th Gen";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag99 = productType == "iPad13,10";
                                        if (flag99)
                                        {
                                            return "iPad Pro 12.9 inch 5th Gen";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag100 = num <= 609627343U;
                                if (flag100)
                                {
                                    bool flag101 = num != 592849724U;
                                    if (flag101)
                                    {
                                        bool flag102 = num == 609627343U;
                                        if (flag102)
                                        {
                                            bool flag103 = productType == "iPad13,17";
                                            if (flag103)
                                            {
                                                return "iPad Air 5th Gen (WiFi+Cellular)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag104 = productType == "iPad13,16";
                                        if (flag104)
                                        {
                                            return "iPad Air 5th Gen (WiFi)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag105 = num != 638364159U;
                                    if (flag105)
                                    {
                                        bool flag106 = num != 688697016U;
                                        if (flag106)
                                        {
                                            bool flag107 = num == 693515438U;
                                            if (flag107)
                                            {
                                                bool flag108 = productType == "iPad13,18";
                                                if (flag108)
                                                {
                                                    return "iPad 10th Gen";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag109 = productType == "iPhone12,5";
                                            if (flag109)
                                            {
                                                return "iPhone 11 Pro Max";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag110 = productType == "iPhone12,8";
                                        if (flag110)
                                        {
                                            return "iPhone SE 2nd Gen";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            bool flag111 = num <= 789362730U;
                            if (flag111)
                            {
                                bool flag112 = num <= 734278272U;
                                if (flag112)
                                {
                                    bool flag113 = num != 710293057U;
                                    if (flag113)
                                    {
                                        bool flag114 = num == 734278272U;
                                        if (flag114)
                                        {
                                            bool flag115 = productType == "iPhone13,4";
                                            if (flag115)
                                            {
                                                return "iPhone 12 Pro Max";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag116 = productType == "iPad13,19";
                                        if (flag116)
                                        {
                                            return "iPad 10th Gen";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag117 = num != 755807492U;
                                    if (flag117)
                                    {
                                        bool flag118 = num == 789362730U;
                                        if (flag118)
                                        {
                                            bool flag119 = productType == "iPhone12,3";
                                            if (flag119)
                                            {
                                                return "iPhone 11 Pro";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag120 = productType == "iPhone12,1";
                                        if (flag120)
                                        {
                                            return "iPhone 11";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag121 = num <= 834943986U;
                                if (flag121)
                                {
                                    bool flag122 = num != 818166367U;
                                    if (flag122)
                                    {
                                        bool flag123 = num == 834943986U;
                                        if (flag123)
                                        {
                                            bool flag124 = productType == "iPhone13,2";
                                            if (flag124)
                                            {
                                                return "iPhone 12";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag125 = productType == "iPhone13,1";
                                        if (flag125)
                                        {
                                            return "iPhone 12 Mini";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag126 = num != 851721605U;
                                    if (flag126)
                                    {
                                        bool flag127 = num != 876599987U;
                                        if (flag127)
                                        {
                                            bool flag128 = num == 897947417U;
                                            if (flag128)
                                            {
                                                bool flag129 = productType == "iPod9,1";
                                                if (flag129)
                                                {
                                                    return "7th Gen iPod";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag130 = productType == "iPhone9,4";
                                            if (flag130)
                                            {
                                                return "iPhone 7 Plus";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag131 = productType == "iPhone13,3";
                                        if (flag131)
                                        {
                                            return "iPhone 12 Pro";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        bool flag132 = num <= 1118200753U;
                        if (flag132)
                        {
                            bool flag133 = num <= 993594948U;
                            if (flag133)
                            {
                                bool flag134 = num <= 960488082U;
                                if (flag134)
                                {
                                    bool flag135 = num != 926932844U;
                                    if (flag135)
                                    {
                                        bool flag136 = num == 960488082U;
                                        if (flag136)
                                        {
                                            bool flag137 = productType == "iPhone9,3";
                                            if (flag137)
                                            {
                                                return "iPhone 7";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag138 = productType == "iPhone9,1";
                                        if (flag138)
                                        {
                                            return "iPhone 7";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag139 = num != 977265701U;
                                    if (flag139)
                                    {
                                        bool flag140 = num == 993594948U;
                                        if (flag140)
                                        {
                                            bool flag141 = productType == "iPhone3,3";
                                            if (flag141)
                                            {
                                                return "iPhone 4 CDMA";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag142 = productType == "iPhone9,2";
                                        if (flag142)
                                        {
                                            return "iPhone 7 Plus";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag143 = num <= 1027150186U;
                                if (flag143)
                                {
                                    bool flag144 = num != 1010372567U;
                                    if (flag144)
                                    {
                                        bool flag145 = num == 1027150186U;
                                        if (flag145)
                                        {
                                            bool flag146 = productType == "iPhone3,1";
                                            if (flag146)
                                            {
                                                return "iPhone 4";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag147 = productType == "iPhone3,2";
                                        if (flag147)
                                        {
                                            return "iPhone 4 GSM Rev A";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag148 = num != 1084645515U;
                                    if (flag148)
                                    {
                                        bool flag149 = num != 1101423134U;
                                        if (flag149)
                                        {
                                            bool flag150 = num == 1118200753U;
                                            if (flag150)
                                            {
                                                bool flag151 = productType == "iPad5,3";
                                                if (flag151)
                                                {
                                                    return "iPad Air 2 (WiFi)";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag152 = productType == "iPad5,2";
                                            if (flag152)
                                            {
                                                return "4th Gen iPad mini (WiFi+Cellular)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag153 = productType == "iPad5,1";
                                        if (flag153)
                                        {
                                            return "iPad mini 4 (WiFi)";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            bool flag154 = num <= 1533782097U;
                            if (flag154)
                            {
                                bool flag155 = num <= 1158652399U;
                                if (flag155)
                                {
                                    bool flag156 = num != 1134978372U;
                                    if (flag156)
                                    {
                                        bool flag157 = num == 1158652399U;
                                        if (flag157)
                                        {
                                            bool flag158 = productType == "iPod7,1";
                                            if (flag158)
                                            {
                                                return "6th Gen iPod";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag159 = productType == "iPad5,4";
                                        if (flag159)
                                        {
                                            return "iPad Air 2 (Cellular)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag160 = num != 1483449240U;
                                    if (flag160)
                                    {
                                        bool flag161 = num == 1533782097U;
                                        if (flag161)
                                        {
                                            bool flag162 = productType == "iPhone16,2";
                                            if (flag162)
                                            {
                                                return "iPhone 15 Pro Max";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag163 = productType == "iPhone16,1";
                                        if (flag163)
                                        {
                                            return "iPhone 15 Pro";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag164 = num <= 1571900294U;
                                if (flag164)
                                {
                                    bool flag165 = num != 1538345056U;
                                    if (flag165)
                                    {
                                        bool flag166 = num == 1571900294U;
                                        if (flag166)
                                        {
                                            bool flag167 = productType == "iPad3,4";
                                            if (flag167)
                                            {
                                                return "4th Gen iPad";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag168 = productType == "iPad3,6";
                                        if (flag168)
                                        {
                                            return "4th Gen iPad CDMA+LTE";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag169 = num != 1588677913U;
                                    if (flag169)
                                    {
                                        bool flag170 = num != 1605455532U;
                                        if (flag170)
                                        {
                                            bool flag171 = num == 1613858532U;
                                            if (flag171)
                                            {
                                                bool flag172 = productType == "iPhone1,1";
                                                if (flag172)
                                                {
                                                    return "iPhone";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag173 = productType == "iPad3,2";
                                            if (flag173)
                                            {
                                                return "3rd Gen iPad CDMA";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag174 = productType == "iPad3,5";
                                        if (flag174)
                                        {
                                            return "4th Gen iPad GSM+LTE";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                bool flag175 = num <= 2777501608U;
                if (flag175)
                {
                    bool flag176 = num <= 2286986705U;
                    if (flag176)
                    {
                        bool flag177 = num <= 2081752929U;
                        if (flag177)
                        {
                            bool flag178 = num <= 1743237195U;
                            if (flag178)
                            {
                                bool flag179 = num <= 1655788389U;
                                if (flag179)
                                {
                                    bool flag180 = num != 1622233151U;
                                    if (flag180)
                                    {
                                        bool flag181 = num == 1655788389U;
                                        if (flag181)
                                        {
                                            bool flag182 = productType == "iPad3,1";
                                            if (flag182)
                                            {
                                                return "3rd Gen iPad";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag183 = productType == "iPad3,3";
                                        if (flag183)
                                        {
                                            return "3rd Gen iPad GSM";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag184 = num != 1664191389U;
                                    if (flag184)
                                    {
                                        bool flag185 = num == 1743237195U;
                                        if (flag185)
                                        {
                                            bool flag186 = productType == "iPhone7,2";
                                            if (flag186)
                                            {
                                                return "iPhone 6";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag187 = productType == "iPhone1,2";
                                        if (flag187)
                                        {
                                            return "iPhone 3G";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag188 = num <= 1886294147U;
                                if (flag188)
                                {
                                    bool flag189 = num != 1760014814U;
                                    if (flag189)
                                    {
                                        bool flag190 = num == 1886294147U;
                                        if (flag190)
                                        {
                                            bool flag191 = productType == "iPod3,1";
                                            if (flag191)
                                            {
                                                return "3rd Gen iPod";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag192 = productType == "iPhone7,1";
                                        if (flag192)
                                        {
                                            return "iPhone 6 Plus";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag193 = num != 2031420072U;
                                    if (flag193)
                                    {
                                        bool flag194 = num == 2081752929U;
                                        if (flag194)
                                        {
                                            bool flag195 = productType == "iPhone6,1";
                                            if (flag195)
                                            {
                                                return "iPhone 5S (GSM)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag196 = productType == "iPhone6,2";
                                        if (flag196)
                                        {
                                            return "iPhone 5S (Global)";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            bool flag197 = num <= 2175364388U;
                            if (flag197)
                            {
                                bool flag198 = num <= 2141809150U;
                                if (flag198)
                                {
                                    bool flag199 = num != 2125031531U;
                                    if (flag199)
                                    {
                                        bool flag200 = num == 2141809150U;
                                        if (flag200)
                                        {
                                            bool flag201 = productType == "iPad14,2";
                                            if (flag201)
                                            {
                                                return "iPad mini 6th Gen (WiFi+Cellular)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag202 = productType == "iPad14,1";
                                        if (flag202)
                                        {
                                            return "iPad mini 6th Gen (WiFi)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag203 = num != 2158586769U;
                                    if (flag203)
                                    {
                                        bool flag204 = num == 2175364388U;
                                        if (flag204)
                                        {
                                            bool flag205 = productType == "iPad14,4";
                                            if (flag205)
                                            {
                                                return "iPad Pro 11 inch 4th Gen";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag206 = productType == "iPad14,3";
                                        if (flag206)
                                        {
                                            return "iPad Pro 11 inch 4th Gen";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag207 = num <= 2208919626U;
                                if (flag207)
                                {
                                    bool flag208 = num != 2192142007U;
                                    if (flag208)
                                    {
                                        bool flag209 = num == 2208919626U;
                                        if (flag209)
                                        {
                                            bool flag210 = productType == "iPad14,6";
                                            if (flag210)
                                            {
                                                return "iPad Pro 12.9 inch 6th Gen";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag211 = productType == "iPad14,5";
                                        if (flag211)
                                        {
                                            return "iPad Pro 12.9 inch 6th Gen";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag212 = num != 2253431467U;
                                    if (flag212)
                                    {
                                        bool flag213 = num != 2270209086U;
                                        if (flag213)
                                        {
                                            bool flag214 = num == 2286986705U;
                                            if (flag214)
                                            {
                                                bool flag215 = productType == "iPhone10,4";
                                                if (flag215)
                                                {
                                                    return "iPhone 8";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag216 = productType == "iPhone10,5";
                                            if (flag216)
                                            {
                                                return "iPhone 8 Plus";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag217 = productType == "iPhone10,6";
                                        if (flag217)
                                        {
                                            return "iPhone X GSM";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        bool flag218 = num <= 2643280656U;
                        if (flag218)
                        {
                            bool flag219 = num <= 2475788652U;
                            if (flag219)
                            {
                                bool flag220 = num <= 2320541943U;
                                if (flag220)
                                {
                                    bool flag221 = num != 2303764324U;
                                    if (flag221)
                                    {
                                        bool flag222 = num == 2320541943U;
                                        if (flag222)
                                        {
                                            bool flag223 = productType == "iPhone10,2";
                                            if (flag223)
                                            {
                                                return "iPhone 8 Plus";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag224 = productType == "iPhone10,3";
                                        if (flag224)
                                        {
                                            return "iPhone X Global";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag225 = num != 2337319562U;
                                    if (flag225)
                                    {
                                        bool flag226 = num == 2475788652U;
                                        if (flag226)
                                        {
                                            bool flag227 = productType == "iPad8,10";
                                            if (flag227)
                                            {
                                                return "iPad Pro 11 inch 4th Gen (WiFi+Cellular)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag228 = productType == "iPhone10,1";
                                        if (flag228)
                                        {
                                            return "iPhone 8";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag229 = num <= 2509343890U;
                                if (flag229)
                                {
                                    bool flag230 = num != 2492566271U;
                                    if (flag230)
                                    {
                                        bool flag231 = num == 2509343890U;
                                        if (flag231)
                                        {
                                            bool flag232 = productType == "iPad8,12";
                                            if (flag232)
                                            {
                                                return "iPad Pro 12.9 inch 4th Gen (WiFi+Cellular)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag233 = productType == "iPad8,11";
                                        if (flag233)
                                        {
                                            return "iPad Pro 12.9 inch 4th Gen (WiFi)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag234 = num != 2509658711U;
                                    if (flag234)
                                    {
                                        bool flag235 = num != 2526436330U;
                                        if (flag235)
                                        {
                                            bool flag236 = num == 2643280656U;
                                            if (flag236)
                                            {
                                                bool flag237 = productType == "iPad4,1";
                                                if (flag237)
                                                {
                                                    return "iPad Air (WiFi)";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag238 = productType == "iPad1,2";
                                            if (flag238)
                                            {
                                                return "iPad 3G";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag239 = productType == "iPad1,1";
                                        if (flag239)
                                        {
                                            return "iPad";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            bool flag240 = num <= 2696174405U;
                            if (flag240)
                            {
                                bool flag241 = num <= 2676835894U;
                                if (flag241)
                                {
                                    bool flag242 = num != 2645841548U;
                                    if (flag242)
                                    {
                                        bool flag243 = num == 2676835894U;
                                        if (flag243)
                                        {
                                            bool flag244 = productType == "iPad4,3";
                                            if (flag244)
                                            {
                                                return "1st Gen iPad Air (China)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag245 = productType == "iPad12,2";
                                        if (flag245)
                                        {
                                            return "iPad 9th Gen (WiFi+Cellular)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag246 = num != 2693613513U;
                                    if (flag246)
                                    {
                                        bool flag247 = num == 2696174405U;
                                        if (flag247)
                                        {
                                            bool flag248 = productType == "iPad12,1";
                                            if (flag248)
                                            {
                                                return "iPad 9th Gen (WiFi)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag249 = productType == "iPad4,2";
                                        if (flag249)
                                        {
                                            return "iPad Air (GSM+CDMA)";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag250 = num <= 2727168751U;
                                if (flag250)
                                {
                                    bool flag251 = num != 2710391132U;
                                    if (flag251)
                                    {
                                        bool flag252 = num == 2727168751U;
                                        if (flag252)
                                        {
                                            bool flag253 = productType == "iPad4,4";
                                            if (flag253)
                                            {
                                                return "iPad mini Retina (WiFi)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag254 = productType == "iPad4,5";
                                        if (flag254)
                                        {
                                            return "iPad mini Retina (GSM+CDMA)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag255 = num != 2743946370U;
                                    if (flag255)
                                    {
                                        bool flag256 = num != 2760723989U;
                                        if (flag256)
                                        {
                                            bool flag257 = num == 2777501608U;
                                            if (flag257)
                                            {
                                                bool flag258 = productType == "iPad4,9";
                                                if (flag258)
                                                {
                                                    return "iPad Mini 3 (China)";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag259 = productType == "iPad4,6";
                                            if (flag259)
                                            {
                                                return "iPad mini Retina (China)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag260 = productType == "iPad4,7";
                                        if (flag260)
                                        {
                                            return "iPad mini 3 (WiFi)";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    bool flag261 = num <= 3341589448U;
                    if (flag261)
                    {
                        bool flag262 = num <= 3001134901U;
                        if (flag262)
                        {
                            bool flag263 = num <= 2934024425U;
                            if (flag263)
                            {
                                bool flag264 = num <= 2900469187U;
                                if (flag264)
                                {
                                    bool flag265 = num != 2794279227U;
                                    if (flag265)
                                    {
                                        bool flag266 = num == 2900469187U;
                                        if (flag266)
                                        {
                                            bool flag267 = productType == "iPad11,4";
                                            if (flag267)
                                            {
                                                return "iPad Air 3rd Gen";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag268 = productType == "iPad4,8";
                                        if (flag268)
                                        {
                                            return "iPad mini 3 (GSM+CDMA)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag269 = num != 2917246806U;
                                    if (flag269)
                                    {
                                        bool flag270 = num == 2934024425U;
                                        if (flag270)
                                        {
                                            bool flag271 = productType == "iPad11,6";
                                            if (flag271)
                                            {
                                                return "iPad 8th Gen (WiFi)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag272 = productType == "iPad11,7";
                                        if (flag272)
                                        {
                                            return "iPad 8th Gen (WiFi+Cellular)";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag273 = num <= 2952740857U;
                                if (flag273)
                                {
                                    bool flag274 = num != 2950802044U;
                                    if (flag274)
                                    {
                                        bool flag275 = num == 2952740857U;
                                        if (flag275)
                                        {
                                            bool flag276 = productType == "iPhone14,8";
                                            if (flag276)
                                            {
                                                return "iPhone 14 Plus";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag277 = productType == "iPad11,1";
                                        if (flag277)
                                        {
                                            return "iPad mini 5th Gen (WiFi)";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag278 = num != 2984357282U;
                                    if (flag278)
                                    {
                                        bool flag279 = num != 2989097949U;
                                        if (flag279)
                                        {
                                            bool flag280 = num == 3001134901U;
                                            if (flag280)
                                            {
                                                bool flag281 = productType == "iPad11,2";
                                                if (flag281)
                                                {
                                                    return "iPad mini 5th Gen";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag282 = productType == "iPod5,1";
                                            if (flag282)
                                            {
                                                return "5th Gen iPod";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag283 = productType == "iPad11,3";
                                        if (flag283)
                                        {
                                            return "iPad Air 3rd Gen (WiFi)";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            bool flag284 = num <= 3120517047U;
                            if (flag284)
                            {
                                bool flag285 = num <= 3053406571U;
                                if (flag285)
                                {
                                    bool flag286 = num != 3036628952U;
                                    if (flag286)
                                    {
                                        bool flag287 = num == 3053406571U;
                                        if (flag287)
                                        {
                                            bool flag288 = productType == "iPhone14,2";
                                            if (flag288)
                                            {
                                                return "iPhone 13 Pro";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag289 = productType == "iPhone14,3";
                                        if (flag289)
                                        {
                                            return "iPhone 13 Pro Max";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag290 = num != 3103739428U;
                                    if (flag290)
                                    {
                                        bool flag291 = num == 3120517047U;
                                        if (flag291)
                                        {
                                            bool flag292 = productType == "iPhone14,6";
                                            if (flag292)
                                            {
                                                return "iPhone SE 3rd Gen";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag293 = productType == "iPhone14,7";
                                        if (flag293)
                                        {
                                            return "iPhone 14";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag294 = num <= 3154072285U;
                                if (flag294)
                                {
                                    bool flag295 = num != 3137294666U;
                                    if (flag295)
                                    {
                                        bool flag296 = num == 3154072285U;
                                        if (flag296)
                                        {
                                            bool flag297 = productType == "iPhone14,4";
                                            if (flag297)
                                            {
                                                return "iPhone 13 Mini";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag298 = productType == "iPhone14,5";
                                        if (flag298)
                                        {
                                            return "iPhone 13";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag299 = num != 3266955512U;
                                    if (flag299)
                                    {
                                        bool flag300 = num != 3317288369U;
                                        if (flag300)
                                        {
                                            bool flag301 = num == 3341589448U;
                                            if (flag301)
                                            {
                                                bool flag302 = productType == "iPhone15,2";
                                                if (flag302)
                                                {
                                                    return "iPhone 14 Pro";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag303 = productType == "iPad7,12";
                                            if (flag303)
                                            {
                                                return "iPad 7th Gen 10.2-inch (WiFi+Cellular)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag304 = productType == "iPad7,11";
                                        if (flag304)
                                        {
                                            return "iPad 7th Gen 10.2-inch (WiFi)";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        bool flag305 = num <= 3480373359U;
                        if (flag305)
                        {
                            bool flag306 = num <= 3430040502U;
                            if (flag306)
                            {
                                bool flag307 = num <= 3396485264U;
                                if (flag307)
                                {
                                    bool flag308 = num != 3358367067U;
                                    if (flag308)
                                    {
                                        bool flag309 = num == 3396485264U;
                                        if (flag309)
                                        {
                                            bool flag310 = productType == "iPad2,7";
                                            if (flag310)
                                            {
                                                return "iPad mini CDMA+LTE";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag311 = productType == "iPhone15,3";
                                        if (flag311)
                                        {
                                            return "iPhone 14 Pro Max";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag312 = num != 3413262883U;
                                    if (flag312)
                                    {
                                        bool flag313 = num == 3430040502U;
                                        if (flag313)
                                        {
                                            bool flag314 = productType == "iPad2,5";
                                            if (flag314)
                                            {
                                                return "iPad mini";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag315 = productType == "iPad2,6";
                                        if (flag315)
                                        {
                                            return "iPad mini GSM+LTE";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag316 = num <= 3446818121U;
                                if (flag316)
                                {
                                    bool flag317 = num != 3442255162U;
                                    if (flag317)
                                    {
                                        bool flag318 = num == 3446818121U;
                                        if (flag318)
                                        {
                                            bool flag319 = productType == "iPad2,4";
                                            if (flag319)
                                            {
                                                return "2nd Gen iPad New Revision";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag320 = productType == "iPhone15,4";
                                        if (flag320)
                                        {
                                            return "iPhone 15";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag321 = num != 3459032781U;
                                    if (flag321)
                                    {
                                        bool flag322 = num != 3463595740U;
                                        if (flag322)
                                        {
                                            bool flag323 = num == 3480373359U;
                                            if (flag323)
                                            {
                                                bool flag324 = productType == "iPad2,2";
                                                if (flag324)
                                                {
                                                    return "2nd Gen iPad GSM";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag325 = productType == "iPad2,3";
                                            if (flag325)
                                            {
                                                return "2nd Gen iPad CDMA";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag326 = productType == "iPhone15,5";
                                        if (flag326)
                                        {
                                            return "iPhone 15 Plus";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            bool flag327 = num <= 3663264999U;
                            if (flag327)
                            {
                                bool flag328 = num <= 3506766125U;
                                if (flag328)
                                {
                                    bool flag329 = num != 3497150978U;
                                    if (flag329)
                                    {
                                        bool flag330 = num == 3506766125U;
                                        if (flag330)
                                        {
                                            bool flag331 = productType == "iPhone2,1";
                                            if (flag331)
                                            {
                                                return "iPhone 3GS";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag332 = productType == "iPad2,1";
                                        if (flag332)
                                        {
                                            return "2nd Gen iPad";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag333 = num != 3579376904U;
                                    if (flag333)
                                    {
                                        bool flag334 = num == 3663264999U;
                                        if (flag334)
                                        {
                                            bool flag335 = productType == "iPhone8,1";
                                            if (flag335)
                                            {
                                                return "iPhone 6s";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag336 = productType == "iPhone8,4";
                                        if (flag336)
                                        {
                                            return "iPhone SE (GSM)";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                bool flag337 = num <= 3721962577U;
                                if (flag337)
                                {
                                    bool flag338 = num != 3680042618U;
                                    if (flag338)
                                    {
                                        bool flag339 = num == 3721962577U;
                                        if (flag339)
                                        {
                                            bool flag340 = productType == "iPod1,1";
                                            if (flag340)
                                            {
                                                return "1st Gen iPod";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag341 = productType == "iPhone8,2";
                                        if (flag341)
                                        {
                                            return "iPhone 6s Plus";
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag342 = num != 3981813096U;
                                    if (flag342)
                                    {
                                        bool flag343 = num != 4191237488U;
                                        if (flag343)
                                        {
                                            bool flag344 = num == 4258347964U;
                                            if (flag344)
                                            {
                                                bool flag345 = productType == "iPad6,7";
                                                if (flag345)
                                                {
                                                    return "iPad Pro (12.9 inch, WiFi)";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag346 = productType == "iPad6,3";
                                            if (flag346)
                                            {
                                                return "iPad Pro (9.7 inch, WiFi)";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag347 = productType == "iPod2,1";
                                        if (flag347)
                                        {
                                            return "2nd Gen iPod";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return "Unknown Device";
        }

        public string unsetPWDBackup(string pwd)
        {
            string text = "";
            Process process = new Process();
            process.StartInfo.FileName = this.getPathLibiMobileDevice() + "\\idevicebackup2.exe";
            process.StartInfo.Arguments = $"backup encryption off {pwd}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            try
            {
                process.Start();
                bool flag = process.WaitForExit(30000);
                if (flag)
                {
                    text = process.StandardOutput.ReadToEnd();
                    Console.WriteLine(text);
                }
                else
                {
                    process.Kill();
                    text = "The process was terminated due to timeout.";
                }
            }
            catch (Exception ex)
            {
                text = "An error occurred: " + ex.Message;
            }
            finally
            {
                process.Close();
            }
            return text;
        }

        public string setPWDBackup()
        {
            string text = "";
            Process process = new Process();
            process.StartInfo.FileName = this.getPathLibiMobileDevice() + "\\idevicebackup2.exe";
            process.StartInfo.Arguments = "encryption on 123";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            try
            {
                process.Start();
                bool flag = process.WaitForExit(30000);
                if (flag)
                {
                    text = process.StandardOutput.ReadToEnd();
                    Console.WriteLine(text);
                }
                else
                {
                    process.Kill();
                    text = "The process was terminated due to timeout.";
                }
            }
            catch (Exception ex)
            {
                text = "An error occurred: " + ex.Message;
            }
            finally
            {
                process.Close();
            }
            return text;
        }

        public string makeBackUp(string path)
        {
            string text = "";
            Process process = new Process();
            process.StartInfo.FileName = this.getPathLibiMobileDevice() + "\\idevicebackup2.exe";
            process.StartInfo.Arguments = "backup --full " + path;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            try
            {
                process.Start();
                text = process.StandardOutput.ReadToEnd();
                Console.WriteLine(text);
            }
            catch (Exception ex)
            {
                text = "An error occurred: " + ex.Message;
            }
            finally
            {
                process.Close();
            }
            return text;
        }

        private string string_0 = Path.GetTempPath();

        private string string_1 = Directory.GetCurrentDirectory();
    }
}
