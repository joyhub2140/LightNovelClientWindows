﻿

#pragma checksum "C:\Users\Yupeng\Source\Workspaces\LightNovelClientWindows\LightNovelClient\LightNovelClient.Shared\Controls\RichTextView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E19B556EF74B5F5FEBBC3F8C285503BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightNovel.Controls
{
    partial class RichTextView : global::Windows.UI.Xaml.Controls.UserControl
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ScrollViewer ContentScrollViewer; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::LightNovel.Controls.RichTextColumns ContentColumns; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.RichTextBlock ContentTextBlock; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Controls/RichTextView.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            ContentScrollViewer = (global::Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("ContentScrollViewer");
            ContentColumns = (global::LightNovel.Controls.RichTextColumns)this.FindName("ContentColumns");
            ContentTextBlock = (global::Windows.UI.Xaml.Controls.RichTextBlock)this.FindName("ContentTextBlock");
        }
    }
}


