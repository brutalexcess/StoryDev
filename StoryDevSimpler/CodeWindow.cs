using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;

namespace StoryDev
{
    public class CodeWindow : FastColoredTextBox
    {
        private TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        private TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        private TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        private TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Regular);

        AutocompleteMenu popupMenu;

        private readonly string[] commands = { "appendShow();", "appendLink();", "gotoPassage();", "string();", "trace();",
                                             "playSound();", "modifyChannel();", "stopChannel();", "showCharImage();",
                                             "removeCharImage();", "showBGImage();", "removeBGImage();", "goBack();",
                                             "parseJson();", "stringifyJson();", "startEvent();", "stopEvent();", 
                                             "callEvent();", "transCharImage();", "transPassage();", "__stageWidth",
                                             "__stageHeight", "Math", "Math.NEGATIVE_INFINITY", "Math.NaN", "Math.PI",
                                             "Math.POSITIVE_INFINITY", "Math.abs();", "Math.acos();", "Math.asin();",
                                             "Math.atan();", "Math.atan2();", "Math.ceil();", "Math.cos();", "Math.exp();",
                                             "Math.fceil();", "Math.ffloor();", "Math.floor();", "Math.fround();",
                                             "Math.isFinite();", "Math.isNaN();", "Math.log();", "Math.max();",
                                             "Math.min();", "Math.pow();", "Math.random();", "Math.round();", 
                                             "Math.sin();", "Math.sqrt();", "Math.tan();", "rand();", "setLinkFormat();",
                                             "setTextFormat();", "setBGColor();", "setPassageColor();", "setMenuTextColor();"};

        public CodeWindow()
        {
            popupMenu = new AutocompleteMenu(this);
            popupMenu.SearchPattern = @"[\w\.]";

            UpdateFont("Courier New", 10);

            Dock = System.Windows.Forms.DockStyle.Fill;
            WordWrap = true;

            var items = new List<AutocompleteItem>();
            foreach (var item in commands)
                items.Add(new MethodAutocompleteItem2(item));

            popupMenu.Items.SetAutocompleteItems(items);

            this.TextChangedDelayed += CodeWindow_TextChangedDelayed;
        }

        void CodeWindow_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle(GreenStyle);
            e.ChangedRange.ClearStyle(BlueStyle);
            e.ChangedRange.ClearStyle(MagentaStyle);
            e.ChangedRange.ClearStyle(BrownStyle);
            e.ChangedRange.ClearFoldingMarkers();

            e.ChangedRange.SetStyle(BrownStyle, @"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'");
            e.ChangedRange.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);
            e.ChangedRange.SetStyle(MagentaStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");
            e.ChangedRange.SetStyle(BlueStyle, @"\b(for|while|if|else|in|var)\b");
            
            e.ChangedRange.SetFoldingMarkers("{", "}");
        }

        public void UpdateFont(string fontName, float size)
        {
            this.Font = new Font(fontName, size);
        }

    }

    

    /// <summary>
    /// This autocomplete item appears after dot
    /// </summary>
    public class MethodAutocompleteItem2 : MethodAutocompleteItem
    {
        string firstPart;
        string lastPart;

        public MethodAutocompleteItem2(string text)
            : base(text)
        {
            var i = text.LastIndexOf('.');
            if (i < 0)
                firstPart = text;
            else
            {
                firstPart = text.Substring(0, i);
                lastPart = text.Substring(i + 1);
            }
        }

        public override CompareResult Compare(string fragmentText)
        {
            int i = fragmentText.LastIndexOf('.');

            if (i < 0)
            {
                if (firstPart.StartsWith(fragmentText) && string.IsNullOrEmpty(lastPart))
                    return CompareResult.VisibleAndSelected;
                //if (firstPart.ToLower().Contains(fragmentText.ToLower()))
                //  return CompareResult.Visible;
            }
            else
            {
                var fragmentFirstPart = fragmentText.Substring(0, i);
                var fragmentLastPart = fragmentText.Substring(i + 1);


                if (firstPart != fragmentFirstPart)
                    return CompareResult.Hidden;

                if (lastPart != null && lastPart.StartsWith(fragmentLastPart))
                    return CompareResult.VisibleAndSelected;

                if (lastPart != null && lastPart.ToLower().Contains(fragmentLastPart.ToLower()))
                    return CompareResult.Visible;

            }

            return CompareResult.Hidden;
        }

        public override string GetTextForReplace()
        {
            if (lastPart == null)
                return firstPart;

            return firstPart + "." + lastPart;
        }

        public override string ToString()
        {
            if (lastPart == null)
                return firstPart;

            return lastPart;
        }
    }

}
