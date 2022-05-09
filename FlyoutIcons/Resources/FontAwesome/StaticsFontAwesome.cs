//using PMApp.Foundation;
//using System.Linq;
//using Microsoft.Maui;
//using Microsoft.Maui.Controls;

//namespace FontAwesome
//{
//    //NOTE: Font Awesome
//    //see:https://medium.com/@tsjdevapps/use-fontawesome-in-a-xamarin-forms-app-2edf25311db4
//    //see:https://ianvink.wordpress.com/2019/06/26/xamarin-fontawesome-image/
//    //see:https://www.syncfusion.com/kb/12188/how-to-use-font-awesome-icons-in-xamarin-forms-accordion-sfaccordion
//    //see:https://fontawesome.com/v5.15/icons?d=gallery&p=2&q=chevr&m=free
//    public static class StaticsFontAwesome
//    {
//        /// <summary>
//        /// Get the FontAwesomeSolidFontFamil from App.xaml - ResourceDictionary - Key = from EnumFontAwsomeStyle
//        /// </summary>
//        public static string GetFAFamily(this EnumFontAwsomeStyle tEnumFontAwsome)
//        {
//            var tReturn = string.Empty;
//            var tFontKey = (tEnumFontAwsome == EnumFontAwsomeStyle.Brands) ? "FontAwesomeBrands" : (tEnumFontAwsome == EnumFontAwsomeStyle.Solid) ? "FontAwesomeSolid" : "FontAwesomeRegular";
//            if (Application.Current == null) throw new System.NullReferenceException($"{nameof(StaticsFontAwesome)}:{nameof(GetFAFamily)}");
//            if (Application.Current.Resources.TryGetValue(tFontKey, out var tOnPlatform))
//            {
//                var tOnPlatformDictionary = (OnPlatform<string>)tOnPlatform;
//                var tOnItem = tOnPlatformDictionary.Platforms.FirstOrDefault((a) => a.Platform.FirstOrDefault() == DeviceInfo.Name);
//                if (tOnItem != null) tReturn = tOnItem.Value.ToString();
//            }
//            return tReturn ?? string.Empty;
//        }

//        public static string ToFontAwesomeIcons(this EnumTreeNodeType tEnumTreeNodeType)
//        {
//            switch (tEnumTreeNodeType)
//            {
//                case EnumTreeNodeType.Root:
//                    return FontAwesomeIcons.Asterisk;
//                case EnumTreeNodeType.Close:
//                    return FontAwesomeIcons.Folder;
//                case EnumTreeNodeType.Open:
//                    return FontAwesomeIcons.File;
//                case EnumTreeNodeType.Level1:
//                    return FontAwesomeIcons.File;
//                case EnumTreeNodeType.Level2:
//                    return FontAwesomeIcons.File;
//                case EnumTreeNodeType.Level3:
//                    return FontAwesomeIcons.File;
//                case EnumTreeNodeType.Level1Template:
//                    return FontAwesomeIcons.File;
//                case EnumTreeNodeType.Level2Template:
//                    return FontAwesomeIcons.File;
//                case EnumTreeNodeType.Level3Template:
//                    return FontAwesomeIcons.File;
//                default://case EnumTreeNodeType.Default:
//                    return FontAwesomeIcons.Gear;
//            }
//        }

//        public static Color ToFAFontColor(this EnumTreeNodeType tEnumTreeNodeType)
//        {
//            switch (tEnumTreeNodeType)
//            {
//                case EnumTreeNodeType.Close:
//                    return Colors.Red;
//                //case EnumTreeNodeType.Root:
//                //case EnumTreeNodeType.Open:
//                //case EnumTreeNodeType.Level1:
//                //case EnumTreeNodeType.Level2:
//                //case EnumTreeNodeType.Level3:
//                //case EnumTreeNodeType.Level1Template:
//                //case EnumTreeNodeType.Level2Template:
//                //case EnumTreeNodeType.Level3Template:
//                //case EnumTreeNodeType.Default:
//                default:
//                    return Colors.White;
//            }
//        }


//        public static EnumFontAwsomeStyle ToValidFAIconStyle(this string tFontAwesomeIcons, EnumFontAwsomeStyle tPreferredStyle)
//        {
//            var tFoundValue = ValidDictionary().TryGetValue(tFontAwesomeIcons, out var tAvailableStyles);
//            if (!tFoundValue) return EnumFontAwsomeStyle.Solid;
//            var tValidStyles = (EnumFontAwsomeStyle)tAvailableStyles;

//            return ((tValidStyles & tPreferredStyle) == tPreferredStyle)
//                ? tPreferredStyle
//                : ((tValidStyles & EnumFontAwsomeStyle.Solid) == EnumFontAwsomeStyle.Solid)
//                    ? EnumFontAwsomeStyle.Solid
//                    : ((tValidStyles & EnumFontAwsomeStyle.Regular) == EnumFontAwsomeStyle.Regular)
//                        ? EnumFontAwsomeStyle.Regular
//                        : (tValidStyles & EnumFontAwsomeStyle.Brands) == EnumFontAwsomeStyle.Brands
//                            ? EnumFontAwsomeStyle.Brands
//                            : EnumFontAwsomeStyle.Solid;
//        }
    
//        public static Dictionary<string, int> ValidDictionary()
//        {
//            var tValidDictionary = new Dictionary<string, int>();
//            tValidDictionary.Add(FontAwesomeIcons.MartiniGlassEmpty, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.Music, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.MagnifyingGlass, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.Asterisk, (int)EnumFontAwsomeStyle.Solid);

//            tValidDictionary.Add(FontAwesomeIcons.Gear, (int)EnumFontAwsomeStyle.Solid);

//            tValidDictionary.Add(FontAwesomeIcons.AngleLeft, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.AngleRight, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.AngleUp, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.AngleDown, (int)EnumFontAwsomeStyle.Solid);

//            tValidDictionary.Add(FontAwesomeIcons.AnglesLeft, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.AnglesRight, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.AnglesUp, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.AnglesDown, (int)EnumFontAwsomeStyle.Solid);

//            tValidDictionary.Add(FontAwesomeIcons.ChevronLeft, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.ChevronRight, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.ChevronUp, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.ChevronsDown, (int)EnumFontAwsomeStyle.Solid);

//            tValidDictionary.Add(FontAwesomeIcons.CaretLeft, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.CaretRight, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.CaretUp, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.CaretDown, (int)EnumFontAwsomeStyle.Solid);

//            tValidDictionary.Add(FontAwesomeIcons.SquareCaretLeft, (int)EnumFontAwsomeStyle.RegularSolid);
//            tValidDictionary.Add(FontAwesomeIcons.SquareCaretRight, (int)EnumFontAwsomeStyle.RegularSolid);
//            tValidDictionary.Add(FontAwesomeIcons.SquareCaretUp, (int)EnumFontAwsomeStyle.RegularSolid);
//            tValidDictionary.Add(FontAwesomeIcons.SquareCaretDown, (int)EnumFontAwsomeStyle.RegularSolid);

//            tValidDictionary.Add(FontAwesomeIcons.Square, (int)EnumFontAwsomeStyle.RegularSolid);
//            tValidDictionary.Add(FontAwesomeIcons.SquarePlus, (int)EnumFontAwsomeStyle.RegularSolid);
//            tValidDictionary.Add(FontAwesomeIcons.SquareMinus, (int)EnumFontAwsomeStyle.RegularSolid);
//            tValidDictionary.Add(FontAwesomeIcons.SquareCheck, (int)EnumFontAwsomeStyle.RegularSolid);

//            tValidDictionary.Add(FontAwesomeIcons.ArrowLeft, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.ArrowRight, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.ArrowUp, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.ArrowDown, (int)EnumFontAwsomeStyle.Solid);

//            tValidDictionary.Add(FontAwesomeIcons.RightFromBracket, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.RightToBracket, (int)EnumFontAwsomeStyle.Solid);

//            tValidDictionary.Add(FontAwesomeIcons.Calendar, (int)EnumFontAwsomeStyle.RegularSolid);

//            tValidDictionary.Add(FontAwesomeIcons.File, (int)EnumFontAwsomeStyle.RegularSolid);
//            tValidDictionary.Add(FontAwesomeIcons.Folder, (int)EnumFontAwsomeStyle.RegularSolid);
//            tValidDictionary.Add(FontAwesomeIcons.FolderOpen, (int)EnumFontAwsomeStyle.RegularSolid);
//            tValidDictionary.Add(FontAwesomeIcons.Xmark, (int)EnumFontAwsomeStyle.Solid);
//            tValidDictionary.Add(FontAwesomeIcons.Clock, (int)EnumFontAwsomeStyle.RegularSolid);
//            return tValidDictionary;
//        }


//    }
//}
