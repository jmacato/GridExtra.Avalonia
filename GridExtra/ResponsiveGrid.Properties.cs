﻿// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using Avalonia;
// using Avalonia.Controls;

// namespace GridExtra
// {
//     public partial class ResponsiveGrid
//     {
        
//         // 各種ブレークポイントの設定用プロパティ
//         public int MaxDivision
//         {
//             get { return (int)GetValue(MaxDivisionProperty); }
//             set { SetValue(MaxDivisionProperty, value); }
//         }

//         // Using a AvaloniaProperty as the backing store for MaxDivision.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty MaxDivisionProperty =
//             AvaloniaProperty.Register("MaxDivision",
//                                         typeof(int),
//                                         typeof(ResponsiveGrid),
//                                         new FrameworkPropertyMetadata(12, FrameworkPropertyMetadataOptions.AffectsMeasure));



//         public SizeThresholds BreakPoints
//         {
//             get { return (SizeThresholds)GetValue(BreakPointsProperty); }
//             set { SetValue(BreakPointsProperty, value); }
//         }

//         // Using a AvaloniaProperty as the backing store for BreakPoints.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty BreakPointsProperty =
//             AvaloniaProperty.Register("BreakPoints",
//                                         typeof(SizeThresholds),
//                                         typeof(ResponsiveGrid),
//                                         new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure));




//         public bool ShowGridLines
//         {
//             get { return (bool)GetValue(ShowGridLinesProperty); }
//             set { SetValue(ShowGridLinesProperty, value); }
//         }
//         // Using a AvaloniaProperty as the backing store for ShowGridLines.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty ShowGridLinesProperty =
//             AvaloniaProperty.Register("ShowGridLines", typeof(bool), typeof(ResponsiveGrid), new PropertyMetadata(false));



               
//         public static int GetXS(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(XSProperty);
//         }
//         public static void SetXS(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(XSProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for XS.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty XSProperty =
//             AvaloniaProperty.RegisterAttached("XS",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetSM(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(SMProperty);
//         }
//         public static void SetSM(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(SMProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for SM.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty SMProperty =
//             AvaloniaProperty.RegisterAttached("SM",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetMD(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(MDProperty);
//         }
//         public static void SetMD(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(MDProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for MD.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty MDProperty =
//             AvaloniaProperty.RegisterAttached("MD",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetLG(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(LGProperty);
//         }
//         public static void SetLG(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(LGProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for LG.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty LGProperty =
//             AvaloniaProperty.RegisterAttached("LG",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



        

        
//         public static int GetXS_Offset(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(XS_OffsetProperty);
//         }
//         public static void SetXS_Offset(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(XS_OffsetProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for XS_Offset.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty XS_OffsetProperty =
//             AvaloniaProperty.RegisterAttached("XS_Offset",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetSM_Offset(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(SM_OffsetProperty);
//         }
//         public static void SetSM_Offset(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(SM_OffsetProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for SM_Offset.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty SM_OffsetProperty =
//             AvaloniaProperty.RegisterAttached("SM_Offset",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetMD_Offset(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(MD_OffsetProperty);
//         }
//         public static void SetMD_Offset(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(MD_OffsetProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for MD_Offset.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty MD_OffsetProperty =
//             AvaloniaProperty.RegisterAttached("MD_Offset",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetLG_Offset(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(LG_OffsetProperty);
//         }
//         public static void SetLG_Offset(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(LG_OffsetProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for LG_Offset.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty LG_OffsetProperty =
//             AvaloniaProperty.RegisterAttached("LG_Offset",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



        


        
//         public static int GetXS_Push(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(XS_PushProperty);
//         }
//         public static void SetXS_Push(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(XS_PushProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for XS_Push.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty XS_PushProperty =
//             AvaloniaProperty.RegisterAttached("XS_Push",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetSM_Push(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(SM_PushProperty);
//         }
//         public static void SetSM_Push(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(SM_PushProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for SM_Push.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty SM_PushProperty =
//             AvaloniaProperty.RegisterAttached("SM_Push",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetMD_Push(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(MD_PushProperty);
//         }
//         public static void SetMD_Push(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(MD_PushProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for MD_Push.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty MD_PushProperty =
//             AvaloniaProperty.RegisterAttached("MD_Push",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetLG_Push(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(LG_PushProperty);
//         }
//         public static void SetLG_Push(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(LG_PushProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for LG_Push.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty LG_PushProperty =
//             AvaloniaProperty.RegisterAttached("LG_Push",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



        


        
//         public static int GetXS_Pull(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(XS_PullProperty);
//         }
//         public static void SetXS_Pull(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(XS_PullProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for XS_Pull.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty XS_PullProperty =
//             AvaloniaProperty.RegisterAttached("XS_Pull",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetSM_Pull(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(SM_PullProperty);
//         }
//         public static void SetSM_Pull(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(SM_PullProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for SM_Pull.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty SM_PullProperty =
//             AvaloniaProperty.RegisterAttached("SM_Pull",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetMD_Pull(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(MD_PullProperty);
//         }
//         public static void SetMD_Pull(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(MD_PullProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for MD_Pull.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty MD_PullProperty =
//             AvaloniaProperty.RegisterAttached("MD_Pull",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



//         public static int GetLG_Pull(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(LG_PullProperty);
//         }
//         public static void SetLG_Pull(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(LG_PullProperty, value);
//         }

//         // Using a AvaloniaProperty as the backing store for LG_Pull.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty LG_PullProperty =
//             AvaloniaProperty.RegisterAttached("LG_Pull",
//                                                 typeof(int),
//                                                 typeof(ResponsiveGrid),
//                                                 new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));



        


        
//         public static int GetActualColumn(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(ActualColumnProperty);
//         }
//         protected static void SetActualColumn(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(ActualColumnProperty, value);
//         }
//         // Using a AvaloniaProperty as the backing store for ActualColumn.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty ActualColumnProperty =
//             AvaloniaProperty.RegisterAttached("ActualColumn", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0));

//         public static int GetActualRow(AvaloniaObject obj)
//         {
//             return (int)obj.GetValue(ActualRowProperty);
//         }
//         protected static void SetActualRow(AvaloniaObject obj, int value)
//         {
//             obj.SetValue(ActualRowProperty, value);
//         }
//         // Using a AvaloniaProperty as the backing store for ActualRow.  This enables animation, styling, binding, etc...
//         public static readonly AvaloniaProperty ActualRowProperty =
//             AvaloniaProperty.RegisterAttached("ActualRow", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0));

        
//     }
// }
