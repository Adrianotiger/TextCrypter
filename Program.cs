using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace KeyboardTrans
{
    static class Program
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private const int VK_LSHIFT = 0xA0;
        private const int VK_RSHIFT = 0xA1;
        private const int VK_LCONTROL = 0xA2;
        private const int VK_RCONTROL = 0xA3;
        private const int VK_LMENU = 0xA4;
        private const int VK_RMENU = 0xA5;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private static bool bPressed = false;
        public static bool ActivateCrypting = false;
        public enum CryptingMode
        {
            Bubble              = 1,
            Wide                = 2,
            Square              = 3,
            FlipX               = 4,
            FlipY               = 5,
            Superior            = 6,
            Bold                = 7,
            Italic              = 8,
            Bracket             = 9,
            Fraktur             = 10,
            Mathematical        = 11,
            Random              = 99
        };
        public static CryptingMode Crypting = CryptingMode.Bubble;

        private static Encoding enc = new UTF32Encoding(false, true, true);

        private static string[] alphabetsM = 
        {
            "AⒶAᗄᴬＡ𝐀𝐴⒜𝕬𝓐",  /*ÀÄÅĄĀǠǺΆДАѦӒᎪᗋᗩᴀḀẴ₳⏃Ⱑ⒜*/
            "BⒷᙠᗷᴮＢ𝐁𝐵⒝𝕭𝓑",  /*ßƁƄƅɃʙΒВᏴᗹᗺᗿᙖᙞᴃᵇḂḆ⒝*/
            "CⒸƆ⊂ᶜＣ𝐂𝐶⒞𝕮𝓒",  /*Ć¢ƆĊƈʗϾϹϽСҪලᏟᥴᴄḈⅭℭ⒞*/
            "DⒹᗡDᴰＤ𝐃𝐷⒟𝕯𝓓",
            "EⒺƎEᴱＥ𝐄𝐸⒠𝕰𝓔",
            "FⒻᖷᖶᶠＦ𝐅𝐹⒡𝕱𝓕",
            "GⒼᎮ⅁ᴳＧ𝐆𝐺⒢𝕲𝓖",
            "HⒽHHᴴＨ𝐇𝐻⒣𝕳𝓗",
            "IⒾIIᴵＩ𝐈𝐼⒤𝕴𝓘",
            "JⒿႱᘃᴶＪ𝐉𝐽⒥𝕵𝓙",
            "KⓀગʞᴷＫ𝐊𝐾⒦𝕶𝓚",
            "LⓁ⅃⅂ᴸＬ𝐋𝐿⒧𝕷𝓛",
            "MⓂMʍᴹＭ𝐌𝑀⒨𝕸𝓜",
            "NⓃИNᴺＮ𝐍𝑁⒩𝕹𝓝",
            "OⓄOOᴼＯ𝐎𝑂⒪𝕺𝓞",
            "PⓅߟbᴾＰ𝐏𝑃⒫𝕻𝓟",
            "QⓆỌⵚᑫＱ𝐐𝑄⒬𝕼𝓠",
            "RⓇЯᖉᴿＲ𝐑𝑅⒭𝕽𝓡",
            "SⓈƧᴤˢＳ𝐒𝑆⒮𝕾𝓢",
            "TⓉT⊥ᵀＴ𝐓𝑇⒯𝕿𝓣",
            "UⓊU∩ᵁＵ𝐔𝑈⒰𝖀𝓤",
            "VⓋV⋀ˠＶ𝐕𝑉⒱𝖁𝓥",
            "WⓌWMᵂＷ𝐖𝑊⒲𝖂𝓦",
            "XⓍXXˣＸ𝐗𝑋⒳𝖃𝓧",
            "YⓎY⅄ʸＹ𝐘𝑌⒴𝖄𝓨",
            "ZⓏƸZᶻＺ𝐙𝑍⒵𝖅𝓩"
        };

        
        private static String[] alphabetsm = 
        {
            "aⓐɒɐᵃａ𝐚𝑎⒜𝖆𝓪",
            "bⓑdpᵇｂ𝐛𝑏⒝𝖇𝓫",
            "cⓒɔⅽᶜｃ𝐜𝑐⒞𝖈𝓬",
            "dⓓbqᵈｄ𝐝𝑑⒟𝖉𝓭",
            "eⓔɘөᵉｅ𝐞𝑒⒠𝖊𝓮",
            "fⓕʇʈᶠｆ𝐟𝑓⒡𝖋𝓯",
            "gⓖǫɓᵍｇ𝐠𝑔⒢𝖌𝓰",
            "hⓗʜµʰｈ𝐡𝒽⒣𝖍𝓱",
            "iⓘi!ᶦｉ𝐢𝑖⒤𝖎𝓲",
            "jⓙႱɾʲｊ𝐣𝑗⒥𝖏𝓳",
            "kⓚʞʞᵏｋ𝐤𝑘⒦𝖐𝓴",
            "lⓛllᶫｌ𝐥𝑙⒧𝖑𝓵",
            "mⓜmwᵐｍ𝐦𝑚⒨𝖒𝓶",
            "nⓝnuᶰｎ𝐧𝑛⒩𝖓𝓷",
            "oⓞooᵒｏ𝐨𝑜⒪𝖔𝓸",
            "pⓟqbᵖｐ𝐩𝑝⒫𝖕𝓹",
            "qⓠpdᑫｑ𝐪𝑞⒬𝖖𝓺",
            "rⓡɿʁʳｒ𝐫𝑟⒭𝖗𝓻",
            "sⓢƨƨˢｓ𝐬𝑠⒮𝖘𝓼",
            "tⓣƚʇᵗｔ𝐭𝑡⒯𝖙𝓽",
            "uⓤu∩ᵘｕ𝐮𝑢⒰𝖚𝓾",
            "vⓥv٨ᵛｖ𝐯𝑣⒱𝖛𝓿",
            "wⓦwʍʷｗ𝐰𝑤⒲𝖜𝔀",
            "xⓧxxˣｘ𝐱𝑥⒳𝖝𝔁",
            "yⓨyʎʸｙ𝐲𝑦⒴𝖞𝔂",
            "zⓩzzᶻｚ𝐳𝑧⒵𝖟𝔃"
        };

        [STAThread]
        public static void Main()
        {
            _hookID = SetHook(_proc);
            Form1 form = new Form1();
            form.Show();
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static string ConvertChar(Int32 letter, int alphabetIndex)
        {
            if (letter <= 'Z')
            {
                byte[] byArr = enc.GetBytes(alphabetsM[letter - 'A']);
                return String.Format("{0}", UTF32Encoding.UTF32.GetString(byArr, 4 * alphabetIndex, 4)); // maiuscolo
            }
            else
            {
                byte[] byArr = enc.GetBytes(alphabetsm[letter - 'a']);
                return String.Format("{0}", UTF32Encoding.UTF32.GetString(byArr, 4 * alphabetIndex, 4)); // minuscolo
            }
        }

        private static string ConvertCharToSquare(Int32 letter)
        {
            byte[] byArr = UTF8Encoding.UTF32.GetBytes(Char.ConvertFromUtf32(8414));
            return String.Format("{0}{1}  ", Char.ConvertFromUtf32(letter), UTF32Encoding.UTF32.GetString(byArr)); // quadrato
        }

        private static string ConvertCharToRandom(Int32 letter)
        {
            Random rand = new Random();
            switch (rand.Next(0, 7))
            {
                case 0: return ConvertChar(letter, 1); 
                case 1: return ConvertChar(letter, 2); 
                case 2: return ConvertChar(letter, 5); 
                case 3: return ConvertChar(letter, 6); 
                case 4: return ConvertChar(letter, 7);
                case 5: return ConvertChar(letter, 8);
                case 6: return ConvertChar(letter, 10);
                default: return "x";
            }
        }
        
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && ActivateCrypting)
            {
                int ctrlKey = (GetAsyncKeyState(VK_LCONTROL) | GetAsyncKeyState(VK_RCONTROL)) & 0x8000;
                int altKey = (GetAsyncKeyState(VK_LMENU) | GetAsyncKeyState(VK_RMENU)) & 0x8000;

                if (wParam == (IntPtr)WM_KEYDOWN && !bPressed && ctrlKey == 0 && altKey == 0)
                {
                    KBDLLHOOKSTRUCT kbd = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));
                    
                    if (kbd.vkCode >= 'A' && kbd.vkCode <= 'Z')
                    {
                        bPressed = true;
                        String s;
                        int shiftKey = (GetAsyncKeyState(VK_LSHIFT | VK_RSHIFT)) & 0x8000;
                        if (shiftKey <= 0)
                        {
                            kbd.vkCode += 'a' - 'A';
                        }

                        switch (Crypting)
                        {
                            case CryptingMode.Bubble:       s = ConvertChar(kbd.vkCode, 1);          // bubble
                                                            break;
                            case CryptingMode.Square:       s = ConvertCharToSquare(kbd.vkCode);     // quadrato
                                                            break;
                            case CryptingMode.FlipX:        s = ConvertChar(kbd.vkCode, 2);          // specchia orrizontalmente
                                                            break;
                            case CryptingMode.FlipY:        s = ConvertChar(kbd.vkCode, 3);          // specchia verticalmente
                                                            break;
                            case CryptingMode.Superior:     s = ConvertChar(kbd.vkCode, 4);          // appendice
                                                            break;
                            case CryptingMode.Wide:         s = ConvertChar(kbd.vkCode, 5);          // spazio fisso largo
                                                            break;
                            case CryptingMode.Bold:         s = ConvertChar(kbd.vkCode, 6);          // grassetto
                                                            break;
                            case CryptingMode.Italic:       s = ConvertChar(kbd.vkCode, 7);          // corsivo
                                                            break;
                            case CryptingMode.Bracket:      s = ConvertChar(kbd.vkCode, 8);          // parentesi
                                                            break;
                            case CryptingMode.Fraktur:      s = ConvertChar(kbd.vkCode, 9);          // Fraktur (matematica)
                                                            break;
                            case CryptingMode.Mathematical: s = ConvertChar(kbd.vkCode, 10);         // lettere matematiche
                                                            break;
                            default:                        s = ConvertCharToRandom(kbd.vkCode);         // a caso
                                                            break;
                        }
                                                                        
                        Console.WriteLine((Keys)kbd.vkCode);
                        Console.WriteLine((Int32)kbd.scanCode);
                        SendKeys.SendWait(s);
                        return (System.IntPtr)1;
                    }
                } 
                else if (wParam == (IntPtr)WM_KEYUP)
                {
                    bPressed = false;
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        public static string ConvertString(string original)
        {
            String converted = "";
            if (ActivateCrypting)
            {
                for (int i = 0; i < original.Length; i++)
                {
                    if ((original[i] >= 'A' && original[i] <= 'Z') ||
                        (original[i] >= 'a' && original[i] <= 'z'))
                    {
                        switch (Crypting)
                        {
                            case CryptingMode.Bubble: converted += ConvertChar(original[i], 1);          // bubble
                                break;
                            case CryptingMode.Square: converted += ConvertCharToSquare(original[i]);     // quadrato
                                break;
                            case CryptingMode.FlipX: converted += ConvertChar(original[i], 2);          // specchia orrizontalmente
                                break;
                            case CryptingMode.FlipY: converted += ConvertChar(original[i], 3);          // specchia verticalmente
                                break;
                            case CryptingMode.Superior: converted += ConvertChar(original[i], 4);          // appendice
                                break;
                            case CryptingMode.Wide: converted += ConvertChar(original[i], 5);          // spazio fisso largo
                                break;
                            case CryptingMode.Bold: converted += ConvertChar(original[i], 6);          // grassetto
                                break;
                            case CryptingMode.Italic: converted += ConvertChar(original[i], 7);          // corsivo
                                break;
                            case CryptingMode.Bracket: converted += ConvertChar(original[i], 8);          // parentesi
                                break;
                            case CryptingMode.Fraktur: converted += ConvertChar(original[i], 9);          // Fraktur (matematica)
                                break;
                            case CryptingMode.Mathematical: converted += ConvertChar(original[i], 10);         // lettere matematiche
                                break;
                            default: converted += ConvertCharToRandom(original[i]);         // a caso
                                break;
                        }
                    }
                    else
                    {
                        converted += original[i];
                    }
                }
            }
            return converted;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern short GetAsyncKeyState(int vkey);

        [StructLayout(LayoutKind.Sequential)]
        public struct KBDLLHOOKSTRUCT
        {
            public Int32 vkCode;
            public Int32 scanCode;
            public Int32 flags;
            public Int32 time;
            public IntPtr dwExtraInfo;
        }
    }
}
