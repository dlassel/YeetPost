#pragma checksum "C:\Users\rjvar\Desktop\w2020\S.P\sprint 2\Sprint 2 Code\YeetPostV1_4\YeetPostV1_4\Views\Shared\_YeetTabs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfbe086e4a0d20d5cd46bbfbf52922f9318c0dbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__YeetTabs), @"mvc.1.0.view", @"/Views/Shared/_YeetTabs.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\rjvar\Desktop\w2020\S.P\sprint 2\Sprint 2 Code\YeetPostV1_4\YeetPostV1_4\Views\_ViewImports.cshtml"
using YeetPostV1_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rjvar\Desktop\w2020\S.P\sprint 2\Sprint 2 Code\YeetPostV1_4\YeetPostV1_4\Views\_ViewImports.cshtml"
using YeetPostV1_4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfbe086e4a0d20d5cd46bbfbf52922f9318c0dbb", @"/Views/Shared/_YeetTabs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c20e8b24b54daa629e99b9f7a1687b52b8e46db", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__YeetTabs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<v-col cols=""2"">
    <v-tabs vertical>
        <v-tab v-on:click=""filterBy('new', model.location, false)"">
            <v-icon left>mdi-octagram</v-icon>
            New
        </v-tab>
        <v-tab v-on:click=""filterBy('trending', model.location, false)"">
            <v-icon left>mdi-fire</v-icon>
            Trending
        </v-tab>
        <v-combobox v-model=""select""
                    :items=""location""
                    v-on:change=""filterBy('trending', select, true)""
                    label=""Select a City""
                    ></v-combobox>
      


    </v-tabs>
</v-col>
<v-col cols=""2"">

</v-col>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591