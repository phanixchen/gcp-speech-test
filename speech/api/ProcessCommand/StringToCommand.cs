using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;


namespace ProcessCommand
{
    public class StringToCommand
    {
        public StringToCommand()
        {
            curstage = STAGE.Waiting;
            iCutNum = 1;
            iStatus = 0;
        }
        /*
        private readonly Dictionary<string, string> commands = new Dictionary<string, string> {
                                                                        { "action", "Action" }, { "cut", "Pause" }, { "卡", "Pause" },
                                                                        { "調整光線", "SetLight" }, { "調整鏡頭", "SetCam" }, {"調整拍攝", "SetFilming"}, {"拍攝", "SetFilming"}
                                                                    };
        private readonly Dictionary<string, string> chars = new Dictionary<string, string> { { "男主角", "R1" }, { "怪獸", "R2" } };
        private readonly Dictionary<string, string> charpositions = new Dictionary<string, string> {
                                                                        {"一號艙門", "P1" }, {"1號艙門", "P1" },  {"2號艙門", "P2" }, {"二號艙門", "P2" }, {"閘門", "P3"},
                                                                        {"一號倉門", "P1" }, {"1號倉門", "P1" },  {"2號倉門", "P2" }, {"二號倉門", "P2" }, {"咱們", "P3"}, {"咱門", "P3"}
                                                                    };
        private readonly Dictionary<string, string> charsettings = new Dictionary<string, string> {
                                                                        {"槍", "I1"}
                                                                    };
        private readonly Dictionary<string, string> characts = new Dictionary<string, string> {
                                                                        { "偵查", "A1" }, { "走", "A2" }, {"站起", "A3"}, {"瞄準", "A4"}, {"開槍", "A5"},
                                                                        {"逃跑", "A6"}, { "面對", "A7"}, {"吼叫", "A8"}, {"大吼", "A8"}, {"舉手", "A9"}, {"跳入艙門", "A10" },
                                                                        { "爪子攻擊", "A11"}, { "爪攻擊", "A11"}, {"跳", "A12"}, {"後退", "A13"}
                                                                    };

        private readonly Dictionary<string, string> bgchars = new Dictionary<string, string> { { "機械手臂", "BG1" } };
        private readonly Dictionary<string, string> bgacts = new Dictionary<string, string> { { "轉動", "BGA1" }, { "噴火花", "BGA2" } };

        private readonly Dictionary<string, string> lightings = new Dictionary<string, string> {
                                                                        { "調光", "L1" }, { "霧氣", "L2" }
                                                                    };

        private readonly Dictionary<string, string> cameras = new Dictionary<string, string> {
                                                                    { "一號攝影機", "C1" }, {"二號攝影機", "C2" }, {"鳥瞰", "C2" }, {"三號攝影機", "C3" }, {"四號攝影機", "C4" },
                                                                    { "1號攝影機", "C1" }, {"2號攝影機", "C2" }, {"3號攝影機", "C3" }, {"4號攝影機", "C4" }
                                                                };
        private readonly Dictionary<string, string> camerapositions = new Dictionary<string, string> {
                                                                            { "一號機位", "CP1" }, {"二號機位", "CP2" }, {"三號機位", "CP3" }, {"四號機位", "CP4" },
                                                                            { "1號機位", "CP1" }, {"2號機位", "CP2" }, {"3號機位", "CP3" }, {"4號機位", "CP4" },
                                                                            { "一號進位", "CP1" }, {"二號進位", "CP2" }, {"三號進位", "CP3" }, {"四號進位", "CP4" },
                                                                            { "1號進位", "CP1" }, {"2號進位", "CP2" }, {"3號進位", "CP3" }, {"4號進位", "CP4" }
                                                                        };
        private readonly Dictionary<string, string> camerafocus = new Dictionary<string, string> {
                                                                            { "24釐米", "CF1" }, {"35釐米", "CF2" }, {"200釐米", "CF3" },
                                                                            { "二十四釐米", "CF1" }, { "二四釐米", "CF1" }, {"三五釐米", "CF2" }, {"三十五釐米", "CF2" }, {"兩百釐米", "CF3" }, {"二百釐米", "CF3" },
                                                                            { "廣角鏡頭", "CF1" }, {"一般鏡頭", "CF2" }, {"長鏡頭", "CF3" }, {"望遠鏡頭", "CF3" },
                                                                    };
        */

        private readonly Dictionary<string, string> commands = new Dictionary<string, string> {
                                                                        {"action" /* action */, "Action"},{"cut" /* cut */, "Pause"},{"K" /* 卡 */, "Pause"},{"DZGX" /* 調整光線 */, "SetLight"},{"DZJT" /* 調整鏡頭 */, "SetCam"},
                                                                        {"DZPS" /* 調整拍攝 */, "SetFilming"}, {"PS" /* 拍攝 */, "SetFilming"}
                                                                    };
        private readonly Dictionary<string, string> chars = new Dictionary<string, string> { { "NZJ" /* 男主角 */, "R1" }, { "GS" /* 怪獸 */, "R2" } };
        private readonly Dictionary<string, string> charpositions = new Dictionary<string, string> {
                                                                        {"YHCM" /* 一號艙門 */, "P1"}, {"1HCM" /* 1號艙門 */, "P1"}, {"2HCM" /* 2號艙門 */, "P2"}, {"EHCM" /* 二號艙門 */, "P2"}, {"ZM" /* 閘門 */, "P3"}
                                                                    };
        private readonly Dictionary<string, string> charsettings = new Dictionary<string, string> {
                                                                        {"Q" /* 槍 */, "I1"}
                                                                    };
        private readonly Dictionary<string, string> characts = new Dictionary<string, string> {
                                                                        {"ZC" /* 偵查 */, "A1"}, {"Z" /* 走 */, "A2"}, {"ZQ" /* 站起 */, "A3"}, {"MZ" /* 瞄準 */, "A4"}, {"KQ" /* 開槍 */, "A5"}, {"TP" /* 逃跑 */, "A6"},
                                                                        { "MD" /* 面對 */, "A7"}, {"HJ" /* 吼叫 */, "A8"}, {"DH" /* 大吼 */, "A8"}, {"JS" /* 舉手 */, "A9"}, {"TRCM" /* 跳入艙門 */, "A10"},
                                                                        { "ZZGJ" /* 爪子攻擊 */, "A11"}, {"ZGJ" /* 爪攻擊 */, "A11"}, {"T" /* 跳 */, "A12"}, {"HT" /* 後退 */, "A13"}
                                                                    };

        private readonly Dictionary<string, string> bgchars = new Dictionary<string, string> { { "JXSB" /* 機械手臂 */, "BG1" } };
        private readonly Dictionary<string, string> bgacts = new Dictionary<string, string> { { "ZD" /* 轉動 */, "BGA1" }, { "PHH" /* 噴火花 */, "BGA2" } };

        private readonly Dictionary<string, string> lightings = new Dictionary<string, string> {
                                                                        {"DG" /* 調光 */, "L1"}, {"WQ" /* 霧氣 */, "L2"}
                                                                    };

        private readonly Dictionary<string, string> cameras = new Dictionary<string, string> {
                                                                    {"YHSYJ" /* 一號攝影機 */, "C1"}, {"EHSYJ" /* 二號攝影機 */, "C2"}, {"DK" /* 鳥瞰 */, "C2"}, //{"SHSYJ" /* 三號攝影機 */, "C3"},
                                                                    { "SHSYJ" /* 四號攝影機 */, "C4"}, {"1HSYJ" /* 1號攝影機 */, "C1"}, {"2HSYJ" /* 2號攝影機 */, "C2"},
                                                                    { "3HSYJ" /* 3號攝影機 */, "C3"}//, {"4HSYJ" /* 4號攝影機 */, "C4"}
                                                                };
        private readonly Dictionary<string, string> camerapositions = new Dictionary<string, string> {
                                                                            {"YHJW" /* 一號機位 */, "CP1"}, {"EHJW" /* 二號機位 */, "CP2"}, {"SHJW" /* 三號機位 */, "CP3"}, //{"SHJW" /* 四號機位 */, "CP4"},
                                                                            { "1HJW" /* 1號進位 */, "CP1"}, {"2HJW" /* 2號進位 */, "CP2"}, {"3HJW" /* 3號進位 */, "CP3"}//, {"4HJW" /* 4號進位 */, "CP4"}
                                                                        };
        private readonly Dictionary<string, string> camerafocus = new Dictionary<string, string> {
                                                                        {"24LM" /* 24釐米 */, "CF1"}, {"35LM" /* 35釐米 */, "CF2"}, {"200LM" /* 200釐米 */, "CF3"}, {"ESSLM" /* 二十四釐米 */, "CF1"},
                                                                        { "ESLM" /* 二四釐米 */, "CF1"}, {"SWLM" /* 三五釐米 */, "CF2"}, {"SSWLM" /* 三十五釐米 */, "CF2"}, {"LBLM" /* 兩百釐米 */, "CF3"},
                                                                        { "EBLM" /* 二百釐米 */, "CF3"}, {"AJJT" /* 廣角鏡頭 */, "CF1"}, {"YBJT" /* 一般鏡頭 */, "CF2"}, {"CJT" /* 長鏡頭 */, "CF3"},
                                                                        { "WYJT" /* 望遠鏡頭 */, "CF3"}
                                                                    };

        private enum STAGE { Waiting = 0, SetRole = 1, SetCam = 2, SetLight = 4, SetFilming = 5, Action = 99 };

        private static STAGE curstage;
        private static int iCutNum;
        private static int iStatus; // 0: editing, 10: playing
        private string Role, Cam = "一號攝影機", CamPos, Act, BGR, BGRAct, Light, Lightening, Focus;

        public void test()
        {

            foreach (KeyValuePair<string, string> kv in commands)
            {
                Console.Write("{\"" + ChineseConverter.Convert(kv.Key, ChineseConversionDirection.TraditionalToSimplified).ToPinYinAbbr() + "\" /* " + kv.Key + " */, \"" + kv.Value + "\"}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kv in chars)
            {
                Console.Write("{\"" + ChineseConverter.Convert(kv.Key, ChineseConversionDirection.TraditionalToSimplified).ToPinYinAbbr() + "\" /* " + kv.Key + " */, \"" + kv.Value + "\"}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kv in charpositions)
            {
                Console.Write("{\"" + ChineseConverter.Convert(kv.Key, ChineseConversionDirection.TraditionalToSimplified).ToPinYinAbbr() + "\" /* " + kv.Key + " */, \"" + kv.Value + "\"}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kv in charsettings)
            {
                Console.Write("{\"" + ChineseConverter.Convert(kv.Key, ChineseConversionDirection.TraditionalToSimplified).ToPinYinAbbr() + "\" /* " + kv.Key + " */, \"" + kv.Value + "\"}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kv in characts)
            {
                Console.Write("{\"" + ChineseConverter.Convert(kv.Key, ChineseConversionDirection.TraditionalToSimplified).ToPinYinAbbr() + "\" /* " + kv.Key + " */, \"" + kv.Value + "\"}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kv in bgacts)
            {
                Console.Write("{\"" + ChineseConverter.Convert(kv.Key, ChineseConversionDirection.TraditionalToSimplified).ToPinYinAbbr() + "\" /* " + kv.Key + " */, \"" + kv.Value + "\"}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kv in bgchars)
            {
                Console.Write("{\"" + ChineseConverter.Convert(kv.Key, ChineseConversionDirection.TraditionalToSimplified).ToPinYinAbbr() + "\" /* " + kv.Key + " */, \"" + kv.Value + "\"}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kv in lightings)
            {
                Console.Write("{\"" + ChineseConverter.Convert(kv.Key, ChineseConversionDirection.TraditionalToSimplified).ToPinYinAbbr() + "\" /* " + kv.Key + " */, \"" + kv.Value + "\"}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kv in cameras)
            {
                Console.Write("{\"" + ChineseConverter.Convert(kv.Key, ChineseConversionDirection.TraditionalToSimplified).ToPinYinAbbr() + "\" /* " + kv.Key + " */, \"" + kv.Value + "\"}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kv in camerapositions)
            {
                Console.Write("{\"" + ChineseConverter.Convert(kv.Key, ChineseConversionDirection.TraditionalToSimplified).ToPinYinAbbr() + "\" /* " + kv.Key + " */, \"" + kv.Value + "\"}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kv in camerafocus)
            {
                Console.Write("{\"" + ChineseConverter.Convert(kv.Key, ChineseConversionDirection.TraditionalToSimplified).ToPinYinAbbr() + "\" /* " + kv.Key + " */, \"" + kv.Value + "\"}");
            }

            Console.WriteLine();

        }

        public string[] TransToCallFunction(string _command)
        {
            string strSimC = ChineseConverter.Convert(_command, ChineseConversionDirection.TraditionalToSimplified);
            string full = strSimC.ToPinYin();
            string abbr = strSimC.ToPinYinAbbr();


            List<string> lCall = new List<string>();
            if (_command.Contains("卡") || _command.StartsWith("好"))
            {
                curstage = STAGE.Waiting;
                return lCall.ToArray();
            }

            // Role
            foreach (string ch in chars.Keys)
            {
                if (_command.Contains(ch) &&
                    (_command.Contains("定位") || _command.Contains("訂位"))
                   )
                {
                    curstage = STAGE.SetRole;
                    lCall.Add(ProcessSetRolePosition(_command, ch));
                }
            }

            // Position
            foreach (string ch in charpositions.Keys)
            {
                if (_command.Contains(ch))
                {
                    curstage = STAGE.SetRole;
                    lCall.Add(ProcessSetRolePosition(_command, Role));
                }
            }

            // Role Setting
            foreach (string ch in charsettings.Keys)
            {
                if (_command.Contains(ch))
                {
                    curstage = STAGE.SetRole;
                    lCall.Add(ProcessSetRoleItem(_command, Role));
                }
            }


            // set Cam
            if (_command.StartsWith("調整鏡頭") || (_command.Contains("鏡頭") && curstage != STAGE.SetFilming))
            {
                curstage = STAGE.SetCam;
            }

            // select camera
            foreach (string ch in cameras.Keys)
            {
                if (_command.Contains(ch))
                {
                    curstage = STAGE.SetCam;
                    //lCall.Add(ProcessSwitchCam(_command, ch));
                    lCall.Add("SwitchCam(" + cameras[ch] + ");");
                    Cam = ch;

                    //需要補上 default camera position
                }
            }

            // set camera position
            foreach (string _campos in camerapositions.Keys)
            {
                if (_command.Contains(_campos))
                {
                    lCall.Add(ProcessSetCamPosition(_command, Cam));
                }
            }

            // set camera focus
            foreach (string ch in camerafocus.Keys)
            {
                if (_command.Contains(ch))
                {
                    lCall.Add(ProcessSetCamFocus(_command, ch));
                }
            }

            // set Filming
            if (_command.StartsWith("調整拍攝") || _command.Contains("拍攝") ||
                _command.StartsWith("調整拍攝") || _command.Contains("運鏡")
               )
            {
                curstage = STAGE.SetFilming;
            }

            if (curstage == STAGE.SetFilming && _command.Contains("移動") && _command.Contains("攝影機"))
            {
                foreach (string ch in camerapositions.Keys)
                {
                    if (_command.Contains(ch))
                    {
                        lCall.Add("SetCamMove(" + cameras[Cam] + ", " + camerapositions[CamPos] + ", " + camerapositions[ch] + ");");
                        break;
                    }
                }
            }

            string[] arr = lCall.ToArray();

            return arr;
        }

        public string toPinyinAbbr(string _command)
        {
            string strSimC = ChineseConverter.Convert(_command, ChineseConversionDirection.TraditionalToSimplified);
            Console.WriteLine(strSimC);
            string full = strSimC.ToPinYin();
            string abbr = strSimC.ToPinYinAbbr();

            return abbr;
        }

        public string toPinyin(string _command)
        {
            string strSimC = ChineseConverter.Convert(_command, ChineseConversionDirection.TraditionalToSimplified);
            string full = strSimC.ToPinYin();

            return full;
        }



        public string ConvertToCommand_201910(string _command)
        {
            _command = _command.ToUpper();
            string strSimC = ChineseConverter.Convert(_command, ChineseConversionDirection.TraditionalToSimplified);
            string full = strSimC.ToPinYin();
            string abbr = strSimC.ToPinYinAbbr();

            string strreturn = "";

            if (abbr.IndexOf("ACTION") == 0 || abbr.IndexOf("GO") == 0 || abbr.IndexOf("KSPS") == 0 || full.IndexOf("KAIPAI") == 0)
            {
                if (iStatus == 0)
                {
                    iStatus = 10;
                    //return "action";
                    return "go";
                }
            }

            if (full.Contains("BAOZHA")) return "explosion_fx";

            if (abbr.IndexOf("CUT") == 0 || full == "KA" || full == "CUT")
            {
                if (iStatus == 10)
                {
                    iStatus = 0;
                    return "cut";
                }
            }





            #region 切換 cut
            if (full.Contains("XIAYI") || full.Contains("XIA1") || abbr.Contains("XYCUT") || abbr.Contains("XYK") || abbr.Contains("X1CUT") || abbr.Contains("X1K"))
            {
                return "cut_next";
            }
            if (full.Contains("QIANYI") || full.Contains("QIAN1") || abbr.Contains("QYCUT") || abbr.Contains("QYK") || abbr.Contains("Q1CUT") || abbr.Contains("Q1K"))
            {
                return "cut_pre";
            }
            if (full.Contains("SHANGYI") || full.Contains("SHANG1") || abbr.Contains("SYCUT") || abbr.Contains("SYK") || abbr.Contains("S1CUT") || abbr.Contains("S1K"))
            {
                return "cut_pre";
            }
            if (full.Contains("DIYI") || full.Contains("DI1") || abbr.Contains("D1CUT") || abbr.Contains("D1K") ||
                abbr.Contains("DYCUT") || abbr.Contains("DYK"))
            {
                iCutNum = 1;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            if (full.Contains("DIER") || full.Contains("DI2") || abbr.Contains("D2CUT") || abbr.Contains("D2K") || abbr.Contains("DECUT") || abbr.Contains("DEK"))
            {
                iCutNum = 2;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            if (full.Contains("DISAN") || full.Contains("DI3") || abbr.Contains("D3CUT") || abbr.Contains("D3K"))
            {
                iCutNum = 3;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            if (full.Contains("DISI") || full.Contains("DI4") || abbr.Contains("D4CUT") || abbr.Contains("D4K"))
            {
                iCutNum = 4;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            if (full.Contains("DIWU") || full.Contains("DI5") || abbr.Contains("D5CUT") || abbr.Contains("D5K") || abbr.Contains("DWCUT") || abbr.Contains("DWK"))
            {
                iCutNum = 5;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            if (full.Contains("DILIU") || full.Contains("DI6") || abbr.Contains("D6CUT") || abbr.Contains("D6K") || abbr.Contains("DLCUT") || abbr.Contains("DLK"))
            {
                iCutNum = 6;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            #endregion

            #region 調光 開關燈
            if (full.Contains("DENG"))
            {
                if (full.Contains("GUANDENG"))
                {
                    return "light_off";
                }

                if (full.Contains("KAIDENG"))
                {
                    return "light_on";
                }

                if (full.Contains("LIANG")) return "light_upper";
                if (full.Contains("AN")) return "light_lower";
            }

            if (full.Contains("KAIQI") && (full.Contains("DIAOGUANG") || abbr.Contains("DG")))
            {
                return "posteffect_on";
            }
            if (full.Contains("GUANBI") && (full.Contains("DIAOGUANG") || abbr.Contains("DG")))
            {
                return "posteffect_off";
            }
            #endregion

            #region 景深
            if (full.Contains("BIAOZHU") && abbr.Contains("JS")) return "camera_dofdefault";
            if (full.Contains("BEIJING") && abbr.Contains("MH")) return "camera_dofdefault";
            if (abbr.Contains("JS") && full.Contains("KAI")) return "camera_dofdefault";

            if (abbr.Contains("YC") && abbr.Contains("JS")) return "camera_dofclear";
            if (abbr.Contains("BJ") && abbr.Contains("QC")) return "camera_dofclear";
            if (abbr.Contains("HM") && abbr.Contains("QC")) return "camera_dofclear";
            if (abbr.Contains("JS") && full.Contains("GUAN")) return "camera_dofclear";
            #endregion

            #region 切換 focus length
            if (abbr.Contains("ESSLM") || abbr.Contains("24LM") || abbr.Contains("ESLM")) return "camera_len24"; // 鏡頭換成24釐米
            if (full.Contains("BIAOZHUN") || abbr.Contains("BZJT")) return "camera_len24"; // 鏡頭換成24釐米
            if (abbr.Contains("SSWLM") || abbr.Contains("35LM") || abbr.Contains("SWLM")) return "camera_len35";// 鏡頭換成35釐米
            if (full.Contains("WANGYUAN") || abbr.Contains("WYJT")) return "camera_len35";// 鏡頭換成35釐米
            if (full.Contains("ANJIAO") || abbr.Contains("AJJT")) return "camera_len12";// 鏡頭換成廣角
            if (abbr.Contains("YELM") || abbr.Contains("12LM") || abbr.Contains("SELM")) return "camera_len12";// 鏡頭換成廣角
            #endregion

            #region 運鏡
            if (full.Contains("JIWEI"))
            {
                if (full.Contains("ERHAO") || full.Contains("2HAO")) return "camera_posa2";
                if (full.Contains("SHIAO") || full.Contains("4HAO")) return "camera_posb2";
            }
            #endregion

            #region 切換攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("YH") || abbr.Contains("1H"))) return "camera_c1";   // 切換到一號攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("EH") || abbr.Contains("2H"))) return "camera_c2";   // 切換到2號攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("SH") || abbr.Contains("3H"))) return "camera_c3";   // 切換到3號攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("WH") || abbr.Contains("5H"))) return "camera_c5";   // 切換到5號攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("LH") || abbr.Contains("6H"))) return "camera_c6";   // 切換到6號攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("QH") || abbr.Contains("7H"))) return "camera_c7";   // 切換到7號攝影機
            #endregion

            #region 就定位
            if (full.Contains("JIUDINGWEI"))
            {
                string str = "_onposition";

                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                if (abbr.Contains("GS") || abbr.Contains("GW")) str = "monster" + str;
                return str;
            }
            #endregion

            if (full.Contains("ZHENCHA") || full.Contains("CHAKAN"))
            {
                string str = "_detect";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                if (abbr.Contains("GS") || abbr.Contains("GW")) str = "monster" + str;
                return str;
            }

            #region 移動
            if (full.Contains("YIDONG"))
            {
                string str = "";
                if (abbr.Contains("1HWZ") || abbr.Contains("YHWZ") || abbr.Contains("WZ1") || abbr.Contains("WZY") || abbr.Contains("JTDZB") || abbr.Contains("JTZB") || full.Contains("ZUOBIAN")) str = "_pos1";
                if (abbr.Contains("2HWZ") || abbr.Contains("EHWZ") || abbr.Contains("WZ2") || abbr.Contains("WZE") || abbr.Contains("JTDZJ") || abbr.Contains("JTZJ") || full.Contains("ZHONGJIAN")) str = "_pos2";
                if (abbr.Contains("3HWZ") || abbr.Contains("SHWZ") || abbr.Contains("WZ3") || abbr.Contains("WZS") || abbr.Contains("JTDYB") || abbr.Contains("JTYB") || full.Contains("YOUBIAN")) str = "_pos3";

                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                if (abbr.Contains("GS") || abbr.Contains("GW")) str = "monster" + str.Replace("pos", "posd");
                return str;
            }
            #endregion

            #region 靠左右
            if (full.Contains("KAOZUO"))
            {
                string str = "_left";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                if (abbr.Contains("GS") || abbr.Contains("GW")) str = "monster" + str.Replace("pos", "posd");
                return str;
            }
            if (full.Contains("KAOYOU"))
            {
                string str = "_right";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                if (abbr.Contains("GS") || abbr.Contains("GW")) str = "monster" + str.Replace("pos", "posd");
                return str;
            }
            #endregion

            #region 左右轉
            if (full.Contains("ZUOZHUAI"))
            {
                string str = "_turnleft";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                if (abbr.Contains("GS") || abbr.Contains("GW")) str = "monster" + str.Replace("pos", "posd");
                return str;
            }
            if (full.Contains("YOUZHUAI"))
            {
                string str = "_turnright";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                if (abbr.Contains("GS") || abbr.Contains("GW")) str = "monster" + str.Replace("pos", "posd");
                return str;
            }
            #endregion

            #region 瞄準
            if (full.Contains("MIAOZHUN"))
            {
                string str = "_aim";
                string post = full.Substring(full.IndexOf("MIAOZHUN"));
                if (post.Contains("TOU")) str = str + "head";
                if (post.Contains("SHENTI")) str = str + "body";
                if (post.Contains("JIAO") || post.Contains("TUI")) str = str + "foot";

                if (full.Contains("ZHUJIAO") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                //if (abbr.Contains("GS") || abbr.Contains("GW")) str = "monster" + str.Replace("pos", "posd");

                return str;

            }
            #endregion

            #region 其他動作
            if (abbr.Contains("LZZH") || full.Contains("LIZHENG") || full.Contains("ZHANHAO"))
            {
                string str = "_standup";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                return str;
            }

            if (full.Contains("TIAOWU") || (full.Contains("TIAO") && full.Contains("WU")))
            {
                string str = "_dance";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                return str;
            }
            if (full.Contains("TIAO"))
            {
                string str = "_jump";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                return str;
            }

            if (abbr.Contains("GWQR") || full.Contains("GUIXIA"))
            {
                string str = "_beg";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                return str;
            }

            if (full.Contains("CUNXIA"))
            {
                string str = "_squat";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                return str;
            }
            if (full.Contains("JINGLI"))
            {
                string str = "_salute";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                return str;
            }

            if (abbr.Contains("DCQ"))
            {
                string str = "_throwweapon";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                return str;
            }
            if (abbr.Contains("HWQ") || (full.Contains("HUAN") && (full.Contains("QIANG") || full.Contains("WUQI"))))
            {
                string str = "_changeweapon";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                return str;
            }
            #endregion

            #region 怪物倒下
            if (full.Contains("JIDAO") || full.Contains("DADAO"))
            {
                string str = "_down";
                if (abbr.Contains("GS") || abbr.Contains("GW")) str = "monster" + str;
                return str;
            }
            #endregion

            #region 攻擊
            //停止攻擊
            if (abbr.Contains("TZGJ"))
            {
                string str = "_unfire";

                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                return str;
            }
            //攻擊
            if (full.Contains("GONGJI"))
            {
                string str = "_attack";
                string pre = abbr.Substring(0, abbr.IndexOf("GJ"));
                string prefull = full.Substring(0, full.IndexOf("GONGJI"));
                if (pre.Contains("GS") || pre.Contains("GW")) { str = "monster" + str; return str; }
                if (pre.Contains("JS") || pre.Contains("NZJ") || pre.Contains("ZJ") || prefull.Contains("SHIBING") || pre.Contains("SB")) { str = "character" + str; return str; }

                string pos = abbr.Substring(abbr.IndexOf("GJ"));
                string posfull = full.Substring(full.IndexOf("GONGJI"));
                if (pos.Contains("GS") || pos.Contains("GW")) str = "character" + str;
                if (pos.Contains("JS") || pos.Contains("NZJ") || pos.Contains("ZJ") || posfull.Contains("SHIBING") || pos.Contains("SB")) str = "monster" + str;
                return str;
            }
            #endregion

            #region 射擊
            if (full.Contains("KAIQIANG") || full.Contains("KAIHUO") || full.Contains("SHEJI"))
            {
                string str = "_attack";
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;

                return str;
            }
            #endregion








            //cut 1
            //if (iCutNum == 1)
            {
                if (abbr.Contains("QH") /*切換*/ && (abbr.Contains("YHSYJ") || abbr.Contains("1HSYJ"))) return "change_camera_id_c1";   // 切換到一號攝影機
                if (abbr.Contains("SYJ") && (abbr.Contains("EHJW") || abbr.Contains("2HJW"))) return "move_camera_pos_a2";  // 攝影機運動到二號機位
                if (abbr.Contains("SYJ") && (full.Contains("KAOJINJIAOSE") || abbr.Contains("KJJS"))) return "move_camera_pos_a2";  // 攝影機運動到二號機位

            }


            //cut 2
            //if (iCutNum == 1)
            {
                if ((abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ")) && (full.Contains("ZHENCHA") || full.Contains("CHAKAN"))) return "motion_character_detect";    //角色做偵查動作
                if ((abbr.Contains("GS") || abbr.Contains("GW")) && abbr.Contains("DW")) return "onposition_monster";   // 怪物就定位
                if ((abbr.Contains("GS") || abbr.Contains("GW")) && (abbr.Contains("1HCM") || abbr.Contains("YHCM"))) return "move_monster_pos_b1";// 怪物慢慢移動到一號艙門前
                if (abbr.Contains("QH") /*切換*/ && (abbr.Contains("EHSYJ") || abbr.Contains("2HSYJ"))) return "change_camera_id_c2"; // 切換到二號攝影機
                if (abbr.Contains("SYJ") && (abbr.Contains("SHJW") || abbr.Contains("3HJW") || full.Contains("SANHAOJIWEI") || full.Contains("3HAOJIWEI"))) return "move_camera_pos_b2"; // 攝影機運動到三號機位
                if (abbr.Contains("SYJ") && (abbr.Contains("SHJW") || abbr.Contains("4HJW") || full.Contains("SIHAOJIWEI") || full.Contains("4HAOJIWEI"))) return "move_camera_pos_b2"; // 攝影機運動到四號機位
            }

            //cut 3
            //if (iCutNum == 3)
            {
                if (abbr.Contains("QH") /*切換*/ && (abbr.Contains("WHSYJ") || abbr.Contains("5HSYJ") || full.Contains("WUHAOSHEYINGJI") || full.Contains("5HAOSHEYINGJI"))) return "change_camera_id_c5"; // 切換到五號攝影機
            }

            //cut 4
            //if (iCutNum == 4)
            {
                if (abbr.Contains("QH") /*切換*/ && (abbr.Contains("LHSYJ") || abbr.Contains("6HSYJ") || full.Contains("LIUHAOSHEYINGJI") || full.Contains("6HAOSHEYINGJI"))) return "change_camera_id_c6"; // 切換到6號攝影機
                if (abbr.Contains("QH") /*切換*/ && (abbr.Contains("QHSYJ") || abbr.Contains("7HSYJ") || full.Contains("QIHAOSHEYINGJI") || full.Contains("7HAOSHEYINGJI"))) return "change_camera_id_c7_follow"; // 切換到7號攝影機
                if ((abbr.Contains("GS") || abbr.Contains("GW")) && (abbr.Contains("ZCCM") || full.Contains("ZOUCHUCANGMEN"))) return "move_monster_pos_d1";   // 怪物走出艙門到閘門前
                if ((abbr.Contains("GS") || abbr.Contains("GW")) && (abbr.Contains("LJZL") || full.Contains("LIANGJIAOZOULU"))) return "move_monster_pos_d2";   // 快到閘門前成兩腳走路
                if (abbr.Contains("ZMDK") || full.Contains("ZHAMENDAKAI")) return "motion_model1_open";  // 閘門打開
            }

            //cut 5
            //if (iCutNum == 5)
            {
                if (abbr.Contains("QH") /*切換*/ && (abbr.Contains("BHSYJ") || abbr.Contains("8HSYJ") || full.Contains("BAHAOSHEYINGJI") || full.Contains("8HAOSHEYINGJI"))) return "change_camera_id_c8"; // 切換到8號攝影機
                if (abbr.Contains("QH") /*切換*/ && (abbr.Contains("JHSYJ") || abbr.Contains("9HSYJ") || full.Contains("JIUHAOSHEYINGJI") || full.Contains("9HAOSHEYINGJI"))) return "change_camera_id_c9"; // 切換到9號攝影機
                if (abbr.Contains("JXSB") || full.Contains("JIXIESHOUBEI")) return "motion_model2";   // 動機械手臂並噴火花
                if (abbr.Contains("ZMGS") || full.Contains("ZHAMENGUANSHANG")) return "motion_model1_close";  // 閘門關上
            }

            //cut 6
            {
                if (abbr.Contains("QH") /*切換*/ && (abbr.Contains("HJSYJ") || abbr.Contains("SHSYJ") || abbr.Contains("3HSYJ"))) return "change_camera_id_c3"; // 切換到三號攝影機/環景攝影機
                if (abbr.Contains("WLLM") || abbr.Contains("50LM") || abbr.Contains("WSLM")) return "change_camera_len_50";// 鏡頭換成35釐米

                // 景深
                if (abbr.Contains("JSXG") || full.Contains("JINGSHEN"))
                {
                    if (full.Contains("JIAN") || full.Contains("JIASHEN")) return "change_camera_dof_blur";
                    if (full.Contains("BIAOZHUN") || full.Contains("YUSHE")) return "change_camera_dof_default";
                    if (full.Contains("YICHU")) return "change_camera_dof_clear";
                }

                // 主角移動
                //if (abbr.Contains("ZJYD"))
                //if (abbr.Contains("YD"))
                //{
                //    if (abbr.Contains("WZ1") || abbr.Contains("WZY") || abbr.Contains("JTDZB") || abbr.Contains("JTZB") || full.Contains("ZUOBIAN") ) return "move_character_pos_1";
                //    if (abbr.Contains("WZ2") || abbr.Contains("WZE") || abbr.Contains("JTDZJ") || abbr.Contains("JTZJ") || full.Contains("ZHONGJIAN") ) return "move_character_pos_2";
                //    if (abbr.Contains("WZ3") || abbr.Contains("WZS") || abbr.Contains("JTDYB") || abbr.Contains("JTYB") || full.Contains("YOUBIAN")) return "move_character_pos_3";
                //}

                //腳色就定位 from cut 1
                if ((abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ")) && abbr.Contains("DW")) return "onposition_character";    // 角色就定位

                // 主角移動 2
                //if (abbr.Contains("ZJK") || abbr.Contains("NZJK") || abbr.Contains("JSK") )
                //{
                //    if (full.Contains("ZUO")) return "move_character_left";
                //    if (full.Contains("YOU")) return "move_character_right";
                //}




                // 主角動作
                if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ"))
                {
                    if (abbr.Contains("TZGJ")) return "motion_character_unfire";

                    string tmp = "";
                    if (abbr.Contains("JS")) tmp = abbr.Substring(abbr.IndexOf("JS"));
                    else if (abbr.Contains("NZJ")) tmp = abbr.Substring(abbr.IndexOf("NZJ"));
                    else if (abbr.Contains("ZJ")) tmp = abbr.Substring(abbr.IndexOf("ZJ"));
                    else tmp = abbr;

                    if (tmp.Contains("GJ") || tmp.Contains("KQ") || tmp.Contains("KH")) return "motion_character_fire";


                    if (full.Contains("ZUOZHUAI")) return "motion_character_turn_left";
                    if (full.Contains("YOUZHUAI")) return "motion_character_turn_right";
                    if (abbr.Contains("LZZH") || full.Contains("LIZHENG") || full.Contains("ZHANHAO")) return "motion_character_standup";

                    if (full.Contains("TIAOWU")) return "motion_character_dance";
                    if (full.Contains("TIAO")) return "motion_character_jump";

                    if (abbr.Contains("GWQR") || full.Contains("GUIXIA")) return "motion_character_beg";

                    if (full.Contains("CUNXIA")) return "motion_character_squat";
                    if (full.Contains("JINGLI")) return "motion_character_salute";

                    if (abbr.Contains("DCQ")) return "motion_character_throw_weapon";
                    if (abbr.Contains("HWQ") || (full.Contains("HUAN") && (full.Contains("QIANG") || full.Contains("WUQI")))) return "motion_character_change_weapon";



                    if (abbr.Contains("MZGW") || abbr.Contains("MZGS"))
                    {
                        if (full.Contains("TOU")) return "motion_character_aim_head";
                        if (full.Contains("SHENTI")) return "motion_character_aim_body";
                        if ((full.Contains("ZHUJIAO") && (full.Replace("ZHUJIAO", "").Contains("JIAO") || full.Replace("ZHUJIAO", "").Contains("TUI"))) ||
                            (full.Contains("JIAOSE") && (full.Replace("JIAOSE", "").Contains("JIAO") || full.Replace("ZHUJIAO", "").Contains("TUI")))
                           ) return "motion_character_aim_foot";

                        //cut 5
                        return "motion_character_aim"; //if (abbr.Contains("MZGW") || abbr.Contains("MZGS") || full.Contains("MIAOZHUNGUAIWU")) return "motion_character_aim";   // 男主角瞄準怪物

                    }
                }





            }

            return (strreturn == "") ? "UNKNOW" : strreturn;
        }

        public string ConvertToCommand(string _command)
        {
            _command = _command.ToUpper();
            string strSimC = ChineseConverter.Convert(_command, ChineseConversionDirection.TraditionalToSimplified);
            string full = strSimC.ToPinYin();
            string abbr = strSimC.ToPinYinAbbr();

            string strreturn = "";

            if (abbr.IndexOf("ACTION") == 0 || abbr.IndexOf("GO") == 0 || abbr.IndexOf("KSPS") == 0 || full.IndexOf("KAIPAI") == 0)
            {
                if (iStatus == 0)
                {
                    iStatus = 10;
                    //return "action";
                    return "go";
                }
            }

            if (full.Contains("BAOZHA")) return "fx_explosion";

            if (abbr.IndexOf("CUT") == 0 || full == "KA" || full == "CUT")
            {
                if (iStatus == 10)
                {
                    iStatus = 0;
                    return "cut";
                }
            }


            #region 切換 cut
            if (full.Contains("XIAYI") || full.Contains("XIA1") || abbr.Contains("XYCUT") || abbr.Contains("XYK") || abbr.Contains("X1CUT") || abbr.Contains("X1K"))
            {
                return "cut_next";
            }
            if (full.Contains("QIANYI") || full.Contains("QIAN1") || abbr.Contains("QYCUT") || abbr.Contains("QYK") || abbr.Contains("Q1CUT") || abbr.Contains("Q1K"))
            {
                return "cut_pre";
            }
            if (full.Contains("SHANGYI") || full.Contains("SHANG1") || abbr.Contains("SYCUT") || abbr.Contains("SYK") || abbr.Contains("S1CUT") || abbr.Contains("S1K"))
            {
                return "cut_pre";
            }
            if (full.Contains("DIYI") || full.Contains("DI1") || abbr.Contains("D1CUT") || abbr.Contains("D1K") ||
                abbr.Contains("DYCUT") || abbr.Contains("DYK"))
            {
                iCutNum = 1;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            if (full.Contains("DIER") || full.Contains("DI2") || abbr.Contains("D2CUT") || abbr.Contains("D2K") || abbr.Contains("DECUT") || abbr.Contains("DEK"))
            {
                iCutNum = 2;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            if (full.Contains("DISAN") || full.Contains("DI3") || abbr.Contains("D3CUT") || abbr.Contains("D3K"))
            {
                iCutNum = 3;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            if (full.Contains("DISI") || full.Contains("DI4") || abbr.Contains("D4CUT") || abbr.Contains("D4K"))
            {
                iCutNum = 4;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            if (full.Contains("DIWU") || full.Contains("DI5") || abbr.Contains("D5CUT") || abbr.Contains("D5K") || abbr.Contains("DWCUT") || abbr.Contains("DWK"))
            {
                iCutNum = 5;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            if (full.Contains("DILIU") || full.Contains("DI6") || abbr.Contains("D6CUT") || abbr.Contains("D6K") || abbr.Contains("DLCUT") || abbr.Contains("DLK"))
            {
                iCutNum = 6;
                //return "change_cut_" + iCutNum.ToString();
                return "cut_" + iCutNum.ToString();
            }
            #endregion

            #region 調光 開關燈
            if (full.Contains("DENG"))
            {
                if (full.Contains("GUANDENG"))
                {
                    return "light_off";
                }

                if (full.Contains("KAIDENG"))
                {
                    return "light_on";
                }

                if (full.Contains("LIANG")) return "light_upper";
                if (full.Contains("AN")) return "light_lower";
            }

            if (full.Contains("KAIQI") && (full.Contains("DIAOGUANG") || abbr.Contains("DG")))
            {
                return "posteffect_on";
            }
            if (full.Contains("GUANBI") && (full.Contains("DIAOGUANG") || abbr.Contains("DG")))
            {
                return "posteffect_off";
            }
            #endregion

            #region 景深
            if (full.Contains("BIAOZHU") && abbr.Contains("JS")) return "camera_dofdefault";
            if (full.Contains("BEIJING") && abbr.Contains("MH")) return "camera_dofdefault";
            if (abbr.Contains("JS") && full.Contains("KAI")) return "camera_dofdefault";

            if (abbr.Contains("YC") && abbr.Contains("JS")) return "camera_dofclear";
            if (abbr.Contains("BJ") && abbr.Contains("QC")) return "camera_dofclear";
            if (abbr.Contains("HM") && abbr.Contains("QC")) return "camera_dofclear";
            if (abbr.Contains("JS") && full.Contains("GUAN")) return "camera_dofclear";
            #endregion

            #region 切換 focus length
            if (abbr.Contains("ESSLM") || abbr.Contains("24LM") || abbr.Contains("ESLM")) return "camera_len24"; // 鏡頭換成24釐米
            if (full.Contains("BIAOZHUN") || abbr.Contains("BZJT")) return "camera_len24"; // 鏡頭換成24釐米
            if (abbr.Contains("SSWLM") || abbr.Contains("35LM") || abbr.Contains("SWLM")) return "camera_len35";// 鏡頭換成35釐米
            if (full.Contains("WANGYUAN") || abbr.Contains("WYJT")) return "camera_len35";// 鏡頭換成35釐米
            if (full.Contains("ANJIAO") || abbr.Contains("AJJT")) return "camera_len12";// 鏡頭換成廣角
            if (abbr.Contains("YELM") || abbr.Contains("12LM") || abbr.Contains("SELM")) return "camera_len12";// 鏡頭換成廣角
            #endregion

            #region 運鏡
            if (full.Contains("JIWEI"))
            {
                if (full.Contains("ERHAO") || full.Contains("2HAO")) return "camera_posa2";
                if (full.Contains("SIHAO") || full.Contains("4HAO")) return "camera_posb2";
            }
            #endregion

            #region 切換攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("YH") || abbr.Contains("1H"))) return "camera_c1";   // 切換到一號攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("EH") || abbr.Contains("2H"))) return "camera_c2";   // 切換到2號攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("SH") || abbr.Contains("3H"))) return "camera_c3";   // 切換到3號攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("WH") || abbr.Contains("5H"))) return "camera_c5";   // 切換到5號攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("LH") || abbr.Contains("6H"))) return "camera_c6";   // 切換到6號攝影機
            if ((abbr.Contains("SYJ") || abbr.Contains("JT")) && (abbr.Contains("QH") || abbr.Contains("7H"))) return "camera_c7";   // 切換到7號攝影機
            #endregion

            int indexperson = Math.Max(Math.Max(full.IndexOf("SHIBING"), full.IndexOf("ZHUJIAO")), full.IndexOf("JIAOSE"));
            int indexmonster = Math.Max(full.IndexOf("GUAISHOU"), full.IndexOf("GUAIWU"));

            string strprefix = "";
            if ( (indexperson >= 0 && indexmonster < 0) || (indexperson < indexmonster && indexmonster >= 0 && indexperson >= 0))
            {
                //士兵
                strprefix = "character";
            }

            if ((indexmonster >= 0 && indexperson < 0) || (indexmonster < indexperson && indexmonster >= 0 && indexperson >= 0))
            {
                //怪物
                strprefix = "monster";
            }

            SortedDictionary<int, string> dActions = new SortedDictionary<int, string>();

            #region 就定位
            if (full.Contains("JIUDINGWEI"))
            {
                string str = "_onposition";

                dActions.Add(full.IndexOf("JIUDINGWEI"), str);
            }
            #endregion

            if (full.Contains("ZHENCHA") || full.Contains("CHAKAN"))
            {
                string str = "_detect";

                dActions.Add(Math.Max(full.IndexOf("ZHENCHA"), full.IndexOf("CHAKAN")), str);
            }

            #region 移動
            if (full.Contains("YIDONG"))
            {
                string str = "_pos";
                if (abbr.Contains("1HWZ") || abbr.Contains("YHWZ") || abbr.Contains("WZ1") || abbr.Contains("WZY") || abbr.Contains("JTDZB") || abbr.Contains("JTZB") || full.Contains("ZUOBIAN")) str = "_pos1";
                if (abbr.Contains("2HWZ") || abbr.Contains("EHWZ") || abbr.Contains("WZ2") || abbr.Contains("WZE") || abbr.Contains("JTDZJ") || abbr.Contains("JTZJ") || full.Contains("ZHONGJIAN")) str = "_pos2";
                if (abbr.Contains("3HWZ") || abbr.Contains("SHWZ") || abbr.Contains("WZ3") || abbr.Contains("WZS") || abbr.Contains("JTDYB") || abbr.Contains("JTYB") || full.Contains("YOUBIAN")) str = "_pos3";

                //if (abbr.Contains("JS") || abbr.Contains("NZJ") || abbr.Contains("ZJ") || full.Contains("SHIBING") || abbr.Contains("SB")) str = "character" + str;
                if (strprefix == "monster") str = str.Replace("pos", "posd");
                dActions.Add(full.IndexOf("YIDONG"), str);
            }
            #endregion

            #region 靠左右
            if (full.Contains("KAOZUO"))
            {
                string str = "_left";
                dActions.Add(full.IndexOf("KAOZUO"), str);
            }
            if (full.Contains("KAOYOU"))
            {
                string str = "_right";
                dActions.Add(full.IndexOf("KAOYOU"), str);
            }
            #endregion

            #region 左右轉
            if (full.Contains("ZUOZHUAI"))
            {
                string str = "_turnleft";
                dActions.Add(full.IndexOf("ZUOZHUAI"), str);
            }
            if (full.Contains("YOUZHUAI"))
            {
                string str = "_turnright";
                dActions.Add(full.IndexOf("YOUZHUAI"), str);
            }
            #endregion

            #region 瞄準
            if (full.Contains("MIAOZHUN"))
            {
                string str = "_aim";
                string post = full.Substring(full.IndexOf("MIAOZHUN"));
                if (post.Contains("TOU")) str = str + "head";
                if (post.Contains("SHENTI")) str = str + "body";
                if (post.Contains("JIAO") || post.Contains("TUI")) str = str + "foot";

                dActions.Add(full.IndexOf("MIAOZHUN"), str);
            }
            #endregion

            #region 其他動作
            if (full.Contains("LIZHENG") || full.Contains("ZHANHAO"))
            {
                string str = "_standup";
                dActions.Add(Math.Max(full.IndexOf("LIZHENG"), full.IndexOf("ZHANHAO")), str);
            }

            if (full.Contains("TIAOWU") || full.Contains("TIAOYIDUANWU") || full.Contains("TIAOQIWU"))
            {
                string str = "_dance";
                dActions.Add(Math.Max(Math.Max(full.IndexOf("TIAOWU"), full.IndexOf("TIAOYIDUANWU")), full.IndexOf("TIAOQIWU")), str);
            }
            if (full.Contains("TIAO") && (full.Contains("WU") == false || (full.Contains("WU") && full.IndexOf("WU") < full.IndexOf("TIAO"))))
            {
                string str = "_jump";
                dActions.Add(full.IndexOf("TIAO"), str);
            }

            if (full.Contains("GUIDEQIURAO") || full.Contains("GUIXIA"))
            {
                string str = "_beg";
                dActions.Add(Math.Max(full.IndexOf("GUIXIA"), full.IndexOf("GUIDEQIURAO")), str);
            }

            if (full.Contains("CUNXIA"))
            {
                string str = "_squat";
                dActions.Add(full.IndexOf("CUNXIA"), str);
            }
            if (full.Contains("JINGLI"))
            {
                string str = "_salute";
                dActions.Add(full.IndexOf("JINGLI"), str);
            }

            if (full.Contains("DIUCHU"))
            {
                string str = "_throwweapon";
                dActions.Add(full.IndexOf("DIUCHU"), str);
            }
            if (full.Contains("HUAN") && (full.Contains("QIANG") || full.Contains("WUQI")))
            {
                string str = "_changeweapon";
                dActions.Add(full.IndexOf("HUAN"), str);
            }
            #endregion

            #region 怪物倒下
            if (full.Contains("JIDAO") || full.Contains("DADAO") || full.Contains("DAOXIA"))
            {
                string str = "_down";
                dActions.Add(Math.Max(Math.Max(full.IndexOf("JIDAO"), full.IndexOf("DADAO")), full.IndexOf("DAOXIA")), str);
            }
            #endregion

            #region 攻擊
            //停止攻擊
            if (full.Contains("TINGZHI") || full.Contains("TINGHUO"))
            {
                string str = "_unfire";

                dActions.Add(Math.Max(full.IndexOf("TINGZHI"), full.IndexOf("TINGHUO")), str);
            }
            //攻擊
            if (full.Contains("GONGJI"))
            {
                string str = "_attack";
                dActions.Add(full.IndexOf("GONGJI"), str);
            }
            #endregion

            #region 射擊
            if (full.Contains("KAIQIANG") || full.Contains("KAIHUO") || full.Contains("SHEJI"))
            {
                string str = "_attack";
                dActions.Add(Math.Max(Math.Max(full.IndexOf("KAIQIANG"), full.IndexOf("KAIHUO")), full.IndexOf("SHEJI")), str);
            }
            #endregion


            foreach(KeyValuePair<int, string> kv in dActions)
            {
                if (strreturn == "")
                    strreturn = strprefix + kv.Value;
                else
                    strreturn = strreturn + "," + strprefix + kv.Value;
            }

            return (strreturn == "") ? "UNKNOW" : strreturn;
        }

        private string ProcessSetRolePosition(string _command, string _rolekey)
        {
            if (curstage != STAGE.SetRole) return "";
            string pos = "P1";
            if (_rolekey == "怪獸") pos = "P2";

            foreach (string p in charpositions.Keys)
            {
                if (_command.Contains(p))
                {
                    pos = charpositions[p];
                    break;
                }
            }
            Role = _rolekey;
            return "SetRolePosition(" + chars[_rolekey] + ", " + pos + ");";
        }

        private string ProcessSetRoleItem(string _command, string _rolekey)
        {
            if (curstage != STAGE.SetRole) return "";

            string item = "I1";
            if (_rolekey == "怪獸") return "";

            foreach (string p in charsettings.Keys)
            {
                if (_command.Contains(p))
                {
                    item = charsettings[p];
                    break;
                }
            }
            Role = _rolekey;
            return "SetRoleItem(" + chars[_rolekey] + ", " + item + ");";
        }


        private string ProcessSwitchCam(string _command, string _camkey)
        {
            if (curstage != STAGE.SetCam) return "";
            string cam = "C1";

            foreach (string p in cameras.Keys)
            {
                if (_command.Contains(p))
                {
                    cam = cameras[p];
                    break;
                }
            }
            Cam = _camkey;
            return "SwitchCam(" + cameras[_camkey] + ");";
        }

        private string ProcessSetCamPosition(string _command, string _camkey)
        {
            if (curstage != STAGE.SetCam) return "";
            string pos = "CP1";

            foreach (string p in camerapositions.Keys)
            {
                if (_command.Contains(p))
                {
                    pos = camerapositions[p];
                    CamPos = p;
                    break;
                }
            }
            Cam = _camkey;
            return "SetCamPosition(" + cameras[_camkey] + ", " + pos + ");";
        }

        private string ProcessSetCamFocus(string _command, string _camkey)
        {
            if (curstage != STAGE.SetCam) return "";
            string focus = "P1";

            foreach (string p in camerafocus.Keys)
            {
                if (_command.Contains(p))
                {
                    focus = camerafocus[p];
                    break;
                }
            }
            Cam = _camkey;
            return "SetCamFocus(" + cameras[_camkey] + ", " + focus + ");";
        }
    }
}
